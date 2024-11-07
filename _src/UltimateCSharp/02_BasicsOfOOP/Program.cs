
// ----- constructors, properties and const  -------------
//var rect1 = new Rectangulo(5, 10);
// var rect2 = new Rectangulo(-50, -2);

//Console.WriteLine("Nº de Objectos Rectangulo: " + Rectangulo.NumeroDeInstancias);

//Console.WriteLine("Largura: " + rect1.Largura);
//Console.WriteLine("Altura: " + rect1.Altura);
//Console.WriteLine("Área: " + rect1.CalcularArea());
//Console.WriteLine("Circunferência: " + rect1.CalcularCircunferencia());

var consulta2Semanas = new AgendamentoMedico("Bob Smith", 14);
Console.WriteLine($"{consulta2Semanas.ShowAgendamento()}");

var consulta1Semana = new AgendamentoMedico("Margaret Smith"); // numeroDias = 7

var consultaDesconhecido = new AgendamentoMedico();
Console.WriteLine($"{consultaDesconhecido.ShowAgendamento()}");

consultaDesconhecido.Reagendar(new DateTime(2024, 12, 12));
Console.WriteLine($"{consultaDesconhecido.ShowAgendamento()}");


// ------------- Object Initializer ---------------
var pes1 = new Pessoa
{
	Nome = "João",
	AnoNascimento = 1999 
};
Console.WriteLine($"{pes1.Nome} nascido em {pes1.AnoNascimento}");
// pes1.AnoNascimento = 2000; // error init-only property can only be assigne in object initilizer or constructor


// -------------- Computed Properties -----------------
var daily = new DiarioContabilistico(2000, -200);
Console.WriteLine(daily.ImprimirReport);

Console.ReadKey();


class Rectangulo
{
	//const fields are implicitly static
	public const int NumeroDeLados = 4;

	//a static property belong to the class
	public static int NumeroDeInstancias { get; private set; }

	//a static field
	private static DateTime _primeiroUso;


	//readonly property - can only be set in the constructor
	public int Largura { get; }




	//Using methods you can achieving a similar behavior as properties
	private int _altura;

	public int Altura
	{
		//get { return _altura; }
		//set { _altura = value; }
		get => _altura;  // We can use body-expression on properties
		set => _altura = value;

	}


	public int[] Dimensao { get; private set; } // the compiler generate the back-end field


	//a static constructor
	static Rectangulo()
	{
		_primeiroUso = DateTime.Now;
	}

	public Rectangulo(int largura, int altura)
	{
		Largura = GetTamanhoOrDefault(largura, nameof(Largura));
		Altura = GetTamanhoOrDefault(altura, nameof(Altura));
		++NumeroDeInstancias;
	}

	private int GetTamanhoOrDefault(int tamanho, string propriedadeNome)
	{
		const int valorDefaultSeNegativo = 1;
		if (tamanho <= 0)
		{
			Console.WriteLine($"{propriedadeNome} deve ser número positivo.");
			return valorDefaultSeNegativo;
		}

		return tamanho;
	}

	//expression-bodied methods
	//could not be made static as they use the state of an instance (width and height)
	public int CalcularCircunferencia() => 2 * Largura + 2 * _altura;

	public int CalcularArea() => Largura * _altura;

	//a get-only, expression-bodied property
	public string Description => $"Rectângulo com Largura {Largura} " +
		$"e Altura {Altura}";

	//static class can have only static methods
	//a static method, not using any state of an instance
	public static string DescricaoGenerica() =>
		$"Figura plana com quatro lados e quatro angulos rectos.";

	//can be made static
	public string NotUsingAnyState() => "abc";
}

class AgendamentoMedico
{

	private string _nomePaciente { get; set; }
	private DateTime _data { get; set; }

	//calling the below constructor with optional parameters
	//also allows to skip the second/optional parameter
	//public AgendamentoMedico(string nomePaciente): this(nomePaciente, 7)
	//{
	//	_nomePaciente = nomePaciente;
	//}

	public AgendamentoMedico(string nomePaciente = "Desconhecido", int numeroDias = 7)
	{
		_nomePaciente = nomePaciente;
		_data = DateTime.Now.AddDays(numeroDias);
	}

	public DateTime Reagendar(DateTime novoData)
	{
		return _data = novoData;
	}

	// To overload a method we must distinguish methods by count of parameters, they type or order
	// the return type is not enougth to distinguish methods... 
	// DateTime Reagendar(int mesesAdicional, int diasAdicional)
	// DateTime Reagendar(int novoMes, int novoDia)
	// but as best practice differ them by name	
	public DateTime SubscreverMesDia(int novoMes, int novoDia)
	{
		return _data = new DateTime(_data.Year, novoMes, novoDia);
	}

	public DateTime AcrescentarMesDia(int mesesAdicional, int diasAdicional)
	{
		return _data = new DateTime(_data.Year, _data.Month + mesesAdicional, _data.Day + diasAdicional);
	}


	public string ShowAgendamento()
	{
		return $"'{_nomePaciente}' consulta agendada para {_data.ToString("dd/MM/yyyy H:mm")}";
	}
}


class Pessoa
{
	public string Nome { get; set; }
	public int AnoNascimento { get; init; } // Init-only property can only be assigne in
											// object initilizer or constructor

}

public class Section02Exercises
{

}

/// <summary>
/// Exercise 15: Hotel Booking class
/// </summary>
public class HotelMarcacao
{
	public HotelMarcacao(string nomeHospede, DateTime dataInicio, int diasEstadia)
	{
		NomeHospede = nomeHospede;
		DataInicio = dataInicio;
		DataFim = dataInicio.AddDays(diasEstadia);
	}
	public string NomeHospede { get; set; }

	public DateTime DataInicio { get; set; }
	public DateTime DataFim { get; set; }


}


/// <summary>
/// Exercise 16: Implement the Triangle class
///	Requirements:
///  Integer fields base and height setted in constructor
///  CalculateArea(): ((base * height) / 2)   
///  AsString(): returns "Base is B, height is H",
/// </summary>
public class Triangulo
{
	private int _altura { get; set; }
	private int _base { get; set; }

	public Triangulo(int @base, int altura)
	{
		_base = @base;
		_altura = altura;
	}

	public int CalculateArea() => ((_base * _altura) / 2);

	public string AsString() => $"Base é {_base}, altura é {_altura}";

}

/// <summary>
/// Exercise 17: Define a Dog class. 
///		Each Dog will have a name(string), breed (string), and weight (int) fields.
/// </summary>
public class Cao
{
	private string _nome { get; set; }
	private string _raca { get; set; }
	private int _peso { get; set; }

	public Cao(string nome, string raca, int peso)
	{
		_nome = nome;
		_raca = raca;
		_peso = peso;
	}

	public Cao(string nome, int peso, string raca = "mixed-breed")
	{
		_nome = nome;
		_peso = peso;
		_raca = raca;
	}

	public string Descrever()
	{
		return $"O cão chama-se {_nome}, é de raça {_raca} e pesas {_peso} kilogramas, então é um cão {DescricaoPorPeso()}.";
	}

	private string DescricaoPorPeso()
	{
		if (_peso < 5)
			return "leve";
		else if (_peso >= 5 && _peso < 30)
			return "médio";
		else
			return "pesado";

	}
}


/// <summary>
/// Exercise 18: Implement the Order class, with two properties:
/// Item(string) which should not be settable at all
/// Date (DateTime), which should be gettable and settable, the setter should a validate if the given value 
/// has the same year as the current year. If not, the value of the Date property should not be changed.
/// </summary>
public class Pedido
{
	public string Item { get; }

	private DateTime _data { get; set; }
	public DateTime DataPedido
	{
		get { return _data; }
		set
		{
			var ano = value.Year;
			if (ano != DateTime.Now.Year)
				return;

			_data = value;
		}
	}


	public Pedido(string item, DateTime date)
	{
		Item = item;
		DataPedido = date;
	}
}


/// <summary>
/// Exercise 19: DailyAccountState class represents a daily data of a bank account using Computed properties.
/// </summary>
public class DiarioContabilistico
{
	public int SaldoInicial { get; }
	public int SomaDasOperacoes { get; }

	public DiarioContabilistico(
		int saldoInicial,
		int somaDasOperacoes)
	{
		SaldoInicial = saldoInicial;
		SomaDasOperacoes = somaDasOperacoes;
	}

	public int SaldoFinal
	{
		get => SaldoInicial + SomaDasOperacoes;
	}

	public string ImprimirReport
	{
		get
		{
			var agora = DateTime.Now;

			return $"Dia: {agora.Day}, Mês: {agora.Month}, Ano: {agora.Year}, Saldo Inicial: {SaldoInicial}, Saldo Final do Dia: {SaldoFinal}";
		}
	}

}