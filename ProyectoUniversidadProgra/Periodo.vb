Imports System.Data.SqlClient
Public Class Periodo
    Public conexion As New SqlConnection(My.Settings.conexion)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            TxtPeriodo.Text = ""
            TxtDescripcion.Text = ""
            TxtPeriodo.Focus()

        Else
            conexion.Open()
            Button1.Text = "Nuevo"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "insert into Periodo Values (" & Integer.Parse(TxtPeriodo.Text) & " , '" & TxtDescripcion.Text & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se ingreso el nuevo Periodo: " & TxtDescripcion.Text & "")

            Catch ex As Exception

                MsgBox("Por favor ingrese los datos que correspondan", MsgBoxStyle.Critical, "Error, no se han ingresado datos")
            End Try
            conexion.Close()
        End If
    End Sub

End Class