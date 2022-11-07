using System;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CapaNegocio_Personas
    {
        private Capa_Personas objetoCD = new Capa_Personas();

        public DataTable MostrarPersonas() {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPersona ( string nombre,string Apellidos,string Direccion,string Ciudad, string Telefono){

            objetoCD.Insertar(nombre,Apellidos,Direccion,Ciudad,Telefono);
    }

        public void EditarPersona(string nombre, string Apellidos, string Direccion, string Ciudad, string Telefono,string id)
        {
            objetoCD.Editar(nombre, Apellidos, Direccion, Ciudad, Telefono,Convert.ToInt32(id));
        }

        public void EliminarPersona(string id) {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }

    }
}
