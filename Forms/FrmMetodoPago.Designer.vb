<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMetodoPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMetodoPago))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVMetPago = New System.Windows.Forms.DataGridView()
        Me.TxtMetPago = New System.Windows.Forms.TextBox()
        Me.TxtDescripcionPago = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Btnlimpiar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DGVMetPago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(67, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "* Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(79, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'DGVMetPago
        '
        Me.DGVMetPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMetPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMetPago.Location = New System.Drawing.Point(70, 165)
        Me.DGVMetPago.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVMetPago.Name = "DGVMetPago"
        Me.DGVMetPago.ReadOnly = True
        Me.DGVMetPago.RowHeadersWidth = 51
        Me.DGVMetPago.RowTemplate.Height = 24
        Me.DGVMetPago.Size = New System.Drawing.Size(438, 133)
        Me.DGVMetPago.TabIndex = 4
        '
        'TxtMetPago
        '
        Me.TxtMetPago.Location = New System.Drawing.Point(193, 61)
        Me.TxtMetPago.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMetPago.MaxLength = 20
        Me.TxtMetPago.Name = "TxtMetPago"
        Me.TxtMetPago.ShortcutsEnabled = False
        Me.TxtMetPago.Size = New System.Drawing.Size(118, 20)
        Me.TxtMetPago.TabIndex = 1
        '
        'TxtDescripcionPago
        '
        Me.TxtDescripcionPago.Location = New System.Drawing.Point(193, 94)
        Me.TxtDescripcionPago.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtDescripcionPago.MaxLength = 100
        Me.TxtDescripcionPago.Multiline = True
        Me.TxtDescripcionPago.Name = "TxtDescripcionPago"
        Me.TxtDescripcionPago.ShortcutsEnabled = False
        Me.TxtDescripcionPago.Size = New System.Drawing.Size(251, 52)
        Me.TxtDescripcionPago.TabIndex = 2
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Location = New System.Drawing.Point(262, 312)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.BtnAgregar.TabIndex = 3
        Me.BtnAgregar.Text = "&Registrar"
        Me.ToolTip1.SetToolTip(Me.BtnAgregar, "Clic para registar/modificar el método de pago (ALT + R)")
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'BtnEliminar
        '
        Me.BtnEliminar.BackColor = System.Drawing.Color.Firebrick
        Me.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminar.ForeColor = System.Drawing.Color.White
        Me.BtnEliminar.Location = New System.Drawing.Point(347, 312)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 4
        Me.BtnEliminar.Text = "&Eliminar"
        Me.ToolTip1.SetToolTip(Me.BtnEliminar, "Clic para eliminar el método de pago (ALT + E)")
        Me.BtnEliminar.UseVisualStyleBackColor = False
        '
        'Btnlimpiar
        '
        Me.Btnlimpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.Btnlimpiar.Location = New System.Drawing.Point(433, 312)
        Me.Btnlimpiar.Name = "Btnlimpiar"
        Me.Btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.Btnlimpiar.TabIndex = 5
        Me.Btnlimpiar.Text = "&Limpiar"
        Me.ToolTip1.SetToolTip(Me.Btnlimpiar, "Clic para limpiar las cajas de texto (ALT + L)")
        Me.Btnlimpiar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 345)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 137
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(65, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(263, 34)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Métodos de pago"
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(2, 295)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 6
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'FrmMetodoPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(522, 346)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Btnlimpiar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.TxtDescripcionPago)
        Me.Controls.Add(Me.TxtMetPago)
        Me.Controls.Add(Me.DGVMetPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMetodoPago"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración de métodos de pago"
        Me.TopMost = True
        CType(Me.DGVMetPago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGVMetPago As DataGridView
    Friend WithEvents TxtMetPago As TextBox
    Friend WithEvents TxtDescripcionPago As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Btnlimpiar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
