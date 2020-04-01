using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmInicial : Form
    {
        public FrmInicial()
        {
            InitializeComponent();
        }

        private void registrarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrarEmpleado FrmEmpleado = new FrmRegistrarEmpleado();
            FrmEmpleado.MdiParent=this;
            FrmEmpleado.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cconsultarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaEmpleado ConsultaEmpleado = new FrmConsultaEmpleado();
            ConsultaEmpleado.MdiParent = this;
            ConsultaEmpleado.Show();
        }

        private void liquidarNóminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLiquidarEmpleado FrmLiquidacion = new FrmLiquidarEmpleado();
            FrmLiquidacion.Show();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {

        }

        private void registroContratistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado_Contratista FrmContratista = new Empleado_Contratista();
            FrmContratista.MdiParent = this;
            FrmContratista.Show();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
