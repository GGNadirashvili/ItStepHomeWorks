using System;
class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Please Enter The Number");
		int input;
		int.TryParse(Console.ReadLine(), out input);
		MyClass.MyMethod(input);
	}
}
[AttributeUsage(AttributeTargets.Parameter)]
public class GreaterThanZeroAttribute : Attribute
{
	public bool IsValid(int value)
	{
		return value > 0;
	}
}

public static class MyClass
{
	public static void MyMethod([GreaterThanZero] int myParameter)
	{
		if (new GreaterThanZeroAttribute().IsValid(myParameter))
		{
			Console.WriteLine("Parameter is greater than 0.");
		}
		else
		{
			Console.WriteLine("Parameter is not greater than 0 Integer.");
		}
	}
}

