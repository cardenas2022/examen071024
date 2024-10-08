using examen071024.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen071024.Clases
{
    public class Gerente : EmpleadoBase, ISueldoBonificable, IDescuentoImpuesto
    {
        public override int SueldoBase => 8000;

        public double CalcularBonificacion()
        {
            return 1000;
        }

        public override double CalcularSueldo()
        {
            return SueldoBase + CalcularBonificacion() - DescontarSueldo();
        }

        public double DescontarSueldo()
        {
            return SueldoBase * constanteDescuentos.descuento_1;
        }
    }


    }

