namespace Assignment3Part2_SammiRoy;
using static System.Console;

internal class Program
{
    static void Main(string[] args)
    {
        // Initiate Variables
        bool loop = true;
        int menuChoice;

        // Init Arrays & Randomizer
        Random rand = new Random();


        while (loop)
        {
            menuChoice = GetMenuChoice();
            ParseChoice(menuChoice, ref loop);
        }
    }

    /// <summary>
    /// Displays the menu
    /// </summary>
    static void DisplayMenu()
    {
        Clear();
        WriteLine(
            "CPSC1012 Lotto Centre\n" +
            "-------------------------------------\n" +
            "1. Change Lotto MAX winning numbers\n" +
            "2. Change Lotto 6/49 winning numbers\n" +
            "3. Change Lotto EXTRA winning numbers\n" +
            "4. Play Lotto MAX\n" +
            "5. Play Lotto 6/49\n" +
            "0. Exit Program");
    }

    /// <summary>
    /// Check User Input 
    /// </summary>
    /// <returns></returns>
    static int GetMenuChoice()
    {
        // Display Menu
        DisplayMenu();

        // Get input from user
        string userInput = ReadLine();

        // Validate Input
        while (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4" && userInput != "5" && userInput != "0")
        {
            WriteLine("Error! Invalid menu selection.");
            DisplayMenu();
            userInput = ReadLine();
        }

        // Return valid input
        int selection = int.Parse(userInput);
        return selection;
    }

    static void ParseChoice(int userChoice,ref bool loop)
    {
        switch (userChoice)
        {
            case 0:
                // Break game loop, quitting program
                loop = false;
                break;
            case 1:
                // Change Lotto MAX winning numbers

                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
        }
    }

    static void AlterLottoMax()
    {

    }

    /// <summary>
    /// Prompt user for a string, check if it is not empty
    /// </summary>
    /// <param name="prompt">The message displayed to the user</param>
    /// <returns>A Non-Empty string</returns>
    static string GetNonEmptyString(string prompt)
    {
        string userInput;

        Write(prompt);
        userInput = ReadLine();

        while (string.IsNullOrEmpty(userInput))
        {
            Write("Error! Please try again: ");
            userInput = ReadLine();
        }

        return userInput;
    }

    /// <summary>
    /// Prompt user for an integer, check that it is positive
    /// </summary>
    /// <param name="prompt">The initial message displayed to the user</param>
    /// <returns>A postive integer</returns>
    static int GetPositiveInt(string prompt)
    {
        string userInput;
        int validOutput;

        Write(prompt);
        userInput = ReadLine();

        while (!int.TryParse(userInput, out validOutput) || validOutput <= 0)
        {
            Write("Error! Please try again: ");
            userInput = ReadLine();
        }

        return validOutput;
    }

}