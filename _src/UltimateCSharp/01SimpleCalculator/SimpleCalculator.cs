Console.WriteLine("Olá!");
Console.WriteLine("Introduza 1º número:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduza 2º número:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("O que deseja fazer com os números?");
Console.WriteLine("[A]dicionar");
Console.WriteLine("[S]ubtrair");
Console.WriteLine("[M]ultiplicar");

string operacao = Console.ReadLine().ToUpper();

string result = string.Empty;

if (operacao == "A")
	result = $"{num1} + {num2} = {num1 + num2}";
else if (operacao == "S")
	result = $"{num1} - {num2} = {num1 - num2}";
else if (operacao == "M")
	result = $"{num1} * {num2} = {num1 * num2}";
else
	result = "Opção Inválida!!";

Console.WriteLine(result);


Console.WriteLine("Press Any Key to Close.");
Console.ReadKey();
