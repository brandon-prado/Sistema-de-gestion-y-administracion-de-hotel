<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPago
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPago))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDatoReservacion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.DGVPagos = New System.Windows.Forms.DataGridView()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.TxtCantidadTotalHabitaciones = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCantidadCargoTotal = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtCantidadTotalCargoExtra = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtCantidadPagadaXCliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelCantidadRestante = New System.Windows.Forms.Label()
        Me.LabelDinero = New System.Windows.Forms.Label()
        Me.TxtCantidadRestante = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LabelEstadoPago = New System.Windows.Forms.Label()
        Me.PBEstadoPago = New System.Windows.Forms.PictureBox()
        Me.PBEstado = New System.Windows.Forms.PictureBox()
        CType(Me.DGVPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEstadoPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(55, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 39)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Pago de servicio"
        '
        'TxtDatoReservacion
        '
        Me.TxtDatoReservacion.Enabled = False
        Me.TxtDatoReservacion.Location = New System.Drawing.Point(122, 66)
        Me.TxtDatoReservacion.MaxLength = 30
        Me.TxtDatoReservacion.Name = "TxtDatoReservacion"
        Me.TxtDatoReservacion.Size = New System.Drawing.Size(178, 20)
        Me.TxtDatoReservacion.TabIndex = 266
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(61, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 31)
        Me.Label4.TabIndex = 265
        Me.Label4.Text = "Folio:"
        '
        'Label24
        '
        Me.Label24.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label24.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(62, 271)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(582, 24)
        Me.Label24.TabIndex = 289
        Me.Label24.Text = "Lista de pagos realizados a la reservación:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DGVPagos
        '
        Me.DGVPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGVPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVPagos.Location = New System.Drawing.Point(65, 296)
        Me.DGVPagos.Name = "DGVPagos"
        Me.DGVPagos.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVPagos.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVPagos.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVPagos.Size = New System.Drawing.Size(629, 164)
        Me.DGVPagos.TabIndex = 288
        '
        'BtnPagar
        '
        Me.BtnPagar.BackColor = System.Drawing.Color.OliveDrab
        Me.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagar.ForeColor = System.Drawing.Color.White
        Me.BtnPagar.Location = New System.Drawing.Point(814, 420)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(158, 45)
        Me.BtnPagar.TabIndex = 1
        Me.BtnPagar.Text = "&Pagar"
        Me.ToolTip1.SetToolTip(Me.BtnPagar, "Clic para proceder a pagar (ALT + P) (ENTER)")
        Me.BtnPagar.UseVisualStyleBackColor = False
        '
        'TxtCantidadTotalHabitaciones
        '
        Me.TxtCantidadTotalHabitaciones.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadTotalHabitaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadTotalHabitaciones.Location = New System.Drawing.Point(343, 110)
        Me.TxtCantidadTotalHabitaciones.Name = "TxtCantidadTotalHabitaciones"
        Me.TxtCantidadTotalHabitaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadTotalHabitaciones.Size = New System.Drawing.Size(146, 31)
        Me.TxtCantidadTotalHabitaciones.TabIndex = 301
        Me.TxtCantidadTotalHabitaciones.Text = "[Dato]"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(61, 110)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(276, 31)
        Me.Label12.TabIndex = 300
        Me.Label12.Text = "Cantidad de la/s habitación/es:"
        '
        'TxtCantidadCargoTotal
        '
        Me.TxtCantidadCargoTotal.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadCargoTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadCargoTotal.Location = New System.Drawing.Point(343, 185)
        Me.TxtCantidadCargoTotal.Name = "TxtCantidadCargoTotal"
        Me.TxtCantidadCargoTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadCargoTotal.Size = New System.Drawing.Size(146, 31)
        Me.TxtCantidadCargoTotal.TabIndex = 299
        Me.TxtCantidadCargoTotal.Text = "[Dato]"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(61, 185)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(313, 31)
        Me.Label22.TabIndex = 298
        Me.Label22.Text = "Cantidad de cargo total:            "
        '
        'TxtCantidadTotalCargoExtra
        '
        Me.TxtCantidadTotalCargoExtra.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadTotalCargoExtra.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadTotalCargoExtra.Location = New System.Drawing.Point(343, 146)
        Me.TxtCantidadTotalCargoExtra.Name = "TxtCantidadTotalCargoExtra"
        Me.TxtCantidadTotalCargoExtra.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadTotalCargoExtra.Size = New System.Drawing.Size(146, 31)
        Me.TxtCantidadTotalCargoExtra.TabIndex = 297
        Me.TxtCantidadTotalCargoExtra.Text = "[Dato]"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(61, 146)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(276, 31)
        Me.Label20.TabIndex = 296
        Me.Label20.Text = "Cantidad de cargo/s extra:        "
        '
        'TxtCantidadPagadaXCliente
        '
        Me.TxtCantidadPagadaXCliente.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadPagadaXCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadPagadaXCliente.Location = New System.Drawing.Point(343, 222)
        Me.TxtCantidadPagadaXCliente.Name = "TxtCantidadPagadaXCliente"
        Me.TxtCantidadPagadaXCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadPagadaXCliente.Size = New System.Drawing.Size(146, 31)
        Me.TxtCantidadPagadaXCliente.TabIndex = 303
        Me.TxtCantidadPagadaXCliente.Text = "[Dato]"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(61, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(327, 31)
        Me.Label3.TabIndex = 302
        Me.Label3.Text = "Cantidad pagada por el cliente:  "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(319, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(18, 31)
        Me.Label5.TabIndex = 304
        Me.Label5.Text = "$"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(319, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(18, 31)
        Me.Label6.TabIndex = 305
        Me.Label6.Text = "$"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(319, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(18, 31)
        Me.Label7.TabIndex = 306
        Me.Label7.Text = "$"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(319, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(18, 31)
        Me.Label8.TabIndex = 307
        Me.Label8.Text = "$"
        '
        'LabelCantidadRestante
        '
        Me.LabelCantidadRestante.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCantidadRestante.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelCantidadRestante.Location = New System.Drawing.Point(462, 222)
        Me.LabelCantidadRestante.Name = "LabelCantidadRestante"
        Me.LabelCantidadRestante.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelCantidadRestante.Size = New System.Drawing.Size(163, 31)
        Me.LabelCantidadRestante.TabIndex = 308
        Me.LabelCantidadRestante.Text = "Cantidad restante:  "
        '
        'LabelDinero
        '
        Me.LabelDinero.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDinero.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDinero.Location = New System.Drawing.Point(603, 222)
        Me.LabelDinero.Name = "LabelDinero"
        Me.LabelDinero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelDinero.Size = New System.Drawing.Size(18, 31)
        Me.LabelDinero.TabIndex = 310
        Me.LabelDinero.Text = "$"
        '
        'TxtCantidadRestante
        '
        Me.TxtCantidadRestante.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidadRestante.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TxtCantidadRestante.Location = New System.Drawing.Point(631, 222)
        Me.TxtCantidadRestante.Name = "TxtCantidadRestante"
        Me.TxtCantidadRestante.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCantidadRestante.Size = New System.Drawing.Size(146, 31)
        Me.TxtCantidadRestante.TabIndex = 309
        Me.TxtCantidadRestante.Text = "[Dato]"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(2, 422)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 2
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 493)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LabelEstadoPago
        '
        Me.LabelEstadoPago.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoPago.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelEstadoPago.Location = New System.Drawing.Point(845, 243)
        Me.LabelEstadoPago.Name = "LabelEstadoPago"
        Me.LabelEstadoPago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelEstadoPago.Size = New System.Drawing.Size(127, 75)
        Me.LabelEstadoPago.TabIndex = 313
        Me.LabelEstadoPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBEstadoPago
        '
        Me.PBEstadoPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBEstadoPago.InitialImage = Nothing
        Me.PBEstadoPago.Location = New System.Drawing.Point(764, 243)
        Me.PBEstadoPago.Name = "PBEstadoPago"
        Me.PBEstadoPago.Size = New System.Drawing.Size(75, 75)
        Me.PBEstadoPago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEstadoPago.TabIndex = 312
        Me.PBEstadoPago.TabStop = False
        '
        'PBEstado
        '
        Me.PBEstado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBEstado.Image = CType(resources.GetObject("PBEstado.Image"), System.Drawing.Image)
        Me.PBEstado.InitialImage = Nothing
        Me.PBEstado.Location = New System.Drawing.Point(764, 46)
        Me.PBEstado.Name = "PBEstado"
        Me.PBEstado.Size = New System.Drawing.Size(208, 185)
        Me.PBEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBEstado.TabIndex = 311
        Me.PBEstado.TabStop = False
        '
        'FrmPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1013, 472)
        Me.Controls.Add(Me.LabelEstadoPago)
        Me.Controls.Add(Me.PBEstadoPago)
        Me.Controls.Add(Me.PBEstado)
        Me.Controls.Add(Me.LabelDinero)
        Me.Controls.Add(Me.TxtCantidadRestante)
        Me.Controls.Add(Me.LabelCantidadRestante)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCantidadPagadaXCliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCantidadTotalHabitaciones)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtCantidadCargoTotal)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TxtCantidadTotalCargoExtra)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.BtnPagar)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.DGVPagos)
        Me.Controls.Add(Me.TxtDatoReservacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago"
        CType(Me.DGVPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEstadoPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDatoReservacion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents DGVPagos As DataGridView
    Friend WithEvents BtnPagar As Button
    Friend WithEvents TxtCantidadTotalHabitaciones As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCantidadCargoTotal As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtCantidadTotalCargoExtra As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtCantidadPagadaXCliente As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelCantidadRestante As Label
    Friend WithEvents LabelDinero As Label
    Public WithEvents TxtCantidadRestante As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LabelEstadoPago As Label
    Friend WithEvents PBEstadoPago As PictureBox
    Friend WithEvents PBEstado As PictureBox
End Class
