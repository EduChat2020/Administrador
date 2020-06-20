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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnAsignaturas = New System.Windows.Forms.Button()
        Me.btnListadeEspera = New System.Windows.Forms.Button()
        Me.btnProfesores = New System.Windows.Forms.Button()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
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
        Me.PanelContenedor.Size = New System.Drawing.Size(1158, 600)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PanelFormularios.Controls.Add(Me.lblHora)
        Me.PanelFormularios.Controls.Add(Me.lblFecha)
        Me.PanelFormularios.Controls.Add(Me.Panel4)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(282, 0)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(876, 600)
        Me.PanelFormularios.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 506)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(876, 94)
        Me.Panel4.TabIndex = 3
        '
        'lblHora
        '
        Me.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblHora.Location = New System.Drawing.Point(314, 38)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(270, 91)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "HORA"
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Green
        Me.lblFecha.Location = New System.Drawing.Point(324, 141)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(81, 31)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.btnAgenda)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnAsignaturas)
        Me.PanelMenu.Controls.Add(Me.btnListadeEspera)
        Me.PanelMenu.Controls.Add(Me.btnProfesores)
        Me.PanelMenu.Controls.Add(Me.btnAlumnos)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(282, 600)
        Me.PanelMenu.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(282, 200)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 3
        '
        'btnAgenda
        '
        Me.btnAgenda.FlatAppearance.BorderSize = 0
        Me.btnAgenda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgenda.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgenda.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgenda.Image = CType(resources.GetObject("btnAgenda.Image"), System.Drawing.Image)
        Me.btnAgenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgenda.Location = New System.Drawing.Point(3, 368)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(279, 50)
        Me.btnAgenda.TabIndex = 5
        Me.btnAgenda.Text = "Agenda "
        Me.btnAgenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAgenda.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(282, 126)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(107, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Administrador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(107, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Liceo IEP"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnAsignaturas
        '
        Me.btnAsignaturas.FlatAppearance.BorderSize = 0
        Me.btnAsignaturas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAsignaturas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnAsignaturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignaturas.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignaturas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAsignaturas.Location = New System.Drawing.Point(0, 256)
        Me.btnAsignaturas.Name = "btnAsignaturas"
        Me.btnAsignaturas.Size = New System.Drawing.Size(279, 50)
        Me.btnAsignaturas.TabIndex = 3
        Me.btnAsignaturas.Text = "Asignaturas"
        Me.btnAsignaturas.UseVisualStyleBackColor = True
        '
        'btnListadeEspera
        '
        Me.btnListadeEspera.FlatAppearance.BorderSize = 0
        Me.btnListadeEspera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnListadeEspera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnListadeEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListadeEspera.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListadeEspera.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnListadeEspera.Image = CType(resources.GetObject("btnListadeEspera.Image"), System.Drawing.Image)
        Me.btnListadeEspera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnListadeEspera.Location = New System.Drawing.Point(0, 312)
        Me.btnListadeEspera.Name = "btnListadeEspera"
        Me.btnListadeEspera.Size = New System.Drawing.Size(282, 50)
        Me.btnListadeEspera.TabIndex = 2
        Me.btnListadeEspera.Text = "Lista de espera"
        Me.btnListadeEspera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnListadeEspera.UseVisualStyleBackColor = True
        '
        'btnProfesores
        '
        Me.btnProfesores.FlatAppearance.BorderSize = 0
        Me.btnProfesores.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnProfesores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnProfesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfesores.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfesores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProfesores.Location = New System.Drawing.Point(3, 200)
        Me.btnProfesores.Name = "btnProfesores"
        Me.btnProfesores.Size = New System.Drawing.Size(279, 50)
        Me.btnProfesores.TabIndex = 1
        Me.btnProfesores.Text = "Profesores"
        Me.btnProfesores.UseVisualStyleBackColor = True
        '
        'btnAlumnos
        '
        Me.btnAlumnos.FlatAppearance.BorderSize = 0
        Me.btnAlumnos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAlumnos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlumnos.Font = New System.Drawing.Font("Microsoft YaHei", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlumnos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAlumnos.Image = CType(resources.GetObject("btnAlumnos.Image"), System.Drawing.Image)
        Me.btnAlumnos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlumnos.Location = New System.Drawing.Point(3, 144)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Size = New System.Drawing.Size(279, 50)
        Me.btnAlumnos.TabIndex = 0
        Me.btnAlumnos.Text = "  Alumnos"
        Me.btnAlumnos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAlumnos.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1158, 600)
        Me.Controls.Add(Me.PanelContenedor)
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "FormPrincipal"
        Me.Text = "Menu Principal - Administrador"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnProfesores As Button
    Friend WithEvents btnAlumnos As Button
    Friend WithEvents btnAsignaturas As Button
    Friend WithEvents btnListadeEspera As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAgenda As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Panel3 As Panel
End Class
