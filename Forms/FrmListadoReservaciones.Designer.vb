<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListadoReservaciones
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
        Dim BtnCerrarSesion As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoReservaciones))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnPantallaFolios = New System.Windows.Forms.Button()
        Me.BtnPantallaReservaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaClientes = New System.Windows.Forms.Button()
        Me.BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaUsuarios = New System.Windows.Forms.Button()
        Me.BtnPantallaInicio = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.BtnBuscarReservaciones = New System.Windows.Forms.Button()
        Me.BtnModificarReservacion = New System.Windows.Forms.Button()
        Me.RbMostrarReservacionesActivas = New System.Windows.Forms.RadioButton()
        Me.RbMostrarTodasReservaciones = New System.Windows.Forms.RadioButton()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.BtnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimeFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimeFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.TxtDatoBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNuevaReservacion = New System.Windows.Forms.Button()
        Me.CBBuscarPor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVListadoReservaciones = New System.Windows.Forms.DataGridView()
        Me.RbMostrarReservacionesConCheckOut = New System.Windows.Forms.RadioButton()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.RbMostrarReservacionesCanceladas = New System.Windows.Forms.RadioButton()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnCalendario = New System.Windows.Forms.Button()
        Me.BtnConfirmarCheckInReal = New System.Windows.Forms.Button()
        Me.BtnConfirmarCheckOutReal = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnImprimir = New System.Windows.Forms.Button()
        BtnCerrarSesion = New System.Windows.Forms.Button()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVListadoReservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        BtnCerrarSesion.Location = New System.Drawing.Point(170, 155)
        BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(0)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New System.Drawing.Size(98, 26)
        BtnCerrarSesion.TabIndex = 16
        BtnCerrarSesion.TabStop = False
        BtnCerrarSesion.Text = "Cerrar sesión"
        BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        BtnCerrarSesion.UseVisualStyleBackColor = False
        AddHandler BtnCerrarSesion.Click, AddressOf Me.BtnCerrarSesion_Click
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRegresar.CausesValidation = False
        Me.BtnRegresar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.FlatAppearance.BorderSize = 0
        Me.BtnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick
        Me.BtnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnRegresar.ForeColor = System.Drawing.Color.Black
        Me.BtnRegresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnRegresar.Location = New System.Drawing.Point(75, 641)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRegresar.Size = New System.Drawing.Size(239, 36)
        Me.BtnRegresar.TabIndex = 15
        Me.BtnRegresar.TabStop = False
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnPantallaFolios
        '
        Me.BtnPantallaFolios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaFolios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPantallaFolios.CausesValidation = False
        Me.BtnPantallaFolios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPantallaFolios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaFolios.FlatAppearance.BorderSize = 0
        Me.BtnPantallaFolios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnPantallaFolios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.BtnPantallaFolios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaFolios.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPantallaFolios.ForeColor = System.Drawing.Color.Black
        Me.BtnPantallaFolios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPantallaFolios.Location = New System.Drawing.Point(75, 567)
        Me.BtnPantallaFolios.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaFolios.Name = "BtnPantallaFolios"
        Me.BtnPantallaFolios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaFolios.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaFolios.TabIndex = 22
        Me.BtnPantallaFolios.Text = "Folios"
        Me.BtnPantallaFolios.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPantallaFolios.UseVisualStyleBackColor = False
        '
        'BtnPantallaReservaciones
        '
        Me.BtnPantallaReservaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaReservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPantallaReservaciones.CausesValidation = False
        Me.BtnPantallaReservaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPantallaReservaciones.Enabled = False
        Me.BtnPantallaReservaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaReservaciones.FlatAppearance.BorderSize = 0
        Me.BtnPantallaReservaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.BtnPantallaReservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.BtnPantallaReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaReservaciones.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPantallaReservaciones.ForeColor = System.Drawing.Color.Black
        Me.BtnPantallaReservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPantallaReservaciones.Location = New System.Drawing.Point(75, 500)
        Me.BtnPantallaReservaciones.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaReservaciones.Name = "BtnPantallaReservaciones"
        Me.BtnPantallaReservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaReservaciones.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaReservaciones.TabIndex = 21
        Me.BtnPantallaReservaciones.Text = "Reservaciones"
        Me.BtnPantallaReservaciones.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPantallaReservaciones.UseVisualStyleBackColor = False
        '
        'BtnPantallaClientes
        '
        Me.BtnPantallaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPantallaClientes.CausesValidation = False
        Me.BtnPantallaClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPantallaClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaClientes.FlatAppearance.BorderSize = 0
        Me.BtnPantallaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnPantallaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        Me.BtnPantallaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaClientes.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPantallaClientes.ForeColor = System.Drawing.Color.Black
        Me.BtnPantallaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPantallaClientes.Location = New System.Drawing.Point(75, 430)
        Me.BtnPantallaClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaClientes.Name = "BtnPantallaClientes"
        Me.BtnPantallaClientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaClientes.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaClientes.TabIndex = 20
        Me.BtnPantallaClientes.Text = "Clientes"
        Me.BtnPantallaClientes.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPantallaClientes.UseVisualStyleBackColor = False
        '
        'BtnPantallaHabitaciones
        '
        Me.BtnPantallaHabitaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaHabitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPantallaHabitaciones.CausesValidation = False
        Me.BtnPantallaHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPantallaHabitaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaHabitaciones.FlatAppearance.BorderSize = 0
        Me.BtnPantallaHabitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate
        Me.BtnPantallaHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown
        Me.BtnPantallaHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaHabitaciones.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPantallaHabitaciones.ForeColor = System.Drawing.Color.Black
        Me.BtnPantallaHabitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPantallaHabitaciones.Location = New System.Drawing.Point(75, 364)
        Me.BtnPantallaHabitaciones.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaHabitaciones.Name = "BtnPantallaHabitaciones"
        Me.BtnPantallaHabitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaHabitaciones.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaHabitaciones.TabIndex = 19
        Me.BtnPantallaHabitaciones.TabStop = False
        Me.BtnPantallaHabitaciones.Text = "Habitaciones"
        Me.BtnPantallaHabitaciones.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPantallaHabitaciones.UseVisualStyleBackColor = False
        '
        'BtnPantallaUsuarios
        '
        Me.BtnPantallaUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPantallaUsuarios.CausesValidation = False
        Me.BtnPantallaUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPantallaUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnPantallaUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        Me.BtnPantallaUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        Me.BtnPantallaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaUsuarios.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPantallaUsuarios.ForeColor = System.Drawing.Color.Black
        Me.BtnPantallaUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPantallaUsuarios.Location = New System.Drawing.Point(77, 297)
        Me.BtnPantallaUsuarios.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaUsuarios.Name = "BtnPantallaUsuarios"
        Me.BtnPantallaUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaUsuarios.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaUsuarios.TabIndex = 18
        Me.BtnPantallaUsuarios.TabStop = False
        Me.BtnPantallaUsuarios.Text = "Usuarios"
        Me.BtnPantallaUsuarios.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPantallaUsuarios.UseVisualStyleBackColor = False
        '
        'BtnPantallaInicio
        '
        Me.BtnPantallaInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPantallaInicio.CausesValidation = False
        Me.BtnPantallaInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPantallaInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaInicio.FlatAppearance.BorderSize = 0
        Me.BtnPantallaInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPantallaInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.BtnPantallaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaInicio.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPantallaInicio.ForeColor = System.Drawing.Color.Black
        Me.BtnPantallaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnPantallaInicio.Location = New System.Drawing.Point(75, 231)
        Me.BtnPantallaInicio.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaInicio.Name = "BtnPantallaInicio"
        Me.BtnPantallaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaInicio.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaInicio.TabIndex = 17
        Me.BtnPantallaInicio.TabStop = False
        Me.BtnPantallaInicio.Text = "Pantalla de inicio"
        Me.BtnPantallaInicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPantallaInicio.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox5.Location = New System.Drawing.Point(31, 430)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 36)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 92
        Me.PictureBox5.TabStop = False
        '
        'BtnBuscarReservaciones
        '
        Me.BtnBuscarReservaciones.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnBuscarReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarReservaciones.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarReservaciones.Location = New System.Drawing.Point(1244, 176)
        Me.BtnBuscarReservaciones.Name = "BtnBuscarReservaciones"
        Me.BtnBuscarReservaciones.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarReservaciones.TabIndex = 8
        Me.BtnBuscarReservaciones.Text = "&Buscar"
        Me.ToolTip1.SetToolTip(Me.BtnBuscarReservaciones, "Clic para buscar una reservación con Check Out en un rango de fecha (ALT + B)")
        Me.BtnBuscarReservaciones.UseVisualStyleBackColor = False
        '
        'BtnModificarReservacion
        '
        Me.BtnModificarReservacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModificarReservacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.BtnModificarReservacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.BtnModificarReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarReservacion.ForeColor = System.Drawing.Color.White
        Me.BtnModificarReservacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnModificarReservacion.Location = New System.Drawing.Point(1193, 643)
        Me.BtnModificarReservacion.Name = "BtnModificarReservacion"
        Me.BtnModificarReservacion.Size = New System.Drawing.Size(63, 38)
        Me.BtnModificarReservacion.TabIndex = 9
        Me.BtnModificarReservacion.Text = "&Modificar Cancelar"
        Me.ToolTip1.SetToolTip(Me.BtnModificarReservacion, "Clic para modificar/cancelar la reservación seleccionada (ALT + M)")
        Me.BtnModificarReservacion.UseVisualStyleBackColor = False
        '
        'RbMostrarReservacionesActivas
        '
        Me.RbMostrarReservacionesActivas.AutoSize = True
        Me.RbMostrarReservacionesActivas.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarReservacionesActivas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarReservacionesActivas.Location = New System.Drawing.Point(325, 174)
        Me.RbMostrarReservacionesActivas.Name = "RbMostrarReservacionesActivas"
        Me.RbMostrarReservacionesActivas.Size = New System.Drawing.Size(195, 24)
        Me.RbMostrarReservacionesActivas.TabIndex = 3
        Me.RbMostrarReservacionesActivas.TabStop = True
        Me.RbMostrarReservacionesActivas.Text = "Ver reservaciones activas"
        Me.RbMostrarReservacionesActivas.UseVisualStyleBackColor = True
        '
        'RbMostrarTodasReservaciones
        '
        Me.RbMostrarTodasReservaciones.AutoSize = True
        Me.RbMostrarTodasReservaciones.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarTodasReservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarTodasReservaciones.Location = New System.Drawing.Point(325, 144)
        Me.RbMostrarTodasReservaciones.Name = "RbMostrarTodasReservaciones"
        Me.RbMostrarTodasReservaciones.Size = New System.Drawing.Size(207, 24)
        Me.RbMostrarTodasReservaciones.TabIndex = 2
        Me.RbMostrarTodasReservaciones.TabStop = True
        Me.RbMostrarTodasReservaciones.Text = "Ver todas las reservaciones"
        Me.RbMostrarTodasReservaciones.UseVisualStyleBackColor = True
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbHora.Location = New System.Drawing.Point(1113, 35)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 228
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(31, 364)
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
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(32, 297)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 90
        Me.PictureBox3.TabStop = False
        '
        'FechaHora
        '
        '
        'LbRol
        '
        Me.LbRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbRol.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.ForeColor = System.Drawing.Color.Black
        Me.LbRol.Location = New System.Drawing.Point(171, 129)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(124, 22)
        Me.LbRol.TabIndex = 131
        Me.LbRol.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LbRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbUsuario
        '
        Me.LbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbUsuario.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LbUsuario.ForeColor = System.Drawing.Color.Black
        Me.LbUsuario.Location = New System.Drawing.Point(171, 12)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(124, 117)
        Me.LbUsuario.TabIndex = 130
        Me.LbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnLimpiarBusqueda
        '
        Me.BtnLimpiarBusqueda.BackgroundImage = CType(resources.GetObject("BtnLimpiarBusqueda.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiarBusqueda.Location = New System.Drawing.Point(708, 651)
        Me.BtnLimpiarBusqueda.Name = "BtnLimpiarBusqueda"
        Me.BtnLimpiarBusqueda.Size = New System.Drawing.Size(21, 21)
        Me.BtnLimpiarBusqueda.TabIndex = 247
        Me.BtnLimpiarBusqueda.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(916, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(318, 31)
        Me.Label5.TabIndex = 245
        Me.Label5.Text = "Rango de fecha:"
        '
        'DateTimeFechaFinal
        '
        Me.DateTimeFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaFinal.Location = New System.Drawing.Point(1222, 148)
        Me.DateTimeFechaFinal.Name = "DateTimeFechaFinal"
        Me.DateTimeFechaFinal.Size = New System.Drawing.Size(97, 20)
        Me.DateTimeFechaFinal.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(1149, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 31)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "Final:"
        '
        'DateTimeFechaInicial
        '
        Me.DateTimeFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaInicial.Location = New System.Drawing.Point(989, 148)
        Me.DateTimeFechaInicial.Name = "DateTimeFechaInicial"
        Me.DateTimeFechaInicial.Size = New System.Drawing.Size(97, 20)
        Me.DateTimeFechaInicial.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(916, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 31)
        Me.Label10.TabIndex = 241
        Me.Label10.Text = "Inicial:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(321, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(318, 31)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Lista de los clientes:"
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbFecha.Location = New System.Drawing.Point(996, 4)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(344, 23)
        Me.LbFecha.TabIndex = 227
        '
        'TxtDatoBuscar
        '
        Me.TxtDatoBuscar.Location = New System.Drawing.Point(581, 650)
        Me.TxtDatoBuscar.MaxLength = 30
        Me.TxtDatoBuscar.Name = "TxtDatoBuscar"
        Me.TxtDatoBuscar.ShortcutsEnabled = False
        Me.TxtDatoBuscar.Size = New System.Drawing.Size(121, 20)
        Me.TxtDatoBuscar.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(313, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 64)
        Me.Label1.TabIndex = 226
        Me.Label1.Text = "Listado de reservaciones"
        '
        'BtnNuevaReservacion
        '
        Me.BtnNuevaReservacion.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnNuevaReservacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnNuevaReservacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.BtnNuevaReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevaReservacion.ForeColor = System.Drawing.Color.White
        Me.BtnNuevaReservacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNuevaReservacion.Location = New System.Drawing.Point(1262, 643)
        Me.BtnNuevaReservacion.Name = "BtnNuevaReservacion"
        Me.BtnNuevaReservacion.Size = New System.Drawing.Size(58, 38)
        Me.BtnNuevaReservacion.TabIndex = 1
        Me.BtnNuevaReservacion.Text = "&Nueva"
        Me.ToolTip1.SetToolTip(Me.BtnNuevaReservacion, "Clic para registrar una reservación (ALT + N)")
        Me.BtnNuevaReservacion.UseVisualStyleBackColor = False
        '
        'CBBuscarPor
        '
        Me.CBBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBuscarPor.FormattingEnabled = True
        Me.CBBuscarPor.Items.AddRange(New Object() {"Nombre", "Identificación", "Teléfono", "Número de habitación"})
        Me.CBBuscarPor.Location = New System.Drawing.Point(450, 649)
        Me.CBBuscarPor.Name = "CBBuscarPor"
        Me.CBBuscarPor.Size = New System.Drawing.Size(121, 21)
        Me.CBBuscarPor.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(323, 644)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(111, 29)
        Me.Label3.TabIndex = 236
        Me.Label3.Text = "Buscar por:"
        '
        'DGVListadoReservaciones
        '
        Me.DGVListadoReservaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVListadoReservaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVListadoReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVListadoReservaciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVListadoReservaciones.Location = New System.Drawing.Point(323, 216)
        Me.DGVListadoReservaciones.Name = "DGVListadoReservaciones"
        Me.DGVListadoReservaciones.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVListadoReservaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVListadoReservaciones.Size = New System.Drawing.Size(997, 412)
        Me.DGVListadoReservaciones.TabIndex = 235
        '
        'RbMostrarReservacionesConCheckOut
        '
        Me.RbMostrarReservacionesConCheckOut.AutoSize = True
        Me.RbMostrarReservacionesConCheckOut.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarReservacionesConCheckOut.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarReservacionesConCheckOut.Location = New System.Drawing.Point(623, 174)
        Me.RbMostrarReservacionesConCheckOut.Name = "RbMostrarReservacionesConCheckOut"
        Me.RbMostrarReservacionesConCheckOut.Size = New System.Drawing.Size(246, 24)
        Me.RbMostrarReservacionesConCheckOut.TabIndex = 5
        Me.RbMostrarReservacionesConCheckOut.TabStop = True
        Me.RbMostrarReservacionesConCheckOut.Text = "Ver reservaciones con Check Out"
        Me.RbMostrarReservacionesConCheckOut.UseVisualStyleBackColor = True
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox11.Location = New System.Drawing.Point(49, 49)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(83, 80)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 98
        Me.PictureBox11.TabStop = False
        '
        'RbMostrarReservacionesCanceladas
        '
        Me.RbMostrarReservacionesCanceladas.AutoSize = True
        Me.RbMostrarReservacionesCanceladas.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarReservacionesCanceladas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarReservacionesCanceladas.Location = New System.Drawing.Point(623, 144)
        Me.RbMostrarReservacionesCanceladas.Name = "RbMostrarReservacionesCanceladas"
        Me.RbMostrarReservacionesCanceladas.Size = New System.Drawing.Size(220, 24)
        Me.RbMostrarReservacionesCanceladas.TabIndex = 4
        Me.RbMostrarReservacionesCanceladas.TabStop = True
        Me.RbMostrarReservacionesCanceladas.Text = "Ver reservaciones canceladas"
        Me.RbMostrarReservacionesCanceladas.UseVisualStyleBackColor = True
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox10.Location = New System.Drawing.Point(11, 17)
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
        Me.PictureBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox8.Location = New System.Drawing.Point(32, 641)
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
        Me.PictureBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox7.Location = New System.Drawing.Point(32, 567)
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
        Me.PictureBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox6.Location = New System.Drawing.Point(32, 500)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(41, 36)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 93
        Me.PictureBox6.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 790)
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
        Me.Panel1.Controls.Add(Me.BtnPantallaUsuarios)
        Me.Panel1.Controls.Add(Me.BtnRegresar)
        Me.Panel1.Controls.Add(Me.BtnPantallaFolios)
        Me.Panel1.Controls.Add(Me.BtnPantallaReservaciones)
        Me.Panel1.Controls.Add(Me.BtnPantallaClientes)
        Me.Panel1.Controls.Add(Me.BtnPantallaHabitaciones)
        Me.Panel1.Controls.Add(Me.BtnPantallaInicio)
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
        Me.Panel1.Location = New System.Drawing.Point(-6, -11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(296, 726)
        Me.Panel1.TabIndex = 229
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(32, 231)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'BtnCalendario
        '
        Me.BtnCalendario.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnCalendario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.BtnCalendario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.BtnCalendario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalendario.ForeColor = System.Drawing.Color.White
        Me.BtnCalendario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCalendario.Location = New System.Drawing.Point(1113, 643)
        Me.BtnCalendario.Name = "BtnCalendario"
        Me.BtnCalendario.Size = New System.Drawing.Size(74, 38)
        Me.BtnCalendario.TabIndex = 10
        Me.BtnCalendario.Text = "Ver &calendario"
        Me.ToolTip1.SetToolTip(Me.BtnCalendario, "Clic para ver el calendario de reservaciones (ALT + C)")
        Me.BtnCalendario.UseVisualStyleBackColor = False
        '
        'BtnConfirmarCheckInReal
        '
        Me.BtnConfirmarCheckInReal.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnConfirmarCheckInReal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfirmarCheckInReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmarCheckInReal.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmarCheckInReal.ForeColor = System.Drawing.Color.White
        Me.BtnConfirmarCheckInReal.Location = New System.Drawing.Point(759, 644)
        Me.BtnConfirmarCheckInReal.Name = "BtnConfirmarCheckInReal"
        Me.BtnConfirmarCheckInReal.Size = New System.Drawing.Size(138, 38)
        Me.BtnConfirmarCheckInReal.TabIndex = 11
        Me.BtnConfirmarCheckInReal.Text = "Confirmar Check &In"
        Me.ToolTip1.SetToolTip(Me.BtnConfirmarCheckInReal, "Clic para confirmar el Check In real de la reservación seleccionada (ALT + I)")
        Me.BtnConfirmarCheckInReal.UseVisualStyleBackColor = False
        '
        'BtnConfirmarCheckOutReal
        '
        Me.BtnConfirmarCheckOutReal.BackColor = System.Drawing.Color.Tomato
        Me.BtnConfirmarCheckOutReal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfirmarCheckOutReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmarCheckOutReal.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirmarCheckOutReal.ForeColor = System.Drawing.Color.White
        Me.BtnConfirmarCheckOutReal.Location = New System.Drawing.Point(903, 643)
        Me.BtnConfirmarCheckOutReal.Name = "BtnConfirmarCheckOutReal"
        Me.BtnConfirmarCheckOutReal.Size = New System.Drawing.Size(138, 38)
        Me.BtnConfirmarCheckOutReal.TabIndex = 12
        Me.BtnConfirmarCheckOutReal.Text = "Confirmar Check &Out"
        Me.ToolTip1.SetToolTip(Me.BtnConfirmarCheckOutReal, "Clic para confirmar el Check Out real de la reservación seleccionada (ALT + O)")
        Me.BtnConfirmarCheckOutReal.UseVisualStyleBackColor = False
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackgroundImage = CType(resources.GetObject("BtnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImprimir.Location = New System.Drawing.Point(1055, 643)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(40, 38)
        Me.BtnImprimir.TabIndex = 248
        Me.ToolTip1.SetToolTip(Me.BtnImprimir, "Clic para imprimir los datos actuales")
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'FrmListadoReservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1354, 691)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnConfirmarCheckOutReal)
        Me.Controls.Add(Me.BtnConfirmarCheckInReal)
        Me.Controls.Add(Me.BtnCalendario)
        Me.Controls.Add(Me.BtnBuscarReservaciones)
        Me.Controls.Add(Me.BtnModificarReservacion)
        Me.Controls.Add(Me.RbMostrarReservacionesActivas)
        Me.Controls.Add(Me.RbMostrarTodasReservaciones)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.BtnLimpiarBusqueda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimeFechaFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimeFechaInicial)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.TxtDatoBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnNuevaReservacion)
        Me.Controls.Add(Me.CBBuscarPor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVListadoReservaciones)
        Me.Controls.Add(Me.RbMostrarReservacionesConCheckOut)
        Me.Controls.Add(Me.RbMostrarReservacionesCanceladas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListadoReservaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de reservaciones"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVListadoReservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BtnBuscarReservaciones As Button
    Friend WithEvents BtnModificarReservacion As Button
    Friend WithEvents RbMostrarReservacionesActivas As RadioButton
    Friend WithEvents RbMostrarTodasReservaciones As RadioButton
    Friend WithEvents LbHora As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents FechaHora As Timer
    Friend WithEvents LbRol As Label
    Friend WithEvents LbUsuario As Label
    Friend WithEvents BtnLimpiarBusqueda As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimeFechaFinal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimeFechaInicial As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents TxtDatoBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnNuevaReservacion As Button
    Friend WithEvents CBBuscarPor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVListadoReservaciones As DataGridView
    Friend WithEvents RbMostrarReservacionesConCheckOut As RadioButton
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents RbMostrarReservacionesCanceladas As RadioButton
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnCalendario As Button
    Friend WithEvents BtnConfirmarCheckInReal As Button
    Friend WithEvents BtnConfirmarCheckOutReal As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnImprimir As Button
    Friend WithEvents BtnPantallaHabitaciones As Button
    Friend WithEvents BtnPantallaUsuarios As Button
    Public WithEvents BtnPantallaInicio As Button
    Friend WithEvents BtnPantallaClientes As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnPantallaFolios As Button
    Friend WithEvents BtnPantallaReservaciones As Button
End Class
