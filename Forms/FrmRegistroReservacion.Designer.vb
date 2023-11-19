<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRegistroReservacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroReservacion))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DateTimeFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.BtnSeleccionarCliente = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnNotaReservacion = New System.Windows.Forms.Button()
        Me.BntAsignarHabitacion = New System.Windows.Forms.Button()
        Me.BtnQuitarHabitacion = New System.Windows.Forms.Button()
        Me.BtnCrearReservacion = New System.Windows.Forms.Button()
        Me.BtnConfirmaFechaProgramada = New System.Windows.Forms.Button()
        Me.BtnCorregirFecha = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGVHabitacionesDisponibles = New System.Windows.Forms.DataGridView()
        Me.DGVHabitacionesAsignadas = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckPaso1 = New System.Windows.Forms.PictureBox()
        Me.CheckPaso2 = New System.Windows.Forms.PictureBox()
        Me.CheckPaso3 = New System.Windows.Forms.PictureBox()
        Me.LbAviso2 = New System.Windows.Forms.Label()
        Me.LbAviso3 = New System.Windows.Forms.Label()
        Me.DGVDatoHabitacion = New System.Windows.Forms.DataGridView()
        Me.PBImagenHabitacion = New System.Windows.Forms.PictureBox()
        Me.LbHabitacionSeleccionada = New System.Windows.Forms.Label()
        Me.LbQuitarHabitacion = New System.Windows.Forms.Label()
        Me.LbAgregarHabitacion = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVHabitacionesDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVHabitacionesAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPaso1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPaso2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckPaso3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVDatoHabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBImagenHabitacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimeFechaIngreso
        '
        Me.DateTimeFechaIngreso.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.DateTimeFechaIngreso.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.DateTimeFechaIngreso.Cursor = System.Windows.Forms.Cursors.Default
        Me.DateTimeFechaIngreso.CustomFormat = "dd/MM/yy"
        Me.DateTimeFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeFechaIngreso.Location = New System.Drawing.Point(963, 180)
        Me.DateTimeFechaIngreso.Name = "DateTimeFechaIngreso"
        Me.DateTimeFechaIngreso.Size = New System.Drawing.Size(130, 20)
        Me.DateTimeFechaIngreso.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.DateTimeFechaIngreso, "Selecciona la fecha y hora programada de la reservación")
        Me.DateTimeFechaIngreso.Value = New Date(2022, 10, 26, 12, 0, 0, 0)
        '
        'DateTimeFechaSalida
        '
        Me.DateTimeFechaSalida.CustomFormat = "dd/MM/yy"
        Me.DateTimeFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeFechaSalida.Location = New System.Drawing.Point(1200, 179)
        Me.DateTimeFechaSalida.Name = "DateTimeFechaSalida"
        Me.DateTimeFechaSalida.Size = New System.Drawing.Size(132, 20)
        Me.DateTimeFechaSalida.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.DateTimeFechaSalida, "Selecciona la fecha y hora programada fin de la reservación")
        Me.DateTimeFechaSalida.Value = New Date(2022, 10, 26, 12, 0, 0, 0)
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.ForeColor = System.Drawing.Color.White
        Me.BtnRegistrar.Location = New System.Drawing.Point(1249, 641)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(83, 35)
        Me.BtnRegistrar.TabIndex = 12
        Me.BtnRegistrar.Text = "&Registrar"
        Me.ToolTip1.SetToolTip(Me.BtnRegistrar, "Clic para confirmar la reservación (ALT + R)")
        Me.BtnRegistrar.UseVisualStyleBackColor = False
        '
        'BtnSeleccionarCliente
        '
        Me.BtnSeleccionarCliente.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSeleccionarCliente.ForeColor = System.Drawing.Color.White
        Me.BtnSeleccionarCliente.Location = New System.Drawing.Point(368, 179)
        Me.BtnSeleccionarCliente.Name = "BtnSeleccionarCliente"
        Me.BtnSeleccionarCliente.Size = New System.Drawing.Size(112, 21)
        Me.BtnSeleccionarCliente.TabIndex = 1
        Me.BtnSeleccionarCliente.Text = "&Seleccionar cliente"
        Me.ToolTip1.SetToolTip(Me.BtnSeleccionarCliente, "Clic para seleccionar/registar el cliente (ALT + S)")
        Me.BtnSeleccionarCliente.UseVisualStyleBackColor = False
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(32, 631)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para salir/cancelar la reservación")
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'BtnNotaReservacion
        '
        Me.BtnNotaReservacion.BackColor = System.Drawing.Color.Chocolate
        Me.BtnNotaReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotaReservacion.ForeColor = System.Drawing.Color.White
        Me.BtnNotaReservacion.Location = New System.Drawing.Point(382, 206)
        Me.BtnNotaReservacion.Name = "BtnNotaReservacion"
        Me.BtnNotaReservacion.Size = New System.Drawing.Size(98, 23)
        Me.BtnNotaReservacion.TabIndex = 2
        Me.BtnNotaReservacion.Text = "Agregar &nota"
        Me.ToolTip1.SetToolTip(Me.BtnNotaReservacion, "Clic para agregar una nota a la reservación (ALT + N)")
        Me.BtnNotaReservacion.UseVisualStyleBackColor = False
        '
        'BntAsignarHabitacion
        '
        Me.BntAsignarHabitacion.BackgroundImage = CType(resources.GetObject("BntAsignarHabitacion.BackgroundImage"), System.Drawing.Image)
        Me.BntAsignarHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BntAsignarHabitacion.Location = New System.Drawing.Point(757, 361)
        Me.BntAsignarHabitacion.Name = "BntAsignarHabitacion"
        Me.BntAsignarHabitacion.Size = New System.Drawing.Size(35, 35)
        Me.BntAsignarHabitacion.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.BntAsignarHabitacion, "Clic para agregar la habitación seleccionada a la reservación")
        Me.BntAsignarHabitacion.UseVisualStyleBackColor = True
        '
        'BtnQuitarHabitacion
        '
        Me.BtnQuitarHabitacion.BackgroundImage = CType(resources.GetObject("BtnQuitarHabitacion.BackgroundImage"), System.Drawing.Image)
        Me.BtnQuitarHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnQuitarHabitacion.Location = New System.Drawing.Point(757, 417)
        Me.BtnQuitarHabitacion.Name = "BtnQuitarHabitacion"
        Me.BtnQuitarHabitacion.Size = New System.Drawing.Size(35, 35)
        Me.BtnQuitarHabitacion.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.BtnQuitarHabitacion, "Clic para quitar la habitación seleccionada de la reservación")
        Me.BtnQuitarHabitacion.UseVisualStyleBackColor = True
        '
        'BtnCrearReservacion
        '
        Me.BtnCrearReservacion.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnCrearReservacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCrearReservacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnCrearReservacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnCrearReservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCrearReservacion.ForeColor = System.Drawing.Color.White
        Me.BtnCrearReservacion.Location = New System.Drawing.Point(504, 179)
        Me.BtnCrearReservacion.Name = "BtnCrearReservacion"
        Me.BtnCrearReservacion.Size = New System.Drawing.Size(110, 31)
        Me.BtnCrearReservacion.TabIndex = 3
        Me.BtnCrearReservacion.Text = "Continuar al paso &2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.BtnCrearReservacion, "Clic para continuar al paso 2 (ALT + 2)")
        Me.BtnCrearReservacion.UseVisualStyleBackColor = False
        '
        'BtnConfirmaFechaProgramada
        '
        Me.BtnConfirmaFechaProgramada.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnConfirmaFechaProgramada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnConfirmaFechaProgramada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnConfirmaFechaProgramada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnConfirmaFechaProgramada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnConfirmaFechaProgramada.ForeColor = System.Drawing.Color.White
        Me.BtnConfirmaFechaProgramada.Location = New System.Drawing.Point(1212, 213)
        Me.BtnConfirmaFechaProgramada.Name = "BtnConfirmaFechaProgramada"
        Me.BtnConfirmaFechaProgramada.Size = New System.Drawing.Size(120, 29)
        Me.BtnConfirmaFechaProgramada.TabIndex = 6
        Me.BtnConfirmaFechaProgramada.Text = "Continuar al paso &3"
        Me.ToolTip1.SetToolTip(Me.BtnConfirmaFechaProgramada, "Clic para continuar al paso 3 (ALT + 3)")
        Me.BtnConfirmaFechaProgramada.UseVisualStyleBackColor = False
        '
        'BtnCorregirFecha
        '
        Me.BtnCorregirFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnCorregirFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCorregirFecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnCorregirFecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnCorregirFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCorregirFecha.ForeColor = System.Drawing.Color.White
        Me.BtnCorregirFecha.Location = New System.Drawing.Point(1057, 213)
        Me.BtnCorregirFecha.Name = "BtnCorregirFecha"
        Me.BtnCorregirFecha.Size = New System.Drawing.Size(149, 29)
        Me.BtnCorregirFecha.TabIndex = 7
        Me.BtnCorregirFecha.Text = "Ingresar &fecha nuevamente"
        Me.ToolTip1.SetToolTip(Me.BtnCorregirFecha, "Clic para coregir la fecha de hospedaje (ALT + F)")
        Me.BtnCorregirFecha.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(205, 129)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(463, 31)
        Me.Label16.TabIndex = 214
        Me.Label16.Text = "Selecciona el cliente:"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(203, 259)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(329, 31)
        Me.Label15.TabIndex = 213
        Me.Label15.Text = "Selecciona la/s habitación/es:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(140, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(73, 31)
        Me.Label11.TabIndex = 203
        Me.Label11.Text = "* Cliente:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(873, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(148, 31)
        Me.Label10.TabIndex = 201
        Me.Label10.Text = "* Check In:"
        '
        'LbRol
        '
        Me.LbRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbRol.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.ForeColor = System.Drawing.Color.Black
        Me.LbRol.Location = New System.Drawing.Point(7, 233)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(103, 22)
        Me.LbRol.TabIndex = 182
        Me.LbRol.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LbRol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.Location = New System.Drawing.Point(966, 6)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(379, 23)
        Me.LbFecha.TabIndex = 181
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(146, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 64)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "Registro de reservación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.Location = New System.Drawing.Point(1118, 37)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 182
        '
        'FechaHora
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnRegresar)
        Me.Panel1.Controls.Add(Me.LbRol)
        Me.Panel1.Controls.Add(Me.LbUsuario)
        Me.Panel1.Controls.Add(Me.PictureBox11)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Location = New System.Drawing.Point(-1, -11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 726)
        Me.Panel1.TabIndex = 183
        '
        'LbUsuario
        '
        Me.LbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbUsuario.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUsuario.ForeColor = System.Drawing.Color.Black
        Me.LbUsuario.Location = New System.Drawing.Point(6, 112)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(104, 117)
        Me.LbUsuario.TabIndex = 181
        Me.LbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Brown
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(931, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(496, 31)
        Me.Label2.TabIndex = 219
        Me.Label2.Text = "Selecciona la fecha programada:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(1099, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(148, 31)
        Me.Label3.TabIndex = 220
        Me.Label3.Text = "* Check Out:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(138, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(513, 31)
        Me.Label5.TabIndex = 226
        Me.Label5.Text = "Lista de las habitaciones disponibles al rango de fecha seleccionado:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ":"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(139, 500)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(422, 31)
        Me.Label6.TabIndex = 228
        Me.Label6.Text = "Lista de la/s reservaciones a la habitación seleccionada:"
        '
        'DGVHabitacionesDisponibles
        '
        Me.DGVHabitacionesDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVHabitacionesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHabitacionesDisponibles.Location = New System.Drawing.Point(143, 335)
        Me.DGVHabitacionesDisponibles.Name = "DGVHabitacionesDisponibles"
        Me.DGVHabitacionesDisponibles.ReadOnly = True
        Me.DGVHabitacionesDisponibles.Size = New System.Drawing.Size(488, 152)
        Me.DGVHabitacionesDisponibles.TabIndex = 7
        '
        'DGVHabitacionesAsignadas
        '
        Me.DGVHabitacionesAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVHabitacionesAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVHabitacionesAsignadas.Location = New System.Drawing.Point(906, 336)
        Me.DGVHabitacionesAsignadas.Name = "DGVHabitacionesAsignadas"
        Me.DGVHabitacionesAsignadas.ReadOnly = True
        Me.DGVHabitacionesAsignadas.Size = New System.Drawing.Size(426, 142)
        Me.DGVHabitacionesAsignadas.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(903, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(379, 31)
        Me.Label7.TabIndex = 230
        Me.Label7.Text = "Lista de las habitaciones asignadas:"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Location = New System.Drawing.Point(219, 179)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.Size = New System.Drawing.Size(143, 20)
        Me.TxtNombreCliente.TabIndex = 233
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(143, 116)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(64, 49)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 235
        Me.PictureBox9.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(1186, 118)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(64, 50)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 236
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(142, 244)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(64, 49)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox13.TabIndex = 237
        Me.PictureBox13.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(151, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(463, 31)
        Me.Label9.TabIndex = 238
        Me.Label9.Text = "Realizar los 3 pasos para realizar una reservación:"
        '
        'CheckPaso1
        '
        Me.CheckPaso1.Image = CType(resources.GetObject("CheckPaso1.Image"), System.Drawing.Image)
        Me.CheckPaso1.Location = New System.Drawing.Point(376, 115)
        Me.CheckPaso1.Name = "CheckPaso1"
        Me.CheckPaso1.Size = New System.Drawing.Size(50, 50)
        Me.CheckPaso1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CheckPaso1.TabIndex = 240
        Me.CheckPaso1.TabStop = False
        '
        'CheckPaso2
        '
        Me.CheckPaso2.Image = CType(resources.GetObject("CheckPaso2.Image"), System.Drawing.Image)
        Me.CheckPaso2.Location = New System.Drawing.Point(1267, 118)
        Me.CheckPaso2.Name = "CheckPaso2"
        Me.CheckPaso2.Size = New System.Drawing.Size(50, 50)
        Me.CheckPaso2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CheckPaso2.TabIndex = 241
        Me.CheckPaso2.TabStop = False
        '
        'CheckPaso3
        '
        Me.CheckPaso3.Image = CType(resources.GetObject("CheckPaso3.Image"), System.Drawing.Image)
        Me.CheckPaso3.Location = New System.Drawing.Point(438, 245)
        Me.CheckPaso3.Name = "CheckPaso3"
        Me.CheckPaso3.Size = New System.Drawing.Size(50, 50)
        Me.CheckPaso3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CheckPaso3.TabIndex = 242
        Me.CheckPaso3.TabStop = False
        '
        'LbAviso2
        '
        Me.LbAviso2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.LbAviso2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAviso2.ForeColor = System.Drawing.Color.Black
        Me.LbAviso2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbAviso2.Location = New System.Drawing.Point(963, 493)
        Me.LbAviso2.Name = "LbAviso2"
        Me.LbAviso2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbAviso2.Size = New System.Drawing.Size(369, 40)
        Me.LbAviso2.TabIndex = 244
        Me.LbAviso2.Text = "* Una vez terminado el proceso de selección, da clic en Registrar para confirmar " &
    "la reservación."
        '
        'LbAviso3
        '
        Me.LbAviso3.BackColor = System.Drawing.Color.Salmon
        Me.LbAviso3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAviso3.ForeColor = System.Drawing.Color.Black
        Me.LbAviso3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbAviso3.Location = New System.Drawing.Point(963, 542)
        Me.LbAviso3.Name = "LbAviso3"
        Me.LbAviso3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbAviso3.Size = New System.Drawing.Size(369, 57)
        Me.LbAviso3.TabIndex = 245
        Me.LbAviso3.Text = "* Sí se requiere cancelar el proceso de reservación, da clic en ← para cancelar e" &
    "l proceso, deberás quitar las habitaciones previamente seleccionadas."
        '
        'DGVDatoHabitacion
        '
        Me.DGVDatoHabitacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVDatoHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDatoHabitacion.Location = New System.Drawing.Point(143, 524)
        Me.DGVDatoHabitacion.Name = "DGVDatoHabitacion"
        Me.DGVDatoHabitacion.ReadOnly = True
        Me.DGVDatoHabitacion.Size = New System.Drawing.Size(488, 152)
        Me.DGVDatoHabitacion.TabIndex = 11
        '
        'PBImagenHabitacion
        '
        Me.PBImagenHabitacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBImagenHabitacion.InitialImage = Nothing
        Me.PBImagenHabitacion.Location = New System.Drawing.Point(651, 523)
        Me.PBImagenHabitacion.Name = "PBImagenHabitacion"
        Me.PBImagenHabitacion.Size = New System.Drawing.Size(241, 153)
        Me.PBImagenHabitacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBImagenHabitacion.TabIndex = 247
        Me.PBImagenHabitacion.TabStop = False
        '
        'LbHabitacionSeleccionada
        '
        Me.LbHabitacionSeleccionada.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHabitacionSeleccionada.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbHabitacionSeleccionada.Location = New System.Drawing.Point(650, 492)
        Me.LbHabitacionSeleccionada.Name = "LbHabitacionSeleccionada"
        Me.LbHabitacionSeleccionada.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbHabitacionSeleccionada.Size = New System.Drawing.Size(266, 31)
        Me.LbHabitacionSeleccionada.TabIndex = 248
        Me.LbHabitacionSeleccionada.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LbQuitarHabitacion
        '
        Me.LbQuitarHabitacion.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbQuitarHabitacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbQuitarHabitacion.Location = New System.Drawing.Point(795, 418)
        Me.LbQuitarHabitacion.Name = "LbQuitarHabitacion"
        Me.LbQuitarHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbQuitarHabitacion.Size = New System.Drawing.Size(107, 34)
        Me.LbQuitarHabitacion.TabIndex = 249
        Me.LbQuitarHabitacion.Text = "Quitar habitación asignada"
        '
        'LbAgregarHabitacion
        '
        Me.LbAgregarHabitacion.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbAgregarHabitacion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbAgregarHabitacion.Location = New System.Drawing.Point(637, 361)
        Me.LbAgregarHabitacion.Name = "LbAgregarHabitacion"
        Me.LbAgregarHabitacion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LbAgregarHabitacion.Size = New System.Drawing.Size(115, 35)
        Me.LbAgregarHabitacion.TabIndex = 250
        Me.LbAgregarHabitacion.Text = "Agregar habitación seleccionada"
        Me.LbAgregarHabitacion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkOrange
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(963, 259)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(369, 40)
        Me.Label13.TabIndex = 251
        Me.Label13.Text = "* La entrada es a partir de las 14:00 hrs y la salida antes de las 13:59 hrs."
        '
        'FrmRegistroReservacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1354, 691)
        Me.Controls.Add(Me.BtnCorregirFecha)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnQuitarHabitacion)
        Me.Controls.Add(Me.BntAsignarHabitacion)
        Me.Controls.Add(Me.LbAgregarHabitacion)
        Me.Controls.Add(Me.LbQuitarHabitacion)
        Me.Controls.Add(Me.PBImagenHabitacion)
        Me.Controls.Add(Me.LbHabitacionSeleccionada)
        Me.Controls.Add(Me.DGVDatoHabitacion)
        Me.Controls.Add(Me.LbAviso3)
        Me.Controls.Add(Me.LbAviso2)
        Me.Controls.Add(Me.CheckPaso3)
        Me.Controls.Add(Me.CheckPaso2)
        Me.Controls.Add(Me.CheckPaso1)
        Me.Controls.Add(Me.BtnConfirmaFechaProgramada)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.DGVHabitacionesAsignadas)
        Me.Controls.Add(Me.DGVHabitacionesDisponibles)
        Me.Controls.Add(Me.BtnCrearReservacion)
        Me.Controls.Add(Me.TxtNombreCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnNotaReservacion)
        Me.Controls.Add(Me.DateTimeFechaSalida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRegistrar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnSeleccionarCliente)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTimeFechaIngreso)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegistroReservacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de reservación"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVHabitacionesDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVHabitacionesAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPaso1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPaso2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckPaso3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVDatoHabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBImagenHabitacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents BtnSeleccionarCliente As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DateTimeFechaIngreso As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents LbRol As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents FechaHora As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbUsuario As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimeFechaSalida As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnNotaReservacion As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DGVHabitacionesDisponibles As DataGridView
    Friend WithEvents DGVHabitacionesAsignadas As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents BntAsignarHabitacion As Button
    Friend WithEvents BtnQuitarHabitacion As Button
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents BtnCrearReservacion As Button
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnConfirmaFechaProgramada As Button
    Friend WithEvents CheckPaso1 As PictureBox
    Friend WithEvents CheckPaso2 As PictureBox
    Friend WithEvents CheckPaso3 As PictureBox
    Friend WithEvents LbAviso2 As Label
    Friend WithEvents LbAviso3 As Label
    Friend WithEvents DGVDatoHabitacion As DataGridView
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PBImagenHabitacion As PictureBox
    Friend WithEvents LbHabitacionSeleccionada As Label
    Friend WithEvents LbQuitarHabitacion As Label
    Friend WithEvents LbAgregarHabitacion As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents BtnCorregirFecha As Button
End Class
