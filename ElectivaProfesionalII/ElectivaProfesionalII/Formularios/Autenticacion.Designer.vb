<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAutenticacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAutenticacion))
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Picture_salir = New System.Windows.Forms.PictureBox()
        Me.Picture_ingresar = New System.Windows.Forms.PictureBox()
        Me.Comb_tipo = New System.Windows.Forms.ComboBox()
        Me.Text_clave = New System.Windows.Forms.TextBox()
        Me.Text_usuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_ingresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(233, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(132, 130)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'Picture_salir
        '
        Me.Picture_salir.Image = CType(resources.GetObject("Picture_salir.Image"), System.Drawing.Image)
        Me.Picture_salir.Location = New System.Drawing.Point(110, 102)
        Me.Picture_salir.Name = "Picture_salir"
        Me.Picture_salir.Size = New System.Drawing.Size(74, 62)
        Me.Picture_salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture_salir.TabIndex = 21
        Me.Picture_salir.TabStop = False
        '
        'Picture_ingresar
        '
        Me.Picture_ingresar.Image = CType(resources.GetObject("Picture_ingresar.Image"), System.Drawing.Image)
        Me.Picture_ingresar.Location = New System.Drawing.Point(13, 102)
        Me.Picture_ingresar.Name = "Picture_ingresar"
        Me.Picture_ingresar.Size = New System.Drawing.Size(74, 62)
        Me.Picture_ingresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture_ingresar.TabIndex = 20
        Me.Picture_ingresar.TabStop = False
        '
        'Comb_tipo
        '
        Me.Comb_tipo.FormattingEnabled = True
        Me.Comb_tipo.Items.AddRange(New Object() {"Administrador", "Empleado", "Contador"})
        Me.Comb_tipo.Location = New System.Drawing.Point(62, 62)
        Me.Comb_tipo.Name = "Comb_tipo"
        Me.Comb_tipo.Size = New System.Drawing.Size(165, 21)
        Me.Comb_tipo.TabIndex = 19
        '
        'Text_clave
        '
        Me.Text_clave.Location = New System.Drawing.Point(62, 38)
        Me.Text_clave.Name = "Text_clave"
        Me.Text_clave.Size = New System.Drawing.Size(165, 20)
        Me.Text_clave.TabIndex = 18
        Me.Text_clave.UseSystemPasswordChar = True
        '
        'Text_usuario
        '
        Me.Text_usuario.Location = New System.Drawing.Point(62, 12)
        Me.Text_usuario.Name = "Text_usuario"
        Me.Text_usuario.Size = New System.Drawing.Size(165, 20)
        Me.Text_usuario.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 12)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Copyright ©2016 Derechos Reservados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Clave:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Usuario:"
        '
        'FormAutenticacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(376, 181)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Picture_salir)
        Me.Controls.Add(Me.Picture_ingresar)
        Me.Controls.Add(Me.Comb_tipo)
        Me.Controls.Add(Me.Text_clave)
        Me.Controls.Add(Me.Text_usuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAutenticacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso - SysControl"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_ingresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Picture_salir As PictureBox
    Friend WithEvents Picture_ingresar As PictureBox
    Friend WithEvents Comb_tipo As ComboBox
    Friend WithEvents Text_clave As TextBox
    Friend WithEvents Text_usuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
