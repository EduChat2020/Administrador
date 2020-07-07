Imports System.Data.Odbc
Public Class DNuevoAlumno


    Public Con As Conecto = New Conecto  'DEFINE UN OBJETO DEL TIPO DE LA CLASE QUE CONECTA CON MYSQL

    Public Function graboNuevoAlumno(ByVal nuevoalumno As CapaEmpaquetadora2.ENuevoAlumno) As Integer


        Try
            Try
                'UTILIZO UN ODBCOMMAND
                'LLAMA A UN PROCEDIMIENTO DE MYSQL 

                Dim cmd As OdbcCommand = New OdbcCommand("{call nuevo_alumno (?,?,?,?,?)}", Con.cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@CedulaA", nuevoalumno.funCedulaA)
                cmd.Parameters.AddWithValue("@NombreA", nuevoalumno.funNombreA)
                cmd.Parameters.AddWithValue("@PApellidoA", nuevoalumno.funPrimerApellidoA) ' CARGO LOS PARÁMETROS POSICIONALES QUE ESPERA EL PROCEDIMIENTO MYSQL
                cmd.Parameters.AddWithValue("@SApellidoA", nuevoalumno.funSegundoApellidoA)
                cmd.Parameters.AddWithValue("@tipo", 1)   'para saber el tipo de procedimiento que tiene que hacer la BD



                Con.cn.Open() 'ABRO LA CONECCIÓN


                Dim dr As OdbcDataReader = cmd.ExecuteReader() 'LEO DE MYSQL Y CARGO UN DATA READER'
                dr.Read()
               

                dr.Close()

            Catch exx As OdbcException
                MsgBox(exx.Message)

                Return 0
            Finally
                Con.cn.Close()
            End Try


        Catch ex As Exception
            MsgBox("error en el primer catch")

        End Try

    End Function


End Class
