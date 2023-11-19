<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListadoEgreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListadoEgreso))
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnPantallaFolios = New System.Windows.Forms.Button()
        Me.BtnPantallaReservaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaClientes = New System.Windows.Forms.Button()
        Me.BtnPantallaHabitaciones = New System.Windows.Forms.Button()
        Me.BtnPantallaUsuarios = New System.Windows.Forms.Button()
        Me.BtnPantallaInicio = New System.Windows.Forms.Button()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbUsuario = New System.Windows.Forms.Label()
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.LbHora = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnVerTodos = New System.Windows.Forms.Button()
        Me.BtnImprimirIngreso = New System.Windows.Forms.Button()
        Me.DGVEgresos = New System.Windows.Forms.DataGridView()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimeFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimeFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        BtnCerrarSesion = New System.Windows.Forms.Button()
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
        CType(Me.DGVEgresos, System.ComponentModel.ISupportInitialize).BeginInit()
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
        BtnCerrarSesion.TabIndex = 106
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
        Me.BtnRegresar.Location = New System.Drawing.Point(73, 634)
        Me.BtnRegresar.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnRegresar.Size = New System.Drawing.Size(239, 36)
        Me.BtnRegresar.TabIndex = 5
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
        Me.BtnPantallaFolios.Location = New System.Drawing.Point(73, 560)
        Me.BtnPantallaFolios.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaFolios.Name = "BtnPantallaFolios"
        Me.BtnPantallaFolios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaFolios.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaFolios.TabIndex = 11
        Me.BtnPantallaFolios.TabStop = False
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
        Me.BtnPantallaReservaciones.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPantallaReservaciones.FlatAppearance.BorderSize = 0
        Me.BtnPantallaReservaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.BtnPantallaReservaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise
        Me.BtnPantallaReservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPantallaReservaciones.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Bold)
        Me.BtnPantallaReservaciones.ForeColor = System.Drawing.Color.Black
        Me.BtnPantallaReservaciones.Location = New System.Drawing.Point(73, 493)
        Me.BtnPantallaReservaciones.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaReservaciones.Name = "BtnPantallaReservaciones"
        Me.BtnPantallaReservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaReservaciones.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaReservaciones.TabIndex = 10
        Me.BtnPantallaReservaciones.TabStop = False
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
        Me.BtnPantallaClientes.Location = New System.Drawing.Point(73, 423)
        Me.BtnPantallaClientes.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaClientes.Name = "BtnPantallaClientes"
        Me.BtnPantallaClientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaClientes.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaClientes.TabIndex = 9
        Me.BtnPantallaClientes.TabStop = False
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
        Me.BtnPantallaHabitaciones.Location = New System.Drawing.Point(73, 357)
        Me.BtnPantallaHabitaciones.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaHabitaciones.Name = "BtnPantallaHabitaciones"
        Me.BtnPantallaHabitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaHabitaciones.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaHabitaciones.TabIndex = 8
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
        Me.BtnPantallaUsuarios.Location = New System.Drawing.Point(73, 290)
        Me.BtnPantallaUsuarios.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaUsuarios.Name = "BtnPantallaUsuarios"
        Me.BtnPantallaUsuarios.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaUsuarios.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaUsuarios.TabIndex = 7
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
        Me.BtnPantallaInicio.Location = New System.Drawing.Point(73, 224)
        Me.BtnPantallaInicio.Margin = New System.Windows.Forms.Padding(0)
        Me.BtnPantallaInicio.Name = "BtnPantallaInicio"
        Me.BtnPantallaInicio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnPantallaInicio.Size = New System.Drawing.Size(239, 36)
        Me.BtnPantallaInicio.TabIndex = 6
        Me.BtnPantallaInicio.TabStop = False
        Me.BtnPantallaInicio.Text = "Pantalla de inicio"
        Me.BtnPantallaInicio.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnPantallaInicio.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LbRol)
        Me.Panel1.Controls.Add(Me.LbUsuario)
        Me.Panel1.Controls.Add(BtnCerrarSesion)
        Me.Panel1.Controls.Add(Me.BtnRegresar)
        Me.Panel1.Controls.Add(Me.BtnPantallaFolios)
        Me.Panel1.Controls.Add(Me.BtnPantallaReservaciones)
        Me.Panel1.Controls.Add(Me.BtnPantallaClientes)
        Me.Panel1.Controls.Add(Me.BtnPantallaHabitaciones)
        Me.Panel1.Controls.Add(Me.BtnPantallaUsuarios)
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
        Me.Panel1.Location = New System.Drawing.Point(-2, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 726)
        Me.Panel1.TabIndex = 289
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
        'FechaHora
        '
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.Location = New System.Drawing.Point(1118, 36)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 288
        '
        'BtnVerTodos
        '
        Me.BtnVerTodos.BackColor = System.Drawing.Color.SandyBrown
        Me.BtnVerTodos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVerTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVerTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVerTodos.Location = New System.Drawing.Point(1218, 644)
        Me.BtnVerTodos.Name = "BtnVerTodos"
        Me.BtnVerTodos.Size = New System.Drawing.Size(99, 35)
        Me.BtnVerTodos.TabIndex = 300
        Me.BtnVerTodos.Text = "&Ver todos"
        Me.ToolTip1.SetToolTip(Me.BtnVerTodos, "Clic para ver todos los egresos (ALT + V)")
        Me.BtnVerTodos.UseVisualStyleBackColor = False
        '
        'BtnImprimirIngreso
        '
        Me.BtnImprimirIngreso.BackgroundImage = CType(resources.GetObject("BtnImprimirIngreso.BackgroundImage"), System.Drawing.Image)
        Me.BtnImprimirIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnImprimirIngreso.Location = New System.Drawing.Point(1172, 644)
        Me.BtnImprimirIngreso.Name = "BtnImprimirIngreso"
        Me.BtnImprimirIngreso.Size = New System.Drawing.Size(40, 38)
        Me.BtnImprimirIngreso.TabIndex = 301
        Me.ToolTip1.SetToolTip(Me.BtnImprimirIngreso, "Clic para imprimir los datos actuales")
        Me.BtnImprimirIngreso.UseVisualStyleBackColor = True
        '
        'DGVEgresos
        '
        Me.DGVEgresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEgresos.Location = New System.Drawing.Point(301, 201)
        Me.DGVEgresos.Name = "DGVEgresos"
        Me.DGVEgresos.ReadOnly = True
        Me.DGVEgresos.Size = New System.Drawing.Size(1016, 427)
        Me.DGVEgresos.TabIndex = 292
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(297, 167)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(403, 31)
        Me.Label15.TabIndex = 290
        Me.Label15.Text = "Historial de apertura y cierre de turnos en caja:"
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.Location = New System.Drawing.Point(995, 5)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(350, 23)
        Me.LbFecha.TabIndex = 287
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(290, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 64)
        Me.Label1.TabIndex = 286
        Me.Label1.Text = "Información de egresos"
        '
        'BtnBuscar
        '
        Me.BtnBuscar.BackColor = System.Drawing.Color.DarkCyan
        Me.BtnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBuscar.ForeColor = System.Drawing.Color.White
        Me.BtnBuscar.Location = New System.Drawing.Point(679, 128)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 4
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(299, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(318, 31)
        Me.Label5.TabIndex = 298
        Me.Label5.Text = "Rango de fecha:"
        '
        'DateTimeFechaFinal
        '
        Me.DateTimeFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaFinal.Location = New System.Drawing.Point(558, 130)
        Me.DateTimeFechaFinal.Name = "DateTimeFechaFinal"
        Me.DateTimeFechaFinal.Size = New System.Drawing.Size(97, 20)
        Me.DateTimeFechaFinal.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(485, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 31)
        Me.Label4.TabIndex = 296
        Me.Label4.Text = "Final:"
        '
        'DateTimeFechaInicial
        '
        Me.DateTimeFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeFechaInicial.Location = New System.Drawing.Point(372, 130)
        Me.DateTimeFechaInicial.Name = "DateTimeFechaInicial"
        Me.DateTimeFechaInicial.Size = New System.Drawing.Size(97, 20)
        Me.DateTimeFechaInicial.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(299, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 31)
        Me.Label10.TabIndex = 294
        Me.Label10.Text = "Inicial:"
        '
        'FrmListadoEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.BtnImprimirIngreso)
        Me.Controls.Add(Me.BtnVerTodos)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateTimeFechaFinal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimeFechaInicial)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.DGVEgresos)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmListadoEgreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado de egresos"
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
        CType(Me.DGVEgresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbRol As Label
    Friend WithEvents LbUsuario As Label
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
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents FechaHora As Timer
    Friend WithEvents LbHora As Label
    Friend WithEvents ToolTip1 As ToolTip
    Public WithEvents DGVEgresos As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimeFechaFinal As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimeFechaInicial As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnVerTodos As Button
    Friend WithEvents BtnImprimirIngreso As Button
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents BtnPantallaFolios As Button
    Friend WithEvents BtnPantallaReservaciones As Button
    Friend WithEvents BtnPantallaClientes As Button
    Friend WithEvents BtnPantallaHabitaciones As Button
    Friend WithEvents BtnPantallaUsuarios As Button
    Friend WithEvents BtnPantallaInicio As Button
End Class
