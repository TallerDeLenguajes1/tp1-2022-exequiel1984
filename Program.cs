

try
{
    Console.WriteLine("Ingrese la base:");
    Double num = Convert.ToDouble(Console.ReadLine());

    Double cuadrado = num * num;


    Console.WriteLine("Cuadrado:" + cuadrado);
    Console.ReadKey();
}
catch (FormatException e)
{
    Console.WriteLine("Valor invalido: " + e.Message);
}