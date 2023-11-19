<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRol))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtRol = New System.Windows.Forms.TextBox()
        Me.BtnAgregarNivelPermiso = New System.Windows.Forms.Button()
        Me.CBNivelPermiso = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVRoles = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnRegresar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(51, 345)
        Me.Panel1.TabIndex = 5
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(3, 294)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 7
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 345)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(52, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(51, 287)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.TxtRol)
        Me.Panel3.Controls.Add(Me.BtnAgregarNivelPermiso)
        Me.Panel3.Controls.Add(Me.CBNivelPermiso)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.TxtDescripcion)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.BtnLimpiar)
        Me.Panel3.Controls.Add(Me.BtnEliminar)
        Me.Panel3.Controls.Add(Me.BtnRegistrar)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.DGVRoles)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(50, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(510, 345)
        Me.Panel3.TabIndex = 6
        '
        'TxtRol
        '
        Me.TxtRol.Location = New System.Drawing.Point(127, 66)
        Me.TxtRol.MaxLength = 20
        Me.TxtRol.Name = "TxtRol"
        Me.TxtRol.ShortcutsEnabled = False
        Me.TxtRol.Size = New System.Drawing.Size(94, 20)
        Me.TxtRol.TabIndex = 1
        '
        'BtnAgregarNivelPermiso
        '
        Me.BtnAgregarNivelPermiso.BackgroundImage = CType(resources.GetObject("BtnAgregarNivelPermiso.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregarNivelPermiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarNivelPermiso.Location = New System.Drawing.Point(475, 66)
        Me.BtnAgregarNivelPermiso.Name = "BtnAgregarNivelPermiso"
        Me.BtnAgregarNivelPermiso.Size = New System.Drawing.Size(21, 21)
        Me.BtnAgregarNivelPermiso.TabIndex = 141
        Me.BtnAgregarNivelPermiso.UseVisualStyleBackColor = True
        '
        'CBNivelPermiso
        '
        Me.CBNivelPermiso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNivelPermiso.FormattingEnabled = True
        Me.CBNivelPermiso.Location = New System.Drawing.Point(376, 66)
        Me.CBNivelPermiso.Name = "CBNivelPermiso"
        Me.CBNivelPermiso.Size = New System.Drawing.Size(95, 21)
        Me.CBNivelPermiso.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(237, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(143, 31)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Nivel de permiso:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(127, 94)
        Me.TxtDescripcion.MaxLength = 100
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ShortcutsEnabled = False
        Me.TxtDescripcion.Size = New System.Drawing.Size(370, 49)
        Me.TxtDescripcion.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(16, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(105, 31)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Descripción:"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal
        Me.BtnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(423, 308)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 6
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para limpiar las cajas de texto (ALT + L)")
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.BtnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed
        Me.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(338, 308)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 5
        Me.BtnEliminar.Text = "&Eliminar"
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Clic para eliminar el rol seleccionado (ALT + E)")
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(250, 308)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrar.TabIndex = 4
        Me.BtnRegistrar.Text = "&Registrar"
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Clic para registrar/modificar el rol (ALT + R)")
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(222, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(72, 31)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "*"
        '
        'DGVRoles
        '
        Me.DGVRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRoles.Location = New System.Drawing.Point(20, 158)
        Me.DGVRoles.Name = "DGVRoles"
        Me.DGVRoles.ReadOnly = True
        Me.DGVRoles.Size = New System.Drawing.Size(477, 134)
        Me.DGVRoles.TabIndex = 130
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(72, 31)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Rol:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 39)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Administrar roles"
        '
        'FrmRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(559, 344)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRol"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de roles"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVRoles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVRoles As DataGridView
    Friend WithEvents TxtRol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnAgregarNivelPermiso As Button
    Friend WithEvents CBNivelPermiso As ComboBox
    Friend WithEvents Label4 As Label
End Class
