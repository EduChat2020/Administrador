﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnAgenda = New System.Windows.Forms.Button()
        Me.btnListaEspera = New System.Windows.Forms.Button()
        Me.btnAOP = New System.Windows.Forms.Button()
        Me.btnAlumnos = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedor.SuspendLayout()
        Me.PanelFormularios.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContenedor.MinimumSize = New System.Drawing.Size(549, 400)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1582, 813)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.AutoScroll = True
        Me.PanelFormularios.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelFormularios.Controls.Add(Me.PictureBox1)
        Me.PanelFormularios.Controls.Add(Me.lblFecha)
        Me.PanelFormularios.Controls.Add(Me.lblHora)
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(269, 0)
        Me.PanelFormularios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1313, 813)
        Me.PanelFormularios.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(400, 102)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(581, 154)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(448, 452)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(125, 44)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        '
        'lblHora
        '
        Me.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(432, 321)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(404, 135)
        Me.lblHora.TabIndex = 0
        Me.lblHora.Text = "HORA"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnAgenda)
        Me.PanelMenu.Controls.Add(Me.btnListaEspera)
        Me.PanelMenu.Controls.Add(Me.btnAOP)
        Me.PanelMenu.Controls.Add(Me.btnAlumnos)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(269, 813)
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
        Me.btnAgenda.Location = New System.Drawing.Point(0, 250)
        Me.btnAgenda.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgenda.Name = "btnAgenda"
        Me.btnAgenda.Size = New System.Drawing.Size(269, 50)
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
        Me.btnListaEspera.Location = New System.Drawing.Point(0, 200)
        Me.btnListaEspera.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnListaEspera.Name = "btnListaEspera"
        Me.btnListaEspera.Size = New System.Drawing.Size(269, 50)
        Me.btnListaEspera.TabIndex = 28
        Me.btnListaEspera.Text = "Lista de espera"
        Me.btnListaEspera.UseVisualStyleBackColor = True
        '
        'btnAOP
        '
        Me.btnAOP.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAOP.FlatAppearance.BorderSize = 0
        Me.btnAOP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAOP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.btnAOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAOP.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnAOP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAOP.Image = CType(resources.GetObject("btnAOP.Image"), System.Drawing.Image)
        Me.btnAOP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAOP.Location = New System.Drawing.Point(0, 150)
        Me.btnAOP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAOP.Name = "btnAOP"
        Me.btnAOP.Size = New System.Drawing.Size(269, 50)
        Me.btnAOP.TabIndex = 26
        Me.btnAOP.Text = "AOP"
        Me.btnAOP.UseVisualStyleBackColor = True
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
        Me.btnAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAlumnos.Name = "btnAlumnos"
        Me.btnAlumnos.Size = New System.Drawing.Size(269, 50)
        Me.btnAlumnos.TabIndex = 24
        Me.btnAlumnos.Text = "  Alúmnos"
        Me.btnAlumnos.UseVisualStyleBackColor = True
        '
        'PanelLogo
        '
        Me.PanelLogo.Controls.Add(Me.Label2)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(269, 100)
        Me.PanelLogo.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(51, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 44)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "EduChat"
        '
        'Timer1
        '
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1582, 813)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1299, 698)
        Me.Name = "FormPrincipal"
        Me.Text = "Aplicación Administrador"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelFormularios.ResumeLayout(False)
        Me.PanelFormularios.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents btnAgenda As Button
    Friend WithEvents btnListaEspera As Button
    Friend WithEvents btnAOP As Button
    Friend WithEvents btnAlumnos As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
