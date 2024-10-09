Console.WriteLine("Digite o número de um mês para saber sua estação: ");
int numeroEscolhido = int.Parse(Console.ReadLine());

string v = "Verão";
string o = "Outono";
string p = "Primavera";
string i = "Inverno";

switch (numeroEscolhido)
{
    case 1:
        Console.WriteLine($"Você escolheu o mês de Janeiro a estação é: {v}");
        break;

    case 2:
        Console.WriteLine($"Você escolheu o mês de Fevereiro a estação é: {v}");
        break;

    case 3:
        Console.WriteLine($"Você escolheu o mês de Março a estação é: {o}");
        break;
    case 4:
        Console.WriteLine($"Você escolheu o mês de Abril a estação é: {o}");
        break;

    case 5:
        Console.WriteLine($"Você escolheu o mês de Maio a estação é: {o}");
        break;

    case 6:
        Console.WriteLine($"Você escolheu o mês de Junho a estação é: {i}");
        break;

    case 7:
        Console.WriteLine($"Você escolheu o mês de Julho a estação é: {i}");
        break;

    case 8:
        Console.WriteLine($"Você escolheu o mês de Agosto a estação é: {i}");
        break;

    case 9:
        Console.WriteLine($"Você escolheu o mês de Setembro a estação é: {p}");
        break;

    case 10:
        Console.WriteLine($"Você escolheu o mês de Outubro a estação é: {p}");
        break;

    case 11:
        Console.WriteLine($"Você escolheu o mês de Novembro a estação é: {p}");
        break;

    case 12:
        Console.WriteLine($"Você escolheu o mês de Dezembro a estação é: {v}");
        break;

    default:
        Console.WriteLine("O número escolhido não é um mês");
        break;
}
Console.WriteLine("Pressione Enter para ecerrar");
Console.ReadKey();