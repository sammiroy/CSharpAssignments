namespace Assignment3Part2_SammiRoy;

internal class Program
{
    static void Main(string[] args)
    {
        
    }

    // Display Menu, process information
    static void DisplayMenu()
    {
        Console.WriteLine(
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
    /// Prompt user for a string, check if it is not empty
    /// </summary>
    /// <param name="prompt">The message displayed to the user</param>
    /// <returns>A Non-Empty string</returns>
    static string GetNonEmptyString(string prompt)
    {
        string userInput;

        Console.Write(prompt);
        userInput = Console.ReadLine();

        while (string.IsNullOrEmpty(userInput))
        {
            Console.WriteLine("Error, invalid string!");
            Console.Write("Please try again: ");
            userInput = Console.ReadLine();
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

        Console.Write(prompt);
        userInput = Console.ReadLine();

        while (!int.TryParse(userInput, out validOutput) || validOutput < 0)
        {
            Console.WriteLine("Error, inavlid integer!");
            Console.Write("Please try again: ");
            userInput = Console.ReadLine();
        }

        return validOutput;
    }

}