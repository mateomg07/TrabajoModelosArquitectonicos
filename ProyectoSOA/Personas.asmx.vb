Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://Localhost/")>
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Personas
    Inherits System.Web.Services.WebService
    <WebMethod()>
    Public Function BuscaRegistro() As DataSet

        Dim ds As New DataSet

        Conexiones.AbrirConexion()

        Conexiones.adaptador = New SqlClient.SqlDataAdapter("select * from personas ", Conexiones.Cnn)
        Conexiones.adaptador.Fill(ds)

        Return ds
    End Function

    <WebMethod()>
    Public Function NuevoRegistro(ByVal NOMBRE As String, ByVal APELLIDO As String, ByVal DIRECCION As String, ByVal CIUDAD As String, ByVal TELEFONO As String)
        Conexiones.AbrirConexion()
        Conexiones.Cnn.Open()

        Conexiones.comando = New SqlClient.SqlCommand("insert into personas(nombre,apellido,Direccion,ciudad,Telefono) values('" & NOMBRE & "','" & APELLIDO & "','" & DIRECCION & "','" & CIUDAD & "','" & TELEFONO & "')", Conexiones.Cnn)
        Conexiones.comando.ExecuteNonQuery()

        Conexiones.Cnn.Close()
        Return True
    End Function


    <WebMethod()>
    Public Function ActualizarRegistro(ByVal ID As Integer, ByVal NOMBRE As String, ByVal APELLIDO As String, ByVal DIRECCION As String, ByVal CIUDAD As String, ByVal TELEFONO As String)
        Conexiones.AbrirConexion()
        Conexiones.Cnn.Open()

        Conexiones.comando = New SqlClient.SqlCommand("update personas set NOMBRE='" & NOMBRE & "', APELLIDO='" & APELLIDO & "', DIRECCION='" & DIRECCION & "', CIUDAD='" & CIUDAD & "',telefono='" & TELEFONO & "' where ID=" & ID, Conexiones.Cnn)
        Conexiones.comando.ExecuteNonQuery()

        Conexiones.Cnn.Close()
        Return True
    End Function

    <WebMethod()>
    Public Function EliminaRegistro(ByVal ID As Integer)
        Conexiones.AbrirConexion()
        Conexiones.Cnn.Open()

        Conexiones.comando = New SqlClient.SqlCommand("delete from personas where ID=" & ID, Conexiones.Cnn)
        Conexiones.comando.ExecuteNonQuery()

        Conexiones.Cnn.Close()
        Return True
    End Function

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

End Class