Console.WriteLine("---CALCULO DE DIVISION---");

int cociente = CalcularDivision();

Console.WriteLine("Resultado = " + cociente);

static int CalcularDivision()
{
    try
    {
        Console.WriteLine("Ingrese el dividendo:");
        int dividendo = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el divisor:");
        int divisor = Convert.ToInt32(Console.ReadLine());

        int resultado = dividendo / divisor;
        return resultado;
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Ingreso 0 en el divisor. No es posible dividir en 0");
        Console.WriteLine($"Mensaje para el usuario: {ex.Message}");
        Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
        Console.WriteLine($"Pila de llamadas: {ex.StackTrace}");
        Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
        Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
        throw;
    }
    
}