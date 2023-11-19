<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCorrecto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCorrecto))
        Me.PBCorrecto = New System.Windows.Forms.PictureBox()
        Me.LbMensaje = New System.Windows.Forms.Label()
        Me.BtnSi = New System.Windows.Forms.Button()
        CType(Me.PBCorrecto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PBCorrecto
        '
        Me.PBCorrecto.Image = CType(resources.GetObject("PBCorrecto.Image"), System.Drawing.Image)
        Me.PBCorrecto.Location = New System.Drawing.Point(10, 15)
        Me.PBCorrecto.Name = "PBCorrecto"
        Me.PBCorrecto.Size = New System.Drawing.Size(123, 125)
        Me.PBCorrecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBCorrecto.TabIndex = 130
        Me.PBCorrecto.TabStop = False
        '
        'LbMensaje
        '
        Me.LbMensaje.BackColor = System.Drawing.Color.White
        Me.LbMensaje.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbMensaje.ForeColor = System.Drawing.Color.Black
        Me.LbMensaje.Location = New System.Drawing.Point(139, 16)
        Me.LbMensaje.Name = "LbMensaje"
        Me.LbMensaje.Size = New System.Drawing.Size(262, 99)
        Me.LbMensaje.TabIndex = 129
        Me.LbMensaje.Text = "AVISO"
        '
        'BtnSi
        '
        Me.BtnSi.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnSi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSi.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSi.ForeColor = System.Drawing.Color.White
        Me.BtnSi.Location = New System.Drawing.Point(302, 118)
        Me.BtnSi.Name = "BtnSi"
        Me.BtnSi.Size = New System.Drawing.Size(95, 38)
        Me.BtnSi.TabIndex = 1
        Me.BtnSi.Text = "Aceptar"
        Me.BtnSi.UseVisualStyleBackColor = False
        '
        'FrmCorrecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(411, 170)
        Me.Controls.Add(Me.PBCorrecto)
        Me.Controls.Add(Me.LbMensaje)
        Me.Controls.Add(Me.BtnSi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCorrecto"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmación"
        Me.TopMost = True
        CType(Me.PBCorrecto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PBCorrecto As PictureBox
    Friend WithEvents LbMensaje As Label
    Friend WithEvents BtnSi As Button
End Class
