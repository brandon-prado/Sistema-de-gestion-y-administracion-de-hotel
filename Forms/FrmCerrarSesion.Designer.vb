<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCerrarSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCerrarSesion))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LbMensaje = New System.Windows.Forms.Label()
        Me.BtnNo = New System.Windows.Forms.Button()
        Me.BtnSi = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 123
        Me.PictureBox1.TabStop = False
        '
        'LbMensaje
        '
        Me.LbMensaje.BackColor = System.Drawing.Color.White
        Me.LbMensaje.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMensaje.ForeColor = System.Drawing.Color.Black
        Me.LbMensaje.Location = New System.Drawing.Point(136, 17)
        Me.LbMensaje.Name = "LbMensaje"
        Me.LbMensaje.Size = New System.Drawing.Size(267, 69)
        Me.LbMensaje.TabIndex = 122
        Me.LbMensaje.Text = "¿Estás seguro/a de cerrar sesión?"
        Me.LbMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnNo
        '
        Me.BtnNo.BackColor = System.Drawing.Color.Firebrick
        Me.BtnNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed
        Me.BtnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNo.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNo.ForeColor = System.Drawing.Color.White
        Me.BtnNo.Location = New System.Drawing.Point(298, 115)
        Me.BtnNo.Name = "BtnNo"
        Me.BtnNo.Size = New System.Drawing.Size(95, 38)
        Me.BtnNo.TabIndex = 2
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
        Me.BtnSi.Location = New System.Drawing.Point(197, 115)
        Me.BtnSi.Name = "BtnSi"
        Me.BtnSi.Size = New System.Drawing.Size(95, 38)
        Me.BtnSi.TabIndex = 1
        Me.BtnSi.Text = "Sí"
        Me.BtnSi.UseVisualStyleBackColor = False
        '
        'FrmCerrarSesion
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
        Me.Name = "FrmCerrarSesion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cerrar sesión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LbMensaje As Label
    Friend WithEvents BtnNo As Button
    Friend WithEvents BtnSi As Button
End Class
