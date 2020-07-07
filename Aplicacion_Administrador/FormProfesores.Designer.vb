<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProfesores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormProfesores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAyudaP = New System.Windows.Forms.Label()
        Me.btnEliminar_Profesor = New System.Windows.Forms.Button()
        Me.btnEditar_Profesor = New System.Windows.Forms.Button()
        Me.btnNuevo_Profesor = New System.Windows.Forms.Button()
        Me.DTProfesores = New System.Windows.Forms.DataGridView()
        Me.ID_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.BackColor = System.Drawing.Color.Transparent
        Me.lblAyuda.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.Red
        Me.lblAyuda.Location = New System.Drawing.Point(-139, -29)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(77, 19)
        Me.lblAyuda.TabIndex = 16
        Me.lblAyuda.Text = "Click Aqui"
        Me.lblAyuda.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-152, -68)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(312, -68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 37)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Control de Alumnos"
        '
        'lblAyudaP
        '
        Me.lblAyudaP.AutoSize = True
        Me.lblAyudaP.BackColor = System.Drawing.Color.Transparent
        Me.lblAyudaP.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyudaP.ForeColor = System.Drawing.Color.Red
        Me.lblAyudaP.Location = New System.Drawing.Point(25, 49)
        Me.lblAyudaP.Name = "lblAyudaP"
        Me.lblAyudaP.Size = New System.Drawing.Size(77, 19)
        Me.lblAyudaP.TabIndex = 23
        Me.lblAyudaP.Text = "Click Aqui"
        Me.lblAyudaP.Visible = False
        '
        'btnEliminar_Profesor
        '
        Me.btnEliminar_Profesor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar_Profesor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminar_Profesor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar_Profesor.FlatAppearance.BorderSize = 2
        Me.btnEliminar_Profesor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEliminar_Profesor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEliminar_Profesor.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnEliminar_Profesor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnEliminar_Profesor.Location = New System.Drawing.Point(944, 255)
        Me.btnEliminar_Profesor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar_Profesor.Name = "btnEliminar_Profesor"
        Me.btnEliminar_Profesor.Size = New System.Drawing.Size(173, 55)
        Me.btnEliminar_Profesor.TabIndex = 22
        Me.btnEliminar_Profesor.Text = "Eliminar"
        Me.btnEliminar_Profesor.UseVisualStyleBackColor = False
        '
        'btnEditar_Profesor
        '
        Me.btnEditar_Profesor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar_Profesor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditar_Profesor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnEditar_Profesor.FlatAppearance.BorderSize = 2
        Me.btnEditar_Profesor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditar_Profesor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditar_Profesor.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnEditar_Profesor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnEditar_Profesor.Location = New System.Drawing.Point(944, 165)
        Me.btnEditar_Profesor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditar_Profesor.Name = "btnEditar_Profesor"
        Me.btnEditar_Profesor.Size = New System.Drawing.Size(173, 55)
        Me.btnEditar_Profesor.TabIndex = 21
        Me.btnEditar_Profesor.Text = "Editar"
        Me.btnEditar_Profesor.UseVisualStyleBackColor = False
        '
        'btnNuevo_Profesor
        '
        Me.btnNuevo_Profesor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo_Profesor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo_Profesor.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnNuevo_Profesor.FlatAppearance.BorderSize = 2
        Me.btnNuevo_Profesor.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNuevo_Profesor.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNuevo_Profesor.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnNuevo_Profesor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnNuevo_Profesor.Location = New System.Drawing.Point(944, 79)
        Me.btnNuevo_Profesor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNuevo_Profesor.Name = "btnNuevo_Profesor"
        Me.btnNuevo_Profesor.Size = New System.Drawing.Size(173, 55)
        Me.btnNuevo_Profesor.TabIndex = 20
        Me.btnNuevo_Profesor.Text = "Nuevo"
        Me.btnNuevo_Profesor.UseVisualStyleBackColor = False
        '
        'DTProfesores
        '
        Me.DTProfesores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTProfesores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DTProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTProfesores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Alumnos, Me.Nombre_Alumnos, Me.Apellido_Alumnos, Me.Cedula_Alumnos, Me.Telefono_Alumnos})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTProfesores.DefaultCellStyle = DataGridViewCellStyle2
        Me.DTProfesores.Location = New System.Drawing.Point(28, 79)
        Me.DTProfesores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTProfesores.Name = "DTProfesores"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTProfesores.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DTProfesores.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DTProfesores.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DTProfesores.RowTemplate.Height = 24
        Me.DTProfesores.Size = New System.Drawing.Size(884, 517)
        Me.DTProfesores.TabIndex = 19
        '
        'ID_Alumnos
        '
        Me.ID_Alumnos.HeaderText = "ID"
        Me.ID_Alumnos.MinimumWidth = 6
        Me.ID_Alumnos.Name = "ID_Alumnos"
        Me.ID_Alumnos.ReadOnly = True
        Me.ID_Alumnos.Width = 75
        '
        'Nombre_Alumnos
        '
        Me.Nombre_Alumnos.HeaderText = "NOMBRE"
        Me.Nombre_Alumnos.MinimumWidth = 6
        Me.Nombre_Alumnos.Name = "Nombre_Alumnos"
        Me.Nombre_Alumnos.ReadOnly = True
        Me.Nombre_Alumnos.Width = 125
        '
        'Apellido_Alumnos
        '
        Me.Apellido_Alumnos.HeaderText = "APELLIDO"
        Me.Apellido_Alumnos.MinimumWidth = 6
        Me.Apellido_Alumnos.Name = "Apellido_Alumnos"
        Me.Apellido_Alumnos.ReadOnly = True
        Me.Apellido_Alumnos.Width = 125
        '
        'Cedula_Alumnos
        '
        Me.Cedula_Alumnos.HeaderText = "CEDULA"
        Me.Cedula_Alumnos.MinimumWidth = 6
        Me.Cedula_Alumnos.Name = "Cedula_Alumnos"
        Me.Cedula_Alumnos.Width = 125
        '
        'Telefono_Alumnos
        '
        Me.Telefono_Alumnos.HeaderText = "TELEFONO"
        Me.Telefono_Alumnos.MinimumWidth = 6
        Me.Telefono_Alumnos.Name = "Telefono_Alumnos"
        Me.Telefono_Alumnos.Width = 125
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(12, 10)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 18
        Me.btnCerrar.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(312, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 37)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Control de Profesores"
        '
        'FormProfesores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1129, 606)
        Me.Controls.Add(Me.lblAyudaP)
        Me.Controls.Add(Me.btnEliminar_Profesor)
        Me.Controls.Add(Me.btnEditar_Profesor)
        Me.Controls.Add(Me.btnNuevo_Profesor)
        Me.Controls.Add(Me.DTProfesores)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormProfesores"
        Me.Text = "Profesores"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAyuda As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAyudaP As Label
    Friend WithEvents btnEliminar_Profesor As Button
    Friend WithEvents btnEditar_Profesor As Button
    Friend WithEvents btnNuevo_Profesor As Button
    Friend WithEvents DTProfesores As DataGridView
    Friend WithEvents ID_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Apellido_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Cedula_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Telefono_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Label3 As Label
End Class
