<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.btnAOG = New System.Windows.Forms.Button()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.btnListadeEspera = New System.Windows.Forms.Button()
        Me.btnProfesores = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.MinimumSize = New System.Drawing.Size(550, 400)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1300, 700)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelFormularios.Controls.Add(Me.lblFecha)
        Me.PanelFormularios.Controls.Add(Me.lblHora)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(279, 0)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1021, 700)
        Me.PanelFormularios.TabIndex = 1
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(299, 271)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(137, 45)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(281, 129)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(409, 142)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "HORA"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Label2)
        Me.PanelMenu.Controls.Add(Me.btnAgenda)
        Me.PanelMenu.Controls.Add(Me.btnAOG)
        Me.PanelMenu.Controls.Add(Me.btnAlumnos)
        Me.PanelMenu.Controls.Add(Me.btnListadeEspera)
        Me.PanelMenu.Controls.Add(Me.btnProfesores)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(279, 700)
        Me.PanelMenu.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(43, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 45)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "EduChat"
        '
        'btnAgenda
        '
        Me.btnAgenda.FlatAppearance.BorderSize = 0
        Me.btnAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgenda.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgenda.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgenda.Image = CType(resources.GetObject("btnAgenda.Image"), System.Drawing.Image)
        Me.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgenda.Location = New System.Drawing.Point(-1, 389)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(279, 50)
        Me.btnAgenda.TabIndex = 23
        Me.btnAgenda.Text = "Agenda "
        Me.btnAgenda.UseVisualStyleBackColor = True
        '
        'btnAOG
        '
        Me.btnAOG.FlatAppearance.BorderSize = 0
        Me.btnAOG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAOG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAOG.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnAOG.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAOG.Image = CType(resources.GetObject("btnAOG.Image"), System.Drawing.Image)
        Me.btnAOG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAOG.Location = New System.Drawing.Point(-1, 277)
        Me.btnAOG.Name = "btnAOG"
        Me.btnAOG.Size = New System.Drawing.Size(279, 50)
        Me.btnAOG.TabIndex = 22
        Me.btnAOG.Text = "AOG"
        Me.btnAOG.UseVisualStyleBackColor = True
        '
        'btnAlumnos
        '
        Me.btnAlumnos.FlatAppearance.BorderSize = 0
        Me.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlumnos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnAlumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAlumnos.Image = CType(resources.GetObject("btnAlumnos.Image"), System.Drawing.Image)
        Me.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlumnos.Location = New System.Drawing.Point(-1, 165)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Size = New System.Drawing.Size(279, 50)
        Me.btnAlumnos.TabIndex = 19
        Me.btnAlumnos.Text = "  Alumnos"
        Me.btnAlumnos.UseVisualStyleBackColor = True
        '
        'btnListadeEspera
        '
        Me.btnListadeEspera.FlatAppearance.BorderSize = 0
        Me.btnListadeEspera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnListadeEspera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnListadeEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadeEspera.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnListadeEspera.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnListadeEspera.Image = CType(resources.GetObject("btnListadeEspera.Image"), System.Drawing.Image)
        Me.btnListadeEspera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListadeEspera.Location = New System.Drawing.Point(-1, 333)
        Me.btnListadeEspera.Name = "btnListadeEspera"
        Me.btnListadeEspera.Size = New System.Drawing.Size(282, 50)
        Me.btnListadeEspera.TabIndex = 21
        Me.btnListadeEspera.Text = "Lista de espera"
        Me.btnListadeEspera.UseVisualStyleBackColor = True
        '
        'btnProfesores
        '
        Me.btnProfesores.FlatAppearance.BorderSize = 0
        Me.btnProfesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnProfesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfesores.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnProfesores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProfesores.Image = CType(resources.GetObject("btnProfesores.Image"), System.Drawing.Image)
        Me.btnProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfesores.Location = New System.Drawing.Point(-1, 221)
        Me.btnProfesores.Name = "btnProfesores"
        Me.btnProfesores.Size = New System.Drawing.Size(279, 50)
        Me.btnProfesores.TabIndex = 20
        Me.btnProfesores.Text = "Profesores"
        Me.btnProfesores.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1300, 700)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1300, 700)
        Me.Name = "FormPrincipal"
        Me.Text = "Menu Principal - Administrador"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgenda As Button
    Friend WithEvents btnAOG As Button
    Friend WithEvents btnAlumnos As Button
    Friend WithEvents btnListadeEspera As Button
    Friend WithEvents btnProfesores As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
End Class
