int numero;

while (true)
{
    Console.Write("Insira um número inteiro positivo: ");
    string entrada = Console.ReadLine();

    if (int.TryParse(entrada, out numero) && numero >= 0)
    {
        break; 
    }
    else
    {
        Console.WriteLine("Erro: Por favor, insira um número inteiro positivo.");
    }
}

long fatorial = 1;
for (int i = 1; i <= numero; i++)
{
    fatorial *= i; 
}

Console.WriteLine($"\nO fatorial de {numero} é: {fatorial}");

Console.Write("Digite Enter para encerrar o programa");
Console.ReadKey();
