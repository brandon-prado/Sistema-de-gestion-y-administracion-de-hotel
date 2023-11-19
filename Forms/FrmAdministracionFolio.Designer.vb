<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministracionFolio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdministracionFolio))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnBuscarFolio = New System.Windows.Forms.Button()
        Me.BtnAgregarCargoExtra = New System.Windows.Forms.Button()
        Me.BtnPago = New System.Windows.Forms.Button()
        Me.BtnTodosCargosExtra = New System.Windows.Forms.Button()
        Me.BtnCancelarReservacion = New System.Windows.Forms.Button()
        Me.BtnPantallaFolios = New System.Windows.Forms.Button()
        Me.BtnPantallaReservaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaClientes = New System.Windows.Forms.Button()
        Me.BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaUsuarios = New System.Windows.Forms.Button()
        Me.BtnPantallaInicio = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbHabitacion = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDatoReservacion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtEstadoFolio = New System.Windows.Forms.Label()
        Me.TxtAtendidoPor = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtFechaHoraFolio = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DGVHabitacionesLigadas = New System.Windows.Forms.DataGridView()
        Me.TxtCantidadTotalCargoExtra = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtCantidadCargoTotal = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DGVCargosExtra = New System.Windows.Forms.DataGridView()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtCantidadTotalHabitaciones = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelEstadoPago = New System.Windows.Forms.Label()
        Me.PBEstadoPago = New System.Windows.Forms.PictureBox()
        Me.PBEstado = New System.Windows.Forms.PictureBox()
        Me.PBImagenHabitacion = New System.Windows.Forms.PictureBox()
        BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVHabitacionesLigadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCargosExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEstadoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBImagenHabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
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
        BtnCerrarSesion.TabIndex = 7
        BtnCerrarSesion.TabStop = False
        BtnCerrarSesion.Text = "Cerrar sesión"
        BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        BtnCerrarSesion.UseVisualStyleBackColor = False
        AddHandler BtnCerrarSesion.Click, AddressOf Me.BtnCerrarSesion_Click
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
        'BtnBuscarFolio
        '
        Me.BtnBuscarFolio.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnBuscarFolio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscarFolio.ForeColor = System.Drawing.Color.White
        Me.BtnBuscarFolio.Location = New System.Drawing.Point(375, 136)
        Me.BtnBuscarFolio.Name = "BtnBuscarFolio"
        Me.BtnBuscarFolio.Size = New System.Drawing.Size(114, 23)
        Me.BtnBuscarFolio.TabIndex = 1
        Me.BtnBuscarFolio.Text = "&Buscar folio"
        Me.ToolTip1.SetToolTip(Me.BtnBuscarFolio, "Clic para buscar el folio activo (ALT + B)")
        Me.BtnBuscarFolio.UseVisualStyleBackColor = False
        '
        'BtnAgregarCargoExtra
        '
        Me.BtnAgregarCargoExtra.BackColor = System.Drawing.Color.DarkOrange
        Me.BtnAgregarCargoExtra.FlatAppearance.BorderColor = System.Drawing.Color.SandyBrown
        Me.BtnAgregarCargoExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarCargoExtra.ForeColor = System.Drawing.Color.Black
        Me.BtnAgregarCargoExtra.Location = New System.Drawing.Point(476, 660)
        Me.BtnAgregarCargoExtra.Name = "BtnAgregarCargoExtra"
        Me.BtnAgregarCargoExtra.Size = New System.Drawing.Size(128, 23)
        Me.BtnAgregarCargoExtra.TabIndex = 4
        Me.BtnAgregarCargoExtra.Text = "&Agregar cargo/s extra"
        Me.ToolTip1.SetToolTip(Me.BtnAgregarCargoExtra, "Clic para agregar un cargo extra a la cuenta (ALT + A)")
        Me.BtnAgregarCargoExtra.UseVisualStyleBackColor = False
        '
        'BtnPago
        '
        Me.BtnPago.BackColor = System.Drawing.Color.OliveDrab
        Me.BtnPago.Enabled = False
        Me.BtnPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPago.ForeColor = System.Drawing.Color.White
        Me.BtnPago.Location = New System.Drawing.Point(1131, 625)
        Me.BtnPago.Name = "BtnPago"
        Me.BtnPago.Size = New System.Drawing.Size(201, 45)
        Me.BtnPago.TabIndex = 5
        Me.BtnPago.Text = "&Realizar/Ver pago"
        Me.ToolTip1.SetToolTip(Me.BtnPago, "Clic para realizar/ver el/los pagos realizados (ALT + R)")
        Me.BtnPago.UseVisualStyleBackColor = False
        '
        'BtnTodosCargosExtra
        '
        Me.BtnTodosCargosExtra.BackColor = System.Drawing.Color.IndianRed
        Me.BtnTodosCargosExtra.Enabled = False
        Me.BtnTodosCargosExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTodosCargosExtra.ForeColor = System.Drawing.Color.White
        Me.BtnTodosCargosExtra.Location = New System.Drawing.Point(610, 660)
        Me.BtnTodosCargosExtra.Name = "BtnTodosCargosExtra"
        Me.BtnTodosCargosExtra.Size = New System.Drawing.Size(161, 23)
        Me.BtnTodosCargosExtra.TabIndex = 3
        Me.BtnTodosCargosExtra.Text = "&Mostrar todos los cargos extra"
        Me.ToolTip1.SetToolTip(Me.BtnTodosCargosExtra, "Clic para mostrar todos los cargos extra de la/s habitació/nes asignadas  (ALT + " &
        "M)")
        Me.BtnTodosCargosExtra.UseVisualStyleBackColor = False
        '
        'BtnCancelarReservacion
        '
        Me.BtnCancelarReservacion.BackColor = System.Drawing.Color.Firebrick
        Me.BtnCancelarReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarReservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarReservacion.ForeColor = System.Drawing.Color.White
        Me.BtnCancelarReservacion.Location = New System.Drawing.Point(882, 625)
        Me.BtnCancelarReservacion.Name = "BtnCancelarReservacion"
        Me.BtnCancelarReservacion.Size = New System.Drawing.Size(235, 45)
        Me.BtnCancelarReservacion.TabIndex = 6
        Me.BtnCancelarReservacion.Text = "&Cancelar reservación"
        Me.ToolTip1.SetToolTip(Me.BtnCancelarReservacion, "Clic para cancelar la reservación (ALT + C)")
        Me.BtnCancelarReservacion.UseVisualStyleBackColor = False
        Me.BtnCancelarReservacion.Visible = False
        '
        'BtnPantallaFolios
        '
        Me.BtnPantallaFolios.Enabled = False
        Me.BtnPantallaFolios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaFolios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaFolios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnPantallaFolios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaFolios.Image = CType(resources.GetObject("BtnPantallaFolios.Image"), System.Drawing.Image)
        Me.BtnPantallaFolios.Location = New System.Drawing.Point(35, 578)
        Me.BtnPantallaFolios.Name = "BtnPantallaFolios"
        Me.BtnPantallaFolios.Size = New System.Drawing.Size(41, 42)
        Me.BtnPantallaFolios.TabIndex = 13
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
        Me.BtnPantallaReservaciones.TabIndex = 12
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
        Me.BtnPantallaClientes.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.BtnPantallaClientes, "Clientes")
        Me.BtnPantallaClientes.UseVisualStyleBackColor = True
        '
        'BtnPantallaHabitaciones
        '
        Me.BtnPantallaHabitaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaHabitaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaHabitaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.BtnPantallaHabitaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaHabitaciones.Image = CType(resources.GetObject("BtnPantallaHabitaciones.Image"), System.Drawing.Image)
        Me.BtnPantallaHabitaciones.Location = New System.Drawing.Point(35, 381)
        Me.BtnPantallaHabitaciones.Name = "BtnPantallaHabitaciones"
        Me.BtnPantallaHabitaciones.Size = New System.Drawing.Size(41, 42)
        Me.BtnPantallaHabitaciones.TabIndex = 10
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
        Me.BtnPantallaUsuarios.TabIndex = 9
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
        Me.BtnPantallaInicio.TabIndex = 8
        Me.BtnPantallaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPantallaInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.BtnPantallaInicio, "Pantalla de inicio")
        Me.BtnPantallaInicio.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(34, 647)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Regresar")
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'FechaHora
        '
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
        Me.Panel1.Location = New System.Drawing.Point(-2, -9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 726)
        Me.Panel1.TabIndex = 261
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
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbHora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbHora.Location = New System.Drawing.Point(1114, 42)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 259
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbFecha.Location = New System.Drawing.Point(953, 10)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(388, 23)
        Me.LbFecha.TabIndex = 258
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(121, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 64)
        Me.Label1.TabIndex = 257
        Me.Label1.Text = "Resumen de folio"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(130, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(525, 31)
        Me.Label2.TabIndex = 262
        Me.Label2.Text = "Resumen de la informacion del folio de reservación:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(130, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 31)
        Me.Label3.TabIndex = 263
        Me.Label3.Text = "Folio:"
        '
        'TxtDatoReservacion
        '
        Me.TxtDatoReservacion.Enabled = False
        Me.TxtDatoReservacion.Location = New System.Drawing.Point(191, 136)
        Me.TxtDatoReservacion.MaxLength = 30
        Me.TxtDatoReservacion.Name = "TxtDatoReservacion"
        Me.TxtDatoReservacion.Size = New System.Drawing.Size(178, 20)
        Me.TxtDatoReservacion.TabIndex = 264
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(132, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(146, 31)
        Me.Label8.TabIndex = 267
        Me.Label8.Text = "Estado de folio:"
        '
        'TxtEstadoFolio
        '
        Me.TxtEstadoFolio.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEstadoFolio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtEstadoFolio.Location = New System.Drawing.Point(326, 210)
        Me.TxtEstadoFolio.Name = "TxtEstadoFolio"
        Me.TxtEstadoFolio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtEstadoFolio.Size = New System.Drawing.Size(226, 31)
        Me.TxtEstadoFolio.TabIndex = 268
        '
        'TxtAtendidoPor
        '
        Me.TxtAtendidoPor.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAtendidoPor.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtAtendidoPor.Location = New System.Drawing.Point(326, 246)
        Me.TxtAtendidoPor.Name = "TxtAtendidoPor"
        Me.TxtAtendidoPor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAtendidoPor.Size = New System.Drawing.Size(316, 31)
        Me.TxtAtendidoPor.TabIndex = 270
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(132, 247)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(146, 31)
        Me.Label13.TabIndex = 269
        Me.Label13.Text = "Atendido por:"
        '
        'TxtFechaHoraFolio
        '
        Me.TxtFechaHoraFolio.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaHoraFolio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtFechaHoraFolio.Location = New System.Drawing.Point(326, 177)
        Me.TxtFechaHoraFolio.Name = "TxtFechaHoraFolio"
        Me.TxtFechaHoraFolio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtFechaHoraFolio.Size = New System.Drawing.Size(226, 31)
        Me.TxtFechaHoraFolio.TabIndex = 272
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(132, 177)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(202, 31)
        Me.Label15.TabIndex = 271
        Me.Label15.Text = "Fecha y hora del folio:"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtNombreCliente.Location = New System.Drawing.Point(326, 282)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNombreCliente.Size = New System.Drawing.Size(316, 31)
        Me.TxtNombreCliente.TabIndex = 274
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(132, 283)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(180, 31)
        Me.Label17.TabIndex = 273
        Me.Label17.Text = "Nombre del cliente:"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(132, 324)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(220, 31)
        Me.Label18.TabIndex = 275
        Me.Label18.Text = "Habitación/es asignada/s:"
        '
        'DGVHabitacionesLigadas
        '
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVHabitacionesLigadas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVHabitacionesLigadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGVHabitacionesLigadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHabitacionesLigadas.Location = New System.Drawing.Point(136, 348)
        Me.DGVHabitacionesLigadas.Name = "DGVHabitacionesLigadas"
        Me.DGVHabitacionesLigadas.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVHabitacionesLigadas.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVHabitacionesLigadas.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DGVHabitacionesLigadas.Size = New System.Drawing.Size(417, 144)
        Me.DGVHabitacionesLigadas.TabIndex = 15
        '
        'TxtCantidadTotalCargoExtra
        '
        Me.TxtCantidadTotalCargoExtra.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadTotalCargoExtra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadTotalCargoExtra.Location = New System.Drawing.Point(1120, 452)
        Me.TxtCantidadTotalCargoExtra.Name = "TxtCantidadTotalCargoExtra"
        Me.TxtCantidadTotalCargoExtra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadTotalCargoExtra.Size = New System.Drawing.Size(207, 31)
        Me.TxtCantidadTotalCargoExtra.TabIndex = 278
        Me.TxtCantidadTotalCargoExtra.Text = "0.0"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(836, 452)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(338, 31)
        Me.Label20.TabIndex = 277
        Me.Label20.Text = "Cantidad de cargo/s extra: $"
        '
        'TxtCantidadCargoTotal
        '
        Me.TxtCantidadCargoTotal.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadCargoTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadCargoTotal.Location = New System.Drawing.Point(1121, 544)
        Me.TxtCantidadCargoTotal.Name = "TxtCantidadCargoTotal"
        Me.TxtCantidadCargoTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadCargoTotal.Size = New System.Drawing.Size(207, 31)
        Me.TxtCantidadCargoTotal.TabIndex = 280
        Me.TxtCantidadCargoTotal.Text = "0.0"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(861, 544)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(313, 31)
        Me.Label22.TabIndex = 279
        Me.Label22.Text = "Cantidad de cargo total: $"
        '
        'DGVCargosExtra
        '
        Me.DGVCargosExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCargosExtra.Location = New System.Drawing.Point(136, 524)
        Me.DGVCargosExtra.Name = "DGVCargosExtra"
        Me.DGVCargosExtra.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVCargosExtra.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVCargosExtra.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DGVCargosExtra.Size = New System.Drawing.Size(635, 127)
        Me.DGVCargosExtra.TabIndex = 16
        '
        'Label24
        '
        Me.Label24.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(133, 499)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(582, 24)
        Me.Label24.TabIndex = 287
        Me.Label24.Text = "Selecciona la habitación para ver la información correspondiente de el/los cargo/" &
    "s extra:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(555, 324)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(165, 31)
        Me.Label23.TabIndex = 289
        Me.Label23.Text = "Imagen:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtCantidadTotalHabitaciones
        '
        Me.TxtCantidadTotalHabitaciones.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadTotalHabitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadTotalHabitaciones.Location = New System.Drawing.Point(1120, 376)
        Me.TxtCantidadTotalHabitaciones.Name = "TxtCantidadTotalHabitaciones"
        Me.TxtCantidadTotalHabitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadTotalHabitaciones.Size = New System.Drawing.Size(207, 31)
        Me.TxtCantidadTotalHabitaciones.TabIndex = 295
        Me.TxtCantidadTotalHabitaciones.Text = "0.0"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(794, 376)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(501, 31)
        Me.Label12.TabIndex = 294
        Me.Label12.Text = "Cantidad de la/s habitación/es: $"
        '
        'LabelEstadoPago
        '
        Me.LabelEstadoPago.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoPago.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelEstadoPago.Location = New System.Drawing.Point(860, 177)
        Me.LabelEstadoPago.Name = "LabelEstadoPago"
        Me.LabelEstadoPago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelEstadoPago.Size = New System.Drawing.Size(115, 31)
        Me.LabelEstadoPago.TabIndex = 298
        Me.LabelEstadoPago.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PBEstadoPago
        '
        Me.PBEstadoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBEstadoPago.InitialImage = Nothing
        Me.PBEstadoPago.Location = New System.Drawing.Point(860, 211)
        Me.PBEstadoPago.Name = "PBEstadoPago"
        Me.PBEstadoPago.Size = New System.Drawing.Size(115, 113)
        Me.PBEstadoPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEstadoPago.TabIndex = 297
        Me.PBEstadoPago.TabStop = False
        '
        'PBEstado
        '
        Me.PBEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBEstado.Image = CType(resources.GetObject("PBEstado.Image"), System.Drawing.Image)
        Me.PBEstado.InitialImage = Nothing
        Me.PBEstado.Location = New System.Drawing.Point(981, 68)
        Me.PBEstado.Name = "PBEstado"
        Me.PBEstado.Size = New System.Drawing.Size(268, 256)
        Me.PBEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEstado.TabIndex = 296
        Me.PBEstado.TabStop = False
        '
        'PBImagenHabitacion
        '
        Me.PBImagenHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBImagenHabitacion.InitialImage = Nothing
        Me.PBImagenHabitacion.Location = New System.Drawing.Point(559, 348)
        Me.PBImagenHabitacion.Name = "PBImagenHabitacion"
        Me.PBImagenHabitacion.Size = New System.Drawing.Size(212, 144)
        Me.PBImagenHabitacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBImagenHabitacion.TabIndex = 288
        Me.PBImagenHabitacion.TabStop = False
        '
        'FrmAdministracionFolio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.LabelEstadoPago)
        Me.Controls.Add(Me.PBEstadoPago)
        Me.Controls.Add(Me.PBEstado)
        Me.Controls.Add(Me.BtnCancelarReservacion)
        Me.Controls.Add(Me.TxtCantidadTotalHabitaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnTodosCargosExtra)
        Me.Controls.Add(Me.PBImagenHabitacion)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.DGVCargosExtra)
        Me.Controls.Add(Me.BtnPago)
        Me.Controls.Add(Me.BtnAgregarCargoExtra)
        Me.Controls.Add(Me.TxtCantidadCargoTotal)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TxtCantidadTotalCargoExtra)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.DGVHabitacionesLigadas)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtNombreCliente)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtFechaHoraFolio)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtAtendidoPor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtEstadoFolio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnBuscarFolio)
        Me.Controls.Add(Me.TxtDatoReservacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdministracionFolio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Información de folio"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVHabitacionesLigadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCargosExtra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEstadoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBImagenHabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents BtnPantallaFolios As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnPantallaReservaciones As Button
    Friend WithEvents BtnPantallaClientes As Button
    Friend WithEvents BtnPantallaHabitaciones As Button
    Friend WithEvents BtnPantallaUsuarios As Button
    Friend WithEvents BtnPantallaInicio As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents FechaHora As Timer
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbUsuario As Label
    Friend WithEvents LbRol As Label
    Friend WithEvents LbHabitacion As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscarFolio As Button
    Friend WithEvents TxtDatoReservacion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtEstadoFolio As Label
    Friend WithEvents TxtAtendidoPor As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtFechaHoraFolio As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtNombreCliente As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DGVHabitacionesLigadas As DataGridView
    Friend WithEvents TxtCantidadTotalCargoExtra As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtCantidadCargoTotal As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents BtnAgregarCargoExtra As Button
    Friend WithEvents BtnPago As Button
    Friend WithEvents DGVCargosExtra As DataGridView
    Friend WithEvents Label24 As Label
    Friend WithEvents PBImagenHabitacion As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents BtnTodosCargosExtra As Button
    Friend WithEvents TxtCantidadTotalHabitaciones As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnCancelarReservacion As Button
    Friend WithEvents PBEstado As PictureBox
    Friend WithEvents PBEstadoPago As PictureBox
    Friend WithEvents LabelEstadoPago As Label
End Class
