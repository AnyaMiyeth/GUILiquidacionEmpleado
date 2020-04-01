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
    public partial class Empleado_Contratista : Form
    {
        EmpleadoService ServicoEmpleado = new EmpleadoService();
        string Identificacion, Nombre, Apellido = string.Empty;
        decimal HorasTrabajadas, ValorHorasTrabajadas = 0;

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        public Empleado_Contratista()
        {
            InitializeComponent();
        }

        private void Empleado_Contratista_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoService ServicoEmpleado = new EmpleadoService();
                Identificacion = TxtIdentificacion.Text;
                Nombre = TxtNombre.Text;
                Apellido = TxtApellido.Text;
                HorasTrabajadas = Convert.ToDecimal(TxtHorasTrabajadas.Text);
                ValorHorasTrabajadas = Convert.ToDecimal(TxtValorHorasTrabajadas.Text);
                Empleado Empleado = new EmpleadoContratista(Identificacion, Nombre, Apellido, HorasTrabajadas, ValorHorasTrabajadas);
                string Resultado = ServicoEmpleado.Guardar(Empleado);
                MessageBox.Show(Resultado, "Resultado de guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Verifique los datosdigitados: " + ex.Message,"Error en los datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           

        }
    }
}
