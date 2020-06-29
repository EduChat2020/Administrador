<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAlumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlumnos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.DTAlumnos = New System.Windows.Forms.DataGridView()
        Me.ID_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo_Alumno = New System.Windows.Forms.Button()
        Me.btnEditar_Alumno = New System.Windows.Forms.Button()
        Me.btnEliminar_Alumno = New System.Windows.Forms.Button()
        Me.lblAyuda = New System.Windows.Forms.Label()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(312, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Control de Alumnos"
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(12, 9)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.TabStop = False
        '
        'DTAlumnos
        '
        Me.DTAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DTAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Alumnos, Me.Nombre_Alumnos, Me.Apellido_Alumnos, Me.Cedula_Alumnos, Me.Telefono_Alumnos})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTAlumnos.DefaultCellStyle = DataGridViewCellStyle2
        Me.DTAlumnos.Location = New System.Drawing.Point(28, 78)
        Me.DTAlumnos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTAlumnos.Name = "DTAlumnos"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTAlumnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DTAlumnos.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DTAlumnos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DTAlumnos.RowTemplate.Height = 24
        Me.DTAlumnos.Size = New System.Drawing.Size(884, 517)
        Me.DTAlumnos.TabIndex = 5
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
        'btnNuevo_Alumno
        '
        Me.btnNuevo_Alumno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo_Alumno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo_Alumno.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnNuevo_Alumno.FlatAppearance.BorderSize = 2
        Me.btnNuevo_Alumno.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNuevo_Alumno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNuevo_Alumno.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnNuevo_Alumno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnNuevo_Alumno.Location = New System.Drawing.Point(944, 78)
        Me.btnNuevo_Alumno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNuevo_Alumno.Name = "btnNuevo_Alumno"
        Me.btnNuevo_Alumno.Size = New System.Drawing.Size(173, 55)
        Me.btnNuevo_Alumno.TabIndex = 6
        Me.btnNuevo_Alumno.Text = "Nuevo"
        Me.btnNuevo_Alumno.UseVisualStyleBackColor = False
        '
        'btnEditar_Alumno
        '
        Me.btnEditar_Alumno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditar_Alumno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditar_Alumno.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnEditar_Alumno.FlatAppearance.BorderSize = 2
        Me.btnEditar_Alumno.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditar_Alumno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditar_Alumno.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnEditar_Alumno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnEditar_Alumno.Location = New System.Drawing.Point(944, 164)
        Me.btnEditar_Alumno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditar_Alumno.Name = "btnEditar_Alumno"
        Me.btnEditar_Alumno.Size = New System.Drawing.Size(173, 55)
        Me.btnEditar_Alumno.TabIndex = 7
        Me.btnEditar_Alumno.Text = "Editar"
        Me.btnEditar_Alumno.UseVisualStyleBackColor = False
        '
        'btnEliminar_Alumno
        '
        Me.btnEliminar_Alumno.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar_Alumno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminar_Alumno.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar_Alumno.FlatAppearance.BorderSize = 2
        Me.btnEliminar_Alumno.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEliminar_Alumno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEliminar_Alumno.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnEliminar_Alumno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnEliminar_Alumno.Location = New System.Drawing.Point(944, 254)
        Me.btnEliminar_Alumno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar_Alumno.Name = "btnEliminar_Alumno"
        Me.btnEliminar_Alumno.Size = New System.Drawing.Size(173, 55)
        Me.btnEliminar_Alumno.TabIndex = 8
        Me.btnEliminar_Alumno.Text = "Eliminar"
        Me.btnEliminar_Alumno.UseVisualStyleBackColor = False
        '
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.BackColor = System.Drawing.Color.Transparent
        Me.lblAyuda.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.Red
        Me.lblAyuda.Location = New System.Drawing.Point(25, 48)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(77, 19)
        Me.lblAyuda.TabIndex = 9
        Me.lblAyuda.Text = "Click Aqui"
        Me.lblAyuda.Visible = False
        '
        'FormAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1129, 606)
        Me.Controls.Add(Me.lblAyuda)
        Me.Controls.Add(Me.btnEliminar_Alumno)
        Me.Controls.Add(Me.btnEditar_Alumno)
        Me.Controls.Add(Me.btnNuevo_Alumno)
        Me.Controls.Add(Me.DTAlumnos)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormAlumnos"
        Me.ShowInTaskbar = False
        Me.Text = "Alumnos"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents DTAlumnos As DataGridView
    Friend WithEvents btnNuevo_Alumno As Button
    Friend WithEvents btnEditar_Alumno As Button
    Friend WithEvents btnEliminar_Alumno As Button
    Friend WithEvents ID_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Apellido_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Cedula_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Telefono_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents lblAyuda As Label
End Class
