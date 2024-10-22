
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
