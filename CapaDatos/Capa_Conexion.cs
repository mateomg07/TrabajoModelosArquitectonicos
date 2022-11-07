using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class Capa_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=C-MATEO\\SQLSERVER2014;DataBase= Proyecto;Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
