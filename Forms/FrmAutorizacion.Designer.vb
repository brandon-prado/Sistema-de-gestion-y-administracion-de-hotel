<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAutorizacion
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAutorizacion))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.CbMostrarOcultarContrasena = New System.Windows.Forms.CheckBox()
        Me.BtnAcceder = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(2, 403)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para cancelar la autorización")
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 452)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.BtnLimpiar)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.TxtUsuario)
        Me.Panel3.Controls.Add(Me.TxtContrasena)
        Me.Panel3.Controls.Add(Me.CbMostrarOcultarContrasena)
        Me.Panel3.Controls.Add(Me.BtnAcceder)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(41, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(377, 456)
        Me.Panel3.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 41)
        Me.Label4.TabIndex = 236
        Me.Label4.Text = "Para acceder al menu correspondiente requiere credenciales administrativas."
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(303, 310)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(26, 25)
        Me.BtnLimpiar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para limpiar cajas de texto")
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(124, 105)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(129, 130)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 232
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(58, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 234
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(58, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 233
        Me.Label2.Text = "Usuario:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(192, 256)
        Me.TxtUsuario.MaxLength = 15
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.ShortcutsEnabled = False
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 22)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(192, 311)
        Me.TxtContrasena.MaxLength = 20
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.ShortcutsEnabled = False
        Me.TxtContrasena.Size = New System.Drawing.Size(100, 22)
        Me.TxtContrasena.TabIndex = 2
        Me.TxtContrasena.UseSystemPasswordChar = True
        '
        'CbMostrarOcultarContrasena
        '
        Me.CbMostrarOcultarContrasena.AutoSize = True
        Me.CbMostrarOcultarContrasena.BackColor = System.Drawing.Color.Transparent
        Me.CbMostrarOcultarContrasena.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.CbMostrarOcultarContrasena.Location = New System.Drawing.Point(192, 350)
        Me.CbMostrarOcultarContrasena.Name = "CbMostrarOcultarContrasena"
        Me.CbMostrarOcultarContrasena.Size = New System.Drawing.Size(118, 22)
        Me.CbMostrarOcultarContrasena.TabIndex = 3
        Me.CbMostrarOcultarContrasena.Text = "Mostrar/Ocultar"
        Me.CbMostrarOcultarContrasena.UseVisualStyleBackColor = False
        '
        'BtnAcceder
        '
        Me.BtnAcceder.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab
        Me.BtnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAcceder.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAcceder.ForeColor = System.Drawing.Color.White
        Me.BtnAcceder.Location = New System.Drawing.Point(138, 394)
        Me.BtnAcceder.Name = "BtnAcceder"
        Me.BtnAcceder.Size = New System.Drawing.Size(95, 38)
        Me.BtnAcceder.TabIndex = 4
        Me.BtnAcceder.Text = "&Acceder"
        Me.ToolTip1.SetToolTip(Me.BtnAcceder, "Haz clic para permitir la autorización (ALT + A) (ENTER)")
        Me.BtnAcceder.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 39)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Requiere autorización"
        '
        'FrmAutorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(415, 451)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAutorizacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autorización"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents CbMostrarOcultarContrasena As CheckBox
    Friend WithEvents BtnAcceder As Button
End Class
