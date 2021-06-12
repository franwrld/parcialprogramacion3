Imports System.Data.SqlClient
Public Class Matricula
    Public conexion As New SqlConnection(My.Settings.conexion)
    Public comprobar As SqlDataReader
    Public lector As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            TxtIdMatricula.Clear()
            TxtFechMatricula.Clear()
            TxtIdEstud.Clear()
            TxtIdMatricula.Focus()

        Else
            conexion.Open()
            Button1.Text = "Registrar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "insert into Matricula Values (" & Integer.Parse(TxtIdMatricula.Text) & " , '" & Date.Parse(TxtFechMatricula.Text) & "','" & Integer.Parse(TxtIdEstud.Text) & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se ingreso la nueva Matricula con Id: " & TxtIdMatricula.Text & "")

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
            eliminar.CommandText = "DELETE from Matricula where IdMatricula = " & Integer.Parse(TxtIdMatricula.Text)

            eliminar.ExecuteNonQuery()
            MsgBox("Se eliminó la Matricula con ID : " & TxtIdMatricula.Text & "")
        Catch ex As Exception
            MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
        End Try
        conexion.Close()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.Open()
        Dim comando As New SqlCommand("selectmatricula", conexion)



        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@idmatricula", TxtIdMatricula.Text)

            lector = comando.ExecuteReader
            lector.Read()
            If (lector.HasRows()) Then
                TxtFechMatricula.Text = lector("FechaMatricula")
                TxtIdEstud.Text = lector("IdEstudiante")
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
            TxtFechMatricula.Clear()
            TxtIdEstud.Clear()
            TxtIdMatricula.Focus()
        Else
            conexion.Open()
            Button4.Text = "Editar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "update Matricula set FechaMatricula = '" & TxtFechMatricula.Text & "',IdEstudiante = '" & TxtIdEstud.Text & "' where IdMatricula = " & Integer.Parse(TxtIdMatricula.Text)

                comando.ExecuteNonQuery()
                MsgBox("Se actualizo la matricula con Id: " & TxtIdMatricula.Text)
            Catch ex As Exception
                MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
            End Try
            conexion.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sqll As String
        sqll = "Select*From Matricula"
        Dim adapt As New SqlClient.SqlDataAdapter(sqll, conexion)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "IdMatricula")
        DataGridView1.DataSource = obtenerdatos
        DataGridView1.DataMember = "IdMatricula"
    End Sub

    Private Sub Matricula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaRegistroNotasDataSet11.Matricula' Puede moverla o quitarla según sea necesario.
        Me.MatriculaTableAdapter1.Fill(Me.SistemaRegistroNotasDataSet11.Matricula)

    End Sub
End Class