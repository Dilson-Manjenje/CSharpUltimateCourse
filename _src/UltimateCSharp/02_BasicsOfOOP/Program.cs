//var rect1 = new Rectangulo(5, 10);
//var rect2 = new Rectangulo(50, 100);

//Console.WriteLine("Nº de Objectos Rectangulo: " + Rectangulo.NumeroDeInstancias);

//Console.WriteLine("Largura: " + rect1.Largura);
//Console.WriteLine("Altura: " + rect1.GetAltura());
//Console.WriteLine("Área: " + rect1.CalcularArea());
//Console.WriteLine("Circunferência: " + rect1.CalcularCircunferencia());

var consulta2Semanas = new AgendamentoMedico("Bob Smith", 14);
Console.WriteLine($"{consulta2Semanas.ShowAgendamento()}");

var consulta1Semana = new AgendamentoMedico("Margaret Smith");
var consultaDesconhecido = new AgendamentoMedico();
Console.WriteLine($"{consultaDesconhecido.ShowAgendamento()}");



Console.ReadKey();


class Rectangulo
{
	//const fields are implicitly static
	public const int NumeroDeLados = 4;

	//a static property belong to the class
	public static int NumeroDeInstancias { get; private set; }

	//a static field
	private static DateTime _primeiroUso;

	//a static constructor
	static Rectangulo()
	{
		_primeiroUso = DateTime.Now;
	}

	public Rectangulo(int largura, int altura)
	{
		Largura = GetTamanhoOrDefault(largura, nameof(Largura));
		_altura = GetTamanhoOrDefault(altura, nameof(_altura));
		++NumeroDeInstancias;
	}

	//readonly property - can only be set in the constructor
	public int Largura { get; }

	//Using methods you can achieving a similar behavior as properties
	private int _altura;
	public int GetAltura() => _altura;

	public void SetAltura(int value)
	{
		if (value > 0)
			_altura = value;
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
		$"e Altura {_altura}";

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
	//public AgendamentoMedico(string nomePaciente): this(nomePaciente, 7)
	//{
	//	_nomePaciente = nomePaciente;
	//}

	public AgendamentoMedico(string nomePaciente = "Desconhecido", int numeroDias = 7)
	{
		_nomePaciente = nomePaciente;
		_data = DateTime.Now.AddDays(7);
	}

	public string ShowAgendamento()
	{
		return $"Paciente {_nomePaciente} consulta agendada para {_data.ToString("dd/MM/yyyy H:mm")}";
	}
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
public class Dog
{
	private string _name { get; set; }
	private string _breed { get; set; }
	private int _weight { get; set; }

	public Dog(string name, string breed, int weight)
	{
		_name = name;
		_breed = breed;
		_weight = weight;
	}

	public Dog(string name, int weight, string breed = "mixed-breed")
	{
		_name = name;
		_weight = weight;
		_breed = breed;
	}

	public string Describe()
	{
		return $"This dog is named {_name}, it's a {_breed}, and it weighs {_weight} kilograms, so it's a {WeightDescription()} dog.";
	}

	private string WeightDescription()
	{
		if (_weight < 5)
			return "tiny";
		else if (_weight >= 5 && _weight < 30)
			return "medium";
		else
			return "large";

	}
}