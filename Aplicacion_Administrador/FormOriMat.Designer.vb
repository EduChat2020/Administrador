<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormOriMat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormOriMat))
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTNMaterias = New System.Windows.Forms.DataGridView()
        Me.IDMateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Materia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agregarmateria = New System.Windows.Forms.Button()
        Me.Editarmateria = New System.Windows.Forms.Button()
        Me.Eliminarmateria = New System.Windows.Forms.Button()
        Me.DTNOrientacion = New System.Windows.Forms.DataGridView()
        Me.IDOrientacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orientacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agregarorientacion = New System.Windows.Forms.Button()
        Me.Editarorientacion = New System.Windows.Forms.Button()
        Me.Eliminarorientacion = New System.Windows.Forms.Button()
        Me.DTNRelacion = New System.Windows.Forms.DataGridView()
        Me.IDRelacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIDMateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIDOrientacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgregarRelacion = New System.Windows.Forms.Button()
        Me.Eliminarrelacion = New System.Windows.Forms.Button()
        Me.DTNProfesores = New System.Windows.Forms.DataGridView()
        Me.IDProfesor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Profesor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Agregarprofesor = New System.Windows.Forms.Button()
        Me.Editarprofesor = New System.Windows.Forms.Button()
        Me.Eliminarprofesor = New System.Windows.Forms.Button()
        Me.DTNProfesorRelacion = New System.Windows.Forms.DataGridView()
        Me.FIDRelacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIDProfesor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminarprofrel = New System.Windows.Forms.Button()
        Me.Agregarprofrel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTNMaterias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTNOrientacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTNRelacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTNProfesores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTNProfesorRelacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(35, 14)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(16, 16)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(460, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(536, 37)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Control de orientaciones y materias"
        '
        'DTNMaterias
        '
        Me.DTNMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTNMaterias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDMateria, Me.Materia})
        Me.DTNMaterias.Location = New System.Drawing.Point(56, 111)
        Me.DTNMaterias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTNMaterias.Name = "DTNMaterias"
        Me.DTNMaterias.RowHeadersWidth = 51
        Me.DTNMaterias.Size = New System.Drawing.Size(343, 268)
        Me.DTNMaterias.TabIndex = 7
        '
        'IDMateria
        '
        Me.IDMateria.HeaderText = "IDMateria"
        Me.IDMateria.MinimumWidth = 6
        Me.IDMateria.Name = "IDMateria"
        Me.IDMateria.Width = 125
        '
        'Materia
        '
        Me.Materia.HeaderText = "Materia"
        Me.Materia.MinimumWidth = 6
        Me.Materia.Name = "Materia"
        Me.Materia.Width = 125
        '
        'Agregarmateria
        '
        Me.Agregarmateria.Location = New System.Drawing.Point(56, 386)
        Me.Agregarmateria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Agregarmateria.Name = "Agregarmateria"
        Me.Agregarmateria.Size = New System.Drawing.Size(100, 28)
        Me.Agregarmateria.TabIndex = 8
        Me.Agregarmateria.Text = "Agregar"
        Me.Agregarmateria.UseVisualStyleBackColor = True
        '
        'Editarmateria
        '
        Me.Editarmateria.Location = New System.Drawing.Point(179, 386)
        Me.Editarmateria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Editarmateria.Name = "Editarmateria"
        Me.Editarmateria.Size = New System.Drawing.Size(100, 28)
        Me.Editarmateria.TabIndex = 9
        Me.Editarmateria.Text = "Editar"
        Me.Editarmateria.UseVisualStyleBackColor = True
        '
        'Eliminarmateria
        '
        Me.Eliminarmateria.Location = New System.Drawing.Point(299, 386)
        Me.Eliminarmateria.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminarmateria.Name = "Eliminarmateria"
        Me.Eliminarmateria.Size = New System.Drawing.Size(100, 28)
        Me.Eliminarmateria.TabIndex = 10
        Me.Eliminarmateria.Text = "Eliminar"
        Me.Eliminarmateria.UseVisualStyleBackColor = True
        '
        'DTNOrientacion
        '
        Me.DTNOrientacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTNOrientacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDOrientacion, Me.Orientacion})
        Me.DTNOrientacion.Location = New System.Drawing.Point(1021, 111)
        Me.DTNOrientacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTNOrientacion.Name = "DTNOrientacion"
        Me.DTNOrientacion.RowHeadersWidth = 51
        Me.DTNOrientacion.Size = New System.Drawing.Size(343, 268)
        Me.DTNOrientacion.TabIndex = 11
        '
        'IDOrientacion
        '
        Me.IDOrientacion.HeaderText = "IDOrientacion"
        Me.IDOrientacion.MinimumWidth = 6
        Me.IDOrientacion.Name = "IDOrientacion"
        Me.IDOrientacion.Width = 125
        '
        'Orientacion
        '
        Me.Orientacion.HeaderText = "Orientacion"
        Me.Orientacion.MinimumWidth = 6
        Me.Orientacion.Name = "Orientacion"
        Me.Orientacion.Width = 125
        '
        'Agregarorientacion
        '
        Me.Agregarorientacion.Location = New System.Drawing.Point(1021, 386)
        Me.Agregarorientacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Agregarorientacion.Name = "Agregarorientacion"
        Me.Agregarorientacion.Size = New System.Drawing.Size(100, 28)
        Me.Agregarorientacion.TabIndex = 12
        Me.Agregarorientacion.Text = "Agregar"
        Me.Agregarorientacion.UseVisualStyleBackColor = True
        '
        'Editarorientacion
        '
        Me.Editarorientacion.Location = New System.Drawing.Point(1144, 386)
        Me.Editarorientacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Editarorientacion.Name = "Editarorientacion"
        Me.Editarorientacion.Size = New System.Drawing.Size(100, 28)
        Me.Editarorientacion.TabIndex = 13
        Me.Editarorientacion.Text = "Editar"
        Me.Editarorientacion.UseVisualStyleBackColor = True
        '
        'Eliminarorientacion
        '
        Me.Eliminarorientacion.Location = New System.Drawing.Point(1264, 386)
        Me.Eliminarorientacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminarorientacion.Name = "Eliminarorientacion"
        Me.Eliminarorientacion.Size = New System.Drawing.Size(100, 28)
        Me.Eliminarorientacion.TabIndex = 14
        Me.Eliminarorientacion.Text = "Eliminar"
        Me.Eliminarorientacion.UseVisualStyleBackColor = True
        '
        'DTNRelacion
        '
        Me.DTNRelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTNRelacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRelacion, Me.FIDMateria, Me.FIDOrientacion})
        Me.DTNRelacion.Location = New System.Drawing.Point(488, 140)
        Me.DTNRelacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTNRelacion.Name = "DTNRelacion"
        Me.DTNRelacion.RowHeadersWidth = 51
        Me.DTNRelacion.Size = New System.Drawing.Size(461, 239)
        Me.DTNRelacion.TabIndex = 15
        '
        'IDRelacion
        '
        Me.IDRelacion.HeaderText = "IDRelacion"
        Me.IDRelacion.MinimumWidth = 6
        Me.IDRelacion.Name = "IDRelacion"
        Me.IDRelacion.Width = 125
        '
        'FIDMateria
        '
        Me.FIDMateria.HeaderText = "FIDMateria"
        Me.FIDMateria.MinimumWidth = 6
        Me.FIDMateria.Name = "FIDMateria"
        Me.FIDMateria.Width = 125
        '
        'FIDOrientacion
        '
        Me.FIDOrientacion.HeaderText = "FIDOrientacion"
        Me.FIDOrientacion.MinimumWidth = 6
        Me.FIDOrientacion.Name = "FIDOrientacion"
        Me.FIDOrientacion.Width = 125
        '
        'AgregarRelacion
        '
        Me.AgregarRelacion.Location = New System.Drawing.Point(407, 279)
        Me.AgregarRelacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AgregarRelacion.Name = "AgregarRelacion"
        Me.AgregarRelacion.Size = New System.Drawing.Size(63, 28)
        Me.AgregarRelacion.TabIndex = 16
        Me.AgregarRelacion.Text = ">"
        Me.AgregarRelacion.UseVisualStyleBackColor = True
        '
        'Eliminarrelacion
        '
        Me.Eliminarrelacion.Location = New System.Drawing.Point(407, 219)
        Me.Eliminarrelacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminarrelacion.Name = "Eliminarrelacion"
        Me.Eliminarrelacion.Size = New System.Drawing.Size(63, 26)
        Me.Eliminarrelacion.TabIndex = 17
        Me.Eliminarrelacion.Text = "<"
        Me.Eliminarrelacion.UseVisualStyleBackColor = True
        '
        'DTNProfesores
        '
        Me.DTNProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTNProfesores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDProfesor, Me.Profesor})
        Me.DTNProfesores.Location = New System.Drawing.Point(56, 512)
        Me.DTNProfesores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTNProfesores.Name = "DTNProfesores"
        Me.DTNProfesores.RowHeadersWidth = 51
        Me.DTNProfesores.Size = New System.Drawing.Size(343, 185)
        Me.DTNProfesores.TabIndex = 18
        '
        'IDProfesor
        '
        Me.IDProfesor.HeaderText = "IDProfesor"
        Me.IDProfesor.MinimumWidth = 6
        Me.IDProfesor.Name = "IDProfesor"
        Me.IDProfesor.Width = 125
        '
        'Profesor
        '
        Me.Profesor.HeaderText = "Profesor"
        Me.Profesor.MinimumWidth = 6
        Me.Profesor.Name = "Profesor"
        Me.Profesor.Width = 125
        '
        'Agregarprofesor
        '
        Me.Agregarprofesor.Location = New System.Drawing.Point(56, 704)
        Me.Agregarprofesor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Agregarprofesor.Name = "Agregarprofesor"
        Me.Agregarprofesor.Size = New System.Drawing.Size(92, 28)
        Me.Agregarprofesor.TabIndex = 19
        Me.Agregarprofesor.Text = "Agregar"
        Me.Agregarprofesor.UseVisualStyleBackColor = True
        '
        'Editarprofesor
        '
        Me.Editarprofesor.Location = New System.Drawing.Point(179, 704)
        Me.Editarprofesor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Editarprofesor.Name = "Editarprofesor"
        Me.Editarprofesor.Size = New System.Drawing.Size(76, 28)
        Me.Editarprofesor.TabIndex = 20
        Me.Editarprofesor.Text = "Editar"
        Me.Editarprofesor.UseVisualStyleBackColor = True
        '
        'Eliminarprofesor
        '
        Me.Eliminarprofesor.Location = New System.Drawing.Point(297, 704)
        Me.Eliminarprofesor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminarprofesor.Name = "Eliminarprofesor"
        Me.Eliminarprofesor.Size = New System.Drawing.Size(101, 28)
        Me.Eliminarprofesor.TabIndex = 21
        Me.Eliminarprofesor.Text = "Eliminar"
        Me.Eliminarprofesor.UseVisualStyleBackColor = True
        '
        'DTNProfesorRelacion
        '
        Me.DTNProfesorRelacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTNProfesorRelacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FIDRelacion, Me.FIDProfesor})
        Me.DTNProfesorRelacion.Location = New System.Drawing.Point(540, 450)
        Me.DTNProfesorRelacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DTNProfesorRelacion.Name = "DTNProfesorRelacion"
        Me.DTNProfesorRelacion.RowHeadersWidth = 51
        Me.DTNProfesorRelacion.Size = New System.Drawing.Size(333, 185)
        Me.DTNProfesorRelacion.TabIndex = 22
        '
        'FIDRelacion
        '
        Me.FIDRelacion.HeaderText = "FIDRelacion"
        Me.FIDRelacion.MinimumWidth = 6
        Me.FIDRelacion.Name = "FIDRelacion"
        Me.FIDRelacion.Width = 125
        '
        'FIDProfesor
        '
        Me.FIDProfesor.HeaderText = "FIDProfesor"
        Me.FIDProfesor.MinimumWidth = 6
        Me.FIDProfesor.Name = "FIDProfesor"
        Me.FIDProfesor.Width = 125
        '
        'Eliminarprofrel
        '
        Me.Eliminarprofrel.Location = New System.Drawing.Point(432, 512)
        Me.Eliminarprofrel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Eliminarprofrel.Name = "Eliminarprofrel"
        Me.Eliminarprofrel.Size = New System.Drawing.Size(84, 28)
        Me.Eliminarprofrel.TabIndex = 23
        Me.Eliminarprofrel.Text = "<"
        Me.Eliminarprofrel.UseVisualStyleBackColor = True
        '
        'Agregarprofrel
        '
        Me.Agregarprofrel.Location = New System.Drawing.Point(432, 561)
        Me.Agregarprofrel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Agregarprofrel.Name = "Agregarprofrel"
        Me.Agregarprofrel.Size = New System.Drawing.Size(84, 28)
        Me.Agregarprofrel.TabIndex = 24
        Me.Agregarprofrel.Text = ">"
        Me.Agregarprofrel.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Aplicacion_Administrador.My.Resources.Resources._887652_desktop_512x512
        Me.PictureBox1.Location = New System.Drawing.Point(1060, 450)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 256)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'FormOriMat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1416, 785)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Agregarprofrel)
        Me.Controls.Add(Me.Eliminarprofrel)
        Me.Controls.Add(Me.DTNProfesorRelacion)
        Me.Controls.Add(Me.Eliminarprofesor)
        Me.Controls.Add(Me.Editarprofesor)
        Me.Controls.Add(Me.Agregarprofesor)
        Me.Controls.Add(Me.DTNProfesores)
        Me.Controls.Add(Me.Eliminarrelacion)
        Me.Controls.Add(Me.AgregarRelacion)
        Me.Controls.Add(Me.DTNRelacion)
        Me.Controls.Add(Me.Eliminarorientacion)
        Me.Controls.Add(Me.Editarorientacion)
        Me.Controls.Add(Me.Agregarorientacion)
        Me.Controls.Add(Me.DTNOrientacion)
        Me.Controls.Add(Me.Eliminarmateria)
        Me.Controls.Add(Me.Editarmateria)
        Me.Controls.Add(Me.Agregarmateria)
        Me.Controls.Add(Me.DTNMaterias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormOriMat"
        Me.Text = "FormOriMat"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTNMaterias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTNOrientacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTNRelacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTNProfesores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTNProfesorRelacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DTNMaterias As DataGridView
    Friend WithEvents IDMateria As DataGridViewTextBoxColumn
    Friend WithEvents Materia As DataGridViewTextBoxColumn
    Friend WithEvents Agregarmateria As Button
    Friend WithEvents Editarmateria As Button
    Friend WithEvents Eliminarmateria As Button
    Friend WithEvents DTNOrientacion As DataGridView
    Friend WithEvents IDOrientacion As DataGridViewTextBoxColumn
    Friend WithEvents Orientacion As DataGridViewTextBoxColumn
    Friend WithEvents Agregarorientacion As Button
    Friend WithEvents Editarorientacion As Button
    Friend WithEvents Eliminarorientacion As Button
    Friend WithEvents DTNRelacion As DataGridView
    Friend WithEvents IDRelacion As DataGridViewTextBoxColumn
    Friend WithEvents FIDMateria As DataGridViewTextBoxColumn
    Friend WithEvents FIDOrientacion As DataGridViewTextBoxColumn
    Friend WithEvents AgregarRelacion As Button
    Friend WithEvents Eliminarrelacion As Button
    Friend WithEvents DTNProfesores As DataGridView
    Friend WithEvents IDProfesor As DataGridViewTextBoxColumn
    Friend WithEvents Profesor As DataGridViewTextBoxColumn
    Friend WithEvents Agregarprofesor As Button
    Friend WithEvents Editarprofesor As Button
    Friend WithEvents Eliminarprofesor As Button
    Friend WithEvents DTNProfesorRelacion As DataGridView
    Friend WithEvents FIDRelacion As DataGridViewTextBoxColumn
    Friend WithEvents FIDProfesor As DataGridViewTextBoxColumn
    Friend WithEvents Eliminarprofrel As Button
    Friend WithEvents Agregarprofrel As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
