namespace Assignment4Part2_SammiRoy;
using static Console;

internal class Program
{
    static void Main(string[] args)
    {
        MultipleChoiceQuestion question = new MultipleChoiceQuestion();
        
        question.QuestionText = "Enter a string";
        WriteLine(question.QuestionText);
    }
}