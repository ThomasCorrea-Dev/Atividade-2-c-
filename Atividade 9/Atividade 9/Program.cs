string[] diasDaSemana = new string[]
{
    "segunda-feira",
    "terça-feira",
    "quarta-feira",
    "quinta-feira",
    "sexta-feira",
    "sabado",
    "domingo"
};

string[] tarefas = new string[7];

for (int i = 0; i < 7; i++)
{
    Console.Write($"tarefas para {diasDaSemana[i]}: ");
    tarefas[i] = Console.ReadLine();
}

Console.Write("Pressione Enter para encerrar");
Console.ReadKey();