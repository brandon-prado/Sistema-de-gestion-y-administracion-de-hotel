<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEgreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEgreso))
        Me.LbFecha = New System.Windows.Forms.Label()
        Me.LbHora = New System.Windows.Forms.Label()
        Me.DGVEgreso = New System.Windows.Forms.DataGridView()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnAutorizar = New System.Windows.Forms.Button()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.CBCaja = New System.Windows.Forms.ComboBox()
        Me.FechaHora = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnTodosEgresos = New System.Windows.Forms.Button()
        Me.TxtCantidadRetirar = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGVEgreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbFecha
        '
        Me.LbFecha.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFecha.Location = New System.Drawing.Point(395, 5)
        Me.LbFecha.Name = "LbFecha"
        Me.LbFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbFecha.Size = New System.Drawing.Size(278, 23)
        Me.LbFecha.TabIndex = 215
        '
        'LbHora
        '
        Me.LbHora.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbHora.Location = New System.Drawing.Point(446, 37)
        Me.LbHora.Name = "LbHora"
        Me.LbHora.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LbHora.Size = New System.Drawing.Size(228, 23)
        Me.LbHora.TabIndex = 216
        '
        'DGVEgreso
        '
        Me.DGVEgreso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEgreso.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGVEgreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEgreso.Location = New System.Drawing.Point(79, 212)
        Me.DGVEgreso.Margin = New System.Windows.Forms.Padding(2)
        Me.DGVEgreso.Name = "DGVEgreso"
        Me.DGVEgreso.RowHeadersWidth = 51
        Me.DGVEgreso.RowTemplate.Height = 24
        Me.DGVEgreso.Size = New System.Drawing.Size(575, 180)
        Me.DGVEgreso.TabIndex = 214
        '
        'BtnRegresar
        '
        Me.BtnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.BackgroundImage = CType(resources.GetObject("BtnRegresar.BackgroundImage"), System.Drawing.Image)
        Me.BtnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRegresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRegresar.Location = New System.Drawing.Point(1, 400)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(45, 46)
        Me.BtnRegresar.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.BtnRegresar, "Clic para cancelar el proceso de egreso")
        Me.BtnRegresar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 449)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 211
        Me.PictureBox1.TabStop = False
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLimpiar.ForeColor = System.Drawing.Color.White
        Me.BtnLimpiar.Location = New System.Drawing.Point(588, 403)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(69, 31)
        Me.BtnLimpiar.TabIndex = 4
        Me.BtnLimpiar.Text = "&Limpiar"
        Me.ToolTip1.SetToolTip(Me.BtnLimpiar, "Clic para limpiar las cajas de texto (ALT + L)")
        Me.BtnLimpiar.UseVisualStyleBackColor = False
        '
        'BtnAutorizar
        '
        Me.BtnAutorizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAutorizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAutorizar.ForeColor = System.Drawing.Color.White
        Me.BtnAutorizar.Location = New System.Drawing.Point(515, 403)
        Me.BtnAutorizar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAutorizar.Name = "BtnAutorizar"
        Me.BtnAutorizar.Size = New System.Drawing.Size(69, 31)
        Me.BtnAutorizar.TabIndex = 3
        Me.BtnAutorizar.Text = "&Autorizar"
        Me.ToolTip1.SetToolTip(Me.BtnAutorizar, "Clic para autorizar el retiro en caja (ALT + A) (ENTER)")
        Me.BtnAutorizar.UseVisualStyleBackColor = False
        '
        'TxtConcepto
        '
        Me.TxtConcepto.Location = New System.Drawing.Point(159, 137)
        Me.TxtConcepto.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtConcepto.Multiline = True
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.ShortcutsEnabled = False
        Me.TxtConcepto.Size = New System.Drawing.Size(241, 43)
        Me.TxtConcepto.TabIndex = 2
        '
        'CBCaja
        '
        Me.CBCaja.Enabled = False
        Me.CBCaja.FormattingEnabled = True
        Me.CBCaja.Items.AddRange(New Object() {"1"})
        Me.CBCaja.Location = New System.Drawing.Point(148, 90)
        Me.CBCaja.Margin = New System.Windows.Forms.Padding(2)
        Me.CBCaja.Name = "CBCaja"
        Me.CBCaja.Size = New System.Drawing.Size(92, 21)
        Me.CBCaja.TabIndex = 206
        '
        'FechaHora
        '
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(256, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(193, 31)
        Me.Label6.TabIndex = 280
        Me.Label6.Text = "Cantidad a retirar: $"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(73, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(327, 44)
        Me.Label4.TabIndex = 281
        Me.Label4.Text = "Egreso de turno"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(75, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(68, 31)
        Me.Label1.TabIndex = 282
        Me.Label1.Text = "Turno:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(75, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(193, 31)
        Me.Label2.TabIndex = 283
        Me.Label2.Text = "Concepto:"
        '
        'BtnTodosEgresos
        '
        Me.BtnTodosEgresos.BackColor = System.Drawing.Color.OliveDrab
        Me.BtnTodosEgresos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTodosEgresos.ForeColor = System.Drawing.Color.White
        Me.BtnTodosEgresos.Location = New System.Drawing.Point(79, 403)
        Me.BtnTodosEgresos.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnTodosEgresos.Name = "BtnTodosEgresos"
        Me.BtnTodosEgresos.Size = New System.Drawing.Size(134, 31)
        Me.BtnTodosEgresos.TabIndex = 5
        Me.BtnTodosEgresos.Text = "&Ver todos los egresos"
        Me.ToolTip1.SetToolTip(Me.BtnTodosEgresos, "Clic para ver todos los egresos de turno (ALT + V)")
        Me.BtnTodosEgresos.UseVisualStyleBackColor = False
        '
        'TxtCantidadRetirar
        '
        Me.TxtCantidadRetirar.Location = New System.Drawing.Point(420, 88)
        Me.TxtCantidadRetirar.MaxLength = 15
        Me.TxtCantidadRetirar.Name = "TxtCantidadRetirar"
        Me.TxtCantidadRetirar.ShortcutsEnabled = False
        Me.TxtCantidadRetirar.Size = New System.Drawing.Size(100, 20)
        Me.TxtCantidadRetirar.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OliveDrab
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(217, 403)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 31)
        Me.Button1.TabIndex = 284
        Me.Button1.Text = "Ver todos los &ingresos"
        Me.ToolTip1.SetToolTip(Me.Button1, "Clic para ver todos los ingresos (ALT + I)")
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(675, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtCantidadRetirar)
        Me.Controls.Add(Me.BtnTodosEgresos)
        Me.Controls.Add(Me.TxtConcepto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LbFecha)
        Me.Controls.Add(Me.LbHora)
        Me.Controls.Add(Me.DGVEgreso)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnAutorizar)
        Me.Controls.Add(Me.CBCaja)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEgreso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Egreso de turno"
        CType(Me.DGVEgreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbFecha As Label
    Friend WithEvents LbHora As Label
    Friend WithEvents DGVEgreso As DataGridView
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnAutorizar As Button
    Friend WithEvents TxtConcepto As TextBox
    Friend WithEvents CBCaja As ComboBox
    Friend WithEvents FechaHora As Timer
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnTodosEgresos As Button
    Friend WithEvents TxtCantidadRetirar As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
End Class
