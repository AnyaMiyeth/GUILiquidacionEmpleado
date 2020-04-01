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
    public partial class FrmLiquidarEmpleado : Form
    {
        LiquidacionNominaService ServicioLiquidacion = new LiquidacionNominaService();
        EmpleadoService ServicioEmpleado = new EmpleadoService();

        string vigencia;
        string periodo;
        List<Empleado> empleados;
        List<LiquidacionDto> liquidaciones;
        


        public FrmLiquidarEmpleado()
        {
            InitializeComponent();
        }

        private void BtnLiquidar_Click(object sender, EventArgs e)
        {
            vigencia = TxtVigencia.Text;
            periodo = CmbPeriodo.Text;
            List<string> resultados = new List<string>();

            if (string.IsNullOrEmpty(vigencia) || string.IsNullOrEmpty(periodo))
            {
                MessageBox.Show("No ha digitado la vigencia o el periodo a liquidar");
            }
            else
            {
                string mensaje;
                empleados = ServicioEmpleado.Consultar();
                resultados = ServicioLiquidacion.Guardar(vigencia, periodo, empleados);
                liquidaciones = ServicioLiquidacion.Consultar();
                GridLiquidacion.DataSource = null;
                GridLiquidacion.DataSource = liquidaciones;
                GridLiquidacion.Refresh();
                ConvertirToString(resultados);
                mensaje = ConvertirToString(resultados);
                MessageBox.Show(mensaje);

            }

        }

        private string ConvertirToString(List<string> resultados)
        {
            string mensaje=string.Empty;
            foreach (var item in resultados)
            {
                mensaje += item + "\n";
            }
            return mensaje;
        }
    }
}
