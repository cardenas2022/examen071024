using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen071024.Clases
{
    public class Empresa
    {
        public List<EmpleadoBase> empleados;
        public Empresa(List<EmpleadoBase> empleadosIniciales)
        {
            empleados = empleadosIniciales;
        }
        public void AgregarEmpleado(EmpleadoBase empleado)
        {
            empleados.Add(empleado);
            Console.WriteLine($"Empleado {empleado.Nombre} agregado a la empresa.");
        }
        public void MostrarListadoEmpleados()
        {
            Console.WriteLine("\nListado de Empleados:");
            foreach (var empleado in empleados)
            {
                empleado.MostrarDetalles();
            }

            Console.WriteLine($"\nTotal de Empleados: {empleados.Count}");
            Console.WriteLine($"Suma Total de Sueldos: {CalcularSumaSueldos()}");
        }
        public double CalcularSumaSueldos()
        {
            double totalSueldo = 0;
            foreach (var empleado in empleados)
            {
                totalSueldo += empleado.CalcularSueldo();
            }
            return totalSueldo;
        }
    }
}
