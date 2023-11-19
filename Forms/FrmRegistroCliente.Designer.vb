<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroCliente))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtIdentificacionCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMaternoCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPaternoCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAgregarNivelPermiso = New System.Windows.Forms.Button()
        Me.CBGenero = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNotaCliente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 353)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TxtIdentificacionCliente
        '
        Me.TxtIdentificacionCliente.Location = New System.Drawing.Point(620, 134)
        Me.TxtIdentificacionCliente.MaxLength = 13
        Me.TxtIdentificacionCliente.Name = "TxtIdentificacionCliente"
        Me.TxtIdentificacionCliente.ShortcutsEnabled = False
        Me.TxtIdentificacionCliente.Size = New System.Drawing.Size(96, 20)
        Me.TxtIdentificacionCliente.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(492, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(144, 31)
        Me.Label7.TabIndex = 176
        Me.Label7.Text = "* Identificación:"
        '
        'CBEstado
        '
        Me.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"Activo", "Check Out", "Desactivado"})
        Me.CBEstado.Location = New System.Drawing.Point(794, 135)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(89, 21)
        Me.CBEstado.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(722, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(90, 31)
        Me.Label8.TabIndex = 174
        Me.Label8.Text = "* Estado:"
        '
        'TxtTelefonoCliente
        '
        Me.TxtTelefonoCliente.Location = New System.Drawing.Point(389, 134)
        Me.TxtTelefonoCliente.MaxLength = 10
        Me.TxtTelefonoCliente.Name = "TxtTelefonoCliente"
        Me.TxtTelefonoCliente.ShortcutsEnabled = False
        Me.TxtTelefonoCliente.Size = New System.Drawing.Size(88, 20)
        Me.TxtTelefonoCliente.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(291, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(99, 31)
        Me.Label9.TabIndex = 172
        Me.Label9.Text = "* Teléfono:"
        '
        'TxtMaternoCliente
        '
        Me.TxtMaternoCliente.Location = New System.Drawing.Point(760, 93)
        Me.TxtMaternoCliente.MaxLength = 30
        Me.TxtMaternoCliente.Name = "TxtMaternoCliente"
        Me.TxtMaternoCliente.ShortcutsEnabled = False
        Me.TxtMaternoCliente.Size = New System.Drawing.Size(123, 20)
        Me.TxtMaternoCliente.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(606, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(148, 31)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "* Apellido Materno:"
        '
        'TxtPaternoCliente
        '
        Me.TxtPaternoCliente.Location = New System.Drawing.Point(464, 93)
        Me.TxtPaternoCliente.MaxLength = 30
        Me.TxtPaternoCliente.Name = "TxtPaternoCliente"
        Me.TxtPaternoCliente.ShortcutsEnabled = False
        Me.TxtPaternoCliente.Size = New System.Drawing.Size(120, 20)
        Me.TxtPaternoCliente.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(314, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(144, 31)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "* Apellido Paterno:"
        '
        'BtnAgregarNivelPermiso
        '
        Me.BtnAgregarNivelPermiso.BackgroundImage = CType(resources.GetObject("BtnAgregarNivelPermiso.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregarNivelPermiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarNivelPermiso.Location = New System.Drawing.Point(254, 135)
        Me.BtnAgregarNivelPermiso.Name = "BtnAgregarNivelPermiso"
        Me.BtnAgregarNivelPermiso.Size = New System.Drawing.Size(21, 21)
        Me.BtnAgregarNivelPermiso.TabIndex = 167
        Me.BtnAgregarNivelPermiso.UseVisualStyleBackColor = True
        '
        'CBGenero
        '
        Me.CBGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBGenero.FormattingEnabled = True
        Me.CBGenero.Location = New System.Drawing.Point(170, 134)
        Me.CBGenero.Name = "CBGenero"
        Me.CBGenero.Size = New System.Drawing.Size(78, 21)
        Me.CBGenero.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(85, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(90, 31)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "* Género:"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Location = New System.Drawing.Point(174, 90)
        Me.TxtNombreCliente.MaxLength = 30
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.ShortcutsEnabled = False
        Me.TxtNombreCliente.Size = New System.Drawing.Size(120, 20)
        Me.TxtNombreCliente.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(85, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(99, 31)
        Me.Label2.TabIndex = 163
        Me.Label2.Text = "* Nombre:"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(11, 298)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 11
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(82, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 39)
        Me.Label1.TabIndex = 179
        Me.Label1.Text = "Registro de cliente"
        '
        'TxtNotaCliente
        '
        Me.TxtNotaCliente.Location = New System.Drawing.Point(174, 180)
        Me.TxtNotaCliente.MaxLength = 100
        Me.TxtNotaCliente.Multiline = True
        Me.TxtNotaCliente.Name = "TxtNotaCliente"
        Me.TxtNotaCliente.ShortcutsEnabled = False
        Me.TxtNotaCliente.Size = New System.Drawing.Size(225, 139)
        Me.TxtNotaCliente.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(99, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(99, 31)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "Nota:"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(800, 303)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(83, 35)
        Me.BtnLimpiar.TabIndex = 10
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para limpiar las cajas de texto (ALT + L)")
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(704, 303)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(83, 35)
        Me.BtnRegistrar.TabIndex = 9
        Me.BtnRegistrar.Text = "&Registrar"
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Clic para registrar un cliente (ALT + R)")
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'FrmRegistroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(909, 351)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.TxtNotaCliente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.TxtIdentificacionCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBEstado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTelefonoCliente)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtMaternoCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPaternoCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnAgregarNivelPermiso)
        Me.Controls.Add(Me.CBGenero)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNombreCliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegistroCliente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de cliente"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtIdentificacionCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTelefonoCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtMaternoCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPaternoCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAgregarNivelPermiso As Button
    Friend WithEvents CBGenero As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNotaCliente As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
