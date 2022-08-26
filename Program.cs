

try
{
    Console.WriteLine("Ingrese el dividendo:");
    int dividendo = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingrese el divisor:");
    int divisor = Convert.ToInt32(Console.ReadLine());



    int cociente = dividendo / divisor;


    Console.WriteLine("Resultado:" + cociente);

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}