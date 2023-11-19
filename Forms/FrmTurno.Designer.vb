<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTurno
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
        Dim BtnCerrarSesion As System.Windows.Forms.Button
        Dim BtnRegresar As System.Windows.Forms.Button
        Dim BtnPantallaFolios As System.Windows.Forms.Button
        Dim BtnPantallaReservaciones As System.Windows.Forms.Button
        Dim BtnPantallaClientes As System.Windows.Forms.Button
        Dim BtnPantallaHabitaciones As System.Windows.Forms.Button
        Dim BtnPantallaUsuarios As System.Windows.Forms.Button
        Dim BtnPantallaInicio As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTurno))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRetiroManual = New System.Windows.Forms.Button()
        Me.BtnCerrarSesionSinCorte = New System.Windows.Forms.Button()
        Me.BtnImprimirIngreso = New System.Windows.Forms.Button()
        Me.BtnVerIngresos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.DGVTurnos = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCantidadApertura = New System.Windows.Forms.Label()
        Me.TxtCantidadActual = New System.Windows.Forms.Label()
        Me.TxtCantidadRetiro = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        BtnCerrarSesion = New System.Windows.Forms.Button()
        BtnRegresar = New System.Windows.Forms.Button()
        BtnPantallaFolios = New System.Windows.Forms.Button()
        BtnPantallaReservaciones = New System.Windows.Forms.Button()
        BtnPantallaClientes = New System.Windows.Forms.Button()
        BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        BtnPantallaUsuarios = New System.Windows.Forms.Button()
        BtnPantallaInicio = New System.Windows.Forms.Button()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrarSesion
        '
        BtnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnCerrarSesion.CausesValidation = False
        BtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        BtnCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnCerrarSesion.FlatAppearance.BorderSize = 0
        BtnCerrarSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        BtnCerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue
        BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnCerrarSesion.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BtnCerrarSesion.ForeColor = System.Drawing.Color.Black
        BtnCerrarSesion.Location = New System.Drawing.Point(164, 158)
        BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(0)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New System.Drawing.Size(98, 26)
        BtnCerrarSesion.TabIndex = 5
        BtnCerrarSesion.TabStop = False
        BtnCerrarSesion.Text = "Cerrar sesión"
        BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        BtnCerrarSesion.UseVisualStyleBackColor = False
        AddHandler BtnCerrarSesion.Click, AddressOf Me.BtnCerrarSesion_Click
        '
        'BtnRegresar
        '
        BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnRegresar.CausesValidation = False
        BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        BtnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnRegresar.FlatAppearance.BorderSize = 0
        BtnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        BtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnRegresar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnRegresar.ForeColor = System.Drawing.Color.Black
        BtnRegresar.Location = New System.Drawing.Point(73, 634)
        BtnRegresar.Margin = New System.Windows.Forms.Padding(0)
        BtnRegresar.Name = "BtnRegresar"
        BtnRegresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnRegresar.Size = New System.Drawing.Size(239, 36)
        BtnRegresar.TabIndex = 4
        BtnRegresar.TabStop = False
        BtnRegresar.Text = "Regresar"
        BtnRegresar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnRegresar.UseVisualStyleBackColor = False
        AddHandler BtnRegresar.Click, AddressOf Me.BtnRegresar_Click
        '
        'BtnPantallaFolios
        '
        BtnPantallaFolios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaFolios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnPantallaFolios.CausesValidation = False
        BtnPantallaFolios.Cursor = System.Windows.Forms.Cursors.Hand
        BtnPantallaFolios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaFolios.FlatAppearance.BorderSize = 0
        BtnPantallaFolios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        BtnPantallaFolios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        BtnPantallaFolios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnPantallaFolios.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnPantallaFolios.ForeColor = System.Drawing.Color.Black
        BtnPantallaFolios.Location = New System.Drawing.Point(73, 560)
        BtnPantallaFolios.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaFolios.Name = "BtnPantallaFolios"
        BtnPantallaFolios.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaFolios.Size = New System.Drawing.Size(239, 36)
        BtnPantallaFolios.TabIndex = 11
        BtnPantallaFolios.TabStop = False
        BtnPantallaFolios.Text = "Folios"
        BtnPantallaFolios.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaFolios.UseVisualStyleBackColor = False
        AddHandler BtnPantallaFolios.Click, AddressOf Me.BtnPantallaFolios_Click
        '
        'BtnPantallaReservaciones
        '
        BtnPantallaReservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaReservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnPantallaReservaciones.CausesValidation = False
        BtnPantallaReservaciones.Cursor = System.Windows.Forms.Cursors.Hand
        BtnPantallaReservaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaReservaciones.FlatAppearance.BorderSize = 0
        BtnPantallaReservaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        BtnPantallaReservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        BtnPantallaReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnPantallaReservaciones.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnPantallaReservaciones.ForeColor = System.Drawing.Color.Black
        BtnPantallaReservaciones.Location = New System.Drawing.Point(73, 493)
        BtnPantallaReservaciones.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaReservaciones.Name = "BtnPantallaReservaciones"
        BtnPantallaReservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaReservaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaReservaciones.TabIndex = 10
        BtnPantallaReservaciones.TabStop = False
        BtnPantallaReservaciones.Text = "Reservaciones"
        BtnPantallaReservaciones.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaReservaciones.UseVisualStyleBackColor = False
        AddHandler BtnPantallaReservaciones.Click, AddressOf Me.BtnPantallaReservaciones_Click
        '
        'BtnPantallaClientes
        '
        BtnPantallaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnPantallaClientes.CausesValidation = False
        BtnPantallaClientes.Cursor = System.Windows.Forms.Cursors.Hand
        BtnPantallaClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaClientes.FlatAppearance.BorderSize = 0
        BtnPantallaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        BtnPantallaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        BtnPantallaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnPantallaClientes.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnPantallaClientes.ForeColor = System.Drawing.Color.Black
        BtnPantallaClientes.Location = New System.Drawing.Point(73, 423)
        BtnPantallaClientes.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaClientes.Name = "BtnPantallaClientes"
        BtnPantallaClientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaClientes.Size = New System.Drawing.Size(239, 36)
        BtnPantallaClientes.TabIndex = 9
        BtnPantallaClientes.TabStop = False
        BtnPantallaClientes.Text = "Clientes"
        BtnPantallaClientes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaClientes.UseVisualStyleBackColor = False
        AddHandler BtnPantallaClientes.Click, AddressOf Me.BtnPantallaClientes_Click
        '
        'BtnPantallaHabitaciones
        '
        BtnPantallaHabitaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaHabitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnPantallaHabitaciones.CausesValidation = False
        BtnPantallaHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand
        BtnPantallaHabitaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaHabitaciones.FlatAppearance.BorderSize = 0
        BtnPantallaHabitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        BtnPantallaHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown
        BtnPantallaHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnPantallaHabitaciones.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnPantallaHabitaciones.ForeColor = System.Drawing.Color.Black
        BtnPantallaHabitaciones.Location = New System.Drawing.Point(73, 357)
        BtnPantallaHabitaciones.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaHabitaciones.Name = "BtnPantallaHabitaciones"
        BtnPantallaHabitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaHabitaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaHabitaciones.TabIndex = 8
        BtnPantallaHabitaciones.TabStop = False
        BtnPantallaHabitaciones.Text = "Habitaciones"
        BtnPantallaHabitaciones.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaHabitaciones.UseVisualStyleBackColor = False
        AddHandler BtnPantallaHabitaciones.Click, AddressOf Me.BtnPantallaHabitaciones_Click
        '
        'BtnPantallaUsuarios
        '
        BtnPantallaUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnPantallaUsuarios.CausesValidation = False
        BtnPantallaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        BtnPantallaUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaUsuarios.FlatAppearance.BorderSize = 0
        BtnPantallaUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        BtnPantallaUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        BtnPantallaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnPantallaUsuarios.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnPantallaUsuarios.ForeColor = System.Drawing.Color.Black
        BtnPantallaUsuarios.Location = New System.Drawing.Point(73, 290)
        BtnPantallaUsuarios.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaUsuarios.Name = "BtnPantallaUsuarios"
        BtnPantallaUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaUsuarios.Size = New System.Drawing.Size(239, 36)
        BtnPantallaUsuarios.TabIndex = 7
        BtnPantallaUsuarios.TabStop = False
        BtnPantallaUsuarios.Text = "Usuarios"
        BtnPantallaUsuarios.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaUsuarios.UseVisualStyleBackColor = False
        AddHandler BtnPantallaUsuarios.Click, AddressOf Me.BtnPantallaUsuarios_Click
        '
        'BtnPantallaInicio
        '
        BtnPantallaInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnPantallaInicio.CausesValidation = False
        BtnPantallaInicio.Cursor = System.Windows.Forms.Cursors.Hand
        BtnPantallaInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaInicio.FlatAppearance.BorderSize = 0
        BtnPantallaInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        BtnPantallaInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        BtnPantallaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnPantallaInicio.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnPantallaInicio.ForeColor = System.Drawing.Color.Black
        BtnPantallaInicio.Location = New System.Drawing.Point(73, 224)
        BtnPantallaInicio.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaInicio.Name = "BtnPantallaInicio"
        BtnPantallaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaInicio.Size = New System.Drawing.Size(239, 36)
        BtnPantallaInicio.TabIndex = 6
        BtnPantallaInicio.TabStop = False
        BtnPantallaInicio.Text = "Pantalla de inicio"
        BtnPantallaInicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaInicio.UseVisualStyleBackColor = False
        AddHandler BtnPantallaInicio.Click, AddressOf Me.BtnPantallaInicio_Click
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(302, 639)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(83, 40)
        Me.BtnEliminar.TabIndex = 3
        Me.BtnEliminar.Text = "&Eliminar"
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Clic para eliminar el turno seleccionado (ALT + E)")
        Me.BtnEliminar.UseVisualStyleBackColor = False
        Me.BtnEliminar.Visible = False
        '
        'BtnRetiroManual
        '
        Me.BtnRetiroManual.BackColor = System.Drawing.Color.OliveDrab
        Me.BtnRetiroManual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRetiroManual.ForeColor = System.Drawing.Color.White
        Me.BtnRetiroManual.Location = New System.Drawing.Point(1185, 641)
        Me.BtnRetiroManual.Name = "BtnRetiroManual"
        Me.BtnRetiroManual.Size = New System.Drawing.Size(132, 40)
        Me.BtnRetiroManual.TabIndex = 1
        Me.BtnRetiroManual.Text = "&Realizar retiro manual de la cantidad actual"
        Me.ToolTip1.SetToolTip(Me.BtnRetiroManual, "Clic para realizar un retiro de caja en el turno actual (ALT + R)")
        Me.BtnRetiroManual.UseVisualStyleBackColor = False
        '
        'BtnCerrarSesionSinCorte
        '
        Me.BtnCerrarSesionSinCorte.BackColor = System.Drawing.Color.Firebrick
        Me.BtnCerrarSesionSinCorte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarSesionSinCorte.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarSesionSinCorte.Location = New System.Drawing.Point(391, 639)
        Me.BtnCerrarSesionSinCorte.Name = "BtnCerrarSesionSinCorte"
        Me.BtnCerrarSesionSinCorte.Size = New System.Drawing.Size(132, 40)
        Me.BtnCerrarSesionSinCorte.TabIndex = 2
        Me.BtnCerrarSesionSinCorte.Text = "&Cerrar sesión sin hacer corte de turno"
        Me.ToolTip1.SetToolTip(Me.BtnCerrarSesionSinCorte, "Clic para cerrar sesión sin hacer el corte de caja/turno respectivo (ALT + C)")
        Me.BtnCerrarSesionSinCorte.UseVisualStyleBackColor = False
        Me.BtnCerrarSesionSinCorte.Visible = False
        '
        'BtnImprimirIngreso
        '
        Me.BtnImprimirIngreso.BackgroundImage = CType(resources.GetObject("BtnImprimirIngreso.BackgroundImage"), System.Drawing.Image)
        Me.BtnImprimirIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImprimirIngreso.Location = New System.Drawing.Point(863, 642)
        Me.BtnImprimirIngreso.Name = "BtnImprimirIngreso"
        Me.BtnImprimirIngreso.Size = New System.Drawing.Size(40, 38)
        Me.BtnImprimirIngreso.TabIndex = 286
        Me.ToolTip1.SetToolTip(Me.BtnImprimirIngreso, "Clic para imprimir los datos actuales")
        Me.BtnImprimirIngreso.UseVisualStyleBackColor = True
        '
        'BtnVerIngresos
        '
        Me.BtnVerIngresos.BackColor = System.Drawing.Color.OliveDrab
        Me.BtnVerIngresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerIngresos.ForeColor = System.Drawing.Color.White
        Me.BtnVerIngresos.Location = New System.Drawing.Point(1047, 641)
        Me.BtnVerIngresos.Name = "BtnVerIngresos"
        Me.BtnVerIngresos.Size = New System.Drawing.Size(132, 40)
        Me.BtnVerIngresos.TabIndex = 287
        Me.BtnVerIngresos.Text = "Ver &ingresos"
        Me.ToolTip1.SetToolTip(Me.BtnVerIngresos, "Clic para realizar un retiro de caja en el turno actual (ALT + R)")
        Me.BtnVerIngresos.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OliveDrab
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(909, 641)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 40)
        Me.Button1.TabIndex = 288
        Me.Button1.Text = "&Ver egresos"
        Me.ToolTip1.SetToolTip(Me.Button1, "Clic para realizar un retiro de caja en el turno actual (ALT + R)")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(30, 560)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 94
        Me.PictureBox7.TabStop = False
        '
        'DGVTurnos
        '
        Me.DGVTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVTurnos.Location = New System.Drawing.Point(301, 214)
        Me.DGVTurnos.Name = "DGVTurnos"
        Me.DGVTurnos.Size = New System.Drawing.Size(1016, 416)
        Me.DGVTurnos.TabIndex = 244
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(297, 94)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(695, 31)
        Me.Label16.TabIndex = 243
        Me.Label16.Text = "Estado actual del turno en curso en caja:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(297, 180)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(403, 31)
        Me.Label15.TabIndex = 242
        Me.Label15.Text = "Historial de apertura y cierre de turnos en caja:"
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.Location = New System.Drawing.Point(1001, 24)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(350, 23)
        Me.LbFecha.TabIndex = 239
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(290, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 64)
        Me.Label1.TabIndex = 238
        Me.Label1.Text = "Información de turno"
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.Location = New System.Drawing.Point(1124, 55)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 240
        '
        'FechaHora
        '
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(30, 493)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 93
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(29, 423)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 92
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(29, 357)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 91
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(30, 290)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 90
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(30, 224)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 790)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LbRol)
        Me.Panel1.Controls.Add(Me.LbUsuario)
        Me.Panel1.Controls.Add(BtnCerrarSesion)
        Me.Panel1.Controls.Add(BtnRegresar)
        Me.Panel1.Controls.Add(BtnPantallaFolios)
        Me.Panel1.Controls.Add(BtnPantallaReservaciones)
        Me.Panel1.Controls.Add(BtnPantallaClientes)
        Me.Panel1.Controls.Add(BtnPantallaHabitaciones)
        Me.Panel1.Controls.Add(BtnPantallaUsuarios)
        Me.Panel1.Controls.Add(BtnPantallaInicio)
        Me.Panel1.Controls.Add(Me.PictureBox11)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 726)
        Me.Panel1.TabIndex = 241
        '
        'LbRol
        '
        Me.LbRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbRol.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.ForeColor = System.Drawing.Color.Black
        Me.LbRol.Location = New System.Drawing.Point(165, 130)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(114, 22)
        Me.LbRol.TabIndex = 108
        Me.LbRol.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LbRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbUsuario
        '
        Me.LbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbUsuario.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LbUsuario.ForeColor = System.Drawing.Color.Black
        Me.LbUsuario.Location = New System.Drawing.Point(164, 10)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(115, 122)
        Me.LbUsuario.TabIndex = 107
        Me.LbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(47, 42)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(83, 80)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 98
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(154, 153)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 97
        Me.PictureBox10.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(30, 634)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 95
        Me.PictureBox8.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(297, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(193, 31)
        Me.Label2.TabIndex = 279
        Me.Label2.Text = "Cantidad de apertura: $"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(644, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(163, 31)
        Me.Label3.TabIndex = 280
        Me.Label3.Text = "Cantidad actual: $"
        '
        'TxtCantidadApertura
        '
        Me.TxtCantidadApertura.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadApertura.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadApertura.Location = New System.Drawing.Point(480, 131)
        Me.TxtCantidadApertura.Name = "TxtCantidadApertura"
        Me.TxtCantidadApertura.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadApertura.Size = New System.Drawing.Size(158, 31)
        Me.TxtCantidadApertura.TabIndex = 281
        Me.TxtCantidadApertura.Text = "[DATO]"
        '
        'TxtCantidadActual
        '
        Me.TxtCantidadActual.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadActual.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadActual.Location = New System.Drawing.Point(794, 131)
        Me.TxtCantidadActual.Name = "TxtCantidadActual"
        Me.TxtCantidadActual.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadActual.Size = New System.Drawing.Size(182, 31)
        Me.TxtCantidadActual.TabIndex = 282
        Me.TxtCantidadActual.Text = "[DATO]"
        '
        'TxtCantidadRetiro
        '
        Me.TxtCantidadRetiro.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadRetiro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadRetiro.Location = New System.Drawing.Point(1149, 131)
        Me.TxtCantidadRetiro.Name = "TxtCantidadRetiro"
        Me.TxtCantidadRetiro.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadRetiro.Size = New System.Drawing.Size(189, 31)
        Me.TxtCantidadRetiro.TabIndex = 285
        Me.TxtCantidadRetiro.Text = "0"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(982, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(163, 31)
        Me.Label7.TabIndex = 284
        Me.Label7.Text = "Cantidad de retiro: $"
        '
        'FrmTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnVerIngresos)
        Me.Controls.Add(Me.BtnImprimirIngreso)
        Me.Controls.Add(Me.TxtCantidadRetiro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCerrarSesionSinCorte)
        Me.Controls.Add(Me.TxtCantidadActual)
        Me.Controls.Add(Me.TxtCantidadApertura)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRetiroManual)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.DGVTurnos)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de turnos"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents FechaHora As Timer
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents BtnRetiroManual As Button
    Friend WithEvents LbRol As Label
    Friend WithEvents LbUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCantidadApertura As Label
    Friend WithEvents TxtCantidadActual As Label
    Friend WithEvents BtnCerrarSesionSinCorte As Button
    Friend WithEvents TxtCantidadRetiro As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Public WithEvents DGVTurnos As DataGridView
    Friend WithEvents BtnImprimirIngreso As Button
    Friend WithEvents BtnVerIngresos As Button
    Friend WithEvents Button1 As Button
End Class
