﻿Public Class ConexionDB
    Private Sub ConexionDB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnReintentar_Click(sender As Object, e As EventArgs) Handles btnReintentar.Click
        cn = New ADODB.Connection
        cn.Open("dsn=ElectivaProfesionalII")
        If cn.State = ConnectionState.Open Then
            FormAutenticacion.Show()
            Me.Hide()
        End If
    End Sub
End Class