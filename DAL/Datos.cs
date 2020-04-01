using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Datos
    {
        public static LiquidacionRepository LiquidacionesNominas = new LiquidacionRepository();
        public static EmpleadoRepository Empleado = new EmpleadoRepository();
        
    }
}
