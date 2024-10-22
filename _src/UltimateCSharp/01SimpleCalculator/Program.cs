Console.WriteLine("Hello!");
Console.WriteLine("Input first number:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Input second number:");
int secondNumber = int.Parse(Console.ReadLine());

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string operacao = Console.ReadLine().ToUpper();

string result = string.Empty;

if (operacao == "A")
	result = $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}";
else if (operacao == "S")
	result = $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}";
else if (operacao == "M")
	result = $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}";
else
	result = "Invalid option";

Console.WriteLine(result);


Console.WriteLine("Press Any Key to Close.");
Console.ReadKey();
