int numero;

while (true)
{
    Console.Write("Insira um número inteiro positivo: ");
    string entrada = Console.ReadLine();

    
    if (int.TryParse(entrada, out numero) && numero > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro positivo.");
    }
}

Console.WriteLine($"\nNúmeros ímpares de 1 até {numero}:");

for (int i = 1; i <= numero; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}

Console.Write("Digite Enter para encerrar o programa");
Console.ReadKey();
