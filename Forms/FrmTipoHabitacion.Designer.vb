<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTipoHabitacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTipoHabitacion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.DGVTipoHabitacion = New System.Windows.Forms.DataGridView()
        Me.TxtDescripcionTipo = New System.Windows.Forms.TextBox()
        Me.TxtNombreTipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVTipoHabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(51, 345)
        Me.Panel1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(1, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 46)
        Me.Button1.TabIndex = 6
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-11, -15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(59, 360)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(486, 305)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BtnLimpiar.TabIndex = 5
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para limpiar las cajas de texto (ALT + L)")
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(400, 305)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "&Eliminar"
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Clic para eliminar el tipo de habitación seleccionada (ALT + E)")
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(314, 305)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegistrar.TabIndex = 3
        Me.BtnRegistrar.Text = "&Registrar"
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Clic para registrar/modificar el tipo de habitación (ALT + R) (ENTER)")
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'DGVTipoHabitacion
        '
        Me.DGVTipoHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTipoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTipoHabitacion.Location = New System.Drawing.Point(73, 169)
        Me.DGVTipoHabitacion.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVTipoHabitacion.Name = "DGVTipoHabitacion"
        Me.DGVTipoHabitacion.ReadOnly = True
        Me.DGVTipoHabitacion.RowHeadersWidth = 51
        Me.DGVTipoHabitacion.RowTemplate.Height = 24
        Me.DGVTipoHabitacion.Size = New System.Drawing.Size(488, 122)
        Me.DGVTipoHabitacion.TabIndex = 17
        '
        'TxtDescripcionTipo
        '
        Me.TxtDescripcionTipo.Location = New System.Drawing.Point(176, 92)
        Me.TxtDescripcionTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDescripcionTipo.MaxLength = 100
        Me.TxtDescripcionTipo.Multiline = True
        Me.TxtDescripcionTipo.Name = "TxtDescripcionTipo"
        Me.TxtDescripcionTipo.ShortcutsEnabled = False
        Me.TxtDescripcionTipo.Size = New System.Drawing.Size(385, 57)
        Me.TxtDescripcionTipo.TabIndex = 2
        '
        'TxtNombreTipo
        '
        Me.TxtNombreTipo.Location = New System.Drawing.Point(176, 60)
        Me.TxtNombreTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombreTipo.MaxLength = 30
        Me.TxtNombreTipo.Name = "TxtNombreTipo"
        Me.TxtNombreTipo.ShortcutsEnabled = False
        Me.TxtNombreTipo.Size = New System.Drawing.Size(131, 20)
        Me.TxtNombreTipo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 104)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 22)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "* Tipo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(446, 28)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Administración de tipo de habitación"
        '
        'FrmTipoHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(586, 346)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.DGVTipoHabitacion)
        Me.Controls.Add(Me.TxtDescripcionTipo)
        Me.Controls.Add(Me.TxtNombreTipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FrmTipoHabitacion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Administración de tipos de habitaciones"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVTipoHabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents DGVTipoHabitacion As DataGridView
    Friend WithEvents TxtDescripcionTipo As TextBox
    Friend WithEvents TxtNombreTipo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
