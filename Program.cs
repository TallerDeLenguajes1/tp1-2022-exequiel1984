namespace RRHH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> listaEmpleados = new List<Empleado>();

            Console.WriteLine("Ingrese la cantidad de empleados a cargar:");

            try
            {
                int CantidadEmpleadosACargar = Convert.ToInt32(Console.ReadLine());         
            }
            catch (FormatException e)
            {
                Console.WriteLine("Ingreso un valor invalido ");
                throw;
            }
        }
    }
}