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
        Me.Picture = New System.Windows.Forms.PictureBox()
        Me.Picture_salir = New System.Windows.Forms.PictureBox()
        Me.Picture_ingresar = New System.Windows.Forms.PictureBox()
        Me.Comb_tipo = New System.Windows.Forms.ComboBox()
        Me.Txt_clave = New System.Windows.Forms.TextBox()
        Me.Txt_usuario = New System.Windows.Forms.TextBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_salir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picture_ingresar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture
        '
        Me.Picture.Image = CType(resources.GetObject("Picture.Image"), System.Drawing.Image)
        Me.Picture.Location = New System.Drawing.Point(233, 12)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(132, 130)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 22
        Me.Picture.TabStop = False
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
        'Txt_clave
        '
        Me.Txt_clave.Location = New System.Drawing.Point(62, 38)
        Me.Txt_clave.Name = "Txt_clave"
        Me.Txt_clave.Size = New System.Drawing.Size(165, 20)
        Me.Txt_clave.TabIndex = 18
        Me.Txt_clave.UseSystemPasswordChar = True
        '
        'Txt_usuario
        '
        Me.Txt_usuario.Location = New System.Drawing.Point(62, 12)
        Me.Txt_usuario.Name = "Txt_usuario"
        Me.Txt_usuario.Size = New System.Drawing.Size(165, 20)
        Me.Txt_usuario.TabIndex = 17
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(192, 155)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(173, 12)
        Me.lblInfo.TabIndex = 16
        Me.lblInfo.Text = "Copyright ©2016 Derechos Reservados"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(10, 65)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(31, 13)
        Me.lblTipo.TabIndex = 15
        Me.lblTipo.Text = "Tipo:"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(10, 41)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(37, 13)
        Me.lblClave.TabIndex = 14
        Me.lblClave.Text = "Clave:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(10, 15)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 13
        Me.lblUsuario.Text = "Usuario:"
        '
        'FormAutenticacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(376, 181)
        Me.Controls.Add(Me.Picture)
        Me.Controls.Add(Me.Picture_salir)
        Me.Controls.Add(Me.Picture_ingresar)
        Me.Controls.Add(Me.Comb_tipo)
        Me.Controls.Add(Me.Txt_clave)
        Me.Controls.Add(Me.Txt_usuario)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.lblUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormAutenticacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso - SysControl"
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_salir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picture_ingresar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picture As PictureBox
    Friend WithEvents Picture_salir As PictureBox
    Friend WithEvents Picture_ingresar As PictureBox
    Friend WithEvents Comb_tipo As ComboBox
    Friend WithEvents Txt_clave As TextBox
    Friend WithEvents Txt_usuario As TextBox
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents lblClave As Label
    Friend WithEvents lblUsuario As Label
End Class
