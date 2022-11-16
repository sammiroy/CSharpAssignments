namespace Assignment3Part1_SamanthaRoy;

using System.Collections;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        /*
         Purpose: An application to simulate a game of craps & pig, using methods and menus

        Inputs:
            
        Outputs:

        Algorithm:

        Test Plan:
            Test Case       Test Data       Expected Results

            ---------       ---------       ----------------

        Written By: Samantha Roy

        Written For: Shane Bell

        Section No: A01

        Last Modified: 2022.11.15
         */
        
        // IN/AS VARIABLES
        Random dice = new Random();
        int menuChoice = 1;
        // INIT VARIABLES
        string userInput;
        int bettingAmount;
        while (menuChoice != 0)
        {
            // Reset Variables
            bettingAmount = 0;
            userInput = "";
            // Display & Parse Selection
            DisplaySelection(ref userInput,ref menuChoice);
            ParseSelection(ref menuChoice, ref bettingAmount, ref dice);
        }
    }

    // MENU SELECTION
    // MENU PSUDEOCODE

    // Display menu
    // Prompt user for input
    // Validate input
    // Process input
    static int DisplaySelection(ref string userInput,ref int menuChoice)
    {
        Clear();
        Write(
            "CPSC1012 Casino" +
            "\n---------------" +
            "\n1. Play Craps" +
            "\n2. Play Pig" +
            "\n0. Exit Program" +
            "\n---------------" +
            "\nEnter Menu Choice: "
            );
        userInput = ReadLine();

        while(!int.TryParse(userInput,out menuChoice) || menuChoice < 0 || menuChoice > 2)
        {
            Write("Error! Try Again: ");
            userInput = ReadLine();
        }

        return menuChoice;
    }

    static void ParseSelection(ref int menuChoice, ref int bettingAmount, ref Random dice)
    {
        switch (menuChoice)
        {
            case 1:
                PlayCraps(ref bettingAmount, ref dice);
                break;
            case 2:
                PlayPig(ref dice);
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// Prompt the user for an integer > 0
    /// </summary>
    /// <param name="prompt">Display this inital message when calling the method</param>
    /// <returns>An integer > 0 </returns>
    static int GetValidPositiveInt(string prompt)
    {
        // Init Local Variables
        string userInput;
        int validOutput;

        // Display prompt passed through
        Write(prompt);

        // Assign prompt to userInput
        userInput = ReadLine();

        while(!int.TryParse(userInput,out validOutput) || validOutput <= 0)
        {
            WriteLine("Error! Invaild input, please try again: ");
             userInput = ReadLine();
        }
        return validOutput;
    }


    // GAME METHODS

    static void PlayCraps(ref int bettingAmount, ref Random dice)
    {
        // CRAPS PSUDEOCODE

        // Prompt User for int > 0 as betting amount
        // Roll 2d6
        // Calculate the sum of the roll
        // If the sum is 2, 3, 12 (Craps), user loses
            // Display betting amount loss
        // If the sum is 7 or 11 (Naturals), user wins
        // Display betting amount won
        // Else the sum becomes the "point"
        // Roll again
        // If sum is equal to the point, user wins
        // Display amount won
        // If a sum is equal to 7, user loses
        // Display amount lost
        // Roll until the solution is found
        // Prompt use to play another round (y/n)
        //If no, display betting total
        
        // TODO
        // - Fix points

        // INIT VARIABLES
        // Assign the current betting amount and the bet for round
        int betForRound;
        int totalBet;
        int rollSum;
        bool playAgain = true;
        string userInput;

        while (playAgain)
        {
            bettingAmount += GetValidPositiveInt("Enter Ante: ");

            betForRound = bettingAmount;

            // Roll dice & display sum equation
            int temp1 = dice.Next(1, 7);
            int temp2 = dice.Next(1, 7);
            rollSum = temp1 + temp2;
            WriteLine($"You rolled {temp1} + {temp2} = {rollSum}");
            
            // Interpret rollSum's outcome
            if (rollSum == 2 || rollSum == 3 || rollSum == 12)
            {
                WriteLine($"You lost ${betForRound}.00");
                bettingAmount -= betForRound;
            } else if (rollSum == 7 || rollSum == 11)
            {
                WriteLine($"You won ${betForRound}.00");
                bettingAmount += betForRound;
            } else
            {
                int point = rollSum;
                WriteLine($"The point is {point}");

                bool loop = true;
                while (loop)
                {
                    int temp3 = dice.Next(1, 7);
                    int temp4 = dice.Next(1, 7);
                    rollSum = temp3 + temp4;
                    WriteLine($"You rolled {temp1} + {temp2} = {rollSum}");
                    if (rollSum == 7 || rollSum == point)
                    {
                        loop = false;
                    }
                    
                    if (rollSum == 7)
                    {
                        WriteLine($"You lost ${betForRound}.00");
                        bettingAmount -= betForRound;
                    } else if (rollSum == point)
                    {
                        WriteLine($"You won ${betForRound}.00");
                        bettingAmount += betForRound;
                    }
                }
            }

            Write("Would you like to play again? (Y/N): ");
            userInput = ReadLine().ToLower();
            while (userInput != "y" && userInput != "n")
            {
                Write("Error! Please try again: ");
                userInput = ReadLine().ToLower();
            }

            if (userInput == "n")
            {
                playAgain = false;
            }
        }
    }

    static void PlayPig(ref Random dice)
    {
        // PIG PSUDEOCODE

        // Prompt user for amount of points needed to win
        // Player goes first
        // Roll a d6, display the result
        // If it is a 1, end user's turn immediately and they do not gain any points accumulated during this turn
        // Else add that to current point accumulated
        // Prompt user if they would like to roll again or "hold"
        // Hold ends the user's turn but gives them the points
        // Computer's turn
        // Roll d6, displaying the result
        // IF the compter has accumulated 10 points this turn, hold 
        // Else, keep rolling
        // If the computer rolls a 1 or wins, end the turn immediately

        int goalSum = GetValidPositiveInt("Enter the point total to play for: ");
        bool noWinner = true;
        bool isNotHolding = true;
        string userInput;
        int userPointTotal = 0;
        int systemPointTotal = 0;
        int turnTotal;
        int turnState = 0;
        int roll = 0; 
        while (noWinner)
        {

            // PLAYER TURN
            if (turnState == 0)
            {
                turnTotal = 0;
                WriteLine("It is your turn.");

                // Roll Dice
                while (roll != 1 || isNotHolding)
                {
                    roll = dice.Next();
                    turnTotal += roll;
                    WriteLine($"You rolled a {roll}");

                    // If the roll is 1, 
                    if (roll == 1)
                    {
                        turnTotal = 0;
                    } else
                    {
                        Write("Would you like to hold or roll? (r/h): ");
                        userInput = ReadLine().ToLower();
                        while(userInput != "r" && userInput != "h")
                        {
                            userInput = ReadLine().ToLower();
                        }
                    }
                }

                
                turnState = 1;
            } 
            // COMPUTER TURN
            else if (turnState == 1)
            {
                turnTotal = 0;

                turnState = 0;
            }

            // DISPLAY CURRENT POINTS
            WriteLine(userPointTotal);
            WriteLine(systemPointTotal);
        }


    }
}