using ProyectoMVC.Views;
using ProyectoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;



namespace ProyectoMVC.Controllers
{
    class PersonaController
    {
        private PersonaDatos objetoCD = new PersonaDatos();

        public DataTable MostrarPersonas()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public void InsertarPersona(string nombre, string Apellidos, string Direccion, string Ciudad, string Telefono)
        {

            objetoCD.Insertar(nombre, Apellidos, Direccion, Ciudad, Telefono);
        }

        public void EditarPersona(string nombre, string Apellidos, string Direccion, string Ciudad, string Telefono, string id)
        {
            objetoCD.Editar(nombre, Apellidos, Direccion, Ciudad, Telefono, Convert.ToInt32(id));
        }

        public void EliminarPersona(string id)
        {

            objetoCD.Eliminar(Convert.ToInt32(id));
        }
    }
}
