Public Class FormNuevoAlumno


    Private Sub FormNuevoAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardarA_Click(sender As Object, e As EventArgs) Handles btnGuardarA.Click


        Dim alum As New CapaNegocio2.NNuevoAlumno
        Dim obj As New CapaEmpaquetadora2.ENuevoAlumno

        obj.funNombreA = tbNombreA.Text
        obj.funPrimerApellidoA = tbPrimerApellidoA.Text
        obj.funSegundoApellidoA = tbSegundoApellidoA.Text
        obj.funCedulaA = tbCedulaA.Text



    End Sub

    Private Sub btnCancelarA_Click(sender As Object, e As EventArgs) Handles btnCancelarA.Click
        Me.Close()
    End Sub

#Region "SOLO LETRAS O NUMEROS"
    Private Sub tbCedulaA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCedulaA.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If

    End Sub

    Private Sub tbNombreA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNombreA.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub
    Private Sub tbPrimerApellidoA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPrimerApellidoA.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

    Private Sub tbSegundoApellidoA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSegundoApellidoA.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True

        End If
    End Sub

#End Region

End Class