using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;
namespace Presentacion
{
    public partial class Consultar : Form
    {

        EmpleadoService Servicio = new EmpleadoService();
        public Consultar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Todos")
            {
                dataGridView1.DataSource = Servicio.Consultar();
            }
            else if (true)
            {

            }

        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }
    }
}
