<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSalida))
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.BtnSi = New System.Windows.Forms.Button()
        Me.LbMensaje = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNo
        '
        Me.BtnNo.BackColor = System.Drawing.Color.Brown
        Me.BtnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNo.ForeColor = System.Drawing.Color.White
        Me.BtnNo.Location = New System.Drawing.Point(303, 120)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(95, 38)
        Me.BtnNo.TabIndex = 1
        Me.BtnNo.Text = "No"
        Me.BtnNo.UseVisualStyleBackColor = False
        '
        'BtnSi
        '
        Me.BtnSi.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnSi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OliveDrab
        Me.BtnSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine
        Me.BtnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSi.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSi.ForeColor = System.Drawing.Color.White
        Me.BtnSi.Location = New System.Drawing.Point(202, 120)
        Me.BtnSi.Name = "BtnSi"
        Me.BtnSi.Size = New System.Drawing.Size(95, 38)
        Me.BtnSi.TabIndex = 2
        Me.BtnSi.Text = "Sí"
        Me.BtnSi.UseVisualStyleBackColor = False
        '
        'LbMensaje
        '
        Me.LbMensaje.BackColor = System.Drawing.Color.White
        Me.LbMensaje.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMensaje.ForeColor = System.Drawing.Color.Black
        Me.LbMensaje.Location = New System.Drawing.Point(141, 22)
        Me.LbMensaje.Name = "LbMensaje"
        Me.LbMensaje.Size = New System.Drawing.Size(267, 69)
        Me.LbMensaje.TabIndex = 118
        Me.LbMensaje.Text = "¿Estás seguro/a de salir?"
        Me.LbMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        '
        'FrmSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 170)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LbMensaje)
        Me.Controls.Add(Me.BtnNo)
        Me.Controls.Add(Me.BtnSi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSalida"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salida"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnNo As Button
    Friend WithEvents BtnSi As Button
    Friend WithEvents LbMensaje As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
