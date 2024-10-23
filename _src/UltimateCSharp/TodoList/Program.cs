
public class Program
{
	private List<string> _tarefas { get; set; } = new List<string>();

	public static void Main(string[] args)
	{
		var tarefas = new List<string>();
		Console.WriteLine("Olá!");

		string opcao = string.Empty;	
		do
		{
			MostrarOpcoes();

			opcao = Console.ReadLine().ToUpper();

			switch (opcao)
			{
				case "V":
				case "v":
					ListarTarefas(tarefas);
					break;
				case "A":
				case "a":
					var descricao = string.Empty;
					do
					{
						Console.WriteLine("Descrição da Tarefa:");
						descricao = Console.ReadLine().Trim();

						if (tarefas.IndexOf(descricao.ToLower()) >= 0)
						{
							Console.WriteLine("Tarefa já existe");
							break;
						}
						
						if(!string.IsNullOrEmpty(descricao))
							tarefas.Add(descricao.Trim());

					} while (string.IsNullOrWhiteSpace(descricao));
					break;
				case "E":
				case "e":
					Console.WriteLine("Indique o número da Tarefa a Excluir:");
					var tarefaId = int.Parse(Console.ReadLine());

					for (int idx = 0; idx < tarefas.Count; idx++)
					{
						if(idx == tarefaId)
						{
							var tarefaExcluida = tarefas[idx]; 
							tarefas.Remove(tarefas[idx]);
							Console.WriteLine($"Tarefa '{tarefaExcluida}' excluída!");
						}
					}

					break;
				case "S":
				case "s":
					opcao = "S";
					break;
				default:
					Console.WriteLine("Opção Inválida!!!");
					break;
			}

		} while ( opcao != "S");

		Console.Write("Pressione qualquer tecla para finalizar...");
		Console.ReadKey();

	}

	private static void AddTarefa(List<string> tarefas)
	{
		var descricao = string.Empty;
		do
		{
			Console.WriteLine("Descrição da Tarefa:");
			descricao = Console.ReadLine();

			if (tarefas.IndexOf(descricao.ToLower()) >= 0)
				Console.WriteLine("Tarefa já existe");
			else
				tarefas.Add(descricao);

		} while (string.IsNullOrWhiteSpace(descricao));

		
	}

	private static void MostrarOpcoes()
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

	private static bool IsOpcaoValida(string opcaoSelecionada)
	{
		var opcoes = new List<string>() { "V", "A", "E", "S" };

		return opcoes.IndexOf(opcaoSelecionada) >= 0;
	}

	private static void ExecutarOperacao(string opcao)
	{
		
	}

	private static void ListarTarefas(List<string> tarefas)
	{ 
		var idx = 0;
		foreach (var tarefa in tarefas)
		{
			Console.WriteLine($"{idx} - {tarefa}");
			++idx;
		}
	}
}
