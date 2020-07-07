
Public Class FormPrincipal

#Region "ABRIR FORMS EN PANEL"
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})() 'ABRIR FORMULARIOS DENTRO DE OTROS'
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

    'CERRAR FORMS'
    Private Sub CerrarFormulario(ByVal sender As Object, ByVal e As FormClosedEventArgs)  'COLOR QUE QUEDA CUANDO SE CIERRA INSTANCIA'
        If (Application.OpenForms("FormAlumnos") Is Nothing) Then
            btnAlumnos.BackColor = Color.FromArgb(0, 53, 92)
        End If

        If (Application.OpenForms("FormOriMat") Is Nothing) Then
            btnAOP.BackColor = Color.FromArgb(0, 53, 92)
        End If



    End Sub
#End Region

#Region "BOTONES MENU"
    Private Sub btnAlumnos_Click_1(sender As Object, e As EventArgs) Handles btnAlumnos.Click
        AbrirFormEnPanel(Of FormAlumnos)()
        btnAlumnos.BackColor = Color.FromArgb(0, 102, 204)
    End Sub



    Private Sub btnAOP_Click(sender As Object, e As EventArgs) Handles btnAOP.Click
        AbrirFormEnPanel(Of FormOriMat)()
        btnAOP.BackColor = Color.FromArgb(0, 102, 204)
    End Sub


#End Region

#Region "HORA INICIO"

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = DateTime.Now.ToString("HH:mm:ss")
        lblFecha.Text = DateTime.Now.ToLongDateString()

    End Sub

#End Region


    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load 'HORA MENU'
        Timer1.Enabled = True

    End Sub




End Class
