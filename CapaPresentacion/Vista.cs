using System;
using System.Windows.Forms;
using CapaNegocio;
//using CapaPresentacion.Controllers;

namespace CapaPresentacion
{
    public partial class Vista : Form
    {
        CapaNegocio_Personas objetoCN = new CapaNegocio_Personas();
        private string idPersonas=null;
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

        private void MostrarPersonas() {

            CapaNegocio_Personas objeto = new CapaNegocio_Personas();
            DataPersona.DataSource = objeto.MostrarPersonas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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

        private void btnEditar_Click(object sender, EventArgs e)
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

        private void limpiarForm() {
            txtApellido.Clear();
            txtDireccion.Text = "";
            txtCiudad.Clear();
            txtTelefono.Clear();
            txtNombre.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DataPersona.SelectedRows.Count > 0)
            {
                idPersonas = DataPersona.CurrentRow.Cells["Id"].Value.ToString();
                objetoCN.EliminarPersona(idPersonas);
                MessageBox.Show("Eliminado correctamente");
                btnEliminar.Enabled = false;
            }
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MostrarPersonas();
            btnEliminar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
