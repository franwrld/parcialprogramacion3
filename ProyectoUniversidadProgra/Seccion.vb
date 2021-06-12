Imports System.Data.SqlClient
Public Class Seccion
    Public conexion As New SqlConnection(My.Settings.conexion)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            TxtSeccion.Text = ""
            TxtNomSeccion.Text = ""
            TxtAsignaturaSe.Text = ""
            TxtIdDocenteSe.Text = ""
            TxtIdCodFecha.Text = ""
            TxtSeccion.Focus()

        Else
            conexion.Open()
            Button1.Text = "Registrar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "insert into Seccion Values (" & Integer.Parse(TxtSeccion.Text) & " , '" & TxtNomSeccion.Text & "','" & TxtAsignaturaSe.Text & "','" & TxtIdDocenteSe.Text & "','" & TxtIdCodFecha.Text & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se ingreso la nueva Seccion: " & TxtNomSeccion.Text & "")

            Catch ex As Exception

                MsgBox("Por favor ingrese los datos que correspondan", MsgBoxStyle.Critical, "Error, no se han ingresado datos")
            End Try
            conexion.Close()
        End If

    End Sub
End Class