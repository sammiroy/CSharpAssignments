namespace UnicornRaceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trackLength = 20;
            int playerPos = 17;

            // Gameplay Loop
            while (true)
            {
                //DRAW TRACK, NO TOUCHY
                for (int i = 0; i < trackLength; i++)
                {
                    Console.Write("=");
                }
                Console.WriteLine();
                Console.WriteLine();
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
                for (int i = 0; i < trackLength; i++)
                {
                    Console.Write("=");
                }
            }
            
        }

        static void DrawTrack(int trackLength, int playerPos)
        {
            
        }
    }
}