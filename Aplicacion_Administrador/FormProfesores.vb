Public Class FormProfesores

    Private Sub FormProfesores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTProfesores.Rows.Add(1, "Javier", "Perez", 3242131, 26959301)
        DTProfesores.Rows.Add(2, "Gustavo", "Rodriguez", 3243232, 26953456)
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Profesor_Click(sender As Object, e As EventArgs) Handles btnNuevo_Profesor.Click
        Dim fnp As New FormNuevoProfesor
        fnp.ShowDialog()
    End Sub

    Private Sub btnEditar_Profesor_Click(sender As Object, e As EventArgs) Handles btnEditar_Profesor.Click
        If (DTProfesores.SelectedRows.Count > 0) Then
            Dim fep As New FormEditarProfesor
            fep.tbID.Text = DTProfesores.CurrentRow.Cells(0).Value.ToString()
            fep.tbNombreP.Text = DTProfesores.CurrentRow.Cells(1).Value.ToString()
            fep.tbPrimerApellidoP.Text = DTProfesores.CurrentRow.Cells(2).Value.ToString()
            fep.tbCedulaP.Text = DTProfesores.CurrentRow.Cells(3).Value.ToString()
            fep.tbTelefonoP.Text = DTProfesores.CurrentRow.Cells(4).Value.ToString()
            fep.ShowDialog()
            lblAyuda.Visible = False
        Else
            MessageBox.Show("Por favor seleccione una fila...")
            lblAyudaP.Visible = True

        End If
    End Sub
End Class