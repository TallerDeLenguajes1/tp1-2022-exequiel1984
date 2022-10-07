Console.WriteLine("---CALCULO DE KILOMETROS POR LITRO---");

int kilometrosPorLitro = CalcularKilometrosPorLitros();

Console.WriteLine("Kilometros por litro: " + kilometrosPorLitro);

Console.WriteLine("FIN");


static int CalcularKilometrosPorLitros()
{
    try
    {
       Console.WriteLine("Ingrese los kilometros:");
        int kilometros = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese los litros:");
        int litros = Convert.ToInt32(Console.ReadLine());
        return kilometros / litros; 
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("No se puede dividir en 0");
        Console.WriteLine($"Mensaje para el usuario: {ex.Message}");
        Console.WriteLine($"Nombre de la fuente del error: {ex.Source}");
        Console.WriteLine($"Pila de llamadas: {ex.StackTrace}");
        Console.WriteLine($"Nombre que lanza la excepcion: {ex.TargetSite}");
        Console.WriteLine($"Diccionario con info adicional: {ex.Data}");
        throw;
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