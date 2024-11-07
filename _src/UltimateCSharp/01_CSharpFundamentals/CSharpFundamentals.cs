//###################
//Variables
//###################
//Console.WriteLine(name); // Error cuz is not yet declared and initialized

string name = "Nisha"; //variable initialization at declaration
int number; //variable declaration
number = 5; //variable initialization
number = 10; //assigning new value
Console.WriteLine(number); 
//int lastName = "Smith"; //will not compile, we can't assign string to int



//###################
//Naming variables
//###################
//string class = "First"; //cant use reserved keyword as variables name
string @class = "First"; //can use if we precede it with @


int _number = 10; // its ok use _ underscore
int also_some_number = 5; //valid name, but not C# convention
int alsoSomeNumber = 5; //C# uses lower camel case

//int 1number = 1; //will not compile, digit cannot be the first character
//int number-one = 10; //will not compile, we can't use '-'
int age, Age; // C# is case-sensitive they are two different variables
			  


//###################
//Operators
//###################
int sum = 5 + 10;
int resultNoParenthesis = 5 + 2 * 3;
int resultParenthesis = 5 + (2 * 3);
var stringAndInt = "abc" + 5;



//######################################
//Implicitly/Explicity typed variables
//######################################
string word1 = "text"; //explicitly typed variable
var word2 = "text"; //implicitly typed variable
//var invalidVariable; //Error implicitly typed variables must be initialized


//###################
//Boolean type.
//Logical negation, equality,
//comparison and modulo operators
//###################
Console.WriteLine("Enter a word:");
var userInput = Console.ReadLine();
bool isUserInputAbc = userInput == "ABC";

bool isUserInputNotAbc = userInput != "ABC";
bool isUserInputNotAbc2 = !(userInput == "ABC"); //will be the same as above

var isLargerThan5 = number > 5;
var isSmallerThan10 = number <= 10;

var isLargerOrEqualTo10 = number >= 10;
var isSmallerOrEqualTo6 = number <= 6;

var is10Modulo3EqualTo1 = 10 % 3 == 1; // Module = rest of division
var isEven = number % 2 == 0;
var isOdd = number % 2 != 0;



//###################
//Logical operators &&, ||, !
//###################
var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
var isEqualTo2OrLargerThan6 = number == 2 || number > 6;
var isEqualTo2OrLargerThan6OrSmallerThan200 =
	number == 2 || number > 6 || number < 200;
var isEqualto123OrEvenAndSmallerThan20 =
	number == 123 || (number % 2 == 0 && number < 20);
var isLargerThan5OrSmallerThan0 = number > 5 || number < 5; //if first conditions is true, the second wont be evaluated due to short-circuiting
var isSmallerThanZeroAndEven = number < 0 && number % 2 == 0; //the second conditin will not be evaluated due to short-circuiting



//###################
//if/else statements
//###################
if (userInput.Length <= 3)
{
	Console.WriteLine("Short answer");
}
else if (userInput.Length < 10)
{
	Console.WriteLine("Medium answer");
}
else
{
	Console.WriteLine("Long answer");
}



//###################
//Scopes
//###################
if (userInput.Length == 0)
{
	Console.WriteLine("Empty choice");
	var word = "ABC";
	int someNumber = 5;
	if (word.Length > 0)
	{
		Console.WriteLine(someNumber); //someNumber is available here
	}
}
else
{
	int someNumber = 6; //Same variable name, it is fine, cuz variables live in different scopes
	Console.WriteLine("Your choice is: " + userInput);
	//Console.WriteLine(someNumber); //will not compile; someNumber is not available here
}
Console.WriteLine("Your choice is: " + userInput);



//###################
//Methods - part 1 - void methods
//###################
//See 1_TodoList project for more about methods
void PrintSelectedOption(string selectedOption)
{
	Console.WriteLine("Selected option: " + selectedOption);
}



//###################
//Methods - part 2 - non-void methods
//###################
//See 1_TodoList project for more about methods
int Add(int a, int b)
{
	return a + b;
}

bool IsLong(string input)
{
	return input.Length > 10;
}



//###################
//Parsing a string to an int
//###################
string numberAsText = "123";
int parsedToInt = int.Parse(numberAsText); //would not work if input was, for example, "abc"



//###################
//String interpolation
//###################
int a = 4, b = 2, c = 10;
Console.WriteLine(
	"First is: " + a + ", second is: " + b + ", third is: " + c);

Console.WriteLine(
	$"First is: {a}, second is: {b}, third is: {c}");

Console.WriteLine(
	$"Sum is: {a + b + c}, second is: {b}, third is: {c}");



//###################
//Switch statement
//###################
//See 1_TodoList project for more about switch
//###################
//Char
//###################
char ConvertPointsToGrade(int points)
{
	switch (points)
	{
		case 10:
		case 9:
			return 'A';
		case 8:
		case 7:
		case 6:
			return 'B';
		case 5:
		case 4:
		case 3:
			return 'C';
		case 2:
		case 1:
			return 'D';
		case 0:
			return 'E';
		default:
			return '!';
	}
}



//###################
//While loop
//###################
var numberWhileLoop = 0;
while (numberWhileLoop < 10)
{
	numberWhileLoop += 1;
	Console.WriteLine("Number is: " + numberWhileLoop);
}
Console.WriteLine("The loop is finished.");

var someText = "hello";
while (someText.Length < 15)
{
	someText += 'a';
	Console.WriteLine(someText);
}
Console.WriteLine("The loop is finished.");



//###################
//Do-while loop
//###################
string userInputLong;
do
{
	Console.WriteLine(
		"Enter input longer than 10 letters");
	userInputLong = Console.ReadLine();
} while (userInputLong.Length <= 10);



//###################
//For loop
//###################
for (int i = 0; i < 5; ++i)
{
	Console.WriteLine("Loop run " + i);
}
for (int i = 10; i >= 5; --i)
{
	Console.WriteLine("Loop run " + i);
}
Console.WriteLine("The loop is finished");



//###################
//Break and continue
//###################
for (int i = 0; i < 100; ++i)
{
	if (i > 25)
	{
		break;
	}
	//Console.WriteLine("Loop run " + i);
}

int userNumber;
do
{
	Console.WriteLine(
		"Enter a number larger than 10.");
	var input = Console.ReadLine();
	if (input == "stop")
	{
		break;
	}
	bool isParsableToInt = input.All(char.IsDigit);
	if (!isParsableToInt)
	{
		userNumber = 0;
		continue;
	}
	userNumber = int.Parse(input);
} while (userNumber <= 10);

for (int i = 0; i < 20; i++)
{
	if (i % 3 == 0)
	{
		continue;
	}
	//Console.WriteLine(i);
}



//###################
//Nested loops
//###################
for (int i = 0; i < 4; i++)
{
	for (int j = 0; j < 3; j++)
	{
		Console.WriteLine(
			$"i is {i}, j is {j}");
	}
}



//###################
//Arrays
//###################
var numbers = new int[] { 1, 2, 4, 7, 2 };
numbers[2] = 10;
var firstFromEnd1 = numbers[numbers.Length - 1];
var firstFromEnd2 = numbers[^1];
var secondFromEnd1 = numbers[numbers.Length - 2];
var secondFromEnd2 = numbers[^2];

int sumOfNumbers = 0;
for (int i = 0; i < numbers.Length; i++)
{
	sumOfNumbers += numbers[i];
}



//###################
//Multi-dimensional arrays
//###################
char[,] letters = new char[2, 3];
letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

var letters2 = new char[,]
{
	{'A', 'B','C' },
	{'D', 'E','F' },
};

var height = letters.GetLength(0);
var width = letters.GetLength(1);

for (int i = 0; i < height; i++)
{
	Console.WriteLine($"i is {i}");
	for (int j = 0; j < width; j++)
	{
		Console.WriteLine($"j is {j}");
		Console.WriteLine(
			$"element is {letters[i, j]}");
	}
}




//###################
//Foreach loop
//###################
var words = new string[] { "one", "two", "three" };
foreach (var word in words)
{
	Console.WriteLine(word);
}




//###################
//Lists
//###################
var someWords = new List<string>
{
	"one", "two"
};
someWords.Add("three");
someWords.AddRange(new[] { "four", "five" });
someWords.Remove("three");
someWords.RemoveAt(0);
var indexOfFive = someWords.IndexOf("five");
bool containsOne = someWords.Contains("one");
someWords.Clear();



//###################
//Out parameter
//###################
var variousNumbers = new int[] { 10, -8, 2, 12, -17 };
int countOfNonPositiveNumbers;
var onlyPositive = GetOnlyPositive(
	numbers, out countOfNonPositiveNumbers);

List<int> GetOnlyPositive(
	int[] numbers, out int countOfNonPositive)
{
	var result = new List<int>();
	countOfNonPositive = 0;
	foreach (var number in numbers)
	{
		if (number > 0)
		{
			result.Add(number);
		}
		else
		{
			++countOfNonPositive;
		}
	}
	return result;
}

//###################
//PARSING
//###################
bool isParsed = int.TryParse(
	userInput, out int userInputParsedToInt);
if (isParsed)
{
	Console.WriteLine(
		"Parsed successfully, the result is: " + userInputParsedToInt);
}
else
{
	Console.WriteLine(
		$"Could not parse '{userInput}' to int");
}


Console.WriteLine("Press any key to close");
Console.ReadKey();




RunSection01E14();

void RunSection01E14()
{
	var words = new List<string> { "ONE", "TWO", "TWO!&%", "ONE", "THREE123" };

	var resultado = Section01Exercises.Ex14_GetOnlyUpperCaseWords(words);
	resultado.ForEach(x => Console.WriteLine(x));
}

public class Section01Exercises
{

	/// <summary>
	/// To the result variable, assign the result of: (a + b) / c
	/// </summary>
	public static int Ex01_VariablesAndOperators()
	{
		var a = 5;
		var b = 10;
		var c = 3;

		int result = ((a + b) / c); //your code goes here

		return result;
	}

	/// <summary>
	/// Assign true if the sum of a and b is larger or equal to 17 and false otherwise.
	/// </summary>
	/// <returns></returns>
	public static bool Ex02_BooleanTypesAndOperators()
	{
		int a = 5;
		int b = 12;

		bool isSumLargerOrEqualTo17 = (a + b) >= 17; //your code goes here

		return isSumLargerOrEqualTo17;
	}

	/// <summary>
	///Return a string according to the following rules:
	///	if number is smaller than zero, it should be "negative"
	/// if number is zero, it should be "zero"
	/// if number is larger than zero, it should be "positive"
	/// </summary>
	/// <returns></returns>
	public static string Ex03_IfElseConditionalStatement()
	{
		int number = 0;

		string result;

		if (number < 0)
			result = "negative";
		else if (number == 0)
			result = "zero";
		else
			result = "positive";

		return result;
	}

	/// <summary>
	/// Define the AbsoluteOfSum method, which takes two int parameters, and returns the absolute value of their sum.
	/// </summary>
	public static int Ex04_AbsoluteOfSum(int a, int b)
	{
		return Math.Abs(a + b);
	}

	/// <summary>
	/// Using string interpolation, implement the FormatDate method, given three integers return a date in format YEAR/MONTH/DAY.
	/// </summary>	
	public static string Ex05_FormatDate(int year, int month, int day)
	{
		return $"{year}/{month}/{day}";
	}

	/// <summary>
	/// Gven a day of the week as a number, should return:
	/// "Working day" for numbers 1 to 5
	/// "Weekend" for numbers 6 and 7
	/// "Invalid day number" for any other number
	/// </summary>
	public static string Ex06_DescribeDay(int dayNumber)
	{
		switch (dayNumber)
		{
			case 1:
			case 2:
			case 3:
			case 4:
			case 5:
				return "Working day";
			case 6:
			case 7:
				return "Weekend";
			default:
				return "Invalid day number";
		}
	}

	/// <summary>
	///  Given two integers calculate the sum of numbers between them (including the numbers themselves).
	/// </summary>
	public static int Ex07_CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
	{
		if (lastNumber < firstNumber) return 0;

		var soma = 0;
		var currentNumber = firstNumber;
		while (currentNumber <= lastNumber)
		{
			soma = soma + currentNumber;
			++currentNumber;
		}

		return soma;
	}

	/// <summary>
	/// Given a character and targetLength, should build a string of this character repeated the given number of times.
	/// </summary>
	public static string Ex08_RepeatCharacter(char character, int targetLength)
	{

		string result = string.Empty;
		do
		{
			result += character;
		} while (result.Length < targetLength);

		return result;
	}

	/// <summary>
	/// Calculates the factorial of a given number.
	/// </summary>
	public static int Ex09_Factorial(int number)
	{
		var factorial = 1;

		for (var i = number; i > 1; i--)
		{
			factorial *= i;
		}
		return factorial;

		// Base Case 
		// if( number <= 0) return 1;
		// return number * Factorial(number - 1); 
	}

	/// <summary>
	/// Iterate an array of chars consisting of all letters and add those letters to the result variable
	/// </summary>
	/// <returns></returns>
	public static string Ex10_BuildHelloString()
	{
		char[] letters = { 'h', 'e', 'l', 'l', 'o' };

		var result = "";
		for (int i = 0; i < letters.Length; ++i)
		{
			result += letters[i];
		}

		return result;
	}

	/// <summary>
	/// Given an array of words and a wordToBeChecked, returns true if wordToBeChecked is present in this collection and false otherwise.
	/// </summary>
	public static bool Ex11_IsWordPresentInCollection(string[] words, string wordToBeChecked)
	{
		for (int i = 0; i < words.Length; i++)
		{
			if (words[i] == wordToBeChecked) return true;
		}
		return false;
	}

	/// <summary>
	/// Given a two-dimensional array of integers, returns the maximal value from this array.
	/// If array is empty should return -1.
	/// </summary>
	public static int Ex12_MultiDimensional_FindMax(int[,] numbers)
	{
		var height = numbers.GetLength(0); // GetLength() // get the dimension in multidimensional array
		var width = numbers.GetLength(1);

		if (height == 0 || width == 0)
			return -1;

		var max = -900000000;

		for (int i = 0; i < numbers.GetLength(0); ++i)
		{
			for (int j = 0; j < numbers.GetLength(1); ++j)
				if (numbers[i, j] > max)
					max = numbers[i, j];

		}

		return max;
	}

	/// <summary>
	/// Given a length and an array of words, returns true if any of those words is longer than the given length
	/// </summary>
	public static bool Ex13_IsAnyWordLongerThan(int length, string[] words)
	{
		foreach (var word in words)
			if (word.Length > length) return true;

		return false;
	}

	/// <summary>
	/// GIven a collection of strings, returns a List with strings which contain only uppercase letters.
	/// The result collection should not contain duplicates.
	/// </summary>
	public static List<string> Ex14_GetOnlyUpperCaseWords(List<string> words)
	{
		var result = new List<string>();

		// (word == word.ToUpper() // if word is uppercase
		// word.All(Char.IsUpper)  // if all char are upper, if there is number/symbol is false
		foreach (var word in words)
			//if (word == word.ToUpper() && result.IndexOf(word) == -1)
			if (word.All(Char.IsUpper) && result.IndexOf(word) == -1)
				result.Add(word);

		return result;
	}


}
