using System;

public class Program
{
	public Weapon cosmicHammer;
	public Weapon soulArrow;
	public Weapon irradiatedSpear;


	public void Main()
	{
		//establishes various weapon types
		cosmicHammer = new Weapon();
		soulArrow = new Weapon();
		irradiatedSpear = new Weapon();

		//changes the attributes to each weapon.
		//Damage adds more damage, defense more defense
		//range makes it so the heroes/villains can hit from farther away
		cosmicHammer.damageMultiplier = 5;
		cosmicHammer.defenseMultiplier = 5;
		cosmicHammer.range = 1;
		cosmicHammer.cost = 2725.75;

		soulArrow.damageMultiplier = 2;
		soulArrow.defenseMultiplier = 1;
		soulArrow.range = 15;
		soulArrow.cost = 1200.25;

		irradiatedSpear.damageMultiplier = 15;
		irradiatedSpear.defenseMultiplier = -3;
		irradiatedSpear.range = 5;
		irradiatedSpear.cost = 575.50;

		//finally print out the various attributes to test functionality
		Console.WriteLine(cosmicHammer.damageMultiplier);
		Console.WriteLine(cosmicHammer.defenseMultiplier);
		Console.WriteLine(cosmicHammer.range);
		Console.WriteLine(cosmicHammer.cost);

		Console.WriteLine(soulArrow.damageMultiplier);
		Console.WriteLine(soulArrow.defenseMultiplier);
		Console.WriteLine(soulArrow.range);
		Console.WriteLine(soulArrow.cost);

		Console.WriteLine(irradiatedSpear.damageMultiplier);
		Console.WriteLine(irradiatedSpear.defenseMultiplier);
		Console.WriteLine(irradiatedSpear.range);
		Console.WriteLine(irradiatedSpear.cost);
	}

public class Weapon
{
    //establishes the different attributes
	public int damageMultiplier;
	public int defenseMultiplier;
	public int range;
	public double cost;
}