Public Class FormPrincipal

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Enabled = True
    End Sub

    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = PanelFormularios.Controls.OfType(Of Miform)().FirstOrDefault() 'Busca el formulario en la coleccion'
        'Si form no fue econtrado/ no existe'
        If Formulario Is Nothing Then
            Formulario = New Miform()
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            PanelFormularios.Controls.Add(Formulario)
            PanelFormularios.Tag = Formulario
            AddHandler Formulario.FormClosed, AddressOf Me.CerrarFormulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()
        End If
    End Sub

    Private Sub btnAlumnos_Click(sender As Object, e As EventArgs) Handles btnAlumnos.Click
        AbrirFormEnPanel(Of Form1)()
        btnAlumnos.BackColor = Color.FromArgb(12, 61, 92)
    End Sub

    Private Sub btnProfesores_Click(sender As Object, e As EventArgs) Handles btnProfesores.Click
        AbrirFormEnPanel(Of Form2)()
        btnProfesores.BackColor = Color.FromArgb(12, 61, 92)
    End Sub


    'CERRAR FORMS'
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If (Application.OpenForms("Form1") Is Nothing) Then
            btnAlumnos.BackColor = Color.FromArgb(6, 31, 98)
        End If

        If (Application.OpenForms("Form2") Is Nothing) Then
            btnProfesores.BackColor = Color.FromArgb(6, 31, 98)
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()

    End Sub

End Class
