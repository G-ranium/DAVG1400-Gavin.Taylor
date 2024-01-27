using System;

public class Variables
{
	public int Age = 22;
	public string Name = "Gavin Taylor";
	public string FavoriteFood = "sushi";
}
public class WhoAreYou
{
	public void RunFunction()
	{
		Console.WriteLine($"My name is {Name}");
		Console.WriteLine($"I am {Age} years old");
		Console.WriteLine($"My favorite food is {FavoriteFood}");
		Age += 65;
		Console.WriteLine($"In 65 years I will be {Age} years old");
	}
}
