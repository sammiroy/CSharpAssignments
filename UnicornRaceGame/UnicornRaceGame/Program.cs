namespace UnicornRaceGame
{
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

            Console.Write("Please enter a track length: ");
            playerInput = Console.ReadLine();

            // Validate Track Length is >0
            while (!int.TryParse(playerInput, out trackLength) || trackLength < 1)
            {
                Console.Clear();
                Console.WriteLine("Error! You have entered an invalid track length.");
                Console.Write("Please enter a valid track length (int > 0): ");
                playerInput = Console.ReadLine();
            }
            // Gameplay Loop
            while (noWinner)
            {
                Console.Clear();
                // Display Stats
                Console.WriteLine($"You are at position {playerPos+1}, you rolled a {playerPrevRoll} last round");
                Console.WriteLine($"Your rival is at position {enemyPos + 1}, they rolled a {enemyPrevRoll} last round");

                // Draw Track 
                // Top Fence
                for (int i = 0; i < trackLength; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
                Console.WriteLine();
                // Player
                for (int i = 0; i < trackLength; i++)
                {
                    if (playerPos == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
                Console.WriteLine();
                //  Enemy
                for (int i = 0; i < trackLength; i++)
                {
                    if (enemyPos == i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
                Console.WriteLine();
                for (int i = 0; i < trackLength; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
                Console.WriteLine("Press Enter to go next roll.");
                Console.ReadLine();

                // Check if an ending state has been achieved
                if (playerPos >= trackLength-1 || enemyPos >= trackLength-1)
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
}