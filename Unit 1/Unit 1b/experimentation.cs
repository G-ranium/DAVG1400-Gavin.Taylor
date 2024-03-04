using System;

public class Program
{
	public bool winCondition = false;
    public GameStates gameStates;
    public void Main()
    {
        gameStates = new GameStates();
		winCondition = false;
		Console.WriteLine(@"The objective of this game is to guess the answer to each riddle.
You will have 3 attempts at each riddle, answering a riddle will get you
to the next stage. Keep in mind that answers must be capitalized.
 ");
		gameStates.currentState = GameStates.States.Phase1;
        gameStates.CheckState();
		Console.WriteLine(winCondition);
		
		if(winCondition == true)
		{
		winCondition = false;
		gameStates.currentState = GameStates.States.Phase2;
		gameStates.CheckState();
			if(winCondition == true)
			{
			gameStates.currentState = GameStates.States.endPhase;
			gameStates.CheckState();
			}
		}

    }
}

public class GameStates
{
	Program p = new Program();
    public enum States
    {
        Phase1,
        Phase2,
        endPhase
    }
    public States currentState = States.Phase1;

    public void CheckState()
    {
        switch (currentState)
        {
			//new phase to start
            case States.Phase1:
				//number of attempts user gets
				int attempts = 3;
				//explain that to them lol
				Console.WriteLine("Phase 1 has started. You have " + attempts + @" attempts left
 ");
				//write the riddle
				Console.WriteLine(@"I am not alive, but I grow; I don’t have lungs, but I need air;
I don’t have a mouth, but water kills me. What am I?
 ");			
				//loop that checks their answer, if correct it will tell them so and
				//set winCondition to true, so that the next phase can start
				while(attempts != 0)
				{
					string answer = "Fire";
					if(answer == "Fire")
					{
						Console.WriteLine("Congratulations! The answer was fire.");
						//start next phase by changing to true
						p.winCondition = true;
						break;
					}
					if(answer != "Fire")
					{
						//inform user they are infact wrong and tell them how many more attempts
						Console.WriteLine("Sorry, your answer is incorrect...");
					    attempts -= 1;
						Console.WriteLine("You have " + attempts + @" attempts left
						 ");
					}
				    if(attempts == 0)
					{
						//if they have no more attempts, they lose..
						Console.WriteLine("You are out of attempts :( Thanks for playing!");
					}
				}
				break;
			//new case starts for Phase 2, same form as phase 1
			case States.Phase2:
				attempts = 3;
				Console.WriteLine("Phase 2 has started. You have " + attempts + @" attempts left
 ");
				Console.WriteLine(@"What has a neck but no head?
 ");			
				while(attempts != 0)
				{
					string answer = "a bottle";
					if(answer == "A bottle")
					{
						Console.WriteLine("Congratulations! The answer was A bottle.");
						break;
					}
					if(answer != "Fire")
					{
						Console.WriteLine("Sorry, your answer is incorrect...");
					    attempts -= 1;
						Console.WriteLine("You have " + attempts + @" attempts left
						 ");
					}
				    if(attempts == 0)
					{
						Console.WriteLine("You are out of attempts :( Thanks for playing!");
					}
				}
				break;
				//New case for phase 3, the same pattern follows as previous two phases, except if the answer is correct you get a pat on the back
			case States.endPhase:
				attempts = 3;
				Console.WriteLine("Phase 3 has started. You have " + attempts + @" attempts left
 ");
				Console.WriteLine(@"What has a neck but no head?
 ");			
				while(attempts != 0)
				{
					string answer = "a bottle";
					if(answer == "A promise")
					{
						Console.WriteLine("Congratulations! The answer was A promise. You won the Game!");
						break;
					}
					if(answer != "Fire")
					{
						Console.WriteLine("Sorry, your answer is incorrect...");
					    attempts -= 1;
						Console.WriteLine("You have " + attempts + @" attempts left
						 ");
					}
				    if(attempts == 0)
					{
						Console.WriteLine("You are out of attempts :( Thanks for playing!");
					}
				}
				break;
        }
    }
}