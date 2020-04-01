using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LiquidacionRepository
    {
        private List<Liquidacion> LiquidacionesNomina;

        public LiquidacionRepository()
        {
            LiquidacionesNomina = new List<Liquidacion>(); 
        }

        public void Guardar(Liquidacion liquidacionNomina)
        {
            LiquidacionesNomina.Add(liquidacionNomina);
        }

        public void Eliminar(Liquidacion liquidacionNomina)
        {
            LiquidacionesNomina.Remove(liquidacionNomina);
        }

        public List<Liquidacion> Consultar()
        {
            return LiquidacionesNomina;
        }

        public Liquidacion Buscar(Liquidacion liquidacionNomina)
        {
            foreach (var item in LiquidacionesNomina)
            {
                if (EsEncontrado(item, liquidacionNomina))
                {
                    return item;
                }
            }
            return null;
        }

        private bool EsEncontrado(Liquidacion item, Liquidacion liquidacionNomina)
        {
            return item.Año == liquidacionNomina.Año 
                && item.Periodo == liquidacionNomina.Periodo 
                && item.Empleado.Identificacion == liquidacionNomina.Empleado.Identificacion;
        }

        
    }
}
