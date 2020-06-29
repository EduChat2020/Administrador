Public Class FormAlumnos


    Private Sub FormAlumnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTAlumnos.Rows.Add(1, "Francisco", "Pagani", 3242131, 26959301)
        DTAlumnos.Rows.Add(2, "pepe", "reina", 3243232, 26953456)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Alumno_Click(sender As Object, e As EventArgs) Handles btnNuevo_Alumno.Click
        Dim fna As New FormNuevoAlumno
        fna.ShowDialog()

    End Sub

    Private Sub btnEditar_Alumno_Click(sender As Object, e As EventArgs) Handles btnEditar_Alumno.Click
        If (DTAlumnos.SelectedRows.Count > 0) Then
            Dim fea As New FormEditarAlumno
            fea.tbID.Text = DTAlumnos.CurrentRow.Cells(0).Value.ToString()
            fea.tbNombreA.Text = DTAlumnos.CurrentRow.Cells(1).Value.ToString()
            fea.tbPrimerApellidoA.Text = DTAlumnos.CurrentRow.Cells(2).Value.ToString()
            fea.tbCedulaA.Text = DTAlumnos.CurrentRow.Cells(3).Value.ToString()
            fea.tbTelefonoA.Text = DTAlumnos.CurrentRow.Cells(4).Value.ToString()
            fea.ShowDialog()
            lblAyuda.Visible = False
        Else
            MessageBox.Show("Por favor seleccione una fila...")
            lblAyuda.Visible = True






        End If

    End Sub


End Class
