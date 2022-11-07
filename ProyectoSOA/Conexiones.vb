Imports System.Data.SqlClient
Imports System.Web
Public Class Conexiones
    Implements IHttpModule

    Public Shared adaptador As SqlClient.SqlDataAdapter
    Public Shared comando As SqlClient.SqlCommand
    Public Shared Cnn As SqlClient.SqlConnection

    Private WithEvents _context As HttpApplication

    ''' <summary>
    '''  You will need to configure this module in the Web.config file of your
    '''  web and register it with IIS before being able to use it. For more information
    '''  see the following link: https://go.microsoft.com/?linkid=8101007
    ''' </summary>
#Region "IHttpModule Members"

    Public Sub Dispose() Implements IHttpModule.Dispose

        ' Clean-up code here

    End Sub

    Public Sub Init(ByVal context As HttpApplication) Implements IHttpModule.Init
        _context = context
    End Sub

#End Region

    Public Shared Sub AbrirConexion()

        ' Handles the LogRequest event to provide a custom logging 
        ' implementation for it

        Cnn = New SqlConnection("Server=C-MATEO\\SQLSERVER2014;DataBase= Proyecto;Integrated Security=true")

    End Sub
End Class
