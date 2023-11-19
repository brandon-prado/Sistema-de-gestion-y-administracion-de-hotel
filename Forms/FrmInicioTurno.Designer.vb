<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicioTurno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicioTurno))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCantidadInicialCaja = New System.Windows.Forms.TextBox()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(2, 200)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para cancelar proceso y volver a Inicio de Sesión")
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 326)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab
        Me.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(584, 198)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(95, 38)
        Me.BtnRegistrar.TabIndex = 2
        Me.BtnRegistrar.Text = "&Registrar"
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Clic para iniciar el turno (ALT + R) (ENTER)")
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(70, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 39)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Cantidad inicial"
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.Location = New System.Drawing.Point(461, 28)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 127
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.Location = New System.Drawing.Point(297, 4)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(391, 23)
        Me.LbFecha.TabIndex = 126
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(74, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(486, 31)
        Me.Label4.TabIndex = 230
        Me.Label4.Text = "Ingresa la cantidad para iniciar turno en caja:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(74, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(486, 31)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "Cantidad incial en caja: $"
        '
        'TxtCantidadInicialCaja
        '
        Me.TxtCantidadInicialCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadInicialCaja.Location = New System.Drawing.Point(425, 136)
        Me.TxtCantidadInicialCaja.MaxLength = 7
        Me.TxtCantidadInicialCaja.Name = "TxtCantidadInicialCaja"
        Me.TxtCantidadInicialCaja.ShortcutsEnabled = False
        Me.TxtCantidadInicialCaja.Size = New System.Drawing.Size(154, 38)
        Me.TxtCantidadInicialCaja.TabIndex = 1
        '
        'FechaHora
        '
        '
        'FrmInicioTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(691, 248)
        Me.Controls.Add(Me.TxtCantidadInicialCaja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInicioTurno"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de turno"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCantidadInicialCaja As TextBox
    Friend WithEvents FechaHora As Timer
    Friend WithEvents ToolTip1 As ToolTip
End Class
