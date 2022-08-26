

try
{
    Console.WriteLine("Ingrese los kilometros:");
    int kilometros = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese los litros:");
    int litros = Convert.ToInt32(Console.ReadLine());



    int kilometrosPorLitro = kilometros / litros;


    Console.WriteLine("Kilometros por litro:" + kilometrosPorLitro);

}
catch (DivideByZeroException e)
{
    Console.WriteLine("No se puede dividir en 0 " + e.Message);
}
catch (FormatException e)
{
    Console.WriteLine("metiste una letra " + e.Message);
}