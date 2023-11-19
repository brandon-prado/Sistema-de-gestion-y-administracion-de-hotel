<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCantidadPagar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCantidadPagar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBMetodoPago = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtCantidadRecibida = New System.Windows.Forms.TextBox()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnAgregarMetPago = New System.Windows.Forms.Button()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn100 = New System.Windows.Forms.Button()
        Me.Btn200 = New System.Windows.Forms.Button()
        Me.Btn500 = New System.Windows.Forms.Button()
        Me.Btn1000 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPagoCompleto = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 64)
        Me.Label1.TabIndex = 181
        Me.Label1.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(55, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(486, 31)
        Me.Label4.TabIndex = 232
        Me.Label4.Text = "Ingresa la cantidad recibida del cliente:"
        '
        'CBMetodoPago
        '
        Me.CBMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMetodoPago.FormattingEnabled = True
        Me.CBMetodoPago.Items.AddRange(New Object() {"Nombre cliente", "Apellido paterno cliente", "Identificación cliente", "Teléfono cliente"})
        Me.CBMetodoPago.Location = New System.Drawing.Point(199, 107)
        Me.CBMetodoPago.Name = "CBMetodoPago"
        Me.CBMetodoPago.Size = New System.Drawing.Size(121, 21)
        Me.CBMetodoPago.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(55, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(138, 31)
        Me.Label2.TabIndex = 231
        Me.Label2.Text = "Método de pago:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(55, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(157, 31)
        Me.Label3.TabIndex = 233
        Me.Label3.Text = "Cantidad recibida:"
        '
        'TxtCantidadRecibida
        '
        Me.TxtCantidadRecibida.Location = New System.Drawing.Point(200, 148)
        Me.TxtCantidadRecibida.MaxLength = 15
        Me.TxtCantidadRecibida.Name = "TxtCantidadRecibida"
        Me.TxtCantidadRecibida.ShortcutsEnabled = False
        Me.TxtCantidadRecibida.Size = New System.Drawing.Size(120, 20)
        Me.TxtCantidadRecibida.TabIndex = 1
        '
        'BtnPagar
        '
        Me.BtnPagar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagar.ForeColor = System.Drawing.Color.White
        Me.BtnPagar.Location = New System.Drawing.Point(725, 341)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(103, 51)
        Me.BtnPagar.TabIndex = 3
        Me.BtnPagar.Text = "&Pagar"
        Me.ToolTip1.SetToolTip(Me.BtnPagar, "Clic para procesar el pago correspondiente (ALT + P) (ENTER)")
        Me.BtnPagar.UseVisualStyleBackColor = False
        '
        'BtnAgregarMetPago
        '
        Me.BtnAgregarMetPago.BackgroundImage = CType(resources.GetObject("BtnAgregarMetPago.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregarMetPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarMetPago.Location = New System.Drawing.Point(326, 107)
        Me.BtnAgregarMetPago.Name = "BtnAgregarMetPago"
        Me.BtnAgregarMetPago.Size = New System.Drawing.Size(21, 21)
        Me.BtnAgregarMetPago.TabIndex = 236
        Me.ToolTip1.SetToolTip(Me.BtnAgregarMetPago, "Clic para ver/modificar los métodos de pago")
        Me.BtnAgregarMetPago.UseVisualStyleBackColor = True
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(2, 355)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para cancelar la operación")
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(55, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(486, 31)
        Me.Label5.TabIndex = 241
        Me.Label5.Text = "Acceso rápido:"
        '
        'Btn100
        '
        Me.Btn100.BackgroundImage = CType(resources.GetObject("Btn100.BackgroundImage"), System.Drawing.Image)
        Me.Btn100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn100.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn100.Location = New System.Drawing.Point(661, 225)
        Me.Btn100.Name = "Btn100"
        Me.Btn100.Size = New System.Drawing.Size(167, 80)
        Me.Btn100.TabIndex = 245
        Me.Btn100.UseVisualStyleBackColor = True
        '
        'Btn200
        '
        Me.Btn200.BackgroundImage = CType(resources.GetObject("Btn200.BackgroundImage"), System.Drawing.Image)
        Me.Btn200.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn200.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn200.Location = New System.Drawing.Point(465, 225)
        Me.Btn200.Name = "Btn200"
        Me.Btn200.Size = New System.Drawing.Size(167, 80)
        Me.Btn200.TabIndex = 244
        Me.Btn200.UseVisualStyleBackColor = True
        '
        'Btn500
        '
        Me.Btn500.BackgroundImage = CType(resources.GetObject("Btn500.BackgroundImage"), System.Drawing.Image)
        Me.Btn500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn500.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn500.Location = New System.Drawing.Point(264, 225)
        Me.Btn500.Name = "Btn500"
        Me.Btn500.Size = New System.Drawing.Size(175, 80)
        Me.Btn500.TabIndex = 243
        Me.Btn500.UseVisualStyleBackColor = True
        '
        'Btn1000
        '
        Me.Btn1000.BackgroundImage = CType(resources.GetObject("Btn1000.BackgroundImage"), System.Drawing.Image)
        Me.Btn1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn1000.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn1000.Location = New System.Drawing.Point(59, 225)
        Me.Btn1000.Name = "Btn1000"
        Me.Btn1000.Size = New System.Drawing.Size(175, 80)
        Me.Btn1000.TabIndex = 242
        Me.Btn1000.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-19, -112)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 565)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 182
        Me.PictureBox1.TabStop = False
        '
        'BtnPagoCompleto
        '
        Me.BtnPagoCompleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnPagoCompleto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPagoCompleto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagoCompleto.Location = New System.Drawing.Point(59, 324)
        Me.BtnPagoCompleto.Name = "BtnPagoCompleto"
        Me.BtnPagoCompleto.Size = New System.Drawing.Size(175, 57)
        Me.BtnPagoCompleto.TabIndex = 246
        Me.BtnPagoCompleto.Text = "Pago completo"
        Me.BtnPagoCompleto.UseVisualStyleBackColor = True
        '
        'FrmCantidadPagar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 404)
        Me.Controls.Add(Me.BtnPagoCompleto)
        Me.Controls.Add(Me.Btn100)
        Me.Controls.Add(Me.Btn200)
        Me.Controls.Add(Me.Btn500)
        Me.Controls.Add(Me.Btn1000)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnAgregarMetPago)
        Me.Controls.Add(Me.BtnPagar)
        Me.Controls.Add(Me.TxtCantidadRecibida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CBMetodoPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCantidadPagar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobro de servicio"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBMetodoPago As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtCantidadRecibida As TextBox
    Friend WithEvents BtnPagar As Button
    Friend WithEvents BtnAgregarMetPago As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn1000 As Button
    Friend WithEvents Btn500 As Button
    Friend WithEvents Btn200 As Button
    Friend WithEvents Btn100 As Button
    Friend WithEvents BtnPagoCompleto As Button
End Class
