Module Conexion
    Public cn As ADODB.Connection
    Public rs As ADODB.Recordset

End Module

Function conector(Parametro As String) As String
    Dim Expression As String = "Driver={SQL Server Native Client 11.0};Server=tcp:unitec.database.windows.net,1433;Database=ElectivaProfesionalII;Uid=Yeudiel@unitec;Pwd={Semeolvido+};Encrypt=yes;TrustServerCertificate=no;Connection Timeout=30;"
    Return Expression
End Function