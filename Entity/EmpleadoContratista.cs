using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class EmpleadoContratista:Empleado
    {
        
        public decimal HorasTrabajadas { get; set; }
        public decimal ValorHorasTrabajadas { get; set; }

        public override string Tipo
        {
            get
            {
                return "Contratista";
            }
        }


        public override decimal Salario
        {
            get
            {
                return HorasTrabajadas * ValorHorasTrabajadas;
            }
        }

       
        public EmpleadoContratista(string identificacion, string nombre, string apellido, decimal horasTrabajadas, decimal valorHorasTrabajadas): base(identificacion, nombre, apellido)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            HorasTrabajadas = horasTrabajadas;
            ValorHorasTrabajadas = valorHorasTrabajadas;
            Tipo = "Contratista";
        }

        public EmpleadoContratista()
        {
        }



        //public override string ToString()
        //{
        //    return ($" Detalle de Liquidacion: Horas Trabajadas {HorasTrabajadas:N2} y Valor Hora {ValorHorasTrabajadas:N2}Salario {Salario:N2}  ");
        //}

    }
}
