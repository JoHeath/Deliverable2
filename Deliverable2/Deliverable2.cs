// Welcome to the challenge
Console.WriteLine("Welcome to the coin flip challenge.");
// Asks player their name
Console.WriteLine("What is your name?");
string playersName = Console.ReadLine();
// Asks the player if they would like to play
Console.WriteLine(playersName + " Would you like to do the coin flip challenge?" + " y or n");
string userInput = Console.ReadLine().ToLower();

// Checks if a valid input
if (userInput != "y" && userInput != "n")
{
    Console.WriteLine("Invalid entry");
}

// variables for score tracking
int Heads = 0;
int Tails = 0;
int Score = 0;

// loop for rounds
for (int flips = 0; flips < 5; flips++)
{
    Random coin = new Random();
    int flip = coin.Next(0, 3);


    if (userInput == "y")
    {
        Console.WriteLine("Heads or Tails?");
        string userInput2 = Console.ReadLine().ToLower();

        // Checks if a valid input  
        if (userInput2 != "heads" && userInput2 != "tails")
        {
            Console.WriteLine("Invalid entry");
            break;
        }


        // Checks if guess was correct
        if (userInput2 == "heads" && flip == 1)
        {
            Console.WriteLine("Correct"); Score++;
        }

        if (userInput2 == "tails" && flip == 1)
        {
            Console.WriteLine("Wrong");
        }

        if (userInput2 == "tails" && flip == 2)
        {
            Console.WriteLine("Correct"); Score++;
        }

        if (userInput2 == "heads" && flip == 2)
        {
            Console.WriteLine("Wrong");
        }



        if (flip == 1)
        {
            Console.WriteLine("It's Heads"); Heads++;
        }
        else
        {
            Console.WriteLine("It's Tails"); Tails++;
        }



    }
}



while (userInput == "n")
{
    Console.WriteLine("You are a coward " + playersName);
    break;
}



Console.WriteLine("Thank you " + playersName + " for taking the Coin Flip CHALLENGE!");

Console.WriteLine("you got a score of " + Score + " Congratulations!");

Console.WriteLine("Play again to try for a better score");