using System.Runtime.ConstrainedExecution;

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
		case "R":
			RemoverTarefa();
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
	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine("O que deseja fazer?");
	Console.ResetColor();

	Console.WriteLine("");

	Console.WriteLine("[V] Ver todas tarefas");
	Console.WriteLine("[A] Adicionar tarefa");
	Console.WriteLine("[R] Remover tarefa");
	Console.WriteLine("[S] Sair");
	Console.WriteLine("");
}

void ListarTarefas()
{
	if (IsSemTarefa())
	{
		ShowMsgSemTarefas();
		return;
	}

	for (int idx = 0; idx < _tarefas.Count; idx++)
	{
		Console.WriteLine($"{idx + 1}. {_tarefas[idx]}.");		
	}
}

bool IsSemTarefa()
{
	return _tarefas.Count == 0;
}

void ShowMsgSemTarefas()
{
	Console.ForegroundColor = ConsoleColor.DarkRed;
	Console.WriteLine("Não foram adicionadas tarefas.");
	Console.ResetColor();
}


void AddTarefa()
{
	var descricao = string.Empty;
	do
	{
		Console.WriteLine("Descrição da Tarefa:");
		descricao = Console.ReadLine().ToLower().Trim();

	} while (!IsDescricaoValida(descricao));

	_tarefas.Add(descricao);
	ShowMsgSucesso("adicionada", descricao);
}

bool IsDescricaoValida(string descricao)
{
	if (string.IsNullOrWhiteSpace(descricao))
	{
		ShowMsgErro("Descrição não pode ser vázia");
		return false;
	}

	if (_tarefas.Contains(descricao))
	{
		ShowMsgErro("Descrição deve ser única.");
		return false;
	}

	return true;
}

void RemoverTarefa()
{
	if (IsSemTarefa())
	{
		ShowMsgSemTarefas();
		return;
	}

	int index = -1;
	do
	{
		Console.WriteLine("Informe o indíce da Tarefa a remover:");
		ListarTarefas();
	} while (!IsIndiceValido(out index));


	var tarefaPorRemover = _tarefas[--index];
	_tarefas.Remove(tarefaPorRemover);
	ShowMsgSucesso("removida", tarefaPorRemover);

}

bool IsIndiceValido(out int index)
{
	var userInput = Console.ReadLine();

	if (string.IsNullOrWhiteSpace(userInput))
	{
		ShowMsgErro("Indíce não pode ser vázio");
		index = -1;
		return false;
	}

	if (int.TryParse(userInput, out index)) 
		if (index < 0 || index > _tarefas.Count)
		{
			ShowMsgErro("Indíce inválido!");
			return false;
		}

	return true;
}
void ShowMsgSucesso(string operacao, string tarefa)
{
	Console.ForegroundColor = ConsoleColor.Green;
	Console.WriteLine($"Tarefa {operacao} com sucesso: [{tarefa}]");
	Console.ResetColor();
}

void ShowMsgErro(string msg)
{
	Console.ForegroundColor = ConsoleColor.Red;
	Console.WriteLine($"{msg}");
	Console.ResetColor();
}