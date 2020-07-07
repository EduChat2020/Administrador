<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditarAlumno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditarAlumno))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelarA = New System.Windows.Forms.Button()
        Me.btnGuardarA = New System.Windows.Forms.Button()
        Me.PanelContenedorNA = New System.Windows.Forms.Panel()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbPrimerApellidoA = New System.Windows.Forms.TextBox()
        Me.tbCedulaA = New System.Windows.Forms.TextBox()
        Me.tbTelefonoA = New System.Windows.Forms.TextBox()
        Me.tbNombreA = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblFechadeNacimiento = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelContenedorNA.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelarA)
        Me.Panel1.Controls.Add(Me.btnGuardarA)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 425)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1092, 68)
        Me.Panel1.TabIndex = 10
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
        'PanelContenedorNA
        '
        Me.PanelContenedorNA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContenedorNA.Controls.Add(Me.tbID)
        Me.PanelContenedorNA.Controls.Add(Me.Label2)
        Me.PanelContenedorNA.Controls.Add(Me.PictureBox1)
        Me.PanelContenedorNA.Controls.Add(Me.tbPrimerApellidoA)
        Me.PanelContenedorNA.Controls.Add(Me.tbCedulaA)
        Me.PanelContenedorNA.Controls.Add(Me.tbTelefonoA)
        Me.PanelContenedorNA.Controls.Add(Me.tbNombreA)
        Me.PanelContenedorNA.Controls.Add(Me.lblCedula)
        Me.PanelContenedorNA.Controls.Add(Me.Label1)
        Me.PanelContenedorNA.Controls.Add(Me.lblNombre)
        Me.PanelContenedorNA.Controls.Add(Me.lblFechadeNacimiento)
        Me.PanelContenedorNA.Controls.Add(Me.lblPrimerApellido)
        Me.PanelContenedorNA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedorNA.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedorNA.Name = "PanelContenedorNA"
        Me.PanelContenedorNA.Size = New System.Drawing.Size(1092, 493)
        Me.PanelContenedorNA.TabIndex = 9
        '
        'tbID
        '
        Me.tbID.Enabled = False
        Me.tbID.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbID.Location = New System.Drawing.Point(301, 94)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(417, 22)
        Me.tbID.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 93)
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
        'tbPrimerApellidoA
        '
        Me.tbPrimerApellidoA.Location = New System.Drawing.Point(301, 189)
        Me.tbPrimerApellidoA.Name = "tbPrimerApellidoA"
        Me.tbPrimerApellidoA.Size = New System.Drawing.Size(417, 22)
        Me.tbPrimerApellidoA.TabIndex = 12
        '
        'tbCedulaA
        '
        Me.tbCedulaA.Enabled = False
        Me.tbCedulaA.Location = New System.Drawing.Point(301, 244)
        Me.tbCedulaA.Name = "tbCedulaA"
        Me.tbCedulaA.Size = New System.Drawing.Size(417, 22)
        Me.tbCedulaA.TabIndex = 9
        '
        'tbTelefonoA
        '
        Me.tbTelefonoA.Location = New System.Drawing.Point(301, 288)
        Me.tbTelefonoA.Name = "tbTelefonoA"
        Me.tbTelefonoA.Size = New System.Drawing.Size(417, 22)
        Me.tbTelefonoA.TabIndex = 8
        '
        'tbNombreA
        '
        Me.tbNombreA.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbNombreA.Location = New System.Drawing.Point(301, 137)
        Me.tbNombreA.Name = "tbNombreA"
        Me.tbNombreA.Size = New System.Drawing.Size(417, 22)
        Me.tbNombreA.TabIndex = 7
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCedula.Location = New System.Drawing.Point(50, 241)
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
        Me.lblNombre.Location = New System.Drawing.Point(44, 137)
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
        Me.lblFechadeNacimiento.Location = New System.Drawing.Point(50, 288)
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
        Me.lblPrimerApellido.Location = New System.Drawing.Point(44, 186)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(157, 23)
        Me.lblPrimerApellido.TabIndex = 2
        Me.lblPrimerApellido.Text = "Primer Apellido"
        Me.lblPrimerApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormEditarAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 493)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelContenedorNA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1110, 540)
        Me.MinimumSize = New System.Drawing.Size(1110, 540)
        Me.Name = "FormEditarAlumno"
        Me.Text = "Editar Alumno"
        Me.Panel1.ResumeLayout(False)
        Me.PanelContenedorNA.ResumeLayout(False)
        Me.PanelContenedorNA.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancelarA As Button
    Friend WithEvents btnGuardarA As Button
    Friend WithEvents PanelContenedorNA As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblFechadeNacimiento As Label
    Friend WithEvents lblPrimerApellido As Label
    Public WithEvents tbPrimerApellidoA As TextBox
    Public WithEvents tbCedulaA As TextBox
    Public WithEvents tbTelefonoA As TextBox
    Public WithEvents tbNombreA As TextBox
    Public WithEvents tbID As TextBox
    Friend WithEvents Label2 As Label
End Class
