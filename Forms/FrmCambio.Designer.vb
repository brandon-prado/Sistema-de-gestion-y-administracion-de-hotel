<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambio))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelMensaje = New System.Windows.Forms.Label()
        Me.BtnSi = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IDEA_Software.My.Resources.Resources.dinero
        Me.PictureBox1.Location = New System.Drawing.Point(33, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(0, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(393, 35)
        Me.Label4.TabIndex = 233
        Me.Label4.Text = "Entrega al cliente el cambio de:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelMensaje
        '
        Me.LabelMensaje.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMensaje.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.LabelMensaje.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelMensaje.Location = New System.Drawing.Point(-1, 297)
        Me.LabelMensaje.Name = "LabelMensaje"
        Me.LabelMensaje.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelMensaje.Size = New System.Drawing.Size(394, 68)
        Me.LabelMensaje.TabIndex = 234
        Me.LabelMensaje.Text = "[Dato]"
        Me.LabelMensaje.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSi
        '
        Me.BtnSi.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnSi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSi.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSi.ForeColor = System.Drawing.Color.White
        Me.BtnSi.Location = New System.Drawing.Point(147, 381)
        Me.BtnSi.Name = "BtnSi"
        Me.BtnSi.Size = New System.Drawing.Size(95, 38)
        Me.BtnSi.TabIndex = 235
        Me.BtnSi.Text = "Aceptar"
        Me.BtnSi.UseVisualStyleBackColor = False
        '
        'FrmCambio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(392, 435)
        Me.Controls.Add(Me.BtnSi)
        Me.Controls.Add(Me.LabelMensaje)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambio"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelMensaje As Label
    Friend WithEvents BtnSi As Button
End Class
