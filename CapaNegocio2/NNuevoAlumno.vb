Public Class NNuevoAlumno

    Private Nnuevoalumno As CapaEmpaquetadora2.ENuevoAlumno
    Private DNnuevoalumno As CapaDatos2.DNuevoAlumno 'D es por que se relacion con datos y N porque esta en la capa de negocio'

    Public Function Nagrego(ByVal obj As CapaEmpaquetadora2.ENuevoAlumno) As Integer

        Dim grabonuevoalumno As New CapaDatos2.DNuevoAlumno

        If obj.funNombreA.Length > 0 And obj.funPrimerApellidoA.Length > 0 And obj.funSegundoApellidoA.Length > 0 And obj.funCedulaA = 8 Then

            Return grabonuevoalumno.graboNuevoAlumno(obj) 'graboNuevoAlumno es de la capa de datos'

        Else

   
            Return 0

        End If

    End Function

End Class
