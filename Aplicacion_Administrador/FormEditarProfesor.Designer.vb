<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarProfesor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarProfesor))
        Me.PanelContenedorNA = New System.Windows.Forms.Panel()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbPrimerApellidoP = New System.Windows.Forms.TextBox()
        Me.tbCedulaP = New System.Windows.Forms.TextBox()
        Me.tbTelefonoP = New System.Windows.Forms.TextBox()
        Me.tbNombreP = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblFechadeNacimiento = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelarA = New System.Windows.Forms.Button()
        Me.btnGuardarA = New System.Windows.Forms.Button()
        Me.PanelContenedorNA.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenedorNA
        '
        Me.PanelContenedorNA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContenedorNA.Controls.Add(Me.Panel1)
        Me.PanelContenedorNA.Controls.Add(Me.tbID)
        Me.PanelContenedorNA.Controls.Add(Me.Label2)
        Me.PanelContenedorNA.Controls.Add(Me.PictureBox1)
        Me.PanelContenedorNA.Controls.Add(Me.tbPrimerApellidoP)
        Me.PanelContenedorNA.Controls.Add(Me.tbCedulaP)
        Me.PanelContenedorNA.Controls.Add(Me.tbTelefonoP)
        Me.PanelContenedorNA.Controls.Add(Me.tbNombreP)
        Me.PanelContenedorNA.Controls.Add(Me.lblCedula)
        Me.PanelContenedorNA.Controls.Add(Me.Label1)
        Me.PanelContenedorNA.Controls.Add(Me.lblNombre)
        Me.PanelContenedorNA.Controls.Add(Me.lblFechadeNacimiento)
        Me.PanelContenedorNA.Controls.Add(Me.lblPrimerApellido)
        Me.PanelContenedorNA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedorNA.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedorNA.Name = "PanelContenedorNA"
        Me.PanelContenedorNA.Size = New System.Drawing.Size(1092, 493)
        Me.PanelContenedorNA.TabIndex = 10
        '
        'tbID
        '
        Me.tbID.Enabled = False
        Me.tbID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbID.Location = New System.Drawing.Point(314, 93)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(417, 22)
        Me.tbID.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(765, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 266)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'tbPrimerApellidoP
        '
        Me.tbPrimerApellidoP.Location = New System.Drawing.Point(314, 188)
        Me.tbPrimerApellidoP.Name = "tbPrimerApellidoP"
        Me.tbPrimerApellidoP.Size = New System.Drawing.Size(417, 22)
        Me.tbPrimerApellidoP.TabIndex = 12
        '
        'tbCedulaP
        '
        Me.tbCedulaP.Enabled = False
        Me.tbCedulaP.Location = New System.Drawing.Point(314, 243)
        Me.tbCedulaP.Name = "tbCedulaP"
        Me.tbCedulaP.Size = New System.Drawing.Size(417, 22)
        Me.tbCedulaP.TabIndex = 9
        '
        'tbTelefonoP
        '
        Me.tbTelefonoP.Location = New System.Drawing.Point(314, 287)
        Me.tbTelefonoP.Name = "tbTelefonoP"
        Me.tbTelefonoP.Size = New System.Drawing.Size(417, 22)
        Me.tbTelefonoP.TabIndex = 8
        '
        'tbNombreP
        '
        Me.tbNombreP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbNombreP.Location = New System.Drawing.Point(314, 136)
        Me.tbNombreP.Name = "tbNombreP"
        Me.tbNombreP.Size = New System.Drawing.Size(417, 22)
        Me.tbNombreP.TabIndex = 7
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(57, 240)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(84, 23)
        Me.lblCedula.TabIndex = 3
        Me.lblCedula.Text = "Cédula"
        Me.lblCedula.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(57, 136)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(90, 23)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechadeNacimiento
        '
        Me.lblFechadeNacimiento.AutoSize = True
        Me.lblFechadeNacimiento.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechadeNacimiento.Location = New System.Drawing.Point(57, 287)
        Me.lblFechadeNacimiento.Name = "lblFechadeNacimiento"
        Me.lblFechadeNacimiento.Size = New System.Drawing.Size(93, 23)
        Me.lblFechadeNacimiento.TabIndex = 4
        Me.lblFechadeNacimiento.Text = "Telefono"
        Me.lblFechadeNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.Location = New System.Drawing.Point(57, 185)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(157, 23)
        Me.lblPrimerApellido.TabIndex = 2
        Me.lblPrimerApellido.Text = "Primer Apellido"
        Me.lblPrimerApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelarA)
        Me.Panel1.Controls.Add(Me.btnGuardarA)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 425)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1092, 68)
        Me.Panel1.TabIndex = 18
        '
        'btnCancelarA
        '
        Me.btnCancelarA.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnCancelarA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancelarA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnCancelarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarA.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnCancelarA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarA.Location = New System.Drawing.Point(614, 6)
        Me.btnCancelarA.Name = "btnCancelarA"
        Me.btnCancelarA.Size = New System.Drawing.Size(279, 50)
        Me.btnCancelarA.TabIndex = 2
        Me.btnCancelarA.Text = "Cancelar"
        Me.btnCancelarA.UseVisualStyleBackColor = True
        '
        'btnGuardarA
        '
        Me.btnGuardarA.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardarA.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGuardarA.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGuardarA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarA.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnGuardarA.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarA.Location = New System.Drawing.Point(292, 6)
        Me.btnGuardarA.Name = "btnGuardarA"
        Me.btnGuardarA.Size = New System.Drawing.Size(279, 50)
        Me.btnGuardarA.TabIndex = 1
        Me.btnGuardarA.Text = "Editar"
        Me.btnGuardarA.UseVisualStyleBackColor = True
        '
        'FormEditarProfesor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 493)
        Me.Controls.Add(Me.PanelContenedorNA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1110, 540)
        Me.MinimumSize = New System.Drawing.Size(1110, 540)
        Me.Name = "FormEditarProfesor"
        Me.Text = "Editar Profesor"
        Me.PanelContenedorNA.ResumeLayout(False)
        Me.PanelContenedorNA.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedorNA As Panel
    Public WithEvents tbID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents tbPrimerApellidoP As TextBox
    Public WithEvents tbCedulaP As TextBox
    Public WithEvents tbTelefonoP As TextBox
    Public WithEvents tbNombreP As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFechadeNacimiento As Label
    Friend WithEvents lblPrimerApellido As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelarA As Button
    Friend WithEvents btnGuardarA As Button
End Class
