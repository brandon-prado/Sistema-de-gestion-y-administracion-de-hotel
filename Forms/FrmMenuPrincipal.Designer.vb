<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrincipal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.LbUsuario = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DGVCheckOutProg = New System.Windows.Forms.DataGridView()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGVCheckInProg = New System.Windows.Forms.DataGridView()
        Me.LbRol = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.BtnAdministracion = New System.Windows.Forms.Button()
        Me.BtnCaja = New System.Windows.Forms.Button()
        Me.BtnCobro = New System.Windows.Forms.Button()
        Me.BtnServicioExtra = New System.Windows.Forms.Button()
        Me.BtnFolios = New System.Windows.Forms.Button()
        Me.BtnHabitaciones = New System.Windows.Forms.Button()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.BtnReservaciones = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVCheckOutProg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVCheckInProg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.White
        Me.PictureBox11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(52, 42)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(83, 80)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 43
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(14, 10)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(154, 153)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 42
        Me.PictureBox10.TabStop = False
        '
        'LbUsuario
        '
        Me.LbUsuario.AutoSize = True
        Me.LbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbUsuario.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.LbUsuario.ForeColor = System.Drawing.Color.Black
        Me.LbUsuario.Location = New System.Drawing.Point(181, 48)
        Me.LbUsuario.Name = "LbUsuario"
        Me.LbUsuario.Size = New System.Drawing.Size(0, 24)
        Me.LbUsuario.TabIndex = 41
        Me.LbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(19, 387)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(220, 24)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Check Out programado:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(19, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(204, 24)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Check In programado:"
        '
        'DGVCheckOutProg
        '
        Me.DGVCheckOutProg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVCheckOutProg.BackgroundColor = System.Drawing.Color.White
        Me.DGVCheckOutProg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVCheckOutProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCheckOutProg.Location = New System.Drawing.Point(19, 414)
        Me.DGVCheckOutProg.Name = "DGVCheckOutProg"
        Me.DGVCheckOutProg.ReadOnly = True
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVCheckOutProg.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVCheckOutProg.Size = New System.Drawing.Size(324, 191)
        Me.DGVCheckOutProg.TabIndex = 38
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.BackColor = System.Drawing.Color.DarkRed
        Me.BtnCerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrarSesion.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCerrarSesion.ForeColor = System.Drawing.Color.White
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(20, 631)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(133, 38)
        Me.BtnCerrarSesion.TabIndex = 9
        Me.BtnCerrarSesion.Text = "Cerrar sesión"
        Me.BtnCerrarSesion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DGVCheckInProg)
        Me.Panel1.Controls.Add(Me.LbRol)
        Me.Panel1.Controls.Add(Me.PictureBox11)
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.LbUsuario)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.DGVCheckOutProg)
        Me.Panel1.Controls.Add(Me.BtnCerrarSesion)
        Me.Panel1.Location = New System.Drawing.Point(-4, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(360, 691)
        Me.Panel1.TabIndex = 111
        '
        'DGVCheckInProg
        '
        Me.DGVCheckInProg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DGVCheckInProg.BackgroundColor = System.Drawing.Color.White
        Me.DGVCheckInProg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DGVCheckInProg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCheckInProg.Location = New System.Drawing.Point(20, 202)
        Me.DGVCheckInProg.Name = "DGVCheckInProg"
        Me.DGVCheckInProg.ReadOnly = True
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVCheckInProg.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVCheckInProg.Size = New System.Drawing.Size(324, 182)
        Me.DGVCheckInProg.TabIndex = 45
        '
        'LbRol
        '
        Me.LbRol.AutoSize = True
        Me.LbRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbRol.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRol.ForeColor = System.Drawing.Color.Black
        Me.LbRol.Location = New System.Drawing.Point(181, 106)
        Me.LbRol.Name = "LbRol"
        Me.LbRol.Size = New System.Drawing.Size(10, 22)
        Me.LbRol.TabIndex = 44
        Me.LbRol.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LbRol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.Location = New System.Drawing.Point(1115, 39)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 110
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.Location = New System.Drawing.Point(941, 8)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(401, 23)
        Me.LbFecha.TabIndex = 109
        '
        'FechaHora
        '
        '
        'BtnAdministracion
        '
        Me.BtnAdministracion.BackgroundImage = CType(resources.GetObject("BtnAdministracion.BackgroundImage"), System.Drawing.Image)
        Me.BtnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAdministracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdministracion.Location = New System.Drawing.Point(1129, 422)
        Me.BtnAdministracion.Name = "BtnAdministracion"
        Me.BtnAdministracion.Size = New System.Drawing.Size(202, 195)
        Me.BtnAdministracion.TabIndex = 8
        Me.BtnAdministracion.UseVisualStyleBackColor = True
        '
        'BtnCaja
        '
        Me.BtnCaja.BackgroundImage = CType(resources.GetObject("BtnCaja.BackgroundImage"), System.Drawing.Image)
        Me.BtnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCaja.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCaja.Location = New System.Drawing.Point(881, 422)
        Me.BtnCaja.Name = "BtnCaja"
        Me.BtnCaja.Size = New System.Drawing.Size(202, 195)
        Me.BtnCaja.TabIndex = 7
        Me.BtnCaja.UseVisualStyleBackColor = True
        '
        'BtnCobro
        '
        Me.BtnCobro.BackgroundImage = CType(resources.GetObject("BtnCobro.BackgroundImage"), System.Drawing.Image)
        Me.BtnCobro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCobro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCobro.Location = New System.Drawing.Point(627, 422)
        Me.BtnCobro.Name = "BtnCobro"
        Me.BtnCobro.Size = New System.Drawing.Size(202, 195)
        Me.BtnCobro.TabIndex = 6
        Me.BtnCobro.UseVisualStyleBackColor = True
        '
        'BtnServicioExtra
        '
        Me.BtnServicioExtra.BackgroundImage = CType(resources.GetObject("BtnServicioExtra.BackgroundImage"), System.Drawing.Image)
        Me.BtnServicioExtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnServicioExtra.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnServicioExtra.Location = New System.Drawing.Point(382, 422)
        Me.BtnServicioExtra.Name = "BtnServicioExtra"
        Me.BtnServicioExtra.Size = New System.Drawing.Size(202, 195)
        Me.BtnServicioExtra.TabIndex = 5
        Me.BtnServicioExtra.UseVisualStyleBackColor = True
        '
        'BtnFolios
        '
        Me.BtnFolios.BackgroundImage = CType(resources.GetObject("BtnFolios.BackgroundImage"), System.Drawing.Image)
        Me.BtnFolios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnFolios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFolios.Location = New System.Drawing.Point(1129, 135)
        Me.BtnFolios.Name = "BtnFolios"
        Me.BtnFolios.Size = New System.Drawing.Size(202, 195)
        Me.BtnFolios.TabIndex = 4
        Me.BtnFolios.UseVisualStyleBackColor = True
        '
        'BtnHabitaciones
        '
        Me.BtnHabitaciones.BackgroundImage = CType(resources.GetObject("BtnHabitaciones.BackgroundImage"), System.Drawing.Image)
        Me.BtnHabitaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHabitaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHabitaciones.Location = New System.Drawing.Point(881, 135)
        Me.BtnHabitaciones.Name = "BtnHabitaciones"
        Me.BtnHabitaciones.Size = New System.Drawing.Size(202, 195)
        Me.BtnHabitaciones.TabIndex = 3
        Me.BtnHabitaciones.UseVisualStyleBackColor = True
        '
        'BtnClientes
        '
        Me.BtnClientes.BackgroundImage = CType(resources.GetObject("BtnClientes.BackgroundImage"), System.Drawing.Image)
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientes.Location = New System.Drawing.Point(627, 135)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(202, 195)
        Me.BtnClientes.TabIndex = 2
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'BtnReservaciones
        '
        Me.BtnReservaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReservaciones.Image = CType(resources.GetObject("BtnReservaciones.Image"), System.Drawing.Image)
        Me.BtnReservaciones.Location = New System.Drawing.Point(382, 135)
        Me.BtnReservaciones.Name = "BtnReservaciones"
        Me.BtnReservaciones.Size = New System.Drawing.Size(202, 195)
        Me.BtnReservaciones.TabIndex = 1
        Me.BtnReservaciones.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(1133, 621)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(198, 24)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Administración"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(885, 621)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(198, 24)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Caja"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(627, 621)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(202, 24)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Cobro"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(366, 621)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(234, 48)
        Me.Label9.TabIndex = 97
        Me.Label9.Text = "Servicio a la habitación y cargo extra"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(1129, 333)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 24)
        Me.Label5.TabIndex = 96
        Me.Label5.Text = "Folios"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(881, 333)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 24)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Habitaciones"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(627, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 24)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Clientes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(382, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(202, 24)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "Reservaciones"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(357, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(545, 64)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "Hotel Posada Favela"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1350, 691)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.BtnAdministracion)
        Me.Controls.Add(Me.BtnCaja)
        Me.Controls.Add(Me.BtnCobro)
        Me.Controls.Add(Me.BtnServicioExtra)
        Me.Controls.Add(Me.BtnFolios)
        Me.Controls.Add(Me.BtnHabitaciones)
        Me.Controls.Add(Me.BtnClientes)
        Me.Controls.Add(Me.BtnReservaciones)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú principal"
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVCheckOutProg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVCheckInProg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents LbUsuario As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DGVCheckOutProg As DataGridView
    Friend WithEvents BtnCerrarSesion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LbHora As Label
    Friend WithEvents LbFecha As Label
    Friend WithEvents FechaHora As Timer
    Friend WithEvents BtnAdministracion As Button
    Friend WithEvents BtnCaja As Button
    Friend WithEvents BtnCobro As Button
    Friend WithEvents BtnServicioExtra As Button
    Friend WithEvents BtnFolios As Button
    Friend WithEvents BtnHabitaciones As Button
    Friend WithEvents BtnClientes As Button
    Friend WithEvents BtnReservaciones As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbRol As Label
    Friend WithEvents DGVCheckInProg As DataGridView
End Class
