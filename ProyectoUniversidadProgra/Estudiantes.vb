﻿Imports System.Data.SqlClient
Public Class Estudiantes
    Public conexion As New SqlConnection(My.Settings.conexion)
    Public comprobar As SqlDataReader
    Public lector As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            TxtEstudiante.Clear()
            TxtNombre.Clear()
            TxtApellido.Clear()
            cbsexo.Text = ""
            TxtResidencia.Clear()
            TxtTelefono.Clear()
            TxtEstudiante.Focus()

        Else
            conexion.Open()
            Button1.Text = "Registrar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "insert into Estudiantes Values (" & Integer.Parse(TxtEstudiante.Text) & " , '" & TxtNombre.Text & "','" & TxtApellido.Text & "','" & cbsexo.Text & "','" & TxtResidencia.Text & "','" & Integer.Parse(TxtTelefono.Text) & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se registro el Estudiante: " & TxtNombre.Text & " " & TxtApellido.Text & "")

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
            eliminar.CommandText = "DELETE from Estudiantes where IdEstudiante = " & Integer.Parse(TxtEstudiante.Text)

            eliminar.ExecuteNonQuery()
            MsgBox("Se eliminó el Estudiante con ID : " & TxtEstudiante.Text & "")
        Catch ex As Exception
            MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
        End Try
        conexion.Close()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.Open()
        Dim comando As New SqlCommand("selectestudi", conexion)



        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@idestudiante", TxtEstudiante.Text)

            lector = comando.ExecuteReader
            lector.Read()
            If (lector.HasRows()) Then
                TxtNombre.Text = lector("Nombre")
                TxtApellido.Text = lector("Apellidos")
                cbsexo.Text = lector("Sexo")
                TxtResidencia.Text = lector("Residencia")
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
            TxtEstudiante.Clear()
            TxtNombre.Clear()
            TxtApellido.Clear()
            cbsexo.Text = ""
            TxtResidencia.Clear()
            TxtTelefono.Clear()
            TxtEstudiante.Focus()
        Else
            conexion.Open()
            Button4.Text = "Editar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "update Estudiantes set Nombre = '" & TxtNombre.Text & "',Apellidos = '" & TxtApellido.Text & "',Sexo = '" & cbsexo.Text & "',Residencia = '" & TxtResidencia.Text & "',Telefono = '" & TxtTelefono.Text & "' where IdEstudiante = " & Integer.Parse(TxtEstudiante.Text)

                comando.ExecuteNonQuery()
                MsgBox("Se actualizo el Estudiante con Id: " & TxtEstudiante.Text)
            Catch ex As Exception
                MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
            End Try
            conexion.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sqll As String
        sqll = "Select*From Estudiantes"
        Dim adapt As New SqlClient.SqlDataAdapter(sqll, conexion)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "IdEstudiante")
        DataGridView1.DataSource = obtenerdatos
        DataGridView1.DataMember = "IdEstudiante"
    End Sub

    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaRegistroNotasDataSet12.Estudiantes' Puede moverla o quitarla según sea necesario.
        Me.EstudiantesTableAdapter2.Fill(Me.SistemaRegistroNotasDataSet12.Estudiantes)

    End Sub

End Class

