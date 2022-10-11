namespace RRHH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            CargarListaEmpleados(listaEmpleados);

            MostrarListaEmpleados(listaEmpleados);
        }

        private static void CargarListaEmpleados(List<Empleado> listaEmpleados)
        {

            Console.WriteLine("Ingrese la cantidad de empleados a cargar:");

            try
            {
                int CantidadEmpleadosACargar = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < CantidadEmpleadosACargar; i++)
                {
                    Console.WriteLine($"---CARGA EMPLEADO {i+1} ---");
                    
                    var DatospersonalesEmpleadoNuevo = new DatosPersonales();
                    Console.WriteLine("Ingrese el apellido:");
                    DatospersonalesEmpleadoNuevo.Apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre:");
                    DatospersonalesEmpleadoNuevo.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese fecha de nacimiento:");
                    DatospersonalesEmpleadoNuevo.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    
                    Console.WriteLine("Ingrese el estado civil (Soltero/Casado/Divorciado):");
                    DatospersonalesEmpleadoNuevo.EstadoCivil = Console.ReadLine();
                    if (DatospersonalesEmpleadoNuevo.EstadoCivil == "Casado")
                    {
                        Console.WriteLine("Ingrese la cantidad de hijos:");
                        DatospersonalesEmpleadoNuevo.CantidadHijos = Convert.ToInt32(Console.ReadLine());
                    }
                    if (DatospersonalesEmpleadoNuevo.EstadoCivil == "Divorciado")
                    {
                        Console.WriteLine("Ingrese la fecha del divorcio:");
                        DatospersonalesEmpleadoNuevo.FechaDivorcio = Convert.ToDateTime(Console.ReadLine());
                    }

                    


                    var DatosProfesionalesEmpleadoNuevo = new DatosProfesionales();
                    Console.WriteLine("Ingrese fecha de ingreso: ");
                    DatosProfesionalesEmpleadoNuevo.FechaIngreso = Convert.ToDateTime(Console.ReadLine());

                    Empleado NuevoEmpleado = new Empleado(DatospersonalesEmpleadoNuevo, DatosProfesionalesEmpleadoNuevo);

                    listaEmpleados.Add(NuevoEmpleado);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Ingreso un valor invalido ");
                Console.WriteLine($"Mensaje para el usuario: {ex.Message}");
                Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
                Console.WriteLine($"Pila de llamadas: {ex.StackTrace}");
                Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
                Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
                throw;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Ingreso un numero demasiado grande");
                Console.WriteLine($"Mensaje para el usuario: {ex.Message}");
                Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
                Console.WriteLine($"Pila de llamadas: {ex.StackTrace}");
                Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
                Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
            }        
        }

        private static void MostrarListaEmpleados(List<Empleado> listaEmpleados)
        {
            Console.WriteLine("\n---LISTADO DE EMPLEADOS---");
            foreach (var empleado in listaEmpleados)
            {
                empleado.MostrarEmpleado();
            }
        }
    }
}