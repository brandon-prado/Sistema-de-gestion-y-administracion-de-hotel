<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoFolio
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
        Dim BtnPantallaReservaciones As System.Windows.Forms.Button
        Dim BtnPantallaHabitaciones As System.Windows.Forms.Button
        Dim BtnPantallaInicio As System.Windows.Forms.Button
        Dim BtnCliente As System.Windows.Forms.Button
        Dim BtnCerrarSesion As System.Windows.Forms.Button
        Dim BtnPantallaUsuarios As System.Windows.Forms.Button
        Dim Button1 As System.Windows.Forms.Button
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoFolio))
        Me.RbMostrarFoliosActivos = New System.Windows.Forms.RadioButton()
        Me.RbMostrarTodosFolios = New System.Windows.Forms.RadioButton()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.TxtDatoBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnResumenFolio = New System.Windows.Forms.Button()
        Me.CBBuscarPor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVListadoFolios = New System.Windows.Forms.DataGridView()
        Me.RbMostrarFoliosCompletos = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.RbMostrarFoliosCancelados = New System.Windows.Forms.RadioButton()
        Me.BtnBuscarReservaciones = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimeFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimeFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnHabitacionesAsignadas = New System.Windows.Forms.Button()
        Me.BtnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        BtnRegresar = New System.Windows.Forms.Button()
        BtnPantallaReservaciones = New System.Windows.Forms.Button()
        BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        BtnPantallaInicio = New System.Windows.Forms.Button()
        BtnCliente = New System.Windows.Forms.Button()
        BtnCerrarSesion = New System.Windows.Forms.Button()
        BtnPantallaUsuarios = New System.Windows.Forms.Button()
        Button1 = New System.Windows.Forms.Button()
        CType(Me.DGVListadoFolios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        BtnRegresar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnRegresar.Location = New System.Drawing.Point(73, 640)
        BtnRegresar.Margin = New System.Windows.Forms.Padding(0)
        BtnRegresar.Name = "BtnRegresar"
        BtnRegresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnRegresar.Size = New System.Drawing.Size(239, 36)
        BtnRegresar.TabIndex = 13
        BtnRegresar.TabStop = False
        BtnRegresar.Text = "Regresar"
        BtnRegresar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnRegresar.UseVisualStyleBackColor = False
        AddHandler BtnRegresar.Click, AddressOf Me.BtnRegresar_Click
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
        BtnPantallaReservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnPantallaReservaciones.Location = New System.Drawing.Point(73, 499)
        BtnPantallaReservaciones.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaReservaciones.Name = "BtnPantallaReservaciones"
        BtnPantallaReservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaReservaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaReservaciones.TabIndex = 19
        BtnPantallaReservaciones.TabStop = False
        BtnPantallaReservaciones.Text = "Reservaciones"
        BtnPantallaReservaciones.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaReservaciones.UseVisualStyleBackColor = False
        AddHandler BtnPantallaReservaciones.Click, AddressOf Me.BtnPantallaReservaciones_Click
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
        BtnPantallaHabitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnPantallaHabitaciones.Location = New System.Drawing.Point(73, 363)
        BtnPantallaHabitaciones.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaHabitaciones.Name = "BtnPantallaHabitaciones"
        BtnPantallaHabitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaHabitaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaHabitaciones.TabIndex = 17
        BtnPantallaHabitaciones.TabStop = False
        BtnPantallaHabitaciones.Text = "Habitaciones"
        BtnPantallaHabitaciones.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaHabitaciones.UseVisualStyleBackColor = False
        AddHandler BtnPantallaHabitaciones.Click, AddressOf Me.BtnPantallaHabitaciones_Click
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
        BtnPantallaInicio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnPantallaInicio.Location = New System.Drawing.Point(73, 230)
        BtnPantallaInicio.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaInicio.Name = "BtnPantallaInicio"
        BtnPantallaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaInicio.Size = New System.Drawing.Size(239, 36)
        BtnPantallaInicio.TabIndex = 15
        BtnPantallaInicio.TabStop = False
        BtnPantallaInicio.Text = "Pantalla de inicio"
        BtnPantallaInicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaInicio.UseVisualStyleBackColor = False
        AddHandler BtnPantallaInicio.Click, AddressOf Me.BtnPantallaInicio_Click
        '
        'BtnCliente
        '
        BtnCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnCliente.CausesValidation = False
        BtnCliente.Cursor = System.Windows.Forms.Cursors.Hand
        BtnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnCliente.FlatAppearance.BorderSize = 0
        BtnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSeaGreen
        BtnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chartreuse
        BtnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnCliente.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnCliente.ForeColor = System.Drawing.Color.Black
        BtnCliente.Location = New System.Drawing.Point(76, 429)
        BtnCliente.Margin = New System.Windows.Forms.Padding(0)
        BtnCliente.Name = "BtnCliente"
        BtnCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnCliente.Size = New System.Drawing.Size(239, 36)
        BtnCliente.TabIndex = 18
        BtnCliente.TabStop = False
        BtnCliente.Text = "Clientes"
        BtnCliente.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnCliente.UseVisualStyleBackColor = False
        AddHandler BtnCliente.Click, AddressOf Me.BtnCliente_Click
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
        BtnCerrarSesion.Location = New System.Drawing.Point(168, 154)
        BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(0)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New System.Drawing.Size(98, 26)
        BtnCerrarSesion.TabIndex = 14
        BtnCerrarSesion.TabStop = False
        BtnCerrarSesion.Text = "Cerrar sesión"
        BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        BtnCerrarSesion.UseVisualStyleBackColor = False
        AddHandler BtnCerrarSesion.Click, AddressOf Me.BtnCerrarSesion_Click
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
        BtnPantallaUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnPantallaUsuarios.Location = New System.Drawing.Point(75, 296)
        BtnPantallaUsuarios.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaUsuarios.Name = "BtnPantallaUsuarios"
        BtnPantallaUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaUsuarios.Size = New System.Drawing.Size(239, 36)
        BtnPantallaUsuarios.TabIndex = 16
        BtnPantallaUsuarios.TabStop = False
        BtnPantallaUsuarios.Text = "Usuarios"
        BtnPantallaUsuarios.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaUsuarios.UseVisualStyleBackColor = False
        AddHandler BtnPantallaUsuarios.Click, AddressOf Me.BtnPantallaUsuarios_Click
        '
        'Button1
        '
        Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Button1.CausesValidation = False
        Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Button1.Enabled = False
        Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Button1.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Button1.ForeColor = System.Drawing.Color.Black
        Button1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Button1.Location = New System.Drawing.Point(76, 566)
        Button1.Margin = New System.Windows.Forms.Padding(0)
        Button1.Name = "Button1"
        Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Button1.Size = New System.Drawing.Size(239, 36)
        Button1.TabIndex = 20
        Button1.TabStop = False
        Button1.Text = "Folios"
        Button1.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Button1.UseVisualStyleBackColor = False
        AddHandler Button1.Click, AddressOf Me.Button1_Click
        '
        'RbMostrarFoliosActivos
        '
        Me.RbMostrarFoliosActivos.AutoSize = True
        Me.RbMostrarFoliosActivos.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarFoliosActivos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarFoliosActivos.Location = New System.Drawing.Point(348, 175)
        Me.RbMostrarFoliosActivos.Name = "RbMostrarFoliosActivos"
        Me.RbMostrarFoliosActivos.Size = New System.Drawing.Size(140, 24)
        Me.RbMostrarFoliosActivos.TabIndex = 2
        Me.RbMostrarFoliosActivos.TabStop = True
        Me.RbMostrarFoliosActivos.Text = "Ver folios activos"
        Me.RbMostrarFoliosActivos.UseVisualStyleBackColor = True
        '
        'RbMostrarTodosFolios
        '
        Me.RbMostrarTodosFolios.AutoSize = True
        Me.RbMostrarTodosFolios.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarTodosFolios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarTodosFolios.Location = New System.Drawing.Point(348, 145)
        Me.RbMostrarTodosFolios.Name = "RbMostrarTodosFolios"
        Me.RbMostrarTodosFolios.Size = New System.Drawing.Size(152, 24)
        Me.RbMostrarTodosFolios.TabIndex = 1
        Me.RbMostrarTodosFolios.TabStop = True
        Me.RbMostrarTodosFolios.Text = "Ver todos los folios"
        Me.RbMostrarTodosFolios.UseVisualStyleBackColor = True
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbHora.Location = New System.Drawing.Point(1116, 36)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 228
        '
        'FechaHora
        '
        '
        'LbRol
        '
        Me.LbRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbRol.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.ForeColor = System.Drawing.Color.Black
        Me.LbRol.Location = New System.Drawing.Point(169, 128)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(141, 22)
        Me.LbRol.TabIndex = 131
        Me.LbRol.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LbRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbUsuario
        '
        Me.LbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbUsuario.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LbUsuario.ForeColor = System.Drawing.Color.Black
        Me.LbUsuario.Location = New System.Drawing.Point(169, 11)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(141, 117)
        Me.LbUsuario.TabIndex = 130
        Me.LbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(344, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(396, 31)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Lista de los folios de reservaciones:"
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbFecha.Location = New System.Drawing.Point(971, 5)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(372, 23)
        Me.LbFecha.TabIndex = 227
        '
        'TxtDatoBuscar
        '
        Me.TxtDatoBuscar.Location = New System.Drawing.Point(632, 655)
        Me.TxtDatoBuscar.MaxLength = 30
        Me.TxtDatoBuscar.Name = "TxtDatoBuscar"
        Me.TxtDatoBuscar.ShortcutsEnabled = False
        Me.TxtDatoBuscar.Size = New System.Drawing.Size(121, 20)
        Me.TxtDatoBuscar.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(336, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 64)
        Me.Label1.TabIndex = 226
        Me.Label1.Text = "Listado de folios"
        '
        'BtnResumenFolio
        '
        Me.BtnResumenFolio.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnResumenFolio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnResumenFolio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.BtnResumenFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResumenFolio.ForeColor = System.Drawing.Color.White
        Me.BtnResumenFolio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnResumenFolio.Location = New System.Drawing.Point(1248, 655)
        Me.BtnResumenFolio.Name = "BtnResumenFolio"
        Me.BtnResumenFolio.Size = New System.Drawing.Size(75, 23)
        Me.BtnResumenFolio.TabIndex = 9
        Me.BtnResumenFolio.Text = "&Ver"
        Me.ToolTip1.SetToolTip(Me.BtnResumenFolio, "Clic para ver el resumen del folio seleccionado (ALT + V)")
        Me.BtnResumenFolio.UseVisualStyleBackColor = False
        '
        'CBBuscarPor
        '
        Me.CBBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBuscarPor.FormattingEnabled = True
        Me.CBBuscarPor.Items.AddRange(New Object() {"Nombre de cliente", "Apellido paterno de cliente", "Apellido materno de cliente", "Identificación de cliente", "Teléfono de cliente", "Nombre de usuario"})
        Me.CBBuscarPor.Location = New System.Drawing.Point(461, 654)
        Me.CBBuscarPor.Name = "CBBuscarPor"
        Me.CBBuscarPor.Size = New System.Drawing.Size(155, 21)
        Me.CBBuscarPor.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(344, 649)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(111, 29)
        Me.Label3.TabIndex = 236
        Me.Label3.Text = "Buscar por:"
        '
        'DGVListadoFolios
        '
        Me.DGVListadoFolios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVListadoFolios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVListadoFolios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVListadoFolios.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVListadoFolios.Location = New System.Drawing.Point(346, 233)
        Me.DGVListadoFolios.Name = "DGVListadoFolios"
        Me.DGVListadoFolios.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVListadoFolios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVListadoFolios.Size = New System.Drawing.Size(977, 412)
        Me.DGVListadoFolios.TabIndex = 235
        '
        'RbMostrarFoliosCompletos
        '
        Me.RbMostrarFoliosCompletos.AutoSize = True
        Me.RbMostrarFoliosCompletos.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarFoliosCompletos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarFoliosCompletos.Location = New System.Drawing.Point(536, 146)
        Me.RbMostrarFoliosCompletos.Name = "RbMostrarFoliosCompletos"
        Me.RbMostrarFoliosCompletos.Size = New System.Drawing.Size(177, 24)
        Me.RbMostrarFoliosCompletos.TabIndex = 3
        Me.RbMostrarFoliosCompletos.TabStop = True
        Me.RbMostrarFoliosCompletos.Text = "Ver folios completados"
        Me.RbMostrarFoliosCompletos.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Button1)
        Me.Panel1.Controls.Add(BtnCliente)
        Me.Panel1.Controls.Add(Me.LbRol)
        Me.Panel1.Controls.Add(Me.LbUsuario)
        Me.Panel1.Controls.Add(BtnCerrarSesion)
        Me.Panel1.Controls.Add(BtnPantallaUsuarios)
        Me.Panel1.Controls.Add(BtnRegresar)
        Me.Panel1.Controls.Add(BtnPantallaReservaciones)
        Me.Panel1.Controls.Add(BtnPantallaHabitaciones)
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
        Me.Panel1.Location = New System.Drawing.Point(-3, -10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 726)
        Me.Panel1.TabIndex = 229
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox11.Location = New System.Drawing.Point(47, 48)
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
        Me.PictureBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox10.Location = New System.Drawing.Point(9, 16)
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
        Me.PictureBox8.Location = New System.Drawing.Point(30, 640)
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
        Me.PictureBox7.Location = New System.Drawing.Point(30, 566)
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
        Me.PictureBox6.Location = New System.Drawing.Point(30, 499)
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
        Me.PictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox5.Location = New System.Drawing.Point(29, 429)
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
        Me.PictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox4.Location = New System.Drawing.Point(29, 363)
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
        Me.PictureBox3.Location = New System.Drawing.Point(30, 296)
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
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(30, 230)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 89
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(-10, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 790)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'RbMostrarFoliosCancelados
        '
        Me.RbMostrarFoliosCancelados.AutoSize = True
        Me.RbMostrarFoliosCancelados.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarFoliosCancelados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarFoliosCancelados.Location = New System.Drawing.Point(759, 146)
        Me.RbMostrarFoliosCancelados.Name = "RbMostrarFoliosCancelados"
        Me.RbMostrarFoliosCancelados.Size = New System.Drawing.Size(165, 24)
        Me.RbMostrarFoliosCancelados.TabIndex = 5
        Me.RbMostrarFoliosCancelados.TabStop = True
        Me.RbMostrarFoliosCancelados.Text = "Ver folios cancelados"
        Me.RbMostrarFoliosCancelados.UseVisualStyleBackColor = True
        '
        'BtnBuscarReservaciones
        '
        Me.BtnBuscarReservaciones.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnBuscarReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarReservaciones.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarReservaciones.Location = New System.Drawing.Point(1248, 177)
        Me.BtnBuscarReservaciones.Name = "BtnBuscarReservaciones"
        Me.BtnBuscarReservaciones.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarReservaciones.TabIndex = 8
        Me.BtnBuscarReservaciones.Text = "Buscar"
        Me.BtnBuscarReservaciones.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(967, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(318, 31)
        Me.Label5.TabIndex = 253
        Me.Label5.Text = "Rango de fecha:"
        '
        'DateTimeFechaFinal
        '
        Me.DateTimeFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaFinal.Location = New System.Drawing.Point(1226, 149)
        Me.DateTimeFechaFinal.Name = "DateTimeFechaFinal"
        Me.DateTimeFechaFinal.Size = New System.Drawing.Size(97, 20)
        Me.DateTimeFechaFinal.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(1153, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 31)
        Me.Label4.TabIndex = 251
        Me.Label4.Text = "Final:"
        '
        'DateTimeFechaInicial
        '
        Me.DateTimeFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaInicial.Location = New System.Drawing.Point(1040, 149)
        Me.DateTimeFechaInicial.Name = "DateTimeFechaInicial"
        Me.DateTimeFechaInicial.Size = New System.Drawing.Size(97, 20)
        Me.DateTimeFechaInicial.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(967, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 31)
        Me.Label10.TabIndex = 249
        Me.Label10.Text = "Inicial:"
        '
        'BtnHabitacionesAsignadas
        '
        Me.BtnHabitacionesAsignadas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnHabitacionesAsignadas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnHabitacionesAsignadas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.BtnHabitacionesAsignadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.BtnHabitacionesAsignadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHabitacionesAsignadas.ForeColor = System.Drawing.Color.White
        Me.BtnHabitacionesAsignadas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnHabitacionesAsignadas.Location = New System.Drawing.Point(1087, 656)
        Me.BtnHabitacionesAsignadas.Name = "BtnHabitacionesAsignadas"
        Me.BtnHabitacionesAsignadas.Size = New System.Drawing.Size(155, 23)
        Me.BtnHabitacionesAsignadas.TabIndex = 10
        Me.BtnHabitacionesAsignadas.Text = "&Habitación/es asignada/s"
        Me.ToolTip1.SetToolTip(Me.BtnHabitacionesAsignadas, "Clic para ver las habitaciones asignadas al folio (ALT + H)")
        Me.BtnHabitacionesAsignadas.UseVisualStyleBackColor = False
        '
        'BtnLimpiarBusqueda
        '
        Me.BtnLimpiarBusqueda.BackgroundImage = CType(resources.GetObject("BtnLimpiarBusqueda.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiarBusqueda.Location = New System.Drawing.Point(759, 656)
        Me.BtnLimpiarBusqueda.Name = "BtnLimpiarBusqueda"
        Me.BtnLimpiarBusqueda.Size = New System.Drawing.Size(21, 21)
        Me.BtnLimpiarBusqueda.TabIndex = 247
        Me.BtnLimpiarBusqueda.UseVisualStyleBackColor = True
        '
        'FrmListadoFolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.BtnHabitacionesAsignadas)
        Me.Controls.Add(Me.BtnBuscarReservaciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimeFechaFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimeFechaInicial)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RbMostrarFoliosCancelados)
        Me.Controls.Add(Me.RbMostrarFoliosActivos)
        Me.Controls.Add(Me.RbMostrarTodosFolios)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.BtnLimpiarBusqueda)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.TxtDatoBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnResumenFolio)
        Me.Controls.Add(Me.CBBuscarPor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVListadoFolios)
        Me.Controls.Add(Me.RbMostrarFoliosCompletos)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListadoFolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de folios de reservación/es"
        CType(Me.DGVListadoFolios, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents RbMostrarFoliosActivos As RadioButton
    Friend WithEvents RbMostrarTodosFolios As RadioButton
    Friend WithEvents LbHora As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents FechaHora As Timer
    Friend WithEvents LbRol As Label
    Friend WithEvents LbUsuario As Label
    Friend WithEvents BtnLimpiarBusqueda As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents TxtDatoBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnResumenFolio As Button
    Friend WithEvents CBBuscarPor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVListadoFolios As DataGridView
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents RbMostrarFoliosCompletos As RadioButton
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents RbMostrarFoliosCancelados As RadioButton
    Friend WithEvents BtnBuscarReservaciones As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimeFechaFinal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimeFechaInicial As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnHabitacionesAsignadas As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
