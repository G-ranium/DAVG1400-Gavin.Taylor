using System;

public class Variables
{
	//establishes my age, name and favorite food as variables
	public int Age = 22;
	public string Name = "Gavin Taylor";
	public string FavoriteFood = "sushi";
}
public class WhoAreYou
{
	public void RunFunction()
	{
		//prints my info
		Console.WriteLine($"My name is {Name}");
		Console.WriteLine($"I am {Age} years old");
		Console.WriteLine($"My favorite food is {FavoriteFood}");

		//calculates how old I will be in 65 years
		Age += 65;

		//print out result
		Console.WriteLine($"In 65 years I will be {Age} years old");
	}
}
