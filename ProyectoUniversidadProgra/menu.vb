Imports System.Data.SqlClient
Public Class menu
    Public conexion As New SqlConnection(My.Settings.conexion)

    Private Sub botonRE_Click(sender As Object, e As EventArgs) Handles botonRE.Click
        Estudiantes.Show()
    End Sub

    Private Sub botonRD_Click(sender As Object, e As EventArgs) Handles botonRD.Click
        Docentes.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Asignatura.Show()
    End Sub

    Private Sub botonRM_Click(sender As Object, e As EventArgs) Handles botonRM.Click
        Matricula.Show()
    End Sub

    Private Sub botonRN_Click(sender As Object, e As EventArgs) Handles botonRN.Click
        Notas.Show()
    End Sub

    Private Sub BotonLNA_Click(sender As Object, e As EventArgs) Handles BotonLNA.Click
        ListarNotasAlumnos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        boletadenotas.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("¿Desea salir del programa?", vbQuestion + vbYesNo, "Pregunta") = vbYes Then
            End
        End If
    End Sub

End Class


