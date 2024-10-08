using examen071024.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen071024.Clases
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public abstract int SueldoBase { get; }

        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }

        public string Puesto { get; set; }

        public abstract double CalcularSueldo();


        public virtual void MostrarDetalles()
        {
            Console.WriteLine(Nombre);
            Console.WriteLine(IdEmpleado);
            Console.WriteLine(Puesto);
            Console.WriteLine(SueldoBase);
        }
    }
}
