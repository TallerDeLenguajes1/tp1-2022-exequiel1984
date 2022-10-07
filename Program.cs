int cuadrado = CalculoCuadrado();
Console.WriteLine($"El cuadrado es {cuadrado}");



static int CalculoCuadrado()
{
    
    try
    {
        Console.WriteLine("Ingrese un numero entero");
        int numero = Int32.Parse(Console.ReadLine());
        return numero * numero;   
    }
    catch(FormatException ex)
    {
        Console.WriteLine("Ingreso un valor invalido");
        Console.WriteLine($"Mensaje para el usuario: {ex.Message}");
        Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
        Console.WriteLine($"Pila de llamadas: {ex.StackTrace}");
        Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
        Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
        throw;
    }
    catch(OverflowException ex)
    {
        Console.WriteLine("Ingreso un numero demasiado grande ");
        Console.WriteLine($"Mensaje para el usuario: {ex.Message}");
        Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
        Console.WriteLine($"Pila de llamadas: {ex.StackTrace}");
        Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
        Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
        throw;
    }
    finally
    {
        Console.WriteLine("GAME OVER");
    }
}