int numeroEntero;
Console.WriteLine("Ejercicio 1");
Console.WriteLine("Número entero");
Console.WriteLine("Por favor, ingrese un número entero");
numeroEntero = int.Parse(Console.ReadLine());
{
    if (numeroEntero >= 1)
    {
        Console.WriteLine("numero positivo");
    }

    if (numeroEntero <= -1)
    {
        Console.WriteLine("numero negativo");
    }
    if (numeroEntero == 0)
    {
        Console.WriteLine("cero");

    }


    Console.ReadKey();
    Console.WriteLine(numeroEntero);
}