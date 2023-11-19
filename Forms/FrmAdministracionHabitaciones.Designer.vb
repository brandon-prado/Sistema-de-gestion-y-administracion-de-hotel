<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministrarHabitacion
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
        Dim BtnRegresar As System.Windows.Forms.Button
        Dim BtnCerrarSesion As System.Windows.Forms.Button
        Dim BtnPantallaFolios As System.Windows.Forms.Button
        Dim BtnPantallaReservaciones As System.Windows.Forms.Button
        Dim BtnPantallaClientes As System.Windows.Forms.Button
        Dim BtnPantallaHabitaciones As System.Windows.Forms.Button
        Dim BtnPantallaUsuarios As System.Windows.Forms.Button
        Dim BtnPantallaInicio As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdministrarHabitacion))
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.DGVHabitacion = New System.Windows.Forms.DataGridView()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBEstado = New System.Windows.Forms.ComboBox()
        Me.TxtCapacidad = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.TxtNumero = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCargarImagen = New System.Windows.Forms.Button()
        Me.BtnEliminarImagen = New System.Windows.Forms.Button()
        Me.PBImagenHabitacion = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelCargarImagen = New System.Windows.Forms.Label()
        Me.BtnTipo = New System.Windows.Forms.Button()
        Me.CBTipo = New System.Windows.Forms.ComboBox()
        Me.LabelAlt = New System.Windows.Forms.Label()
        Me.PBAlt = New System.Windows.Forms.PictureBox()
        Me.TimerOcultar = New System.Windows.Forms.Timer(Me.components)
        BtnRegresar = New System.Windows.Forms.Button()
        BtnCerrarSesion = New System.Windows.Forms.Button()
        BtnPantallaFolios = New System.Windows.Forms.Button()
        BtnPantallaReservaciones = New System.Windows.Forms.Button()
        BtnPantallaClientes = New System.Windows.Forms.Button()
        BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        BtnPantallaUsuarios = New System.Windows.Forms.Button()
        BtnPantallaInicio = New System.Windows.Forms.Button()
        CType(Me.DGVHabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBImagenHabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAlt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        BtnRegresar.Location = New System.Drawing.Point(74, 634)
        BtnRegresar.Margin = New System.Windows.Forms.Padding(0)
        BtnRegresar.Name = "BtnRegresar"
        BtnRegresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnRegresar.Size = New System.Drawing.Size(239, 36)
        BtnRegresar.TabIndex = 12
        BtnRegresar.TabStop = False
        BtnRegresar.Text = "Regresar"
        BtnRegresar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnRegresar.UseVisualStyleBackColor = False
        AddHandler BtnRegresar.Click, AddressOf Me.BtnRegresar_Click_1
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
        BtnCerrarSesion.Location = New System.Drawing.Point(165, 149)
        BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(0)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New System.Drawing.Size(98, 26)
        BtnCerrarSesion.TabIndex = 13
        BtnCerrarSesion.TabStop = False
        BtnCerrarSesion.Text = "Cerrar sesión"
        BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        BtnCerrarSesion.UseVisualStyleBackColor = False
        AddHandler BtnCerrarSesion.Click, AddressOf Me.BtnCerrarSesion_Click
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
        BtnPantallaFolios.Location = New System.Drawing.Point(74, 560)
        BtnPantallaFolios.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaFolios.Name = "BtnPantallaFolios"
        BtnPantallaFolios.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaFolios.Size = New System.Drawing.Size(239, 36)
        BtnPantallaFolios.TabIndex = 19
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
        BtnPantallaReservaciones.Location = New System.Drawing.Point(74, 493)
        BtnPantallaReservaciones.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaReservaciones.Name = "BtnPantallaReservaciones"
        BtnPantallaReservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaReservaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaReservaciones.TabIndex = 18
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
        BtnPantallaClientes.Location = New System.Drawing.Point(74, 423)
        BtnPantallaClientes.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaClientes.Name = "BtnPantallaClientes"
        BtnPantallaClientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaClientes.Size = New System.Drawing.Size(239, 36)
        BtnPantallaClientes.TabIndex = 17
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
        BtnPantallaHabitaciones.Enabled = False
        BtnPantallaHabitaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaHabitaciones.FlatAppearance.BorderSize = 0
        BtnPantallaHabitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        BtnPantallaHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown
        BtnPantallaHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnPantallaHabitaciones.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnPantallaHabitaciones.ForeColor = System.Drawing.Color.Black
        BtnPantallaHabitaciones.Location = New System.Drawing.Point(74, 357)
        BtnPantallaHabitaciones.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaHabitaciones.Name = "BtnPantallaHabitaciones"
        BtnPantallaHabitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaHabitaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaHabitaciones.TabIndex = 16
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
        BtnPantallaUsuarios.Location = New System.Drawing.Point(74, 290)
        BtnPantallaUsuarios.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaUsuarios.Name = "BtnPantallaUsuarios"
        BtnPantallaUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaUsuarios.Size = New System.Drawing.Size(239, 36)
        BtnPantallaUsuarios.TabIndex = 15
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
        BtnPantallaInicio.Location = New System.Drawing.Point(74, 224)
        BtnPantallaInicio.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaInicio.Name = "BtnPantallaInicio"
        BtnPantallaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaInicio.Size = New System.Drawing.Size(239, 36)
        BtnPantallaInicio.TabIndex = 14
        BtnPantallaInicio.TabStop = False
        BtnPantallaInicio.Text = "Pantalla de inicio"
        BtnPantallaInicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaInicio.UseVisualStyleBackColor = False
        AddHandler BtnPantallaInicio.Click, AddressOf Me.BtnPantallaInicio_Click
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(317, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(375, 31)
        Me.Label15.TabIndex = 197
        Me.Label15.Text = "Lista de las habitaciones del sistema:"
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(1250, 645)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(83, 35)
        Me.BtnLimpiar.TabIndex = 11
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para limpiar las cajas de texto (ALT + L)")
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(1163, 647)
        Me.BtnEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(83, 33)
        Me.BtnEliminar.TabIndex = 10
        Me.BtnEliminar.Text = "&Eliminar"
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Clic para eliminar la habitación (ALT + E)")
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(1076, 647)
        Me.BtnRegistrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(83, 35)
        Me.BtnRegistrar.TabIndex = 9
        Me.BtnRegistrar.Text = "&Registrar"
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Clic para registrar/modificar la habitación (ALT + R) (ENTER)")
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'DGVHabitacion
        '
        Me.DGVHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHabitacion.Location = New System.Drawing.Point(321, 328)
        Me.DGVHabitacion.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVHabitacion.Name = "DGVHabitacion"
        Me.DGVHabitacion.ReadOnly = True
        Me.DGVHabitacion.RowHeadersWidth = 51
        Me.DGVHabitacion.RowTemplate.Height = 24
        Me.DGVHabitacion.Size = New System.Drawing.Size(627, 295)
        Me.DGVHabitacion.TabIndex = 191
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(321, 113)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(328, 31)
        Me.Label16.TabIndex = 196
        Me.Label16.Text = "Llena la información correspondiente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(512, 169)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 190
        Me.Label7.Text = "* Precio: $"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(322, 169)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 189
        Me.Label6.Text = "* Número:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(322, 234)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 188
        Me.Label5.Text = "* Estado:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(941, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 20)
        Me.Label4.TabIndex = 187
        Me.Label4.Text = "* Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 30.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(313, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(652, 47)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "Administración de habitaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(521, 234)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(718, 169)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "* Capacidad:"
        '
        'CBEstado
        '
        Me.CBEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEstado.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBEstado.FormattingEnabled = True
        Me.CBEstado.Items.AddRange(New Object() {"Disponible", "Ocupada", "Limpieza", "Inactiva"})
        Me.CBEstado.Location = New System.Drawing.Point(396, 234)
        Me.CBEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.CBEstado.Name = "CBEstado"
        Me.CBEstado.Size = New System.Drawing.Size(92, 21)
        Me.CBEstado.TabIndex = 5
        '
        'TxtCapacidad
        '
        Me.TxtCapacidad.Location = New System.Drawing.Point(810, 169)
        Me.TxtCapacidad.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCapacidad.MaxLength = 2
        Me.TxtCapacidad.Name = "TxtCapacidad"
        Me.TxtCapacidad.ShortcutsEnabled = False
        Me.TxtCapacidad.Size = New System.Drawing.Size(92, 20)
        Me.TxtCapacidad.TabIndex = 3
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(631, 234)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ShortcutsEnabled = False
        Me.TxtDescripcion.Size = New System.Drawing.Size(354, 54)
        Me.TxtDescripcion.TabIndex = 6
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(602, 169)
        Me.TxtPrecio.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPrecio.MaxLength = 12
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.ShortcutsEnabled = False
        Me.TxtPrecio.Size = New System.Drawing.Size(92, 20)
        Me.TxtPrecio.TabIndex = 2
        '
        'TxtNumero
        '
        Me.TxtNumero.Location = New System.Drawing.Point(405, 170)
        Me.TxtNumero.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumero.MaxLength = 5
        Me.TxtNumero.Name = "TxtNumero"
        Me.TxtNumero.ShortcutsEnabled = False
        Me.TxtNumero.Size = New System.Drawing.Size(76, 20)
        Me.TxtNumero.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LbRol)
        Me.Panel1.Controls.Add(BtnRegresar)
        Me.Panel1.Controls.Add(Me.LbUsuario)
        Me.Panel1.Controls.Add(BtnCerrarSesion)
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
        Me.Panel1.Location = New System.Drawing.Point(-4, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 726)
        Me.Panel1.TabIndex = 199
        '
        'LbRol
        '
        Me.LbRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbRol.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.ForeColor = System.Drawing.Color.Black
        Me.LbRol.Location = New System.Drawing.Point(166, 123)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(110, 22)
        Me.LbRol.TabIndex = 182
        Me.LbRol.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LbRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbUsuario
        '
        Me.LbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbUsuario.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LbUsuario.ForeColor = System.Drawing.Color.Black
        Me.LbUsuario.Location = New System.Drawing.Point(166, 6)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(110, 117)
        Me.LbUsuario.TabIndex = 181
        Me.LbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(48, 42)
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
        Me.PictureBox10.Location = New System.Drawing.Point(10, 10)
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
        Me.PictureBox8.Location = New System.Drawing.Point(31, 634)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 95
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(31, 560)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 94
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(31, 493)
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
        Me.PictureBox5.Location = New System.Drawing.Point(30, 423)
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
        Me.PictureBox4.Location = New System.Drawing.Point(30, 357)
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
        Me.PictureBox3.Location = New System.Drawing.Point(31, 290)
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
        Me.PictureBox2.Location = New System.Drawing.Point(31, 224)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-9, -14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(300, 790)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.Location = New System.Drawing.Point(945, 7)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(392, 23)
        Me.LbFecha.TabIndex = 200
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.Location = New System.Drawing.Point(1110, 38)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 201
        '
        'FechaHora
        '
        '
        'BtnCargarImagen
        '
        Me.BtnCargarImagen.BackgroundImage = CType(resources.GetObject("BtnCargarImagen.BackgroundImage"), System.Drawing.Image)
        Me.BtnCargarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCargarImagen.Location = New System.Drawing.Point(1076, 595)
        Me.BtnCargarImagen.Name = "BtnCargarImagen"
        Me.BtnCargarImagen.Size = New System.Drawing.Size(21, 21)
        Me.BtnCargarImagen.TabIndex = 226
        Me.ToolTip1.SetToolTip(Me.BtnCargarImagen, "Clic para cargar una imagen de presentación a la habitación seleccionada")
        Me.BtnCargarImagen.UseVisualStyleBackColor = True
        '
        'BtnEliminarImagen
        '
        Me.BtnEliminarImagen.BackColor = System.Drawing.Color.Crimson
        Me.BtnEliminarImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.BtnEliminarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnEliminarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarImagen.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarImagen.ForeColor = System.Drawing.Color.White
        Me.BtnEliminarImagen.Location = New System.Drawing.Point(1232, 592)
        Me.BtnEliminarImagen.Name = "BtnEliminarImagen"
        Me.BtnEliminarImagen.Size = New System.Drawing.Size(101, 28)
        Me.BtnEliminarImagen.TabIndex = 8
        Me.BtnEliminarImagen.Text = "Eliminar imagen"
        Me.ToolTip1.SetToolTip(Me.BtnEliminarImagen, "Clic para eliminar la imagen de la habitación seleccionada")
        Me.BtnEliminarImagen.UseVisualStyleBackColor = False
        '
        'PBImagenHabitacion
        '
        Me.PBImagenHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBImagenHabitacion.InitialImage = Nothing
        Me.PBImagenHabitacion.Location = New System.Drawing.Point(953, 328)
        Me.PBImagenHabitacion.Name = "PBImagenHabitacion"
        Me.PBImagenHabitacion.Size = New System.Drawing.Size(380, 259)
        Me.PBImagenHabitacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBImagenHabitacion.TabIndex = 202
        Me.PBImagenHabitacion.TabStop = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(949, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(165, 31)
        Me.Label8.TabIndex = 203
        Me.Label8.Text = "Imagen:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LabelCargarImagen
        '
        Me.LabelCargarImagen.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCargarImagen.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCargarImagen.Location = New System.Drawing.Point(953, 593)
        Me.LabelCargarImagen.Name = "LabelCargarImagen"
        Me.LabelCargarImagen.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelCargarImagen.Size = New System.Drawing.Size(136, 31)
        Me.LabelCargarImagen.TabIndex = 225
        Me.LabelCargarImagen.Text = "Cargar imagen:"
        '
        'BtnTipo
        '
        Me.BtnTipo.BackgroundImage = CType(resources.GetObject("BtnTipo.BackgroundImage"), System.Drawing.Image)
        Me.BtnTipo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTipo.Location = New System.Drawing.Point(1127, 170)
        Me.BtnTipo.Name = "BtnTipo"
        Me.BtnTipo.Size = New System.Drawing.Size(21, 21)
        Me.BtnTipo.TabIndex = 228
        Me.BtnTipo.UseVisualStyleBackColor = True
        '
        'CBTipo
        '
        Me.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CBTipo.FormattingEnabled = True
        Me.CBTipo.Location = New System.Drawing.Point(1000, 169)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(121, 21)
        Me.CBTipo.TabIndex = 4
        '
        'LabelAlt
        '
        Me.LabelAlt.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlt.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelAlt.Location = New System.Drawing.Point(1048, 653)
        Me.LabelAlt.Name = "LabelAlt"
        Me.LabelAlt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelAlt.Size = New System.Drawing.Size(19, 31)
        Me.LabelAlt.TabIndex = 240
        Me.LabelAlt.Text = "+"
        '
        'PBAlt
        '
        Me.PBAlt.Image = CType(resources.GetObject("PBAlt.Image"), System.Drawing.Image)
        Me.PBAlt.Location = New System.Drawing.Point(987, 647)
        Me.PBAlt.Name = "PBAlt"
        Me.PBAlt.Size = New System.Drawing.Size(52, 36)
        Me.PBAlt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBAlt.TabIndex = 239
        Me.PBAlt.TabStop = False
        '
        'TimerOcultar
        '
        Me.TimerOcultar.Interval = 8000
        '
        'FrmAdministrarHabitacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.LabelAlt)
        Me.Controls.Add(Me.PBAlt)
        Me.Controls.Add(Me.CBTipo)
        Me.Controls.Add(Me.BtnTipo)
        Me.Controls.Add(Me.BtnEliminarImagen)
        Me.Controls.Add(Me.BtnCargarImagen)
        Me.Controls.Add(Me.LabelCargarImagen)
        Me.Controls.Add(Me.PBImagenHabitacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVHabitacion)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBEstado)
        Me.Controls.Add(Me.TxtCapacidad)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.TxtNumero)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdministrarHabitacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de habitaciones"
        CType(Me.DGVHabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBImagenHabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAlt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents Label15 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents DGVHabitacion As DataGridView
    Friend WithEvents Label16 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CBEstado As ComboBox
    Friend WithEvents TxtCapacidad As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents TxtNumero As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbRol As Label
    Friend WithEvents LbUsuario As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LbFecha As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents FechaHora As Timer
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PBImagenHabitacion As PictureBox
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnCargarImagen As Button
    Friend WithEvents LabelCargarImagen As Label
    Friend WithEvents BtnEliminarImagen As Button
    Friend WithEvents BtnTipo As Button
    Friend WithEvents CBTipo As ComboBox
    Friend WithEvents LabelAlt As Label
    Friend WithEvents PBAlt As PictureBox
    Friend WithEvents TimerOcultar As Timer
End Class
