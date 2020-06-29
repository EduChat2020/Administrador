
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

        If (Application.OpenForms("FormProfesores") Is Nothing) Then
            btnProfesores.BackColor = Color.FromArgb(0, 53, 92)
        End If

        If (Application.OpenForms("FormAOG") Is Nothing) Then
            btnAOG.BackColor = Color.FromArgb(0, 53, 92)
        End If

        If (Application.OpenForms("FormAsignaturas") Is Nothing) Then
            btnAsignaturas.BackColor = Color.FromArgb(0, 53, 92)
        End If

        If (Application.OpenForms("FormGrupos") Is Nothing) Then
            btnGrupos.BackColor = Color.FromArgb(0, 53, 92)
        End If

        If (Application.OpenForms("FormOrientaciones") Is Nothing) Then
            btnOrientaciones.BackColor = Color.FromArgb(0, 53, 92)
        End If



    End Sub
#End Region

#Region "BOTONES MENU"
    Private Sub btnAlumnos_Click_1(sender As Object, e As EventArgs) Handles btnAlumnos.Click
        AbrirFormEnPanel(Of FormAlumnos)()
        btnAlumnos.BackColor = Color.FromArgb(0, 102, 204)
    End Sub

    Private Sub btnProfesores_Click_1(sender As Object, e As EventArgs) Handles btnProfesores.Click
        AbrirFormEnPanel(Of FormProfesores)()
        btnProfesores.BackColor = Color.FromArgb(0, 102, 204)
    End Sub


    Private Sub btnAOG_Click_1(sender As Object, e As EventArgs) Handles btnAOG.Click
        showSubMenu(PanelSubMenuAOG)

    End Sub

    Private Sub btnAsignaturas_Click(sender As Object, e As EventArgs) Handles btnAsignaturas.Click
        AbrirFormEnPanel(Of FormAsignaturas)()
        btnAsignaturas.BackColor = Color.FromArgb(0, 102, 204)
    End Sub

    Private Sub btnOrientaciones_Click(sender As Object, e As EventArgs) Handles btnOrientaciones.Click
        AbrirFormEnPanel(Of FormOrientaciones)()
        btnOrientaciones.BackColor = Color.FromArgb(0, 102, 204)
    End Sub

    Private Sub btnGrupos_Click(sender As Object, e As EventArgs) Handles btnGrupos.Click
        AbrirFormEnPanel(Of FormGrupos)()
        btnGrupos.BackColor = Color.FromArgb(0, 102, 204)
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
        hideSubMenu()
    End Sub

    Private Sub hideSubMenu()
        PanelSubMenuAOG.Visible = False

    End Sub

    Private Sub showSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            hideSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub


End Class
