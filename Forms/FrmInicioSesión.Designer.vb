<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicioSesión
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicioSesión))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAcceder = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbMostrarOcultarContrasena = New System.Windows.Forms.CheckBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackgroundImage = CType(resources.GetObject("BtnLimpiar.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiar.Location = New System.Drawing.Point(341, 325)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(26, 25)
        Me.BtnLimpiar.TabIndex = 227
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para limpiar las cajas de texto")
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Crimson
        Me.BtnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.BtnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(265, 416)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(95, 38)
        Me.BtnSalir.TabIndex = 5
        Me.BtnSalir.Text = "&Salir"
        Me.ToolTip1.SetToolTip(Me.BtnSalir, "Clic para cerrar el sistema (ALT + S)")
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'BtnAcceder
        '
        Me.BtnAcceder.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnAcceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab
        Me.BtnAcceder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAcceder.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnAcceder.ForeColor = System.Drawing.Color.White
        Me.BtnAcceder.Location = New System.Drawing.Point(132, 416)
        Me.BtnAcceder.Name = "BtnAcceder"
        Me.BtnAcceder.Size = New System.Drawing.Size(95, 38)
        Me.BtnAcceder.TabIndex = 4
        Me.BtnAcceder.Text = "&Acceder"
        Me.ToolTip1.SetToolTip(Me.BtnAcceder, "Clic para acceder al sistema (ALT + A) (ENTER)")
        Me.BtnAcceder.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(480, 477)
        Me.Panel1.TabIndex = 93
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(482, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 94
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(482, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(433, 477)
        Me.Panel2.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 505)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(21, -14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(459, 553)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.BtnLimpiar)
        Me.Panel4.Controls.Add(Me.BtnSalir)
        Me.Panel4.Controls.Add(Me.PictureBox3)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.TxtUsuario)
        Me.Panel4.Controls.Add(Me.TxtContrasena)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.CbMostrarOcultarContrasena)
        Me.Panel4.Controls.Add(Me.BtnAcceder)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Location = New System.Drawing.Point(482, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(434, 474)
        Me.Panel4.TabIndex = 94
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(141, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(153, 152)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 109
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(96, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(96, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 24)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "Usuario:"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(230, 271)
        Me.TxtUsuario.MaxLength = 15
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.ShortcutsEnabled = False
        Me.TxtUsuario.Size = New System.Drawing.Size(100, 22)
        Me.TxtUsuario.TabIndex = 1
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(230, 326)
        Me.TxtContrasena.MaxLength = 20
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.ShortcutsEnabled = False
        Me.TxtContrasena.Size = New System.Drawing.Size(100, 22)
        Me.TxtContrasena.TabIndex = 2
        Me.TxtContrasena.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(427, 64)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "iHola!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CbMostrarOcultarContrasena
        '
        Me.CbMostrarOcultarContrasena.AutoSize = True
        Me.CbMostrarOcultarContrasena.BackColor = System.Drawing.Color.Transparent
        Me.CbMostrarOcultarContrasena.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.CbMostrarOcultarContrasena.Location = New System.Drawing.Point(230, 365)
        Me.CbMostrarOcultarContrasena.Name = "CbMostrarOcultarContrasena"
        Me.CbMostrarOcultarContrasena.Size = New System.Drawing.Size(118, 22)
        Me.CbMostrarOcultarContrasena.TabIndex = 3
        Me.CbMostrarOcultarContrasena.Text = "Mostrar/Ocultar"
        Me.CbMostrarOcultarContrasena.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(-29, -13)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(463, 56)
        Me.PictureBox4.TabIndex = 114
        Me.PictureBox4.TabStop = False
        '
        'FrmInicioSesión
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 477)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInicioSesión"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de sesión  -  Hotel Posada Favela"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CbMostrarOcultarContrasena As CheckBox
    Friend WithEvents BtnAcceder As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
