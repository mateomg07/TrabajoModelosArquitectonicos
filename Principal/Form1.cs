using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapaPresentacion.Vista f = new CapaPresentacion.Vista();
            f.ShowDialog();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProyectoMVC.Views.Vista f = new ProyectoMVC.Views.Vista();
            f.ShowDialog();
          //  this.Hide();
        }
    }
}
