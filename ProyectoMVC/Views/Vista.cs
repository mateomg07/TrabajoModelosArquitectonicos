using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoMVC.Controllers;
using ProyectoMVC.Models;


namespace ProyectoMVC.Views
{
    public partial class Vista : Form
    {
        PersonaController objetoCN = new PersonaController();
        private string idPersonas = null;
        private bool Editar = false;

        public Vista()
        {
            InitializeComponent();
            // PersonaController ctrl = new PersonaController(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEliminar.Enabled = false;


        }

        private void MostrarPersonas()
        {

            PersonaController objeto = new PersonaController();
            DataPersona.DataSource = objeto.MostrarPersonas();
        }

  



        private void limpiarForm()
        {
            txtApellido.Clear();
            txtDireccion.Text = "";
            txtCiudad.Clear();
            txtTelefono.Clear();
            txtNombre.Clear();

        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (DataPersona.SelectedRows.Count > 0)
            {
                Editar = true;
                txtNombre.Text = DataPersona.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDireccion.Text = DataPersona.CurrentRow.Cells["Direccion"].Value.ToString();
                txtApellido.Text = DataPersona.CurrentRow.Cells["Apellidos"].Value.ToString();
                txtCiudad.Text = DataPersona.CurrentRow.Cells["Ciudad"].Value.ToString();
                txtTelefono.Text = DataPersona.CurrentRow.Cells["Telefono"].Value.ToString();
                idPersonas = DataPersona.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnListar_Click(object sender, EventArgs e)
        {
            MostrarPersonas();
            btnEliminar.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarPersona(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarPersonas();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            //EDITAR
            if (Editar == true)
            {

                try
                {
                    objetoCN.EditarPersona(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtCiudad.Text, txtTelefono.Text, idPersonas);
                    MessageBox.Show("se edito correctamente");
                    MostrarPersonas();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (DataPersona.SelectedRows.Count > 0)
            {
                idPersonas = DataPersona.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarPersona(idPersonas);
                MessageBox.Show("Eliminado correctamente");
                btnEliminar.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }
    }
}
