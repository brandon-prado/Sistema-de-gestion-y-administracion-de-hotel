<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmListadoUsuarios
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
        Dim BtnPantallaUsuarios As System.Windows.Forms.Button
        Dim BtnRegresar As System.Windows.Forms.Button
        Dim BtnPantallaFolios As System.Windows.Forms.Button
        Dim BtnPantallaReservaciones As System.Windows.Forms.Button
        Dim BtnPantallaClientes As System.Windows.Forms.Button
        Dim BtnPantallaHabitaciones As System.Windows.Forms.Button
        Dim BtnPantallaInicio As System.Windows.Forms.Button
        Dim BtnCerrarSesion As System.Windows.Forms.Button
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoUsuarios))
        Me.BtnModificarUsuario = New System.Windows.Forms.Button()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.RbMostrarAccesoSistema = New System.Windows.Forms.RadioButton()
        Me.RbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnNuevoUsuario = New System.Windows.Forms.Button()
        Me.TxtDatoBuscar = New System.Windows.Forms.TextBox()
        Me.CBBuscarPor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGVListadoUsuarios = New System.Windows.Forms.DataGridView()
        Me.RbMostrarInactivos = New System.Windows.Forms.RadioButton()
        Me.RbMostrarSinAcceso = New System.Windows.Forms.RadioButton()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnImprimir = New System.Windows.Forms.Button()
        BtnPantallaUsuarios = New System.Windows.Forms.Button()
        BtnRegresar = New System.Windows.Forms.Button()
        BtnPantallaFolios = New System.Windows.Forms.Button()
        BtnPantallaReservaciones = New System.Windows.Forms.Button()
        BtnPantallaClientes = New System.Windows.Forms.Button()
        BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        BtnPantallaInicio = New System.Windows.Forms.Button()
        BtnCerrarSesion = New System.Windows.Forms.Button()
        CType(Me.DGVListadoUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'BtnPantallaUsuarios
        '
        BtnPantallaUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        BtnPantallaUsuarios.CausesValidation = False
        BtnPantallaUsuarios.Cursor = System.Windows.Forms.Cursors.No
        BtnPantallaUsuarios.Enabled = False
        BtnPantallaUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BtnPantallaUsuarios.FlatAppearance.BorderSize = 0
        BtnPantallaUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Thistle
        BtnPantallaUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson
        BtnPantallaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnPantallaUsuarios.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        BtnPantallaUsuarios.ForeColor = System.Drawing.Color.Black
        BtnPantallaUsuarios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnPantallaUsuarios.Location = New System.Drawing.Point(77, 281)
        BtnPantallaUsuarios.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaUsuarios.Name = "BtnPantallaUsuarios"
        BtnPantallaUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaUsuarios.Size = New System.Drawing.Size(239, 36)
        BtnPantallaUsuarios.TabIndex = 12
        BtnPantallaUsuarios.TabStop = False
        BtnPantallaUsuarios.Text = "Usuarios"
        BtnPantallaUsuarios.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaUsuarios.UseVisualStyleBackColor = False
        AddHandler BtnPantallaUsuarios.Click, AddressOf Me.BtnPantallaUsuarios_Click_1
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
        BtnRegresar.Location = New System.Drawing.Point(75, 631)
        BtnRegresar.Margin = New System.Windows.Forms.Padding(0)
        BtnRegresar.Name = "BtnRegresar"
        BtnRegresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnRegresar.Size = New System.Drawing.Size(239, 36)
        BtnRegresar.TabIndex = 9
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
        BtnPantallaFolios.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnPantallaFolios.Location = New System.Drawing.Point(75, 551)
        BtnPantallaFolios.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaFolios.Name = "BtnPantallaFolios"
        BtnPantallaFolios.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaFolios.Size = New System.Drawing.Size(239, 36)
        BtnPantallaFolios.TabIndex = 16
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
        BtnPantallaReservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnPantallaReservaciones.Location = New System.Drawing.Point(75, 484)
        BtnPantallaReservaciones.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaReservaciones.Name = "BtnPantallaReservaciones"
        BtnPantallaReservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaReservaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaReservaciones.TabIndex = 15
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
        BtnPantallaClientes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnPantallaClientes.Location = New System.Drawing.Point(75, 414)
        BtnPantallaClientes.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaClientes.Name = "BtnPantallaClientes"
        BtnPantallaClientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaClientes.Size = New System.Drawing.Size(239, 36)
        BtnPantallaClientes.TabIndex = 14
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
        BtnPantallaHabitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        BtnPantallaHabitaciones.Location = New System.Drawing.Point(75, 348)
        BtnPantallaHabitaciones.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaHabitaciones.Name = "BtnPantallaHabitaciones"
        BtnPantallaHabitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaHabitaciones.Size = New System.Drawing.Size(239, 36)
        BtnPantallaHabitaciones.TabIndex = 13
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
        BtnPantallaInicio.Location = New System.Drawing.Point(75, 215)
        BtnPantallaInicio.Margin = New System.Windows.Forms.Padding(0)
        BtnPantallaInicio.Name = "BtnPantallaInicio"
        BtnPantallaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        BtnPantallaInicio.Size = New System.Drawing.Size(239, 36)
        BtnPantallaInicio.TabIndex = 11
        BtnPantallaInicio.TabStop = False
        BtnPantallaInicio.Text = "Pantalla de inicio"
        BtnPantallaInicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        BtnPantallaInicio.UseVisualStyleBackColor = False
        AddHandler BtnPantallaInicio.Click, AddressOf Me.BtnPantallaInicio_Click_1
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
        BtnCerrarSesion.TabIndex = 10
        BtnCerrarSesion.TabStop = False
        BtnCerrarSesion.Text = "Cerrar sesión"
        BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        BtnCerrarSesion.UseVisualStyleBackColor = False
        AddHandler BtnCerrarSesion.Click, AddressOf Me.BtnCerrarSesion_Click
        '
        'BtnModificarUsuario
        '
        Me.BtnModificarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModificarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed
        Me.BtnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.BtnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarUsuario.ForeColor = System.Drawing.Color.White
        Me.BtnModificarUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnModificarUsuario.Location = New System.Drawing.Point(1115, 648)
        Me.BtnModificarUsuario.Name = "BtnModificarUsuario"
        Me.BtnModificarUsuario.Size = New System.Drawing.Size(112, 38)
        Me.BtnModificarUsuario.TabIndex = 6
        Me.BtnModificarUsuario.Text = "&Modificar | Eliminar"
        Me.ToolTip1.SetToolTip(Me.BtnModificarUsuario, "Clic para modificar/eliminar el usuario seleccionado (ALT + M)")
        Me.BtnModificarUsuario.UseVisualStyleBackColor = False
        '
        'FechaHora
        '
        '
        'RbMostrarAccesoSistema
        '
        Me.RbMostrarAccesoSistema.AutoSize = True
        Me.RbMostrarAccesoSistema.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarAccesoSistema.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarAccesoSistema.Location = New System.Drawing.Point(314, 170)
        Me.RbMostrarAccesoSistema.Name = "RbMostrarAccesoSistema"
        Me.RbMostrarAccesoSistema.Size = New System.Drawing.Size(257, 24)
        Me.RbMostrarAccesoSistema.TabIndex = 3
        Me.RbMostrarAccesoSistema.TabStop = True
        Me.RbMostrarAccesoSistema.Text = "Ver usuarios con acceso al sistema"
        Me.RbMostrarAccesoSistema.UseVisualStyleBackColor = True
        '
        'RbMostrarTodos
        '
        Me.RbMostrarTodos.AutoSize = True
        Me.RbMostrarTodos.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarTodos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarTodos.Location = New System.Drawing.Point(314, 140)
        Me.RbMostrarTodos.Name = "RbMostrarTodos"
        Me.RbMostrarTodos.Size = New System.Drawing.Size(251, 24)
        Me.RbMostrarTodos.TabIndex = 2
        Me.RbMostrarTodos.TabStop = True
        Me.RbMostrarTodos.Text = "Ver todos los usuarios del sistema"
        Me.RbMostrarTodos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(310, 207)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(437, 31)
        Me.Label2.TabIndex = 127
        Me.Label2.Text = "Lista de los usuarios o empleados del sistema:"
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbHora.Location = New System.Drawing.Point(1115, 39)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 124
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbFecha.Location = New System.Drawing.Point(938, 8)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(404, 23)
        Me.LbFecha.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(280, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 64)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Listado de usuarios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnNuevoUsuario
        '
        Me.BtnNuevoUsuario.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnNuevoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.BtnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoUsuario.ForeColor = System.Drawing.Color.White
        Me.BtnNuevoUsuario.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNuevoUsuario.Location = New System.Drawing.Point(1234, 648)
        Me.BtnNuevoUsuario.Name = "BtnNuevoUsuario"
        Me.BtnNuevoUsuario.Size = New System.Drawing.Size(75, 38)
        Me.BtnNuevoUsuario.TabIndex = 1
        Me.BtnNuevoUsuario.Text = "&Nuevo"
        Me.ToolTip1.SetToolTip(Me.BtnNuevoUsuario, "Clic para registrar un usuario nuevo (ALT + N)")
        Me.BtnNuevoUsuario.UseVisualStyleBackColor = False
        '
        'TxtDatoBuscar
        '
        Me.TxtDatoBuscar.Location = New System.Drawing.Point(558, 654)
        Me.TxtDatoBuscar.MaxLength = 30
        Me.TxtDatoBuscar.Name = "TxtDatoBuscar"
        Me.TxtDatoBuscar.ShortcutsEnabled = False
        Me.TxtDatoBuscar.Size = New System.Drawing.Size(121, 20)
        Me.TxtDatoBuscar.TabIndex = 8
        '
        'CBBuscarPor
        '
        Me.CBBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBuscarPor.FormattingEnabled = True
        Me.CBBuscarPor.Items.AddRange(New Object() {"Nombre", "Apellido paterno", "Apellido materno", "Usuario"})
        Me.CBBuscarPor.Location = New System.Drawing.Point(427, 653)
        Me.CBBuscarPor.Name = "CBBuscarPor"
        Me.CBBuscarPor.Size = New System.Drawing.Size(121, 21)
        Me.CBBuscarPor.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(310, 648)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(111, 47)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Buscar por:"
        '
        'DGVListadoUsuarios
        '
        Me.DGVListadoUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVListadoUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVListadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVListadoUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVListadoUsuarios.Location = New System.Drawing.Point(312, 232)
        Me.DGVListadoUsuarios.Name = "DGVListadoUsuarios"
        Me.DGVListadoUsuarios.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVListadoUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVListadoUsuarios.Size = New System.Drawing.Size(997, 412)
        Me.DGVListadoUsuarios.TabIndex = 132
        '
        'RbMostrarInactivos
        '
        Me.RbMostrarInactivos.AutoSize = True
        Me.RbMostrarInactivos.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarInactivos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarInactivos.Location = New System.Drawing.Point(649, 170)
        Me.RbMostrarInactivos.Name = "RbMostrarInactivos"
        Me.RbMostrarInactivos.Size = New System.Drawing.Size(251, 24)
        Me.RbMostrarInactivos.TabIndex = 5
        Me.RbMostrarInactivos.TabStop = True
        Me.RbMostrarInactivos.Text = "Ver usuarios inactivos del sistema"
        Me.RbMostrarInactivos.UseVisualStyleBackColor = True
        '
        'RbMostrarSinAcceso
        '
        Me.RbMostrarSinAcceso.AutoSize = True
        Me.RbMostrarSinAcceso.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarSinAcceso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarSinAcceso.Location = New System.Drawing.Point(649, 140)
        Me.RbMostrarSinAcceso.Name = "RbMostrarSinAcceso"
        Me.RbMostrarSinAcceso.Size = New System.Drawing.Size(252, 24)
        Me.RbMostrarSinAcceso.TabIndex = 4
        Me.RbMostrarSinAcceso.TabStop = True
        Me.RbMostrarSinAcceso.Text = "Ver usuarios sin acceso al sistema"
        Me.RbMostrarSinAcceso.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LbRol)
        Me.Panel1.Controls.Add(Me.LbUsuario)
        Me.Panel1.Controls.Add(BtnCerrarSesion)
        Me.Panel1.Controls.Add(BtnPantallaUsuarios)
        Me.Panel1.Controls.Add(BtnRegresar)
        Me.Panel1.Controls.Add(BtnPantallaFolios)
        Me.Panel1.Controls.Add(BtnPantallaReservaciones)
        Me.Panel1.Controls.Add(BtnPantallaClientes)
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
        Me.Panel1.Location = New System.Drawing.Point(-7, -11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(281, 726)
        Me.Panel1.TabIndex = 126
        '
        'LbRol
        '
        Me.LbRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbRol.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.ForeColor = System.Drawing.Color.Black
        Me.LbRol.Location = New System.Drawing.Point(171, 129)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(110, 22)
        Me.LbRol.TabIndex = 185
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
        Me.LbUsuario.Size = New System.Drawing.Size(110, 117)
        Me.LbUsuario.TabIndex = 184
        Me.LbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.PictureBox8.Location = New System.Drawing.Point(32, 631)
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
        Me.PictureBox7.Location = New System.Drawing.Point(32, 551)
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
        Me.PictureBox6.Location = New System.Drawing.Point(32, 484)
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
        Me.PictureBox5.Location = New System.Drawing.Point(31, 414)
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
        Me.PictureBox4.Location = New System.Drawing.Point(31, 348)
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
        Me.PictureBox3.Location = New System.Drawing.Point(32, 281)
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
        Me.PictureBox2.Location = New System.Drawing.Point(32, 215)
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
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 790)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(310, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(590, 31)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Selecciona el filtro deseado para ver los usuarios o empleados del sistema:"
        '
        'BtnLimpiarBusqueda
        '
        Me.BtnLimpiarBusqueda.BackgroundImage = CType(resources.GetObject("BtnLimpiarBusqueda.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiarBusqueda.Location = New System.Drawing.Point(685, 656)
        Me.BtnLimpiarBusqueda.Name = "BtnLimpiarBusqueda"
        Me.BtnLimpiarBusqueda.Size = New System.Drawing.Size(21, 21)
        Me.BtnLimpiarBusqueda.TabIndex = 226
        Me.BtnLimpiarBusqueda.UseVisualStyleBackColor = True
        '
        'BtnImprimir
        '
        Me.BtnImprimir.BackgroundImage = CType(resources.GetObject("BtnImprimir.BackgroundImage"), System.Drawing.Image)
        Me.BtnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImprimir.Location = New System.Drawing.Point(1069, 647)
        Me.BtnImprimir.Name = "BtnImprimir"
        Me.BtnImprimir.Size = New System.Drawing.Size(40, 38)
        Me.BtnImprimir.TabIndex = 249
        Me.ToolTip1.SetToolTip(Me.BtnImprimir, "Clic para imprimir los datos actuales")
        Me.BtnImprimir.UseVisualStyleBackColor = True
        '
        'FrmListadoUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.BtnImprimir)
        Me.Controls.Add(Me.BtnLimpiarBusqueda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGVListadoUsuarios)
        Me.Controls.Add(Me.BtnModificarUsuario)
        Me.Controls.Add(Me.RbMostrarAccesoSistema)
        Me.Controls.Add(Me.RbMostrarTodos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnNuevoUsuario)
        Me.Controls.Add(Me.TxtDatoBuscar)
        Me.Controls.Add(Me.CBBuscarPor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RbMostrarInactivos)
        Me.Controls.Add(Me.RbMostrarSinAcceso)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListadoUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de usuarios"
        CType(Me.DGVListadoUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents BtnModificarUsuario As Button
    Friend WithEvents FechaHora As Timer
    Friend WithEvents RbMostrarAccesoSistema As RadioButton
    Friend WithEvents RbMostrarTodos As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnNuevoUsuario As Button
    Friend WithEvents TxtDatoBuscar As TextBox
    Friend WithEvents CBBuscarPor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DGVListadoUsuarios As DataGridView
    Friend WithEvents RbMostrarInactivos As RadioButton
    Friend WithEvents RbMostrarSinAcceso As RadioButton
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
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnLimpiarBusqueda As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnImprimir As Button
End Class
