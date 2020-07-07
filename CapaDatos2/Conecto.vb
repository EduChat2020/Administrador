Imports System.Data.Odbc


Public Class Conecto
    Public cn As OdbcConnection


    Sub New()
        cn = New OdbcConnection("UID=root" &
            ";PWD=root" &
            ";DATABASE= educhat" &
            ";SERVER=localhost" &
            ";DRIVER={MySQL ODBC 8.0 ANSI Driver};")

    End Sub
End Class
