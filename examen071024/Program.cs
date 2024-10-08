// EXAMEN DE C# 7/10/2024

using examen071024.Clases;


List<EmpleadoBase> empleados = new List<EmpleadoBase>();

Gerente gerente = new Gerente
{
    IdEmpleado = 1,
    Nombre = "Hugo Torrico",
    Puesto = "Gerente Desarrollo"
};

Desarrollador desarollador = new Desarrollador
{
    IdEmpleado = 2,
    Nombre = "José Cárdenas",
    Puesto = "Desarrollador Senior",
};

GerenteRRHH rrhh = new GerenteRRHH
{
    IdEmpleado = 3,
    Nombre = "Juan Perez",
    Puesto = "Gerente RRHH"
};

Consultas consultor = new Consultas
{
    IdEmpleado = 4,
    Nombre = "Felipe Cantuarias",
    Puesto = "Asistente informático"
};

//Adicionando a la lista de empleados
empleados.Add(gerente);
empleados.Add(desarollador);
empleados.Add(rrhh);
empleados.Add(consultor);

Empresa empresa = new Empresa(empleados);

void IngresarEmpleado(Empresa empresa)
{
    Console.WriteLine("******TIPOS DE EMPLEADOS EN LA EMPRESA********");
    Console.WriteLine("Seleccione:");
    Console.WriteLine("1. Gerente");
    Console.WriteLine("2. Gerente de RRHH");
    Console.WriteLine("3. Desarrollador");
    Console.WriteLine("4. Consultor externo");
    Console.WriteLine("***************************************");

    int tipoEmpleado = Convert.ToInt32(Console.ReadLine());

    EmpleadoBase nuevoEmpleado = null;

    switch (tipoEmpleado)
    {
        case 1:
            nuevoEmpleado = new Gerente();
            break;
        case 2:
            nuevoEmpleado = new GerenteRRHH();
            break;
        case 3:
            nuevoEmpleado = new Desarrollador();
            break;
        case 4:
            nuevoEmpleado = new Consultas();
            break;
        default:
            Console.WriteLine("Seleccione correctamente el tipo de empleado");
            return;
    }

    Console.Write("Ingrese el ID del empleado: ");
    nuevoEmpleado.IdEmpleado = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingrese el nombre del empleado: ");
    nuevoEmpleado.Nombre = Console.ReadLine();

    Console.Write("Ingrese el puesto del empleado: ");
    nuevoEmpleado.Puesto = Console.ReadLine();

    empresa.AgregarEmpleado(nuevoEmpleado);
}

int opcion = 0;
do
{
    Console.WriteLine("********BIENVENIDO AL SISTEMA**********");
    Console.WriteLine("Elige algunas opciones del menú:");
    Console.WriteLine("1.- Ingresar nuevo empleado");
    Console.WriteLine("2.- Mostrar Lista de empleados");
    Console.WriteLine("3.- Salir del sistema");
    Console.WriteLine("***************************************");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            IngresarEmpleado(empresa);
            break;
        case 2:
            empresa.MostrarListadoEmpleados();
            break;
        case 3:
            Console.WriteLine("Saliste del sistema...");
            break;
        default:
            Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
            break;
    }
} while (opcion != 3);


Console.Read();
