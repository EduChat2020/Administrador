Public Class ENuevoAlumno

    Private nombre As String
    Private primer_apellido As String
    Private segundo_apellido As String
    Private cedula As String

    Public Property funNombreA() As String

        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property

    Public Property funPrimerApellidoA() As String

        Get
            Return primer_apellido
        End Get
        Set(ByVal value As String)
            primer_apellido = value
        End Set
    End Property

    Public Property funSegundoApellidoA() As String

        Get
            Return segundo_apellido
        End Get
        Set(ByVal value As String)
            segundo_apellido = value
        End Set
    End Property

    Public Property funCedulaA() As String

        Get
            Return cedula
        End Get
        Set(ByVal value As String)
            cedula = value
        End Set
    End Property



End Class
