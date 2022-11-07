using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoSOAForms.ServicioSOA;


namespace ProyectoSOAForms
{
    public partial class Vista : Form
    {
       
        public Vista()
        {
            InitializeComponent();
        }

        private void MostrarPersonas()
        {

            using (ServicioSOA.PersonasSoapClient objeto = new ServicioSOA.PersonasSoapClient())
            {
                //  DataPersona.DataSource = objeto.BuscaRegistro();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            //DataPersona.DataSource = ServicioSOA.PersonasSoapClient

          
        }
    }
}
