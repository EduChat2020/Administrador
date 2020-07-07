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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAlumnos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo_Alumno = New System.Windows.Forms.Button()
        Me.btnEditar_Alumno = New System.Windows.Forms.Button()
        Me.btnEliminar_Alumno = New System.Windows.Forms.Button()
        Me.lblAyuda = New System.Windows.Forms.Label()
        Me.btnAsignarMateria = New System.Windows.Forms.Button()
        Me.Telefono_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_Alumnos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DTAlumnos = New System.Windows.Forms.DataGridView()
        Me.lblAlumnos = New System.Windows.Forms.Label()
        Me.DTMaterias = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreMateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOrientacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMaterias = New System.Windows.Forms.Label()
        Me.cbOrientaciones = New System.Windows.Forms.ComboBox()
        Me.DTMateriasAnotadas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardarMaterias = New System.Windows.Forms.Button()
        Me.lblMateriasAnotadas = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnBorrarMaterias = New System.Windows.Forms.Button()
        CType(Me.DTAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTMateriasAnotadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(473, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(303, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Control de Alúmnos"
        '
        'btnNuevo_Alumno
        '
        Me.btnNuevo_Alumno.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNuevo_Alumno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnNuevo_Alumno.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnNuevo_Alumno.FlatAppearance.BorderSize = 2
        Me.btnNuevo_Alumno.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNuevo_Alumno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNuevo_Alumno.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnNuevo_Alumno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnNuevo_Alumno.Location = New System.Drawing.Point(33, 699)
        Me.btnNuevo_Alumno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNuevo_Alumno.Name = "btnNuevo_Alumno"
        Me.btnNuevo_Alumno.Size = New System.Drawing.Size(103, 52)
        Me.btnNuevo_Alumno.TabIndex = 6
        Me.btnNuevo_Alumno.Text = "Nuevo"
        Me.btnNuevo_Alumno.UseVisualStyleBackColor = False
        '
        'btnEditar_Alumno
        '
        Me.btnEditar_Alumno.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEditar_Alumno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEditar_Alumno.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnEditar_Alumno.FlatAppearance.BorderSize = 2
        Me.btnEditar_Alumno.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditar_Alumno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEditar_Alumno.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnEditar_Alumno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnEditar_Alumno.Location = New System.Drawing.Point(167, 699)
        Me.btnEditar_Alumno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditar_Alumno.Name = "btnEditar_Alumno"
        Me.btnEditar_Alumno.Size = New System.Drawing.Size(103, 52)
        Me.btnEditar_Alumno.TabIndex = 7
        Me.btnEditar_Alumno.Text = "Editar"
        Me.btnEditar_Alumno.UseVisualStyleBackColor = False
        '
        'btnEliminar_Alumno
        '
        Me.btnEliminar_Alumno.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEliminar_Alumno.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminar_Alumno.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminar_Alumno.FlatAppearance.BorderSize = 2
        Me.btnEliminar_Alumno.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEliminar_Alumno.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEliminar_Alumno.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnEliminar_Alumno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnEliminar_Alumno.Location = New System.Drawing.Point(304, 699)
        Me.btnEliminar_Alumno.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar_Alumno.Name = "btnEliminar_Alumno"
        Me.btnEliminar_Alumno.Size = New System.Drawing.Size(103, 52)
        Me.btnEliminar_Alumno.TabIndex = 8
        Me.btnEliminar_Alumno.Text = "Eliminar"
        Me.btnEliminar_Alumno.UseVisualStyleBackColor = False
        '
        'lblAyuda
        '
        Me.lblAyuda.AutoSize = True
        Me.lblAyuda.BackColor = System.Drawing.Color.Transparent
        Me.lblAyuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAyuda.ForeColor = System.Drawing.Color.Red
        Me.lblAyuda.Location = New System.Drawing.Point(54, 14)
        Me.lblAyuda.Name = "lblAyuda"
        Me.lblAyuda.Size = New System.Drawing.Size(108, 51)
        Me.lblAyuda.TabIndex = 9
        Me.lblAyuda.Text = "Seleccionar Fila" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       ▼" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "       "
        Me.lblAyuda.Visible = False
        '
        'btnAsignarMateria
        '
        Me.btnAsignarMateria.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAsignarMateria.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAsignarMateria.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnAsignarMateria.FlatAppearance.BorderSize = 2
        Me.btnAsignarMateria.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAsignarMateria.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAsignarMateria.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnAsignarMateria.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAsignarMateria.Location = New System.Drawing.Point(446, 685)
        Me.btnAsignarMateria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAsignarMateria.Name = "btnAsignarMateria"
        Me.btnAsignarMateria.Size = New System.Drawing.Size(132, 66)
        Me.btnAsignarMateria.TabIndex = 10
        Me.btnAsignarMateria.Text = "Asignar Materias"
        Me.btnAsignarMateria.UseVisualStyleBackColor = False
        '
        'Telefono_Alumnos
        '
        Me.Telefono_Alumnos.HeaderText = "TELEFONO"
        Me.Telefono_Alumnos.MinimumWidth = 6
        Me.Telefono_Alumnos.Name = "Telefono_Alumnos"
        Me.Telefono_Alumnos.Width = 125
        '
        'Cedula_Alumnos
        '
        Me.Cedula_Alumnos.HeaderText = "CEDULA"
        Me.Cedula_Alumnos.MinimumWidth = 6
        Me.Cedula_Alumnos.Name = "Cedula_Alumnos"
        Me.Cedula_Alumnos.Width = 125
        '
        'Apellido_Alumnos
        '
        Me.Apellido_Alumnos.HeaderText = "APELLIDO"
        Me.Apellido_Alumnos.MinimumWidth = 6
        Me.Apellido_Alumnos.Name = "Apellido_Alumnos"
        Me.Apellido_Alumnos.ReadOnly = True
        Me.Apellido_Alumnos.Width = 125
        '
        'Nombre_Alumnos
        '
        Me.Nombre_Alumnos.HeaderText = "NOMBRE"
        Me.Nombre_Alumnos.MinimumWidth = 6
        Me.Nombre_Alumnos.Name = "Nombre_Alumnos"
        Me.Nombre_Alumnos.ReadOnly = True
        Me.Nombre_Alumnos.Width = 125
        '
        'ID_Alumnos
        '
        Me.ID_Alumnos.HeaderText = "ID"
        Me.ID_Alumnos.MinimumWidth = 6
        Me.ID_Alumnos.Name = "ID_Alumnos"
        Me.ID_Alumnos.ReadOnly = True
        Me.ID_Alumnos.Width = 75
        '
        'DTAlumnos
        '
        Me.DTAlumnos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DTAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Alumnos, Me.Nombre_Alumnos, Me.Apellido_Alumnos, Me.Cedula_Alumnos, Me.Telefono_Alumnos})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTAlumnos.DefaultCellStyle = DataGridViewCellStyle2
        Me.DTAlumnos.Location = New System.Drawing.Point(56, 67)
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
        Me.DTAlumnos.Size = New System.Drawing.Size(480, 598)
        Me.DTAlumnos.TabIndex = 5
        '
        'lblAlumnos
        '
        Me.lblAlumnos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAlumnos.AutoSize = True
        Me.lblAlumnos.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlumnos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.lblAlumnos.Location = New System.Drawing.Point(238, 34)
        Me.lblAlumnos.Name = "lblAlumnos"
        Me.lblAlumnos.Size = New System.Drawing.Size(94, 23)
        Me.lblAlumnos.TabIndex = 11
        Me.lblAlumnos.Text = "Alumnos"
        '
        'DTMaterias
        '
        Me.DTMaterias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTMaterias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DTMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTMaterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.NombreMateria, Me.NombreOrientacion})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTMaterias.DefaultCellStyle = DataGridViewCellStyle6
        Me.DTMaterias.Enabled = False
        Me.DTMaterias.Location = New System.Drawing.Point(741, 67)
        Me.DTMaterias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTMaterias.Name = "DTMaterias"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTMaterias.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DTMaterias.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DTMaterias.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DTMaterias.RowTemplate.Height = 24
        Me.DTMaterias.Size = New System.Drawing.Size(528, 220)
        Me.DTMaterias.TabIndex = 12
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 75
        '
        'NombreMateria
        '
        Me.NombreMateria.HeaderText = "MATERIA"
        Me.NombreMateria.MinimumWidth = 6
        Me.NombreMateria.Name = "NombreMateria"
        Me.NombreMateria.ReadOnly = True
        Me.NombreMateria.Width = 125
        '
        'NombreOrientacion
        '
        Me.NombreOrientacion.HeaderText = "ORIENTACION"
        Me.NombreOrientacion.MinimumWidth = 6
        Me.NombreOrientacion.Name = "NombreOrientacion"
        Me.NombreOrientacion.ReadOnly = True
        Me.NombreOrientacion.Width = 125
        '
        'lblMaterias
        '
        Me.lblMaterias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaterias.AutoSize = True
        Me.lblMaterias.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaterias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.lblMaterias.Location = New System.Drawing.Point(800, 34)
        Me.lblMaterias.Name = "lblMaterias"
        Me.lblMaterias.Size = New System.Drawing.Size(92, 23)
        Me.lblMaterias.TabIndex = 13
        Me.lblMaterias.Text = "Materias"
        '
        'cbOrientaciones
        '
        Me.cbOrientaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOrientaciones.Enabled = False
        Me.cbOrientaciones.FormattingEnabled = True
        Me.cbOrientaciones.Location = New System.Drawing.Point(987, 34)
        Me.cbOrientaciones.Name = "cbOrientaciones"
        Me.cbOrientaciones.Size = New System.Drawing.Size(282, 24)
        Me.cbOrientaciones.TabIndex = 14
        Me.cbOrientaciones.Text = "Filtrar por Orientacion"
        '
        'DTMateriasAnotadas
        '
        Me.DTMateriasAnotadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTMateriasAnotadas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DTMateriasAnotadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTMateriasAnotadas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.Materias})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DTMateriasAnotadas.DefaultCellStyle = DataGridViewCellStyle10
        Me.DTMateriasAnotadas.Enabled = False
        Me.DTMateriasAnotadas.Location = New System.Drawing.Point(741, 459)
        Me.DTMateriasAnotadas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DTMateriasAnotadas.Name = "DTMateriasAnotadas"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DTMateriasAnotadas.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.DTMateriasAnotadas.RowHeadersWidth = 51
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue
        Me.DTMateriasAnotadas.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DTMateriasAnotadas.RowTemplate.Height = 24
        Me.DTMateriasAnotadas.Size = New System.Drawing.Size(528, 206)
        Me.DTMateriasAnotadas.TabIndex = 15
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 75
        '
        'Materias
        '
        Me.Materias.HeaderText = "MATERIAS"
        Me.Materias.MinimumWidth = 6
        Me.Materias.Name = "Materias"
        Me.Materias.Width = 125
        '
        'btnGuardarMaterias
        '
        Me.btnGuardarMaterias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardarMaterias.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardarMaterias.Enabled = False
        Me.btnGuardarMaterias.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardarMaterias.FlatAppearance.BorderSize = 2
        Me.btnGuardarMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGuardarMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnGuardarMaterias.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnGuardarMaterias.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarMaterias.Image = CType(resources.GetObject("btnGuardarMaterias.Image"), System.Drawing.Image)
        Me.btnGuardarMaterias.Location = New System.Drawing.Point(1016, 308)
        Me.btnGuardarMaterias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardarMaterias.Name = "btnGuardarMaterias"
        Me.btnGuardarMaterias.Size = New System.Drawing.Size(105, 84)
        Me.btnGuardarMaterias.TabIndex = 16
        Me.btnGuardarMaterias.UseVisualStyleBackColor = False
        '
        'lblMateriasAnotadas
        '
        Me.lblMateriasAnotadas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMateriasAnotadas.AutoSize = True
        Me.lblMateriasAnotadas.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMateriasAnotadas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.lblMateriasAnotadas.Location = New System.Drawing.Point(737, 413)
        Me.lblMateriasAnotadas.Name = "lblMateriasAnotadas"
        Me.lblMateriasAnotadas.Size = New System.Drawing.Size(195, 23)
        Me.lblMateriasAnotadas.TabIndex = 17
        Me.lblMateriasAnotadas.Text = "Materias Anotadas"
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
        'btnBorrarMaterias
        '
        Me.btnBorrarMaterias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorrarMaterias.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBorrarMaterias.Enabled = False
        Me.btnBorrarMaterias.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.btnBorrarMaterias.FlatAppearance.BorderSize = 2
        Me.btnBorrarMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBorrarMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnBorrarMaterias.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!)
        Me.btnBorrarMaterias.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBorrarMaterias.Image = CType(resources.GetObject("btnBorrarMaterias.Image"), System.Drawing.Image)
        Me.btnBorrarMaterias.Location = New System.Drawing.Point(877, 308)
        Me.btnBorrarMaterias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBorrarMaterias.Name = "btnBorrarMaterias"
        Me.btnBorrarMaterias.Size = New System.Drawing.Size(105, 84)
        Me.btnBorrarMaterias.TabIndex = 18
        Me.btnBorrarMaterias.UseVisualStyleBackColor = False
        '
        'FormAlumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1295, 766)
        Me.Controls.Add(Me.btnBorrarMaterias)
        Me.Controls.Add(Me.lblMateriasAnotadas)
        Me.Controls.Add(Me.btnGuardarMaterias)
        Me.Controls.Add(Me.DTMateriasAnotadas)
        Me.Controls.Add(Me.cbOrientaciones)
        Me.Controls.Add(Me.lblMaterias)
        Me.Controls.Add(Me.DTMaterias)
        Me.Controls.Add(Me.lblAlumnos)
        Me.Controls.Add(Me.btnAsignarMateria)
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
        CType(Me.DTAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTMateriasAnotadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnNuevo_Alumno As Button
    Friend WithEvents btnEditar_Alumno As Button
    Friend WithEvents btnEliminar_Alumno As Button
    Friend WithEvents lblAyuda As Label
    Friend WithEvents btnAsignarMateria As Button
    Friend WithEvents Telefono_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Cedula_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Apellido_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents ID_Alumnos As DataGridViewTextBoxColumn
    Friend WithEvents DTAlumnos As DataGridView
    Friend WithEvents lblAlumnos As Label
    Friend WithEvents DTMaterias As DataGridView
    Friend WithEvents lblMaterias As Label
    Friend WithEvents cbOrientaciones As ComboBox
    Friend WithEvents DTMateriasAnotadas As DataGridView
    Friend WithEvents btnGuardarMaterias As Button
    Friend WithEvents lblMateriasAnotadas As Label
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Materias As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NombreMateria As DataGridViewTextBoxColumn
    Friend WithEvents NombreOrientacion As DataGridViewTextBoxColumn
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnBorrarMaterias As Button
End Class
