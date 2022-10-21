namespace UnicornRaceGame;
using static System.Console;
internal class Program
{
    static void Main(string[] args)
    {
        // INIT VARS
        // Unset Variables
        string playerInput;
        int trackLength;
        bool noWinner;
        Random roll = new Random();

        // Set Variables
        int playerPrevRoll = 0, enemyPrevRoll = 0;
        bool isStillPlaying = true;
        int playerPos = 0;
        int enemyPos = 0;
        int totalWins = 0, totalLosses = 0, totalDraws = 0;

        
        while (isStillPlaying)
        {
            // Reset noWinner & postitions
            noWinner = true;
            playerPos = 0;
            enemyPos = 0;
            playerPrevRoll = 0;
            enemyPrevRoll = 0;

            // Player Assigned Values
            Clear();
            Write("Please enter a track length: ");
            playerInput = ReadLine();

            // Validate Track Length is >0
            while (!int.TryParse(playerInput, out trackLength) || trackLength < 1)
            {
                Clear();
                WriteLine("Error! You have entered an invalid track length.");
                Write("Please enter a valid track length (int > 0): ");
                playerInput = ReadLine();
            }
            // Gameplay Loop
            while (noWinner)
            {

                // Display Stats
                Clear();
                WriteLine($"You are at position {playerPos + 1}, you rolled a {playerPrevRoll} last round");
                WriteLine($"Your rival is at position {enemyPos + 1}, they rolled a {enemyPrevRoll} last round");

                // Draw Track 
                // Top Wall
                for (int i = 0; i < trackLength; i++)
                {
                    Write("=");
                }
                WriteLine();
                WriteLine();
                // Player
                for (int i = 0; i < trackLength; i++)
                {
                    if (playerPos == i)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }

                }
                WriteLine();
                WriteLine();
                //  Enemy
                for (int i = 0; i < trackLength; i++)
                {
                    if (enemyPos == i)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }

                }
                WriteLine();
                WriteLine();
                // Bottom Wall
                for (int i = 0; i < trackLength; i++)
                {
                    Write("=");
                }
                WriteLine();
                WriteLine("Press Enter to go next roll.");
                ReadLine();

                // Check if an ending state has been achieved
                if (playerPos >= trackLength - 1 || enemyPos >= trackLength - 1)
                {
                    noWinner = false;
                }

                // Roll New Positions (If there isn't a winner)
                if (noWinner)
                {
                    playerPrevRoll = roll.Next(1, 7);
                    playerPos += playerPrevRoll;

                    enemyPrevRoll = roll.Next(1, 7);
                    enemyPos += enemyPrevRoll;

                    // Ensure players do not leave the track
                    if (playerPos > trackLength - 1)
                        playerPos = trackLength - 1;
                    if (enemyPos > trackLength - 1)
                        enemyPos = trackLength - 1;

                }

                // If there is a victor/draw
                if (!noWinner)
                {
                    // Determine Victor
                    if (playerPos == enemyPos)
                    {
                        // Draw
                        Clear();
                        WriteLine("Draw!");
                        totalDraws++;
                    }
                    else if (playerPos > enemyPos)
                    {
                        // Player Win
                        Clear();
                        WriteLine("You Win!");
                        totalWins++;
                    }
                    else if (playerPos < enemyPos)
                    {
                        // Enemy Win
                        Clear();
                        WriteLine("You Lose!");
                        totalLosses++;
                    }

                    // Prompt Player to play again
                    Write("Would you like to play again? (Y/N): ");
                    playerInput = ReadLine().ToLower();
                    while (playerInput != "n" && playerInput != "y")
                    {
                        Write("Invalid input! Would you like to play again? (Y/N): ");
                        playerInput = ReadLine().ToLower();
                    }

                    if (playerInput == "n")
                    {
                        isStillPlaying = false;
                    }
                }
            }
        }
        Clear();
        WriteLine("Thank you for playing!");
        WriteLine($"Games won: {totalWins}");
        WriteLine($"Games lost: {totalLosses}");
        WriteLine($"Games drawn: {totalDraws}");
        ReadLine();
    }
}