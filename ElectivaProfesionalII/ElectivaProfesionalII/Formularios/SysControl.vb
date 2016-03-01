Public Class SysControl
    Private Sub SysControl_Load(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnIngresoInventario_Click(sender As Object, e As EventArgs) Handles btnIngresoInventario.Click
        IngresoInventario.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class