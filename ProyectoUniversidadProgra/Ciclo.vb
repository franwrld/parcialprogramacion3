Imports System.Data.SqlClient
Public Class Ciclo
    Public conexion As New SqlConnection(My.Settings.conexion)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            TxtCiclo.Text = ""
            TxtNumCiclo.Text = ""
            TxtAñoCarrera.Text = ""
            TxtEva1.Text = ""
            TxtEva2.Text = ""
            TxtEva3.Text = ""
            TxtCiclo.Focus()

        Else
            conexion.Open()
            Button1.Text = "Registrar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "insert into Ciclo Values (" & Integer.Parse(TxtCiclo.Text) & " , '" & TxtNumCiclo.Text & "','" & TxtAñoCarrera.Text & "','" & TxtEva1.Text & "','" & TxtEva2.Text & "','" & TxtEva3.Text & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se ingreso un nuevo ciclo con Id: " & TxtCiclo.Text & "")

            Catch ex As Exception

                MsgBox("Por favor ingrese los datos que correspondan", MsgBoxStyle.Critical, "Error, no se han ingresado datos")
            End Try
            conexion.Close()
        End If

    End Sub
End Class