int numero;

Console.Write("Insira um número positivo: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
{
    Console.WriteLine($"\nTabuada do {numero}:");

    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{numero} x {i} = {numero * i}");
    }
}
else
{
    Console.WriteLine("Por favor, insira um número positivo.");
}

Console.Write("Digite Enter para encerrar o programa");
Console.ReadKey();