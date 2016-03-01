<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDetalleFacturaProveedor = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.lblNIT = New System.Windows.Forms.Label()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.lblNombreProveedor = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.txtNIT = New System.Windows.Forms.TextBox()
        CType(Me.dgvDetalleFacturaProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetalleFacturaProveedor
        '
        Me.dgvDetalleFacturaProveedor.AllowUserToOrderColumns = True
        Me.dgvDetalleFacturaProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalleFacturaProveedor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Cantidad, Me.Valor, Me.Total})
        Me.dgvDetalleFacturaProveedor.Location = New System.Drawing.Point(16, 114)
        Me.dgvDetalleFacturaProveedor.Name = "dgvDetalleFacturaProveedor"
        Me.dgvDetalleFacturaProveedor.Size = New System.Drawing.Size(750, 204)
        Me.dgvDetalleFacturaProveedor.TabIndex = 0
        '
        'Codigo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Codigo.DefaultCellStyle = DataGridViewCellStyle1
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        '
        'Descripcion
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle2
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 310
        '
        'Cantidad
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.Format = "N1"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Cantidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Valor
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Valor.DefaultCellStyle = DataGridViewCellStyle4
        Me.Valor.Frozen = True
        Me.Valor.HeaderText = "Valor"
        Me.Valor.Name = "Valor"
        '
        'Total
        '
        Me.Total.Frozen = True
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(588, 14)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(46, 13)
        Me.lblFactura.TabIndex = 1
        Me.lblFactura.Text = "Factura:"
        '
        'txtFactura
        '
        Me.txtFactura.Location = New System.Drawing.Point(640, 11)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(126, 20)
        Me.txtFactura.TabIndex = 2
        '
        'lblNIT
        '
        Me.lblNIT.AutoSize = True
        Me.lblNIT.Location = New System.Drawing.Point(13, 14)
        Me.lblNIT.Name = "lblNIT"
        Me.lblNIT.Size = New System.Drawing.Size(28, 13)
        Me.lblNIT.TabIndex = 3
        Me.lblNIT.Text = "NIT:"
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.Location = New System.Drawing.Point(118, 44)
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(258, 20)
        Me.txtNombreProveedor.TabIndex = 6
        '
        'lblNombreProveedor
        '
        Me.lblNombreProveedor.AutoSize = True
        Me.lblNombreProveedor.Location = New System.Drawing.Point(12, 47)
        Me.lblNombreProveedor.Name = "lblNombreProveedor"
        Me.lblNombreProveedor.Size = New System.Drawing.Size(99, 13)
        Me.lblNombreProveedor.TabIndex = 5
        Me.lblNombreProveedor.Text = "Nombre Proveedor:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New System.Drawing.Point(12, 81)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(52, 13)
        Me.lblTelefono.TabIndex = 7
        Me.lblTelefono.Text = "Telefono:"
        '
        'txtTelefonoProveedor
        '
        Me.txtTelefonoProveedor.Location = New System.Drawing.Point(118, 78)
        Me.txtTelefonoProveedor.Name = "txtTelefonoProveedor"
        Me.txtTelefonoProveedor.Size = New System.Drawing.Size(127, 20)
        Me.txtTelefonoProveedor.TabIndex = 8
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(588, 47)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 13)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(640, 41)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(126, 20)
        Me.dtpFecha.TabIndex = 10
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(690, 325)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.btnFinalizar.TabIndex = 11
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = True
        '
        'txtNIT
        '
        Me.txtNIT.Location = New System.Drawing.Point(118, 12)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.Size = New System.Drawing.Size(127, 20)
        Me.txtNIT.TabIndex = 4
        '
        'IngresoInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 361)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtTelefonoProveedor)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtNombreProveedor)
        Me.Controls.Add(Me.lblNombreProveedor)
        Me.Controls.Add(Me.txtNIT)
        Me.Controls.Add(Me.lblNIT)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.lblFactura)
        Me.Controls.Add(Me.dgvDetalleFacturaProveedor)
        Me.Name = "IngresoInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso Inventario"
        CType(Me.dgvDetalleFacturaProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDetalleFacturaProveedor As DataGridView
    Friend WithEvents lblFactura As Label
    Friend WithEvents txtFactura As TextBox
    Friend WithEvents lblNIT As Label
    Friend WithEvents txtNombreProveedor As TextBox
    Friend WithEvents lblNombreProveedor As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefonoProveedor As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Valor As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents txtNIT As TextBox
End Class
