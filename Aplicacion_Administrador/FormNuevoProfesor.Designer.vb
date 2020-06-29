<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormNuevoProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNuevoProfesor))
        Me.PanelContenedorNP = New System.Windows.Forms.Panel()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.tbTelefonoP = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.tbPrimerApellidoP = New System.Windows.Forms.TextBox()
        Me.tbNombreP = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.tbCedulaP = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelarP = New System.Windows.Forms.Button()
        Me.btnGuardarP = New System.Windows.Forms.Button()
        Me.PanelContenedorNP.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenedorNP
        '
        Me.PanelContenedorNP.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContenedorNP.Controls.Add(Me.lblNombre)
        Me.PanelContenedorNP.Controls.Add(Me.tbTelefonoP)
        Me.PanelContenedorNP.Controls.Add(Me.PictureBox1)
        Me.PanelContenedorNP.Controls.Add(Me.lblPrimerApellido)
        Me.PanelContenedorNP.Controls.Add(Me.Label1)
        Me.PanelContenedorNP.Controls.Add(Me.lblTelefono)
        Me.PanelContenedorNP.Controls.Add(Me.tbPrimerApellidoP)
        Me.PanelContenedorNP.Controls.Add(Me.tbNombreP)
        Me.PanelContenedorNP.Controls.Add(Me.lblCedula)
        Me.PanelContenedorNP.Controls.Add(Me.tbCedulaP)
        Me.PanelContenedorNP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedorNP.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedorNP.Name = "PanelContenedorNP"
        Me.PanelContenedorNP.Size = New System.Drawing.Size(1092, 493)
        Me.PanelContenedorNP.TabIndex = 8
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(83, 132)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(90, 23)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbTelefonoP
        '
        Me.tbTelefonoP.Location = New System.Drawing.Point(305, 281)
        Me.tbTelefonoP.Name = "tbTelefonoP"
        Me.tbTelefonoP.Size = New System.Drawing.Size(417, 22)
        Me.tbTelefonoP.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(763, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 266)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.Location = New System.Drawing.Point(80, 181)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(157, 23)
        Me.lblPrimerApellido.TabIndex = 2
        Me.lblPrimerApellido.Text = "Primer Apellido"
        Me.lblPrimerApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, -22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(83, 278)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(93, 23)
        Me.lblTelefono.TabIndex = 6
        Me.lblTelefono.Text = "Telefono"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbPrimerApellidoP
        '
        Me.tbPrimerApellidoP.Location = New System.Drawing.Point(305, 181)
        Me.tbPrimerApellidoP.Name = "tbPrimerApellidoP"
        Me.tbPrimerApellidoP.Size = New System.Drawing.Size(417, 22)
        Me.tbPrimerApellidoP.TabIndex = 12
        '
        'tbNombreP
        '
        Me.tbNombreP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbNombreP.Location = New System.Drawing.Point(305, 132)
        Me.tbNombreP.Name = "tbNombreP"
        Me.tbNombreP.Size = New System.Drawing.Size(417, 22)
        Me.tbNombreP.TabIndex = 7
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(80, 233)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(84, 23)
        Me.lblCedula.TabIndex = 3
        Me.lblCedula.Text = "Cédula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbCedulaP
        '
        Me.tbCedulaP.Location = New System.Drawing.Point(305, 236)
        Me.tbCedulaP.Name = "tbCedulaP"
        Me.tbCedulaP.Size = New System.Drawing.Size(417, 22)
        Me.tbCedulaP.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelarP)
        Me.Panel1.Controls.Add(Me.btnGuardarP)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 425)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1092, 68)
        Me.Panel1.TabIndex = 9
        '
        'btnCancelarP
        '
        Me.btnCancelarP.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnCancelarP.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancelarP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancelarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarP.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnCancelarP.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarP.Location = New System.Drawing.Point(614, 6)
        Me.btnCancelarP.Name = "btnCancelarP"
        Me.btnCancelarP.Size = New System.Drawing.Size(279, 50)
        Me.btnCancelarP.TabIndex = 2
        Me.btnCancelarP.Text = "Cancelar"
        Me.btnCancelarP.UseVisualStyleBackColor = True
        '
        'btnGuardarP
        '
        Me.btnGuardarP.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardarP.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGuardarP.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGuardarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarP.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnGuardarP.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarP.Location = New System.Drawing.Point(292, 6)
        Me.btnGuardarP.Name = "btnGuardarP"
        Me.btnGuardarP.Size = New System.Drawing.Size(279, 50)
        Me.btnGuardarP.TabIndex = 1
        Me.btnGuardarP.Text = "Guardar"
        Me.btnGuardarP.UseVisualStyleBackColor = True
        '
        'FormNuevoProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1092, 493)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelContenedorNP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1110, 540)
        Me.MinimumSize = New System.Drawing.Size(1110, 540)
        Me.Name = "FormNuevoProfesor"
        Me.Text = "Ingresar Profesor"
        Me.PanelContenedorNP.ResumeLayout(False)
        Me.PanelContenedorNP.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedorNP As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents tbPrimerApellidoP As TextBox
    Public WithEvents tbNombreP As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPrimerApellido As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelarP As Button
    Friend WithEvents btnGuardarP As Button
    Public WithEvents tbTelefonoP As TextBox
    Public WithEvents tbCedulaP As TextBox
    Friend WithEvents lblTelefono As Label
End Class
