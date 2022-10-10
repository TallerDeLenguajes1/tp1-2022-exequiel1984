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
                    Empleado NuevoEmpleado = new Empleado();

                    Console.WriteLine("Ingrese el apellido del empleado: ");
                    NuevoEmpleado.DataPersonal.Apellido = Console.ReadLine();


            
                    listaEmpleados.add(NuevoEmpleado);
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
            foreach (Emple item in listaEmpleados)
            {
                Console.WriteLine("Apellido: " + Emple.DataPersonal.Apellido);
            }
        }
    }
}