using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LiquidacionNominaService
    {
        public Liquidacion liquidacionNomina { get; set; }

        public List<LiquidacionDto> Consultar()
        {
           List<LiquidacionDto> LiquidacionesMapeadas = new List<LiquidacionDto>();
          
           List<Liquidacion> Liquidaciones = Datos.LiquidacionesNominas.Consultar();
            foreach (var item in Liquidaciones)
            {
                LiquidacionesMapeadas.Add(MapearDto(item));
            }
            return LiquidacionesMapeadas;
        }

        public LiquidacionDto MapearDto(Liquidacion itemLiquidacion)
        {
            LiquidacionDto LiqidacionMapeada = new LiquidacionDto();
            LiqidacionMapeada.Año = itemLiquidacion.Año;
            LiqidacionMapeada.Periodo = itemLiquidacion.Periodo;
            LiqidacionMapeada.Identificacion = itemLiquidacion.Empleado.Identificacion;
            LiqidacionMapeada.Nombre = itemLiquidacion.Empleado.Nombre;
            LiqidacionMapeada.Apellido = itemLiquidacion.Empleado.Apellido;
            LiqidacionMapeada.Salario = itemLiquidacion.Empleado.Salario;
            return LiqidacionMapeada;
        }



        public Liquidacion Liquidar(string año, string periodo, Empleado empleado)
        {
            liquidacionNomina = new Liquidacion(año, periodo, empleado);
            return liquidacionNomina;
        }



        public List<Liquidacion> LiquidarGeneral(string año, string periodo, List<Empleado> empleados)
        {
            List<Liquidacion> Liquidaciones = new List<Liquidacion>();

            foreach (var item in empleados)
            {
                Liquidaciones.Add(Liquidar(año, periodo, item));
            }

            return Liquidaciones;
        }



        public string Guardar(string año, string periodo, Empleado empleado)
        {
            liquidacionNomina = new Liquidacion(año, periodo, empleado);

            if (Datos.LiquidacionesNominas.Buscar(liquidacionNomina) == null)
            {
                Datos.LiquidacionesNominas.Guardar(liquidacionNomina);
                return "Se registró la liquidación de la Nómina al empleado " + liquidacionNomina.Empleado.Identificacion;
            }
            else
            {
                return $"La liquidación al empleado {liquidacionNomina.Empleado.Identificacion} ya fue registrada!!!";
            }
        }


        public List<string> Guardar(string año, string periodo, List<Empleado> empleados)
        {

            List<string> resultado = new List<string>();
            foreach (var item in empleados)
            {
                resultado.Add(Guardar(año, periodo, item));
            }
            return resultado;

        }






    }

    public class LiquidacionDto
    {
        public string Año { get; set; }
        public string Periodo { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public virtual decimal Salario { get; set; }

    }


}
