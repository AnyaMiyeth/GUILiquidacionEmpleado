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
    public partial class FrmRegistrarEmpleado : Form, IReceptor
    {
        EmpleadoService Servicio = new EmpleadoService();
        Empleado _empleado;
        public FrmRegistrarEmpleado()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string Identificacion, Nombre, Apellido = string.Empty;
            decimal Sueldo;

            try
            {
                
                Identificacion = TxtIdentificacion.Text;
                Nombre = TxtNombre.Text;
                Apellido = TxtApellido.Text;
                Sueldo = Convert.ToDecimal(TxtSueldo.Text);
                Empleado Trabajador = new EmpleadoPlanta(Identificacion,Nombre,Apellido,Sueldo);
                string Resultado = Servicio.Guardar(Trabajador);
                MessageBox.Show(Resultado, "Resultado de guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Limpiar();
                EmpleadoPlanta em= Servicio.Consultar(Trabajador) as EmpleadoPlanta;
                TxtSueldo.Text = em.Sueldo.ToString();
                
            }
            catch (Exception ex )
            {

                MessageBox.Show("Verifique los datos digitados " + ex.Message, "Resultado de guardar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmConsultaEmpleado frmConsulta = new FrmConsultaEmpleado(this);
            frmConsulta.Show();
        }

        public void Recibir(EmpleadoPlanta empleado)
        {
            if (empleado != null)
            {
                _empleado = empleado;
                TxtNombre.Text = empleado.Nombre;
                TxtApellido.Text = empleado.Apellido;
                TxtIdentificacion.Text = empleado.Identificacion;
                TxtSueldo.Text = Convert.ToString(empleado.Sueldo);
                
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (_empleado == null)
            {
                MessageBox.Show("No ha seleccionado ningún empleado","Eliminar Empleado",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
               string resultado= Servicio.Eliminar(_empleado);
                MessageBox.Show(resultado, "Eliminar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Limpiar();
            }
        }

        private void Limpiar()
        {
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtIdentificacion.Text = "";
            TxtSueldo.Text = "";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void TxtNombre_Validated(object sender, System.EventArgs e)
        {
            if (IsNameValid())
            {
                // Clear the error, if any, in the error provider.
                errorProvider1.SetError(this.TxtNombre, String.Empty);
            }
            else
            {
                // Set the error if the name is not valid.
                errorProvider1.SetError(this.TxtNombre, "Name is required.");
                
            }
        }
        // Functions to verify data.
        private bool IsNameValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (TxtNombre.Text.Length > 0);
        }

        public void Recibir(Empleado empleado)
        {
            throw new NotImplementedException();
        }
    }
}
