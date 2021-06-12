Imports System.Data.SqlClient
Public Class FeEstudio
    Public conexion As New SqlConnection(My.Settings.conexion)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            TxtCodFecha.Text = ""
            TxtFechaI.Text = ""
            TxtFechaF.Text = ""
            TxtCodFecha.Focus()

        Else
            conexion.Open()
            Button1.Text = "Registrar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "insert into FeEstudio Values (" & Integer.Parse(TxtCodFecha.Text) & " , '" & TxtFechaI.Text & "','" & TxtFechaF.Text & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se ingreso la nueva fecha con codigo: " & TxtCodFecha.Text & "")

            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
            conexion.Close()
        End If
    End Sub
End Class