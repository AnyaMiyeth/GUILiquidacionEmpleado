using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EmpleadoPlanta: Empleado
    {

        const decimal PORCENTAJE_PENSION = 0.04m;
        const decimal PORCENTAJE_SALUD = 0.04m;
        const decimal AUXILIOTRANSPORTE = 83140m;
        const decimal SALARIOMINIMOLEGALVIGENTE = 737717m;

        private readonly decimal TopeAuxilioTransporte=2*SALARIOMINIMOLEGALVIGENTE;

        public decimal Sueldo{ get; set; }
       

        public decimal AuxilioTransporte
        {
            get
            {
                return Sueldo <= TopeAuxilioTransporte ? AUXILIOTRANSPORTE : 0m;
            }
        }

        public decimal AportesSalud
        {
            get
            {
                return Sueldo * PORCENTAJE_SALUD;
            }
        }

        public decimal AportesPension
        {
            get
            {
                return Sueldo * PORCENTAJE_PENSION;
            }
        }


        public override decimal Salario
        {
            get
            {
                return Sueldo -AportesSalud-AportesPension + AuxilioTransporte;
            }
        }
        


        public EmpleadoPlanta()
        {


           

        }


        public EmpleadoPlanta(string identificacion, string nombre, string apellido, decimal sueldo) 
        {

            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Sueldo = sueldo;

        }
        //public override string ToString()
        //{


        //    return ($" El salario de {NombreCompleto} Sueldo {Sueldo:N2}  Salud {AportesSalud:N2} Pensión {AportesPension:N2}  Auxilio de transpor {AuxilioTransporte:N2} Salario {Salario:N2} + ");
        //}

    }
}
