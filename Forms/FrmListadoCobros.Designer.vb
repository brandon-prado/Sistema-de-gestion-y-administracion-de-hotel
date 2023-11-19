<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoCobros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoCobros))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnImprimir = New System.Windows.Forms.Button()
        Me.BtnBuscarReservaciones = New System.Windows.Forms.Button()
        Me.BtnImprimirIngreso = New System.Windows.Forms.Button()
        Me.DGVIngresos = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RBTodo = New System.Windows.Forms.RadioButton()
        Me.RbTarjeta = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimeFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimeFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RbEfectivo = New System.Windows.Forms.RadioButton()
        CType(Me.DGVIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackgroundImage = CType(resources.GetObject("BtnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImprimir.Location = New System.Drawing.Point(672, 613)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(40, 38)
        Me.BtnImprimir.TabIndex = 258
        Me.ToolTip1.SetToolTip(Me.BtnImprimir, "Clic para imprimir los datos actuales")
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'BtnBuscarReservaciones
        '
        Me.BtnBuscarReservaciones.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnBuscarReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarReservaciones.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarReservaciones.Location = New System.Drawing.Point(837, 146)
        Me.BtnBuscarReservaciones.Name = "BtnBuscarReservaciones"
        Me.BtnBuscarReservaciones.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarReservaciones.TabIndex = 253
        Me.BtnBuscarReservaciones.Text = "&Buscar"
        Me.ToolTip1.SetToolTip(Me.BtnBuscarReservaciones, "Clic para buscar una reservación con Check Out en un rango de fecha (ALT + B)")
        Me.BtnBuscarReservaciones.UseVisualStyleBackColor = False
        '
        'BtnImprimirIngreso
        '
        Me.BtnImprimirIngreso.BackgroundImage = CType(resources.GetObject("BtnImprimirIngreso.BackgroundImage"), System.Drawing.Image)
        Me.BtnImprimirIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImprimirIngreso.Location = New System.Drawing.Point(872, 525)
        Me.BtnImprimirIngreso.Name = "BtnImprimirIngreso"
        Me.BtnImprimirIngreso.Size = New System.Drawing.Size(40, 38)
        Me.BtnImprimirIngreso.TabIndex = 260
        Me.ToolTip1.SetToolTip(Me.BtnImprimirIngreso, "Clic para imprimir los datos actuales")
        Me.BtnImprimirIngreso.UseVisualStyleBackColor = True
        '
        'DGVIngresos
        '
        Me.DGVIngresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVIngresos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGVIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVIngresos.Location = New System.Drawing.Point(20, 213)
        Me.DGVIngresos.Name = "DGVIngresos"
        Me.DGVIngresos.ReadOnly = True
        Me.DGVIngresos.Size = New System.Drawing.Size(892, 303)
        Me.DGVIngresos.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(52, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(51, 287)
        Me.Panel2.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(16, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(379, 31)
        Me.Label5.TabIndex = 227
        Me.Label5.Text = "Lista de ingresos:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 39)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "Ingresos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnRegresar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-1, -5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(51, 589)
        Me.Panel1.TabIndex = 7
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(2, 522)
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
        Me.PictureBox1.Size = New System.Drawing.Size(51, 575)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnImprimirIngreso)
        Me.Panel3.Controls.Add(Me.RBTodo)
        Me.Panel3.Controls.Add(Me.BtnImprimir)
        Me.Panel3.Controls.Add(Me.BtnBuscarReservaciones)
        Me.Panel3.Controls.Add(Me.RbTarjeta)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.DateTimeFechaFinal)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.DateTimeFechaInicial)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.RbEfectivo)
        Me.Panel3.Controls.Add(Me.DGVIngresos)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(50, -5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(945, 575)
        Me.Panel3.TabIndex = 8
        '
        'RBTodo
        '
        Me.RBTodo.AutoSize = True
        Me.RBTodo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RBTodo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RBTodo.Location = New System.Drawing.Point(20, 107)
        Me.RBTodo.Name = "RBTodo"
        Me.RBTodo.Size = New System.Drawing.Size(171, 24)
        Me.RBTodo.TabIndex = 259
        Me.RBTodo.TabStop = True
        Me.RBTodo.Text = "Ver todos los ingresos"
        Me.RBTodo.UseVisualStyleBackColor = True
        '
        'RbTarjeta
        '
        Me.RbTarjeta.AutoSize = True
        Me.RbTarjeta.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbTarjeta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbTarjeta.Location = New System.Drawing.Point(264, 108)
        Me.RbTarjeta.Name = "RbTarjeta"
        Me.RbTarjeta.Size = New System.Drawing.Size(188, 24)
        Me.RbTarjeta.TabIndex = 249
        Me.RbTarjeta.TabStop = True
        Me.RbTarjeta.Text = "Ver ingresos por tarjeta"
        Me.RbTarjeta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(509, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(318, 31)
        Me.Label2.TabIndex = 257
        Me.Label2.Text = "Rango de fecha:"
        '
        'DateTimeFechaFinal
        '
        Me.DateTimeFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaFinal.Location = New System.Drawing.Point(815, 111)
        Me.DateTimeFechaFinal.Name = "DateTimeFechaFinal"
        Me.DateTimeFechaFinal.Size = New System.Drawing.Size(97, 20)
        Me.DateTimeFechaFinal.TabIndex = 252
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(742, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 31)
        Me.Label4.TabIndex = 256
        Me.Label4.Text = "Final:"
        '
        'DateTimeFechaInicial
        '
        Me.DateTimeFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaInicial.Location = New System.Drawing.Point(582, 111)
        Me.DateTimeFechaInicial.Name = "DateTimeFechaInicial"
        Me.DateTimeFechaInicial.Size = New System.Drawing.Size(97, 20)
        Me.DateTimeFechaInicial.TabIndex = 251
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(509, 108)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 31)
        Me.Label10.TabIndex = 255
        Me.Label10.Text = "Inicial:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(16, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(318, 31)
        Me.Label3.TabIndex = 254
        Me.Label3.Text = "Selecciona el filtro de ingreso deseado:"
        '
        'RbEfectivo
        '
        Me.RbEfectivo.AutoSize = True
        Me.RbEfectivo.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbEfectivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbEfectivo.Location = New System.Drawing.Point(21, 147)
        Me.RbEfectivo.Name = "RbEfectivo"
        Me.RbEfectivo.Size = New System.Drawing.Size(188, 24)
        Me.RbEfectivo.TabIndex = 250
        Me.RbEfectivo.TabStop = True
        Me.RbEfectivo.Text = "Ver ingresos en efectivo"
        Me.RbEfectivo.UseVisualStyleBackColor = True
        '
        'FrmListadoCobros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(984, 567)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListadoCobros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de ingresos"
        CType(Me.DGVIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DGVIngresos As DataGridView
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RBTodo As RadioButton
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents BtnBuscarReservaciones As Button
    Friend WithEvents RbTarjeta As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimeFechaFinal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimeFechaInicial As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RbEfectivo As RadioButton
    Friend WithEvents BtnImprimirIngreso As Button
End Class
