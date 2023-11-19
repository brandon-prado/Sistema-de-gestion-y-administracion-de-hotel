<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSeleccionarCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSeleccionarCliente))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnRegistrarCliente = New System.Windows.Forms.Button()
        Me.BtnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.DGVClientes = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBBuscarPor = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDatoBuscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnRegresar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-1, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(51, 496)
        Me.Panel1.TabIndex = 3
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(4, 439)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 5
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 493)
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
        Me.Panel3.Controls.Add(Me.BtnRegistrarCliente)
        Me.Panel3.Controls.Add(Me.BtnLimpiarBusqueda)
        Me.Panel3.Controls.Add(Me.DGVClientes)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.CBBuscarPor)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.TxtDatoBuscar)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(50, -1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(945, 499)
        Me.Panel3.TabIndex = 4
        '
        'BtnRegistrarCliente
        '
        Me.BtnRegistrarCliente.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.BtnRegistrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrarCliente.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrarCliente.Location = New System.Drawing.Point(808, 457)
        Me.BtnRegistrarCliente.Name = "BtnRegistrarCliente"
        Me.BtnRegistrarCliente.Size = New System.Drawing.Size(124, 23)
        Me.BtnRegistrarCliente.TabIndex = 1
        Me.BtnRegistrarCliente.Text = "&Registrar Cliente"
        Me.ToolTip1.SetToolTip(Me.BtnRegistrarCliente, "Clic para registrar un cliente nuevo (ALT + R)")
        Me.BtnRegistrarCliente.UseVisualStyleBackColor = False
        '
        'BtnLimpiarBusqueda
        '
        Me.BtnLimpiarBusqueda.BackgroundImage = CType(resources.GetObject("BtnLimpiarBusqueda.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiarBusqueda.Location = New System.Drawing.Point(417, 121)
        Me.BtnLimpiarBusqueda.Name = "BtnLimpiarBusqueda"
        Me.BtnLimpiarBusqueda.Size = New System.Drawing.Size(21, 21)
        Me.BtnLimpiarBusqueda.TabIndex = 3
        Me.BtnLimpiarBusqueda.UseVisualStyleBackColor = True
        '
        'DGVClientes
        '
        Me.DGVClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVClientes.Location = New System.Drawing.Point(20, 194)
        Me.DGVClientes.Name = "DGVClientes"
        Me.DGVClientes.ReadOnly = True
        Me.DGVClientes.Size = New System.Drawing.Size(912, 254)
        Me.DGVClientes.TabIndex = 130
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(16, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(486, 31)
        Me.Label4.TabIndex = 229
        Me.Label4.Text = "Seleccione el filtro deseado para realizar la búsqueda:"
        '
        'CBBuscarPor
        '
        Me.CBBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBuscarPor.FormattingEnabled = True
        Me.CBBuscarPor.Items.AddRange(New Object() {"Nombre", "Apellido paterno", "Apellido materno", "Identificación"})
        Me.CBBuscarPor.Location = New System.Drawing.Point(121, 121)
        Me.CBBuscarPor.Name = "CBBuscarPor"
        Me.CBBuscarPor.Size = New System.Drawing.Size(121, 21)
        Me.CBBuscarPor.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(16, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(379, 31)
        Me.Label5.TabIndex = 227
        Me.Label5.Text = "Lista de los clientes:"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(724, 457)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAceptar.TabIndex = 4
        Me.BtnAceptar.Text = "&Aceptar"
        Me.ToolTip1.SetToolTip(Me.BtnAceptar, "Clic para seleccionar el cliente (ALT + A)")
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(397, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(210, 31)
        Me.Label3.TabIndex = 131
        Me.Label3.Text = "*"
        '
        'TxtDatoBuscar
        '
        Me.TxtDatoBuscar.Location = New System.Drawing.Point(275, 121)
        Me.TxtDatoBuscar.MaxLength = 30
        Me.TxtDatoBuscar.Name = "TxtDatoBuscar"
        Me.TxtDatoBuscar.ShortcutsEnabled = False
        Me.TxtDatoBuscar.Size = New System.Drawing.Size(120, 20)
        Me.TxtDatoBuscar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(16, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(99, 31)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Buscar por:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 39)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Seleccionar cliente"
        '
        'FrmSeleccionarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(994, 488)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSeleccionarCliente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Seleccionar cliente"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DGVClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVClientes As DataGridView
    Friend WithEvents TxtDatoBuscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CBBuscarPor As ComboBox
    Friend WithEvents BtnLimpiarBusqueda As Button
    Friend WithEvents BtnRegistrarCliente As Button
End Class
