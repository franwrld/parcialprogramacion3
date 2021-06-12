Imports System.Data.SqlClient
Public Class Asignatura
    Public conexion As New SqlConnection(My.Settings.conexion)
    Public comprobar As SqlDataReader
    Public lector As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            TxtAsignatura.Clear()
            TxtNombre.Clear()
            TxtIdDocente.Clear()
            TxtAsignatura.Focus()

        Else
            conexion.Open()
            Button1.Text = "Registrar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "insert into Asignatura Values (" & Integer.Parse(TxtAsignatura.Text) & " , '" & TxtNombre.Text & "','" & Integer.Parse(TxtIdDocente.Text) & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se ingreso la nueva ASIGNATURA: " & TxtNombre.Text & "")

            Catch ex As Exception

                MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
            End Try
            conexion.Close()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexion.Open()
        Dim eliminar As New SqlCommand("", conexion)

        Try
            eliminar.CommandType = CommandType.Text
            eliminar.CommandText = "DELETE from Asignatura where IdAsignatura = " & Integer.Parse(TxtAsignatura.Text)

            eliminar.ExecuteNonQuery()
            MsgBox("Se eliminó la Asignatura con ID : " & TxtAsignatura.Text & "")
        Catch ex As Exception
            MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
        End Try
        conexion.Close()
    End Sub

    Private Sub Asignatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaRegistroNotasDataSet2.Asignatura' Puede moverla o quitarla según sea necesario.
        Me.AsignaturaTableAdapter.Fill(Me.SistemaRegistroNotasDataSet2.Asignatura)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.Open()
        Dim comando As New SqlCommand("selectasig", conexion)



        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@idasigna", TxtAsignatura.Text)

            lector = comando.ExecuteReader
            lector.Read()
            If (lector.HasRows()) Then
                TxtNombre.Text = lector("NombreAsignatura")
                TxtIdDocente.Text = lector("IdDocente")

            Else
                MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Button4.Text = "Editar") Then
            Button4.Text = "Guardar"
            TxtAsignatura.Clear()
            TxtNombre.Clear()
            TxtIdDocente.Clear()
            TxtAsignatura.Focus()
        Else
            conexion.Open()
            Button4.Text = "Editar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "update Asignatura set NombreAsignatura = '" & TxtNombre.Text & "',IdDocente = '" & TxtIdDocente.Text & "' where IdAsignatura = " & Integer.Parse(TxtAsignatura.Text)

                comando.ExecuteNonQuery()
                MsgBox("Se actualizo la Asignatura con Id: " & TxtAsignatura.Text)
            Catch ex As Exception
                MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
            End Try
            conexion.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sqll As String
        sqll = "Select*From Asignatura"
        Dim adapt As New SqlClient.SqlDataAdapter(sqll, conexion)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "IdAsignatura")
        DataGridView1.DataSource = obtenerdatos
        DataGridView1.DataMember = "IdAsignatura"
    End Sub
End Class