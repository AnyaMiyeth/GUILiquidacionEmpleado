using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUINomina
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void sairDeAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void empladoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void empleadoContratistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleadoContratista FrmContraista = new FrmEmpleadoContratista();
            FrmContraista.MdiParent = this;
            FrmContraista.Show();
        }
    }
}
