using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Liquidacion
        
    {
        public string Año { get; set; }
        public string Periodo { get; set; }
        public Empleado Empleado { get; set; }
       

        public Liquidacion(string año, string periodo, Empleado empleado)
        {
            Año = año;
            Periodo = periodo;
            Empleado = empleado;
        }
        public Liquidacion()
        {
            
        }
        

    }
}
