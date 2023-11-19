<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuAdministracion
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
        Dim BtnRegresar As System.Windows.Forms.Button
        Dim BtnPantallaFolios As System.Windows.Forms.Button
        Dim BtnPantallaReservaciones As System.Windows.Forms.Button
        Dim BtnPantallaClientes As System.Windows.Forms.Button
        Dim BtnPantallaHabitaciones As System.Windows.Forms.Button
        Dim BtnPantallaUsuarios As System.Windows.Forms.Button
        Dim BtnPantallaInicio As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuAdministracion))
        Me.LbHora = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.BtnAdministracion = New System.Windows.Forms.Button()
        Me.BtnCaja = New System.Windows.Forms.Button()
        Me.BtnCobro = New System.Windows.Forms.Button()
        Me.BtnAdminFolio = New System.Windows.Forms.Button()
        Me.BtnHabitacion = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.BtnUsuarios = New System.Windows.Forms.Button()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnAcercaDe = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        BtnCerrarSesion = New System.Windows.Forms.Button()
        BtnRegresar = New System.Windows.Forms.Button()
        BtnPantallaFolios = New System.Windows.Forms.Button()
        BtnPantallaReservaciones = New System.Windows.Forms.Button()
        BtnPantallaClientes = New System.Windows.Forms.Button()
        BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        BtnPantallaUsuarios = New System.Windows.Forms.Button()
        BtnPantallaInicio = New System.Windows.Forms.Button()
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
        BtnCerrarSesion.Location = New System.Drawing.Point(167, 159)
        BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(0)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New System.Drawing.Size(98, 26)
        BtnCerrarSesion.TabIndex = 9
        BtnCerrarSesion.TabStop = False
        BtnCerrarSesion.Text = "Cerrar sesión"
        BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        BtnCerrarSesion.UseVisualStyleBackColor = False
        AddHandler BtnCerrarSesion.Click, AddressOf Me.BtnCerrarSesion_Click_2
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
        BtnRegresar.Size = New System.Drawing.Size(239, 36)
        BtnRegresar.TabIndex = 8
        BtnRegresar.TabStop = False
        BtnRegresar.Text = "Regresar"
        BtnRegresar.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnRegresar.UseVisualStyleBackColor = False
        AddHandler BtnRegresar.Click, AddressOf Me.BtnRegresar_Click_1
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
        BtnPantallaFolios.Size = New System.Drawing.Size(239, 36)
        BtnPantallaFolios.TabIndex = 15
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
        BtnPantallaReservaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaReservaciones.TabIndex = 14
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
        BtnPantallaClientes.Size = New System.Drawing.Size(239, 36)
        BtnPantallaClientes.TabIndex = 13
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
        BtnPantallaHabitaciones.Location = New System.Drawing.Point(74, 357)
        BtnPantallaHabitaciones.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaHabitaciones.Name = "BtnPantallaHabitaciones"
        BtnPantallaHabitaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaHabitaciones.TabIndex = 12
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
        BtnPantallaUsuarios.Size = New System.Drawing.Size(239, 36)
        BtnPantallaUsuarios.TabIndex = 11
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
        BtnPantallaInicio.Size = New System.Drawing.Size(239, 36)
        BtnPantallaInicio.TabIndex = 10
        BtnPantallaInicio.TabStop = False
        BtnPantallaInicio.Text = "Pantalla de inicio"
        BtnPantallaInicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaInicio.UseVisualStyleBackColor = False
        AddHandler BtnPantallaInicio.Click, AddressOf Me.BtnPantallaInicio_Click_1
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.Location = New System.Drawing.Point(1114, 39)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 76
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.Location = New System.Drawing.Point(950, 8)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(391, 23)
        Me.LbFecha.TabIndex = 75
        '
        'BtnAdministracion
        '
        Me.BtnAdministracion.BackgroundImage = CType(resources.GetObject("BtnAdministracion.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdministracion.Location = New System.Drawing.Point(869, 416)
        Me.BtnAdministracion.Name = "BtnAdministracion"
        Me.BtnAdministracion.Size = New System.Drawing.Size(202, 195)
        Me.BtnAdministracion.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.BtnAdministracion, "Clic para entrar al apartado de generación de reportes")
        Me.BtnAdministracion.UseVisualStyleBackColor = True
        '
        'BtnCaja
        '
        Me.BtnCaja.BackgroundImage = CType(resources.GetObject("BtnCaja.BackgroundImage"), System.Drawing.Image)
        Me.BtnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCaja.Location = New System.Drawing.Point(621, 416)
        Me.BtnCaja.Name = "BtnCaja"
        Me.BtnCaja.Size = New System.Drawing.Size(202, 195)
        Me.BtnCaja.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnCaja, "Clic para entrar al apartado de administración de caja/turno")
        Me.BtnCaja.UseVisualStyleBackColor = True
        '
        'BtnCobro
        '
        Me.BtnCobro.BackgroundImage = CType(resources.GetObject("BtnCobro.BackgroundImage"), System.Drawing.Image)
        Me.BtnCobro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCobro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCobro.Location = New System.Drawing.Point(367, 416)
        Me.BtnCobro.Name = "BtnCobro"
        Me.BtnCobro.Size = New System.Drawing.Size(202, 195)
        Me.BtnCobro.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BtnCobro, "Clic para entrar al apartado de administración de cobros")
        Me.BtnCobro.UseVisualStyleBackColor = True
        '
        'BtnAdminFolio
        '
        Me.BtnAdminFolio.BackgroundImage = CType(resources.GetObject("BtnAdminFolio.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdminFolio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdminFolio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdminFolio.Location = New System.Drawing.Point(1110, 129)
        Me.BtnAdminFolio.Name = "BtnAdminFolio"
        Me.BtnAdminFolio.Size = New System.Drawing.Size(202, 195)
        Me.BtnAdminFolio.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BtnAdminFolio, "Clic para entrar al apartado de administración de folios")
        Me.BtnAdminFolio.UseVisualStyleBackColor = True
        '
        'BtnHabitacion
        '
        Me.BtnHabitacion.BackgroundImage = CType(resources.GetObject("BtnHabitacion.BackgroundImage"), System.Drawing.Image)
        Me.BtnHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHabitacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHabitacion.Location = New System.Drawing.Point(862, 129)
        Me.BtnHabitacion.Name = "BtnHabitacion"
        Me.BtnHabitacion.Size = New System.Drawing.Size(202, 195)
        Me.BtnHabitacion.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BtnHabitacion, "Clic para entrar al apartado de administración de habitaciones")
        Me.BtnHabitacion.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(608, 129)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(202, 195)
        Me.Button3.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button3, "Clic para entrar al apartado de administración de clientes")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(869, 614)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 24)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Informes"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(625, 615)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 24)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Caja"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(367, 614)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 24)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Cobro/Historial"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(1110, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 47)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Administrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Folios"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(862, 327)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 47)
        Me.Label4.TabIndex = 61
        Me.Label4.Text = "Administrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Habitaciones"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(608, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 47)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Administrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(363, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(202, 47)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Administrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuarios"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(319, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(452, 64)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "Administración"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FechaHora
        '
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.BackgroundImage = CType(resources.GetObject("BtnUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.BtnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUsuarios.Location = New System.Drawing.Point(363, 129)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(202, 195)
        Me.BtnUsuarios.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.BtnUsuarios, "Clic para entrar al apartado de administración de usuarios")
        Me.BtnUsuarios.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(315, 726)
        Me.Panel1.TabIndex = 90
        '
        'LbRol
        '
        Me.LbRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbRol.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.ForeColor = System.Drawing.Color.Black
        Me.LbRol.Location = New System.Drawing.Point(168, 132)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(136, 22)
        Me.LbRol.TabIndex = 92
        Me.LbRol.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LbRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbUsuario
        '
        Me.LbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbUsuario.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LbUsuario.ForeColor = System.Drawing.Color.Black
        Me.LbUsuario.Location = New System.Drawing.Point(169, 12)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(143, 122)
        Me.LbUsuario.TabIndex = 91
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
        Me.PictureBox1.Size = New System.Drawing.Size(322, 790)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'BtnAcercaDe
        '
        Me.BtnAcercaDe.BackgroundImage = CType(resources.GetObject("BtnAcercaDe.BackgroundImage"), System.Drawing.Image)
        Me.BtnAcercaDe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAcercaDe.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAcercaDe.Location = New System.Drawing.Point(1110, 417)
        Me.BtnAcercaDe.Name = "BtnAcercaDe"
        Me.BtnAcercaDe.Size = New System.Drawing.Size(202, 195)
        Me.BtnAcercaDe.TabIndex = 91
        Me.ToolTip1.SetToolTip(Me.BtnAcercaDe, "Clic para entrar al apartado de información del proyecto")
        Me.BtnAcercaDe.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(1114, 615)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(198, 24)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Acerca de"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmMenuAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnAcercaDe)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnUsuarios)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.BtnAdministracion)
        Me.Controls.Add(Me.BtnCaja)
        Me.Controls.Add(Me.BtnCobro)
        Me.Controls.Add(Me.BtnAdminFolio)
        Me.Controls.Add(Me.BtnHabitacion)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMenuAdministracion"
        Me.Padding = New System.Windows.Forms.Padding(1, 1, 2, 1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú de administración"
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

    End Sub
    Friend WithEvents LbHora As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents BtnAdministracion As Button
    Friend WithEvents BtnCaja As Button
    Friend WithEvents BtnCobro As Button
    Friend WithEvents BtnAdminFolio As Button
    Friend WithEvents BtnHabitacion As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents FechaHora As Timer
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents LbRol As Label
    Friend WithEvents LbUsuario As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnAcercaDe As Button
    Friend WithEvents Label9 As Label
End Class
