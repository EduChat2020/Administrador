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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.btnListaEspera = New System.Windows.Forms.Button()
        Me.PanelSubMenuAOG = New System.Windows.Forms.Panel()
        Me.btnGrupos = New System.Windows.Forms.Button()
        Me.btnOrientaciones = New System.Windows.Forms.Button()
        Me.btnAsignaturas = New System.Windows.Forms.Button()
        Me.btnAOG = New System.Windows.Forms.Button()
        Me.btnProfesores = New System.Windows.Forms.Button()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelSubMenuAOG.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelFormularios.AutoScroll = True
        Me.PanelFormularios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelFormularios.Controls.Add(Me.PictureBox1)
        Me.PanelFormularios.Controls.Add(Me.Panel1)
        Me.PanelFormularios.Controls.Add(Me.lblFecha)
        Me.PanelFormularios.Controls.Add(Me.lblHora)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(270, 0)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1030, 700)
        Me.PanelFormularios.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 640)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1030, 60)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(730, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Creado y Diseñado por TecnoLíder Copyright © Todos los derechos reservados."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(306, 395)
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
        Me.lblHora.Location = New System.Drawing.Point(290, 265)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(409, 142)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "HORA"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnAgenda)
        Me.PanelMenu.Controls.Add(Me.btnListaEspera)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuAOG)
        Me.PanelMenu.Controls.Add(Me.btnAOG)
        Me.PanelMenu.Controls.Add(Me.btnProfesores)
        Me.PanelMenu.Controls.Add(Me.btnAlumnos)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(270, 700)
        Me.PanelMenu.TabIndex = 0
        '
        'btnAgenda
        '
        Me.btnAgenda.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAgenda.FlatAppearance.BorderSize = 0
        Me.btnAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgenda.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgenda.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgenda.Image = CType(resources.GetObject("btnAgenda.Image"), System.Drawing.Image)
        Me.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgenda.Location = New System.Drawing.Point(0, 457)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(270, 50)
        Me.btnAgenda.TabIndex = 30
        Me.btnAgenda.Text = "Agenda "
        Me.btnAgenda.UseVisualStyleBackColor = True
        '
        'btnListaEspera
        '
        Me.btnListaEspera.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnListaEspera.FlatAppearance.BorderSize = 0
        Me.btnListaEspera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnListaEspera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnListaEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListaEspera.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnListaEspera.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnListaEspera.Image = CType(resources.GetObject("btnListaEspera.Image"), System.Drawing.Image)
        Me.btnListaEspera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListaEspera.Location = New System.Drawing.Point(0, 407)
        Me.btnListaEspera.Name = "btnListaEspera"
        Me.btnListaEspera.Size = New System.Drawing.Size(270, 50)
        Me.btnListaEspera.TabIndex = 28
        Me.btnListaEspera.Text = "Lista de espera"
        Me.btnListaEspera.UseVisualStyleBackColor = True
        '
        'PanelSubMenuAOG
        '
        Me.PanelSubMenuAOG.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.PanelSubMenuAOG.Controls.Add(Me.btnGrupos)
        Me.PanelSubMenuAOG.Controls.Add(Me.btnOrientaciones)
        Me.PanelSubMenuAOG.Controls.Add(Me.btnAsignaturas)
        Me.PanelSubMenuAOG.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuAOG.Location = New System.Drawing.Point(0, 250)
        Me.PanelSubMenuAOG.Name = "PanelSubMenuAOG"
        Me.PanelSubMenuAOG.Size = New System.Drawing.Size(270, 157)
        Me.PanelSubMenuAOG.TabIndex = 27
        '
        'btnGrupos
        '
        Me.btnGrupos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGrupos.FlatAppearance.BorderSize = 0
        Me.btnGrupos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnGrupos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGrupos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnGrupos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrupos.Location = New System.Drawing.Point(0, 100)
        Me.btnGrupos.Name = "btnGrupos"
        Me.btnGrupos.Size = New System.Drawing.Size(270, 50)
        Me.btnGrupos.TabIndex = 26
        Me.btnGrupos.Text = "Grupos"
        Me.btnGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrupos.UseVisualStyleBackColor = True
        '
        'btnOrientaciones
        '
        Me.btnOrientaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnOrientaciones.FlatAppearance.BorderSize = 0
        Me.btnOrientaciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnOrientaciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnOrientaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrientaciones.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrientaciones.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnOrientaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrientaciones.Location = New System.Drawing.Point(0, 50)
        Me.btnOrientaciones.Name = "btnOrientaciones"
        Me.btnOrientaciones.Size = New System.Drawing.Size(270, 50)
        Me.btnOrientaciones.TabIndex = 25
        Me.btnOrientaciones.Text = "Orientaciones"
        Me.btnOrientaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrientaciones.UseVisualStyleBackColor = True
        '
        'btnAsignaturas
        '
        Me.btnAsignaturas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAsignaturas.FlatAppearance.BorderSize = 0
        Me.btnAsignaturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAsignaturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignaturas.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignaturas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAsignaturas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignaturas.Location = New System.Drawing.Point(0, 0)
        Me.btnAsignaturas.Name = "btnAsignaturas"
        Me.btnAsignaturas.Size = New System.Drawing.Size(270, 50)
        Me.btnAsignaturas.TabIndex = 24
        Me.btnAsignaturas.Text = "Asignaturas"
        Me.btnAsignaturas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignaturas.UseVisualStyleBackColor = True
        '
        'btnAOG
        '
        Me.btnAOG.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAOG.FlatAppearance.BorderSize = 0
        Me.btnAOG.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAOG.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAOG.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAOG.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnAOG.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAOG.Image = CType(resources.GetObject("btnAOG.Image"), System.Drawing.Image)
        Me.btnAOG.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAOG.Location = New System.Drawing.Point(0, 200)
        Me.btnAOG.Name = "btnAOG"
        Me.btnAOG.Size = New System.Drawing.Size(270, 50)
        Me.btnAOG.TabIndex = 26
        Me.btnAOG.Text = "AOG"
        Me.btnAOG.UseVisualStyleBackColor = True
        '
        'btnProfesores
        '
        Me.btnProfesores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProfesores.FlatAppearance.BorderSize = 0
        Me.btnProfesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnProfesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfesores.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnProfesores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProfesores.Image = CType(resources.GetObject("btnProfesores.Image"), System.Drawing.Image)
        Me.btnProfesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfesores.Location = New System.Drawing.Point(0, 150)
        Me.btnProfesores.Name = "btnProfesores"
        Me.btnProfesores.Size = New System.Drawing.Size(270, 50)
        Me.btnProfesores.TabIndex = 25
        Me.btnProfesores.Text = "Profesores"
        Me.btnProfesores.UseVisualStyleBackColor = True
        '
        'btnAlumnos
        '
        Me.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAlumnos.FlatAppearance.BorderSize = 0
        Me.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlumnos.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnAlumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAlumnos.Image = CType(resources.GetObject("btnAlumnos.Image"), System.Drawing.Image)
        Me.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlumnos.Location = New System.Drawing.Point(0, 100)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Size = New System.Drawing.Size(270, 50)
        Me.btnAlumnos.TabIndex = 24
        Me.btnAlumnos.Text = "  Alúmnos"
        Me.btnAlumnos.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.Label2)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(270, 100)
        Me.PanelLogo.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(50, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 45)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "EduChat"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(259, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(582, 154)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
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
        Me.Text = "Aplicación Administrador"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSubMenuAOG.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnAgenda As Button
    Friend WithEvents btnListaEspera As Button
    Friend WithEvents PanelSubMenuAOG As Panel
    Friend WithEvents btnGrupos As Button
    Friend WithEvents btnOrientaciones As Button
    Friend WithEvents btnAsignaturas As Button
    Friend WithEvents btnAOG As Button
    Friend WithEvents btnProfesores As Button
    Friend WithEvents btnAlumnos As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
