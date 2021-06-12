Imports System.Data.SqlClient
Public Class Docentes
    Public conexion As New SqlConnection(My.Settings.conexion)
    Public comprobar As SqlDataReader
    Public lector As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            TxtIdDocente.Clear()
            TxtNombre.Clear()
            TxtApellido.Clear()
            TxtDireccion.Clear()
            TxtEmail.Clear()
            TxtTelefono.Clear()
            TxtIdDocente.Focus()

        Else
            conexion.Open()
            Button1.Text = "Registrar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "INSERT INTO Docente VALUES (" & Integer.Parse(TxtIdDocente.Text) & " , '" & TxtNombre.Text & "','" & TxtApellido.Text & "','" & TxtDireccion.Text & "','" & TxtEmail.Text & "','" & Integer.Parse(TxtTelefono.Text) & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se ingreso el nuevo Docente: " & TxtNombre.Text & " " & TxtApellido.Text & "")

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
            eliminar.CommandText = "DELETE FROM Docente WHERE IdDocente = " & Integer.Parse(TxtIdDocente.Text)

            eliminar.ExecuteNonQuery()
            MsgBox("Se eliminó el Docente con ID : " & TxtIdDocente.Text & "")
        Catch ex As Exception
            MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
        End Try
        conexion.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.Open()
        Dim comando As New SqlCommand("selectdocente", conexion)



        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@iddocente", TxtIdDocente.Text)

            lector = comando.ExecuteReader
            lector.Read()
            If (lector.HasRows()) Then
                TxtNombre.Text = lector("Nombre")
                TxtApellido.Text = lector("Apellidos")
                TxtDireccion.Text = lector("Direccion")
                TxtEmail.Text = lector("EmailDocente")
                TxtTelefono.Text = lector("Telefono")
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
            TxtIdDocente.Clear()
            TxtNombre.Clear()
            TxtApellido.Clear()
            TxtDireccion.Clear()
            TxtEmail.Clear()
            TxtTelefono.Clear()
            TxtIdDocente.Focus()
        Else
            conexion.Open()
            Button4.Text = "Editar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "update Docente set Nombre = '" & TxtNombre.Text & "',Apellido = '" & TxtApellido.Text & "',Direccion = '" & TxtDireccion.Text & "',EmailDocente = '" & TxtEmail.Text & "',Telefono = '" & TxtTelefono.Text & "' where IdDocente = " & Integer.Parse(TxtIdDocente.Text)

                comando.ExecuteNonQuery()
                MsgBox("Se actualizo el Docente con Id: " & TxtIdDocente.Text)
            Catch ex As Exception
                MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
            End Try
            conexion.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sqll As String
        sqll = "Select*From Docente"
        Dim adapt As New SqlClient.SqlDataAdapter(sqll, conexion)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "IdDocente")
        DataGridView1.DataSource = obtenerdatos
        DataGridView1.DataMember = "IdDocente"
    End Sub


End Class