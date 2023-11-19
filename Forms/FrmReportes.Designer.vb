<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReportes))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnPantallaFolios = New System.Windows.Forms.Button()
        Me.BtnPantallaReservaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaClientes = New System.Windows.Forms.Button()
        Me.BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaUsuarios = New System.Windows.Forms.Button()
        Me.BtnPantallaInicio = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbHabitacion = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTurno = New System.Windows.Forms.Button()
        Me.BtnReservaciones = New System.Windows.Forms.Button()
        Me.BtnTodosClientes = New System.Windows.Forms.Button()
        Me.BtnClientesActivos = New System.Windows.Forms.Button()
        Me.BtnClientesCheckOut = New System.Windows.Forms.Button()
        Me.BtnClientesDesactivados = New System.Windows.Forms.Button()
        Me.BtnTodosUsuarios = New System.Windows.Forms.Button()
        Me.BtnTodoEgreso = New System.Windows.Forms.Button()
        Me.BtnTodoCobros = New System.Windows.Forms.Button()
        Me.BtnReservacionFecha = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnEgresosFecha = New System.Windows.Forms.Button()
        Me.BtnCobrosFecha = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
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
        BtnCerrarSesion.Location = New System.Drawing.Point(10, 232)
        BtnCerrarSesion.Margin = New System.Windows.Forms.Padding(0)
        BtnCerrarSesion.Name = "BtnCerrarSesion"
        BtnCerrarSesion.Size = New System.Drawing.Size(98, 26)
        BtnCerrarSesion.TabIndex = 243
        BtnCerrarSesion.TabStop = False
        BtnCerrarSesion.Text = "Cerrar sesión"
        BtnCerrarSesion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        BtnCerrarSesion.UseVisualStyleBackColor = False
        AddHandler BtnCerrarSesion.Click, AddressOf Me.BtnCerrarSesion_Click_1
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
        Me.BtnPantallaFolios.TabIndex = 248
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
        Me.BtnPantallaReservaciones.TabIndex = 247
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
        Me.BtnPantallaClientes.TabIndex = 246
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
        Me.BtnPantallaHabitaciones.TabIndex = 245
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
        Me.BtnPantallaUsuarios.TabIndex = 244
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
        Me.BtnPantallaInicio.TabIndex = 243
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
        Me.BtnRegresar.TabIndex = 183
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Regresar")
        Me.BtnRegresar.UseVisualStyleBackColor = False
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
        'FechaHora
        '
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(128, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(658, 31)
        Me.Label2.TabIndex = 300
        Me.Label2.Text = "Selecciona el tipo de reporte automático que deseas generar a PDF:"
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
        Me.Panel1.Location = New System.Drawing.Point(-4, -11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(113, 726)
        Me.Panel1.TabIndex = 299
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
        Me.LbHora.Location = New System.Drawing.Point(1112, 40)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 298
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LbFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LbFecha.Location = New System.Drawing.Point(951, 8)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(388, 23)
        Me.LbFecha.TabIndex = 297
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(119, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 64)
        Me.Label1.TabIndex = 296
        Me.Label1.Text = "Reportes "
        '
        'BtnTurno
        '
        Me.BtnTurno.Location = New System.Drawing.Point(134, 123)
        Me.BtnTurno.Name = "BtnTurno"
        Me.BtnTurno.Size = New System.Drawing.Size(132, 40)
        Me.BtnTurno.TabIndex = 301
        Me.BtnTurno.Text = "Reporte de todos los turnos"
        Me.BtnTurno.UseVisualStyleBackColor = True
        '
        'BtnReservaciones
        '
        Me.BtnReservaciones.Location = New System.Drawing.Point(293, 123)
        Me.BtnReservaciones.Name = "BtnReservaciones"
        Me.BtnReservaciones.Size = New System.Drawing.Size(132, 40)
        Me.BtnReservaciones.TabIndex = 302
        Me.BtnReservaciones.Text = "Reporte de todas las reservaciones"
        Me.BtnReservaciones.UseVisualStyleBackColor = True
        '
        'BtnTodosClientes
        '
        Me.BtnTodosClientes.Location = New System.Drawing.Point(451, 123)
        Me.BtnTodosClientes.Name = "BtnTodosClientes"
        Me.BtnTodosClientes.Size = New System.Drawing.Size(132, 40)
        Me.BtnTodosClientes.TabIndex = 303
        Me.BtnTodosClientes.Text = "Reporte de todos los clientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnTodosClientes.UseVisualStyleBackColor = True
        '
        'BtnClientesActivos
        '
        Me.BtnClientesActivos.Location = New System.Drawing.Point(451, 177)
        Me.BtnClientesActivos.Name = "BtnClientesActivos"
        Me.BtnClientesActivos.Size = New System.Drawing.Size(132, 40)
        Me.BtnClientesActivos.TabIndex = 304
        Me.BtnClientesActivos.Text = "Reporte de clientes activos" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnClientesActivos.UseVisualStyleBackColor = True
        '
        'BtnClientesCheckOut
        '
        Me.BtnClientesCheckOut.Location = New System.Drawing.Point(451, 229)
        Me.BtnClientesCheckOut.Name = "BtnClientesCheckOut"
        Me.BtnClientesCheckOut.Size = New System.Drawing.Size(132, 40)
        Me.BtnClientesCheckOut.TabIndex = 305
        Me.BtnClientesCheckOut.Text = "Reporte de clientes con Check Out"
        Me.BtnClientesCheckOut.UseVisualStyleBackColor = True
        '
        'BtnClientesDesactivados
        '
        Me.BtnClientesDesactivados.Location = New System.Drawing.Point(451, 280)
        Me.BtnClientesDesactivados.Name = "BtnClientesDesactivados"
        Me.BtnClientesDesactivados.Size = New System.Drawing.Size(132, 40)
        Me.BtnClientesDesactivados.TabIndex = 306
        Me.BtnClientesDesactivados.Text = "Reporte de clientes desactivados"
        Me.BtnClientesDesactivados.UseVisualStyleBackColor = True
        '
        'BtnTodosUsuarios
        '
        Me.BtnTodosUsuarios.Location = New System.Drawing.Point(610, 123)
        Me.BtnTodosUsuarios.Name = "BtnTodosUsuarios"
        Me.BtnTodosUsuarios.Size = New System.Drawing.Size(132, 40)
        Me.BtnTodosUsuarios.TabIndex = 307
        Me.BtnTodosUsuarios.Text = "Reporte de todos los usuarios/empleados"
        Me.BtnTodosUsuarios.UseVisualStyleBackColor = True
        '
        'BtnTodoEgreso
        '
        Me.BtnTodoEgreso.Location = New System.Drawing.Point(777, 123)
        Me.BtnTodoEgreso.Name = "BtnTodoEgreso"
        Me.BtnTodoEgreso.Size = New System.Drawing.Size(132, 40)
        Me.BtnTodoEgreso.TabIndex = 311
        Me.BtnTodoEgreso.Text = "Reporte de todos los egresos"
        Me.BtnTodoEgreso.UseVisualStyleBackColor = True
        '
        'BtnTodoCobros
        '
        Me.BtnTodoCobros.Location = New System.Drawing.Point(951, 123)
        Me.BtnTodoCobros.Name = "BtnTodoCobros"
        Me.BtnTodoCobros.Size = New System.Drawing.Size(132, 40)
        Me.BtnTodoCobros.TabIndex = 314
        Me.BtnTodoCobros.Text = "Reporte de todos los cobros"
        Me.BtnTodoCobros.UseVisualStyleBackColor = True
        '
        'BtnReservacionFecha
        '
        Me.BtnReservacionFecha.Location = New System.Drawing.Point(134, 478)
        Me.BtnReservacionFecha.Name = "BtnReservacionFecha"
        Me.BtnReservacionFecha.Size = New System.Drawing.Size(132, 52)
        Me.BtnReservacionFecha.TabIndex = 318
        Me.BtnReservacionFecha.Text = "Reporte de reservaciones con rango de fecha"
        Me.BtnReservacionFecha.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(130, 439)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(709, 26)
        Me.Label3.TabIndex = 320
        Me.Label3.Text = "Selecciona el tipo de reporte con rango de fecha que deseas generar a PDF:"
        '
        'BtnEgresosFecha
        '
        Me.BtnEgresosFecha.Location = New System.Drawing.Point(293, 478)
        Me.BtnEgresosFecha.Name = "BtnEgresosFecha"
        Me.BtnEgresosFecha.Size = New System.Drawing.Size(132, 40)
        Me.BtnEgresosFecha.TabIndex = 321
        Me.BtnEgresosFecha.Text = "Reporte de egresos con rango de fecha"
        Me.BtnEgresosFecha.UseVisualStyleBackColor = True
        '
        'BtnCobrosFecha
        '
        Me.BtnCobrosFecha.Location = New System.Drawing.Point(451, 478)
        Me.BtnCobrosFecha.Name = "BtnCobrosFecha"
        Me.BtnCobrosFecha.Size = New System.Drawing.Size(132, 40)
        Me.BtnCobrosFecha.TabIndex = 322
        Me.BtnCobrosFecha.Text = "Reporte de cobros con rango de fecha"
        Me.BtnCobrosFecha.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(910, 382)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(91, 99)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 316
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1019, 361)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(302, 305)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 315
        Me.PictureBox1.TabStop = False
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.BtnCobrosFecha)
        Me.Controls.Add(Me.BtnEgresosFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnReservacionFecha)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnTodoCobros)
        Me.Controls.Add(Me.BtnTodoEgreso)
        Me.Controls.Add(Me.BtnTodosUsuarios)
        Me.Controls.Add(Me.BtnClientesDesactivados)
        Me.Controls.Add(Me.BtnClientesCheckOut)
        Me.Controls.Add(Me.BtnClientesActivos)
        Me.Controls.Add(Me.BtnTodosClientes)
        Me.Controls.Add(Me.BtnReservaciones)
        Me.Controls.Add(Me.BtnTurno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de reportes"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BtnPantallaFolios As Button
    Friend WithEvents BtnPantallaReservaciones As Button
    Friend WithEvents BtnPantallaClientes As Button
    Friend WithEvents BtnPantallaHabitaciones As Button
    Friend WithEvents BtnPantallaUsuarios As Button
    Friend WithEvents BtnPantallaInicio As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents FechaHora As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbUsuario As Label
    Friend WithEvents LbRol As Label
    Friend WithEvents LbHabitacion As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTurno As Button
    Friend WithEvents BtnReservaciones As Button
    Friend WithEvents BtnTodosClientes As Button
    Friend WithEvents BtnClientesActivos As Button
    Friend WithEvents BtnClientesCheckOut As Button
    Friend WithEvents BtnClientesDesactivados As Button
    Friend WithEvents BtnTodosUsuarios As Button
    Friend WithEvents BtnTodoEgreso As Button
    Friend WithEvents BtnTodoCobros As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnReservacionFecha As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnEgresosFecha As Button
    Friend WithEvents BtnCobrosFecha As Button
End Class
