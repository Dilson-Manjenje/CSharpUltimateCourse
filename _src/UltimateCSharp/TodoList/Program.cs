var _tarefas = new List<string>();

Console.WriteLine("Olá!");

string opcao = string.Empty;
do
{
	MostrarOpcoes();

	opcao = Console.ReadLine().ToUpper();

	switch (opcao)
	{
		case "V":
			ListarTarefas();
			break;
		case "A":
			AddTarefa();
			break;
		case "E":
			ExcluirTarefa();
			break;
		case "S":
			opcao = "S";
			break;
		default:
			Console.WriteLine("Opção Inválida!!!");
			break;
	}

} while (opcao != "S");

Console.Write("Pressione qualquer tecla para finalizar...");
Console.ReadKey();

void MostrarOpcoes()
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

void ListarTarefas()
{
	var idx = 1;
	foreach (var tarefa in _tarefas)
	{
		Console.WriteLine($"{idx} - {tarefa}.");
		++idx;
	}
}

void AddTarefa()
{
	var descricao = string.Empty;
	do
	{
		Console.WriteLine("Tarefa Descrição:");
		descricao = Console.ReadLine().Trim();

	} while (!IsDescricaoValida(descricao));

	_tarefas.Add(descricao.Trim());
}

bool IsDescricaoValida(string descricao)
{
	if (string.IsNullOrWhiteSpace(descricao))
	{
		Console.WriteLine("Descrição não pode ser vázia");
		return false;
	}

	if (_tarefas.Contains(descricao))
	{
		Console.WriteLine("Descrição deve ser única.");
		return false;
	}

	return true;
}

void ExcluirTarefa()
{
	Console.WriteLine("Tarefa ID:");
	var tarefaId = int.Parse(Console.ReadLine());
	--tarefaId; 

	for (int idx = 0; idx < _tarefas.Count; idx++)
	{
		if (idx == tarefaId)
		{
			var tarefaExcluida = _tarefas[idx];
			_tarefas.Remove(_tarefas[idx]);
			Console.WriteLine($"Tarefa '{tarefaExcluida}' excluída!");
			break;
		}
	}
}

