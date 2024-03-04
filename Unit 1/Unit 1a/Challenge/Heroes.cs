using System;

public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	public Hero heroFour;

	public Villain villainOne;
	public Villain villainTwo;
	public Villain villainThree;
	public Villain villainFour;

	public void Main()
	{
		//create the various heroes
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		heroFour = new Hero();

		//establishes the attributes of the various heroes
		//health is how many times they can be hit
		//defense negates however much damage
		//flying means they can fly if true
		//power is how much damage is dealt
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.defense = 2;
		heroOne.flying = false;

		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.defense = 4;
		heroTwo.flying = true;

		heroThree.health = 6;
		heroThree.powerLevel = 3;
		heroThree.defense = 3;
		heroThree.flying = false;

		heroThree.health = 2;
		heroThree.powerLevel = 7;
		heroThree.defense = 1;
		heroThree.flying = true;

		//test the various heroes to see if functional
		Console.WriteLine(heroOne.health);
		Console.WriteLine(heroOne.powerLevel);
		Console.WriteLine(heroOne.defense);
		Console.WriteLine(heroOne.flying);

		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
		Console.WriteLine(heroTwo.defense);
		Console.WriteLine(heroTwo.flying);

		Console.WriteLine(heroThree.health);
		Console.WriteLine(heroThree.powerLevel);
		Console.WriteLine(heroThree.defense);
		Console.WriteLine(heroThree.flying);

		Console.WriteLine(heroFour.health);
		Console.WriteLine(heroFour.powerLevel);
		Console.WriteLine(heroFour.defense);
		Console.WriteLine(heroFour.flying);

		//same form with villains as with heroes. Establishes
		//and gives them various attributes
		villainOne = new Villain();
		villainTwo = new Villain();
		villainThree = new Villain();
		villainFour = new Villain();

		villainOne.health = 3;
		villainOne.powerLevel = 2;
		VillainOne.defense = 5;
		villainOne.flying = true;

		villainTwo.health = 5;
		villainTwo.powerLevel = 5;
		VillainTwo.defense = 5;
		villainTwo.flying = true;

		villainThree.health = 6;
		villainThree.powerLevel = 2;
		VillainThree.defense = 2;
		villainThree.flying = false;

		villainFour.health = 1;
		villainFour.powerLevel = 9;
		VillainFour.defense = 1;
		villainFour.flying = true;

		//test functionality
		Console.WriteLine(villainOne.health);
		Console.WriteLine(villainOne.powerLevel);
		Console.WriteLine(villainOne.defense);
		Console.WriteLine(villainOne.flying);

		Console.WriteLine(villainTwo.health);
		Console.WriteLine(villainTwo.powerLevel);
		Console.WriteLine(villainTwo.defense);
		Console.WriteLine(villainTwo.flying);

		Console.WriteLine(villainThree.health);
		Console.WriteLine(villainThree.powerLevel);
		Console.WriteLine(villainThree.defense);
		Console.WriteLine(villainThree.flying);

		Console.WriteLine(villainFour.health);
		Console.WriteLine(villainFour.powerLevel);
		Console.WriteLine(villainFour.defense);
		Console.WriteLine(villainFour.flying);
	}
}

//establish the various attributes for both heroes
//and villains
public class Hero
{
	public int health;
	public int powerLevel;
	public int defense;
	public bool flying;
}
public class Villain
{
	public int health;
	public int powerLevel;
	public int defense;
	public bool flying;
}