Public Class IngresoInventario

    Private Sub IngresoInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn = New ADODB.Connection

        cn.Open("Driver={SQL Server Native Client 11.0};Server=tcp:unitec.database.windows.net,1433;Database=ElectivaProfesionalII;Uid=Yeudiel@unitec;Pwd={Semeolvido+};Encrypt=yes;TrustServerCertificate=no;Connection Timeout=30;")

        txtNombreProveedor.Enabled = False
        txtTelefonoProveedor.Enabled = False
    End Sub


    Private Sub txtNIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIT.KeyPress

        txtNombreProveedor.Enabled = False
        txtTelefonoProveedor.Enabled = False
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
        If e.KeyChar() = ChrW(13) Then
            rs = New ADODB.Recordset
            rs.LockType = ADODB.LockTypeEnum.adLockOptimistic
            rs.CursorType = ADODB.CursorTypeEnum.adOpenKeyset
            rs.let_Source("select * from tblProveedores where id_proveedor = '" & Me.txtNIT.Text & "'")
            rs.ActiveConnection = cn
            rs.Open()
            If rs.RecordCount > 0 Then
                Me.txtNombreProveedor.Text = rs.Fields("NombreProveedor").Value
            Else
                MsgBox("Proveedor no creado en el sistema")

            End If
        End If
    End Sub


End Class

