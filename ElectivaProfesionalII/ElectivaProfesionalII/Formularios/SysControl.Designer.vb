<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SysControl
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnIngresoInventario = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnIngresoInventario
        '
        Me.btnIngresoInventario.Location = New System.Drawing.Point(454, 12)
        Me.btnIngresoInventario.Name = "btnIngresoInventario"
        Me.btnIngresoInventario.Size = New System.Drawing.Size(118, 23)
        Me.btnIngresoInventario.TabIndex = 0
        Me.btnIngresoInventario.Text = "Ingreso Inventario"
        Me.btnIngresoInventario.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(454, 177)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'SysControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresoInventario)
        Me.MaximizeBox = False
        Me.Name = "SysControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SysControl"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnIngresoInventario As Button
    Friend WithEvents btnSalir As Button
End Class
