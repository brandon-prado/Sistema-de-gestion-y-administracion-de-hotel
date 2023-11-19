<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoHabitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoHabitaciones))
        Me.PBImagenHabitacion = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DGVListadoHabitacion = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.TxtDatoBuscar = New System.Windows.Forms.TextBox()
        Me.CBBuscarPor = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnNuevaHabitacion = New System.Windows.Forms.Button()
        Me.RbMostrarHabitacionesDisponibles = New System.Windows.Forms.RadioButton()
        Me.RbMostrarTodasHabitaciones = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RbMostrarHabitacionesMantenimineto = New System.Windows.Forms.RadioButton()
        Me.RbMostrarHabitacionesOcupadas = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.RbMostrarHabitacionesInactivas = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnPantallaFolios = New System.Windows.Forms.Button()
        Me.BtnPantallaReservaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaClientes = New System.Windows.Forms.Button()
        Me.BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaUsuarios = New System.Windows.Forms.Button()
        Me.BtnPantallaInicio = New System.Windows.Forms.Button()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbHabitacion = New System.Windows.Forms.Label()
        Me.BtnModificarHabitacion = New System.Windows.Forms.Button()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        BtnCerrarSesion = New System.Windows.Forms.Button()
        CType(Me.PBImagenHabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVListadoHabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
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
        BtnCerrarSesion.Location = New System.Drawing.Point(10, 232)
        BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(0)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New System.Drawing.Size(98, 26)
        BtnCerrarSesion.TabIndex = 11
        BtnCerrarSesion.TabStop = False
        BtnCerrarSesion.Text = "Cerrar sesión"
        BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        BtnCerrarSesion.UseVisualStyleBackColor = False
        AddHandler BtnCerrarSesion.Click, AddressOf Me.BtnCerrarSesion_Click
        '
        'PBImagenHabitacion
        '
        Me.PBImagenHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBImagenHabitacion.InitialImage = Nothing
        Me.PBImagenHabitacion.Location = New System.Drawing.Point(855, 269)
        Me.PBImagenHabitacion.Name = "PBImagenHabitacion"
        Me.PBImagenHabitacion.Size = New System.Drawing.Size(484, 357)
        Me.PBImagenHabitacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBImagenHabitacion.TabIndex = 206
        Me.PBImagenHabitacion.TabStop = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(855, 245)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(165, 31)
        Me.Label8.TabIndex = 207
        Me.Label8.Text = "Imagen:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DGVListadoHabitacion
        '
        Me.DGVListadoHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVListadoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVListadoHabitacion.Location = New System.Drawing.Point(147, 269)
        Me.DGVListadoHabitacion.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVListadoHabitacion.Name = "DGVListadoHabitacion"
        Me.DGVListadoHabitacion.ReadOnly = True
        Me.DGVListadoHabitacion.RowHeadersWidth = 51
        Me.DGVListadoHabitacion.RowTemplate.Height = 24
        Me.DGVListadoHabitacion.Size = New System.Drawing.Size(703, 357)
        Me.DGVListadoHabitacion.TabIndex = 204
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(143, 245)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(375, 31)
        Me.Label15.TabIndex = 205
        Me.Label15.Text = "Lista de las habitaciones del sistema:"
        '
        'BtnLimpiarBusqueda
        '
        Me.BtnLimpiarBusqueda.BackgroundImage = CType(resources.GetObject("BtnLimpiarBusqueda.BackgroundImage"), System.Drawing.Image)
        Me.BtnLimpiarBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLimpiarBusqueda.Location = New System.Drawing.Point(517, 652)
        Me.BtnLimpiarBusqueda.Name = "BtnLimpiarBusqueda"
        Me.BtnLimpiarBusqueda.Size = New System.Drawing.Size(21, 21)
        Me.BtnLimpiarBusqueda.TabIndex = 229
        Me.BtnLimpiarBusqueda.UseVisualStyleBackColor = True
        '
        'TxtDatoBuscar
        '
        Me.TxtDatoBuscar.Location = New System.Drawing.Point(390, 650)
        Me.TxtDatoBuscar.MaxLength = 10
        Me.TxtDatoBuscar.Name = "TxtDatoBuscar"
        Me.TxtDatoBuscar.ShortcutsEnabled = False
        Me.TxtDatoBuscar.Size = New System.Drawing.Size(121, 20)
        Me.TxtDatoBuscar.TabIndex = 9
        '
        'CBBuscarPor
        '
        Me.CBBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBuscarPor.FormattingEnabled = True
        Me.CBBuscarPor.Items.AddRange(New Object() {"Tipo", "Precio", "Capacidad"})
        Me.CBBuscarPor.Location = New System.Drawing.Point(259, 649)
        Me.CBBuscarPor.Name = "CBBuscarPor"
        Me.CBBuscarPor.Size = New System.Drawing.Size(121, 21)
        Me.CBBuscarPor.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(142, 644)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(111, 29)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "Buscar por:"
        '
        'BtnNuevaHabitacion
        '
        Me.BtnNuevaHabitacion.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnNuevaHabitacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnNuevaHabitacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.BtnNuevaHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevaHabitacion.ForeColor = System.Drawing.Color.White
        Me.BtnNuevaHabitacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNuevaHabitacion.Location = New System.Drawing.Point(1245, 650)
        Me.BtnNuevaHabitacion.Name = "BtnNuevaHabitacion"
        Me.BtnNuevaHabitacion.Size = New System.Drawing.Size(92, 24)
        Me.BtnNuevaHabitacion.TabIndex = 1
        Me.BtnNuevaHabitacion.Text = "&Registrar"
        Me.ToolTip1.SetToolTip(Me.BtnNuevaHabitacion, "Clic para registrar una habitación (ALT + R)")
        Me.BtnNuevaHabitacion.UseVisualStyleBackColor = False
        '
        'RbMostrarHabitacionesDisponibles
        '
        Me.RbMostrarHabitacionesDisponibles.AutoSize = True
        Me.RbMostrarHabitacionesDisponibles.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarHabitacionesDisponibles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarHabitacionesDisponibles.Location = New System.Drawing.Point(152, 190)
        Me.RbMostrarHabitacionesDisponibles.Name = "RbMostrarHabitacionesDisponibles"
        Me.RbMostrarHabitacionesDisponibles.Size = New System.Drawing.Size(213, 24)
        Me.RbMostrarHabitacionesDisponibles.TabIndex = 3
        Me.RbMostrarHabitacionesDisponibles.TabStop = True
        Me.RbMostrarHabitacionesDisponibles.Text = "Ver habitaciones disponibles"
        Me.RbMostrarHabitacionesDisponibles.UseVisualStyleBackColor = True
        '
        'RbMostrarTodasHabitaciones
        '
        Me.RbMostrarTodasHabitaciones.AutoSize = True
        Me.RbMostrarTodasHabitaciones.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarTodasHabitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarTodasHabitaciones.Location = New System.Drawing.Point(152, 160)
        Me.RbMostrarTodasHabitaciones.Name = "RbMostrarTodasHabitaciones"
        Me.RbMostrarTodasHabitaciones.Size = New System.Drawing.Size(200, 24)
        Me.RbMostrarTodasHabitaciones.TabIndex = 2
        Me.RbMostrarTodasHabitaciones.TabStop = True
        Me.RbMostrarTodasHabitaciones.Text = "Ver todas los habitaciones"
        Me.RbMostrarTodasHabitaciones.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(143, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(707, 31)
        Me.Label2.TabIndex = 232
        Me.Label2.Text = "Selecciona el filtro deseado para ver las habitaciones del sistema:"
        '
        'RbMostrarHabitacionesMantenimineto
        '
        Me.RbMostrarHabitacionesMantenimineto.AutoSize = True
        Me.RbMostrarHabitacionesMantenimineto.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarHabitacionesMantenimineto.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarHabitacionesMantenimineto.Location = New System.Drawing.Point(395, 190)
        Me.RbMostrarHabitacionesMantenimineto.Name = "RbMostrarHabitacionesMantenimineto"
        Me.RbMostrarHabitacionesMantenimineto.Size = New System.Drawing.Size(218, 24)
        Me.RbMostrarHabitacionesMantenimineto.TabIndex = 5
        Me.RbMostrarHabitacionesMantenimineto.TabStop = True
        Me.RbMostrarHabitacionesMantenimineto.Text = "Ver habitaciones en limpieza"
        Me.RbMostrarHabitacionesMantenimineto.UseVisualStyleBackColor = True
        '
        'RbMostrarHabitacionesOcupadas
        '
        Me.RbMostrarHabitacionesOcupadas.AutoSize = True
        Me.RbMostrarHabitacionesOcupadas.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarHabitacionesOcupadas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarHabitacionesOcupadas.Location = New System.Drawing.Point(395, 160)
        Me.RbMostrarHabitacionesOcupadas.Name = "RbMostrarHabitacionesOcupadas"
        Me.RbMostrarHabitacionesOcupadas.Size = New System.Drawing.Size(203, 24)
        Me.RbMostrarHabitacionesOcupadas.TabIndex = 4
        Me.RbMostrarHabitacionesOcupadas.TabStop = True
        Me.RbMostrarHabitacionesOcupadas.Text = "Ver habitaciones ocupadas"
        Me.RbMostrarHabitacionesOcupadas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(138, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 64)
        Me.Label1.TabIndex = 237
        Me.Label1.Text = "Listado de Habitaciones"
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbHora.Location = New System.Drawing.Point(1113, 39)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 239
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbFecha.Location = New System.Drawing.Point(958, 7)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(382, 23)
        Me.LbFecha.TabIndex = 238
        '
        'RbMostrarHabitacionesInactivas
        '
        Me.RbMostrarHabitacionesInactivas.AutoSize = True
        Me.RbMostrarHabitacionesInactivas.Font = New System.Drawing.Font("Trebuchet MS", 11.25!)
        Me.RbMostrarHabitacionesInactivas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RbMostrarHabitacionesInactivas.Location = New System.Drawing.Point(702, 160)
        Me.RbMostrarHabitacionesInactivas.Name = "RbMostrarHabitacionesInactivas"
        Me.RbMostrarHabitacionesInactivas.Size = New System.Drawing.Size(200, 24)
        Me.RbMostrarHabitacionesInactivas.TabIndex = 6
        Me.RbMostrarHabitacionesInactivas.TabStop = True
        Me.RbMostrarHabitacionesInactivas.Text = "Ver habitaciones inactivas"
        Me.RbMostrarHabitacionesInactivas.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnPantallaFolios)
        Me.Panel1.Controls.Add(Me.BtnPantallaReservaciones)
        Me.Panel1.Controls.Add(Me.BtnPantallaClientes)
        Me.Panel1.Controls.Add(Me.BtnPantallaHabitaciones)
        Me.Panel1.Controls.Add(Me.BtnPantallaUsuarios)
        Me.Panel1.Controls.Add(Me.BtnPantallaInicio)
        Me.Panel1.Controls.Add(Me.PictureBox11)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(BtnCerrarSesion)
        Me.Panel1.Controls.Add(Me.BtnRegresar)
        Me.Panel1.Controls.Add(Me.LbUsuario)
        Me.Panel1.Controls.Add(Me.LbRol)
        Me.Panel1.Controls.Add(Me.LbHabitacion)
        Me.Panel1.Location = New System.Drawing.Point(-3, -12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 726)
        Me.Panel1.TabIndex = 241
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(3, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(110, 24)
        Me.Label5.TabIndex = 249
        Me.Label5.Text = "Usuarios"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnPantallaFolios
        '
        Me.BtnPantallaFolios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaFolios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaFolios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnPantallaFolios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaFolios.Image = CType(resources.GetObject("BtnPantallaFolios.Image"), System.Drawing.Image)
        Me.BtnPantallaFolios.Location = New System.Drawing.Point(35, 578)
        Me.BtnPantallaFolios.Name = "BtnPantallaFolios"
        Me.BtnPantallaFolios.Size = New System.Drawing.Size(41, 42)
        Me.BtnPantallaFolios.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.BtnPantallaFolios, "Folios")
        Me.BtnPantallaFolios.UseVisualStyleBackColor = True
        '
        'BtnPantallaReservaciones
        '
        Me.BtnPantallaReservaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaReservaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaReservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnPantallaReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaReservaciones.Image = CType(resources.GetObject("BtnPantallaReservaciones.Image"), System.Drawing.Image)
        Me.BtnPantallaReservaciones.Location = New System.Drawing.Point(35, 514)
        Me.BtnPantallaReservaciones.Name = "BtnPantallaReservaciones"
        Me.BtnPantallaReservaciones.Size = New System.Drawing.Size(41, 42)
        Me.BtnPantallaReservaciones.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.BtnPantallaReservaciones, "Calendario")
        Me.BtnPantallaReservaciones.UseVisualStyleBackColor = True
        '
        'BtnPantallaClientes
        '
        Me.BtnPantallaClientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnPantallaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaClientes.Image = CType(resources.GetObject("BtnPantallaClientes.Image"), System.Drawing.Image)
        Me.BtnPantallaClientes.Location = New System.Drawing.Point(35, 450)
        Me.BtnPantallaClientes.Name = "BtnPantallaClientes"
        Me.BtnPantallaClientes.Size = New System.Drawing.Size(41, 42)
        Me.BtnPantallaClientes.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.BtnPantallaClientes, "Clientes")
        Me.BtnPantallaClientes.UseVisualStyleBackColor = True
        '
        'BtnPantallaHabitaciones
        '
        Me.BtnPantallaHabitaciones.Enabled = False
        Me.BtnPantallaHabitaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaHabitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnPantallaHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaHabitaciones.Image = CType(resources.GetObject("BtnPantallaHabitaciones.Image"), System.Drawing.Image)
        Me.BtnPantallaHabitaciones.Location = New System.Drawing.Point(35, 381)
        Me.BtnPantallaHabitaciones.Name = "BtnPantallaHabitaciones"
        Me.BtnPantallaHabitaciones.Size = New System.Drawing.Size(41, 42)
        Me.BtnPantallaHabitaciones.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.BtnPantallaHabitaciones, "Habitaciones")
        Me.BtnPantallaHabitaciones.UseVisualStyleBackColor = True
        '
        'BtnPantallaUsuarios
        '
        Me.BtnPantallaUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnPantallaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaUsuarios.Image = CType(resources.GetObject("BtnPantallaUsuarios.Image"), System.Drawing.Image)
        Me.BtnPantallaUsuarios.Location = New System.Drawing.Point(36, 320)
        Me.BtnPantallaUsuarios.Name = "BtnPantallaUsuarios"
        Me.BtnPantallaUsuarios.Size = New System.Drawing.Size(41, 40)
        Me.BtnPantallaUsuarios.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.BtnPantallaUsuarios, "Usuarios")
        Me.BtnPantallaUsuarios.UseVisualStyleBackColor = True
        '
        'BtnPantallaInicio
        '
        Me.BtnPantallaInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaInicio.FlatAppearance.BorderSize = 0
        Me.BtnPantallaInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnPantallaInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaInicio.Image = CType(resources.GetObject("BtnPantallaInicio.Image"), System.Drawing.Image)
        Me.BtnPantallaInicio.Location = New System.Drawing.Point(36, 263)
        Me.BtnPantallaInicio.Margin = New System.Windows.Forms.Padding(5)
        Me.BtnPantallaInicio.Name = "BtnPantallaInicio"
        Me.BtnPantallaInicio.Padding = New System.Windows.Forms.Padding(1)
        Me.BtnPantallaInicio.Size = New System.Drawing.Size(41, 42)
        Me.BtnPantallaInicio.TabIndex = 12
        Me.BtnPantallaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPantallaInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnPantallaInicio, "Pantalla de inicio")
        Me.BtnPantallaInicio.UseVisualStyleBackColor = True
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(28, 35)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(52, 45)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 98
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(10, 17)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(89, 90)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 97
        Me.PictureBox10.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(3, 616)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(110, 22)
        Me.Label10.TabIndex = 253
        Me.Label10.Text = "Folios"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(3, 550)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(110, 25)
        Me.Label9.TabIndex = 252
        Me.Label9.Text = "Reservaciones"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(3, 489)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(110, 22)
        Me.Label7.TabIndex = 251
        Me.Label7.Text = "Clientes"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(3, 421)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(110, 26)
        Me.Label6.TabIndex = 250
        Me.Label6.Text = "Habitaciones"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(3, 300)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(110, 25)
        Me.Label4.TabIndex = 243
        Me.Label4.Text = "Inicio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(34, 651)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Regresar")
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'LbUsuario
        '
        Me.LbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbUsuario.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsuario.ForeColor = System.Drawing.Color.Black
        Me.LbUsuario.Location = New System.Drawing.Point(6, 95)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(104, 117)
        Me.LbUsuario.TabIndex = 243
        Me.LbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbRol
        '
        Me.LbRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbRol.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.ForeColor = System.Drawing.Color.Black
        Me.LbRol.Location = New System.Drawing.Point(7, 206)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(103, 22)
        Me.LbRol.TabIndex = 182
        Me.LbRol.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LbRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbHabitacion
        '
        Me.LbHabitacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbHabitacion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHabitacion.ForeColor = System.Drawing.Color.Black
        Me.LbHabitacion.Location = New System.Drawing.Point(6, 112)
        Me.LbHabitacion.Name = "LbHabitacion"
        Me.LbHabitacion.Size = New System.Drawing.Size(104, 117)
        Me.LbHabitacion.TabIndex = 181
        Me.LbHabitacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnModificarHabitacion
        '
        Me.BtnModificarHabitacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnModificarHabitacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarHabitacion.ForeColor = System.Drawing.Color.White
        Me.BtnModificarHabitacion.Location = New System.Drawing.Point(1111, 649)
        Me.BtnModificarHabitacion.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnModificarHabitacion.Name = "BtnModificarHabitacion"
        Me.BtnModificarHabitacion.Size = New System.Drawing.Size(120, 24)
        Me.BtnModificarHabitacion.TabIndex = 7
        Me.BtnModificarHabitacion.Text = "&Modificar | Eliminar"
        Me.ToolTip1.SetToolTip(Me.BtnModificarHabitacion, "Clic para modificar/eliminar la habitación seleccionada (ALT + M)")
        Me.BtnModificarHabitacion.UseVisualStyleBackColor = False
        Me.BtnModificarHabitacion.Visible = False
        '
        'FechaHora
        '
        '
        'FrmListadoHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.BtnNuevaHabitacion)
        Me.Controls.Add(Me.BtnModificarHabitacion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RbMostrarHabitacionesInactivas)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RbMostrarHabitacionesDisponibles)
        Me.Controls.Add(Me.RbMostrarTodasHabitaciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RbMostrarHabitacionesMantenimineto)
        Me.Controls.Add(Me.RbMostrarHabitacionesOcupadas)
        Me.Controls.Add(Me.BtnLimpiarBusqueda)
        Me.Controls.Add(Me.TxtDatoBuscar)
        Me.Controls.Add(Me.CBBuscarPor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PBImagenHabitacion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DGVListadoHabitacion)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListadoHabitaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de habitaciones"
        CType(Me.PBImagenHabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVListadoHabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBImagenHabitacion As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DGVListadoHabitacion As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnLimpiarBusqueda As Button
    Friend WithEvents TxtDatoBuscar As TextBox
    Friend WithEvents CBBuscarPor As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNuevaHabitacion As Button
    Friend WithEvents RbMostrarHabitacionesDisponibles As RadioButton
    Friend WithEvents RbMostrarTodasHabitaciones As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents RbMostrarHabitacionesMantenimineto As RadioButton
    Friend WithEvents RbMostrarHabitacionesOcupadas As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents RbMostrarHabitacionesInactivas As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents LbRol As Label
    Friend WithEvents LbHabitacion As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents BtnModificarHabitacion As Button
    Friend WithEvents FechaHora As Timer
    Friend WithEvents LbUsuario As Label
    Friend WithEvents BtnPantallaReservaciones As Button
    Friend WithEvents BtnPantallaClientes As Button
    Friend WithEvents BtnPantallaHabitaciones As Button
    Friend WithEvents BtnPantallaUsuarios As Button
    Friend WithEvents BtnPantallaInicio As Button
    Friend WithEvents BtnPantallaFolios As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
