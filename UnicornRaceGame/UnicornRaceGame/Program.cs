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
        Random roll = new Random();

        // Set Variables
        int playerPrevRoll = 0, enemyPrevRoll = 0;
        bool noWinner = true;
        int playerPos = 0;
        int enemyPos = 0;

        
        // Player Assigned Values

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
            Clear();
            // Display Stats
            WriteLine($"You are at position {playerPos+1}, you rolled a {playerPrevRoll} last round");
            WriteLine($"Your rival is at position {enemyPos + 1}, they rolled a {enemyPrevRoll} last round");

            // Draw Track 
            // Top Fence
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

            // Roll New Positions 
            playerPrevRoll = roll.Next(1, 7);
            playerPos += playerPrevRoll;

            enemyPrevRoll = roll.Next(1, 7);
            enemyPos += enemyPrevRoll;
            
        }
    }
}