Imports System.Data.SqlClient
Public Class boletadenotas
    Public conexion As New SqlConnection(My.Settings.conexion)
    Public comprobar As SqlDataReader
    Public lector As SqlDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            TxtIdboleta.Clear()
            TxtIdAsignatura.Clear()
            cbciclo.Text = ""
            TxtIdEstudiante.Clear()
            TxtIdboleta.Focus()

        Else
            conexion.Open()
            Button1.Text = "Registrar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "insert into BoletaDeNotas Values (" & Integer.Parse(TxtIdboleta.Text) & " , '" & Integer.Parse(TxtIdAsignatura.Text) & "','" & Integer.Parse(cbciclo.Text) & "','" & Integer.Parse(TxtIdEstudiante.Text) & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se ingreso una nueva boleta de notas: " & TxtIdboleta.Text & "")

            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
            conexion.Close()
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conexion.Open()
        Dim eliminar As New SqlCommand("", conexion)

        Try
            eliminar.CommandType = CommandType.Text
            eliminar.CommandText = "DELETE from BoletaDeNotas where IdBoleta = " & Integer.Parse(TxtIdboleta.Text)

            eliminar.ExecuteNonQuery()
            MsgBox("Se eliminó la Boleta con ID : " & TxtIdboleta.Text & "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.Open()
        Dim comando As New SqlCommand("selectboleta", conexion)



        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@idboleta", TxtIdboleta.Text)

            lector = comando.ExecuteReader
            lector.Read()
            If (lector.HasRows()) Then
                TxtIdAsignatura.Text = lector("IdAsignatura")
                cbciclo.Text = lector("IdCiclo")
                TxtIdEstudiante.Text = lector("IdEstudiante")
            Else
                MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
            End If
        Catch ex As Exception
            MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
        End Try
        conexion.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Button4.Text = "Editar") Then
            Button4.Text = "Guardar"
            TxtIdboleta.Clear()
            TxtIdAsignatura.Clear()
            cbciclo.Text = ""
            TxtIdEstudiante.Clear()
            TxtIdboleta.Focus()
        Else
            conexion.Open()
            Button4.Text = "Editar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "update BoletaDeNotas set IdBoleta = '" & Integer.Parse(TxtIdboleta.Text) & "',IdAsignatura = '" & Integer.Parse(TxtIdAsignatura.Text) & "',IdCiclo ='" & Integer.Parse(cbciclo.Text) & "',IdEstudiante ='" & Integer.Parse(TxtIdEstudiante.Text) & "' where IdBoleta = " & Integer.Parse(TxtIdboleta.Text)

                comando.ExecuteNonQuery()
                MsgBox("Se actualizo la BoletoDeNota con Id: " & TxtIdboleta.Text)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conexion.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sqll As String
        sqll = "Select*From BoletaDeNotas"
        Dim adapt As New SqlClient.SqlDataAdapter(sqll, conexion)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "IdBoleta")
        DataGridView1.DataSource = obtenerdatos
        DataGridView1.DataMember = "IdBoleta"
    End Sub

    Private Sub boletadenotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaRegistroNotasDataSet13.BoletaDeNotas' Puede moverla o quitarla según sea necesario.
        Me.BoletaDeNotasTableAdapter2.Fill(Me.SistemaRegistroNotasDataSet13.BoletaDeNotas)

    End Sub
End Class