
Console.WriteLine("Olá!");

bool isValid = false;
do
{
	MostrarOpcoes();

	string opcaoSelecionada = Console.ReadLine();
	isValid = IsOpcaoValida(opcaoSelecionada.ToUpper());

	if (isValid)
		Console.WriteLine($"Opção Selecionada: {opcaoSelecionada}");

} while (!isValid);

static void MostrarOpcoes()
{
	Console.WriteLine("");
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine("O que deseja fazer?");
	Console.ResetColor();

	Console.WriteLine("");

	Console.WriteLine("[V] Ver todas tarefas");
	Console.WriteLine("[A] Adicionar tarefa");
	Console.WriteLine("[E] Excluir tarefa");
	Console.WriteLine("[S] Sair");
	Console.WriteLine("");
}

static bool IsOpcaoValida(string opcaoSelecionada)
{
	var opcoes = new List<string>() { "V", "A", "E", "S" };

	return opcoes.IndexOf(opcaoSelecionada) >= 0;
}

static int Factorial(int number)
{
	int result = 0;
	if (number == 0 || number == 1) return 1; 

	for (int i = 1; number > i; i++)
	{
		result *= i;
	}
}

Console.ReadKey();
