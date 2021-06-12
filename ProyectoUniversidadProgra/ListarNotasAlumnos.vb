Imports System.Data.SqlClient
Public Class ListarNotasAlumnos
    Public conexion As New SqlConnection(My.Settings.conexion)
    Public comprobar As SqlDataReader
    Public lector As SqlDataReader

    Private Sub botonconsultar_Click(sender As Object, e As EventArgs) Handles botonconsultar.Click
        conexion.Open()
        Dim comando As New SqlCommand("listnotas", conexion)

        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@idestudiante", txtidestudiante.Text)
            comando.Parameters.AddWithValue("@idasignatura", txtidasignatura.Text)
            comando.Parameters.AddWithValue("@idperiodo", txtidperiodo.Text)
            comando.Parameters.AddWithValue("@idboleta", txtidboleta.Text)

            lector = comando.ExecuteReader
            lector.Read()
            If (lector.HasRows()) Then
                txtnombre.Text = lector("Nombre")
                txtapellidos.Text = lector("Apellidos")
                txtnombreasigna.Text = lector("NombreAsignatura")
                txtdescripcion.Text = lector("DescripcionNota")
                txtnota.Text = lector("Nota")
                txtpuntos.Text = lector("Puntos")
            Else
                MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()
    End Sub

End Class