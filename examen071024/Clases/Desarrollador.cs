using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen071024.Clases
{
    public class Desarrollador : EmpleadoBase
    {
        public override int SueldoBase => 3000;

        public override double CalcularSueldo()
        {
            return SueldoBase;
        }
    }
}
