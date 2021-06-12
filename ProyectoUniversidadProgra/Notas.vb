Imports System.Data.SqlClient
Public Class Notas
    Public conexion As New SqlConnection(My.Settings.conexion)
    Public comprobar As SqlDataReader
    Public lector As SqlDataReader
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Registrar") Then
            Button1.Text = "Guardar"
            Txtdetallenota.Clear()
            TxtIdboleta.Clear()
            Txtnota.Clear()
            Txtdescripcion.Clear()
            TxtPorcentaje.Clear()
            cbidperiodo.Text = ""
            Txtdetallenota.Focus()

        Else
            conexion.Open()
            Button1.Text = "Registrar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "insert into DetalleNota Values (" & Integer.Parse(Txtdetallenota.Text) & " , '" & Integer.Parse(TxtIdboleta.Text) & "','" & Double.Parse(Txtnota.Text) & "','" & Txtdescripcion.Text & "','" & Double.Parse(TxtPorcentaje.Text) & "','" & Integer.Parse(cbidperiodo.Text) & "')"

                comando.ExecuteNonQuery()
                MsgBox("Se ingreso una nueva nota: " & Txtdetallenota.Text & "")

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
            eliminar.CommandText = "DELETE from DetalleNota where IdDetalleNota = " & Integer.Parse(Txtdetallenota.Text)

            eliminar.ExecuteNonQuery()
            MsgBox("Se eliminó la Nota con ID : " & Txtdetallenota.Text & "")
        Catch ex As Exception
            MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
        End Try
        conexion.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conexion.Open()
        Dim comando As New SqlCommand("selectdetalle", conexion)



        Try
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@iddetalle", Txtdetallenota.Text)

            lector = comando.ExecuteReader
            lector.Read()
            If (lector.HasRows()) Then
                TxtIdboleta.Text = lector("IdBoleta")
                Txtnota.Text = lector("Nota")
                Txtdescripcion.Text = lector("DescripcionNota")
                TxtPorcentaje.Text = lector("Porcentaje")
                cbidperiodo.Text = lector("IdPeriodo")
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
            Txtdetallenota.Clear()
            TxtIdboleta.Clear()
            Txtnota.Clear()
            Txtdescripcion.Clear()
            TxtPorcentaje.Clear()
            cbidperiodo.Text = ""
            Txtdetallenota.Focus()
        Else
            conexion.Open()
            Button4.Text = "Editar"
            Dim comando As New SqlCommand("", conexion)


            Try
                comando.CommandType = CommandType.Text
                comando.CommandText = "update DetalleNota set IdDetalleNota = '" & Integer.Parse(Txtdetallenota.Text) & "',IdBoleta = '" & Integer.Parse(TxtIdboleta.Text) & "',Nota = '" & Double.Parse(Txtnota.Text) & "',DescripcionNota = '" & Txtdescripcion.Text & "',Porcentaje = '" & Double.Parse(TxtPorcentaje.Text) & "',IdPeriodo = '" & Integer.Parse(cbidperiodo.Text) & "' where IdDetalleNota = " & Integer.Parse(Txtdetallenota.Text)

                comando.ExecuteNonQuery()
                MsgBox("Se actualizo la nota con Id: " & Txtdetallenota.Text)
            Catch ex As Exception
                MsgBox("ERROR.DATOS INCORRECTOS", MsgBoxStyle.Critical, "ERROR.NO HAY DATOS INGRESADOS")
            End Try
            conexion.Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sqll As String
        sqll = "Select*From DetalleNota"
        Dim adapt As New SqlClient.SqlDataAdapter(sqll, conexion)
        Dim obtenerdatos As New DataSet
        adapt.Fill(obtenerdatos, "IdDetalleNota")
        DataGridView1.DataSource = obtenerdatos
        DataGridView1.DataMember = "IdDetalleNota"
    End Sub

    Private Sub Notas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'SistemaRegistroNotasDataSet14.DetalleNota' Puede moverla o quitarla según sea necesario.
        Me.DetalleNotaTableAdapter2.Fill(Me.SistemaRegistroNotasDataSet14.DetalleNota)
        'TODO: esta línea de código carga datos en la tabla 'SistemaRegistroNotasDataSet9.DetalleNota' Puede moverla o quitarla según sea necesario.
        Me.DetalleNotaTableAdapter1.Fill(Me.SistemaRegistroNotasDataSet9.DetalleNota)

    End Sub


End Class