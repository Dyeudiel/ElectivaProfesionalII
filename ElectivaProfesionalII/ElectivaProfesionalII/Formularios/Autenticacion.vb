Public Class FormAutenticacion
    'Formato de Autenticacion
    Private Sub FormAutenticacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection
        cn.Open("dsn=ElectivaProfesionalII")
        'valida que la DB este OK, si no lo esta aparece el MSG de ConexionDB.vb
        If cn.State = ConnectionState.Closed Then
            ConexionDB.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Picture_salir_Click(sender As Object, e As EventArgs) Handles Picture_salir.Click
        End
    End Sub

End Class
