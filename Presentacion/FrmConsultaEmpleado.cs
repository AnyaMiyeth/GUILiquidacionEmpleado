using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace Presentacion
{
    public partial class FrmConsultaEmpleado : Form
    {

        EmpleadoService Servico = new EmpleadoService();
        IReceptor FrmReceptor;
        public FrmConsultaEmpleado()
        {
            InitializeComponent();
        }
        public FrmConsultaEmpleado(IReceptor frmReceptor)
        {
            InitializeComponent();
            FrmReceptor = frmReceptor;
        }
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            MostrarDatos(comboBox1.Text);

        }

        private void MostrarDatos(string tipo) {

            if (tipo == "Contratista") { GridEmpleado.DataSource = null;  GridEmpleado.DataSource = Servico.Consultar(); }
            else if (tipo == "Planta") { GridEmpleado.DataSource = null; GridEmpleado.DataSource = Servico.Consultar(tipo); }
            else if (tipo =="Todos") { GridEmpleado.DataSource = null; GridEmpleado.DataSource = Servico.Consultar(tipo); }

        }

        private void GridEmpleado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FrmReceptor != null)
            {
                Empleado empleado = (Empleado)GridEmpleado.CurrentRow.DataBoundItem;
                FrmReceptor.Recibir(empleado);
                this.Hide();
            }
        }

        private void GridEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
