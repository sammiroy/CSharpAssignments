using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;

namespace Assignment4Part3_SammiRoy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person sammi = new Person("Sammi", new DateTime(2004, 1, 25));
            Person dominique = new Person("Dominique", new DateTime(2004, 7, 1));
            Person dj = new Person("Douglas Jouglas", new DateTime(2005, 1, 12));
            Person james = new Person("James", new DateTime(2003, 2, 23));
            Person mom = new Person("Marsha", new DateTime(1972, 11, 26));
            Person risza = new Person("Risza", new DateTime(1989, 7, 25));
            Person bepo = new Person("Beppo", new DateTime(2001, 10, 10));
            Person zero = new Person("Zeroo", new DateTime(2004, 1, 7));

            Console.WriteLine(sammi.AstrolgoicalSign());
            Console.WriteLine(dominique.AstrolgoicalSign());
            Console.WriteLine(dj.AstrolgoicalSign());
            Console.WriteLine(james.AstrolgoicalSign());
            Console.WriteLine(mom.AstrolgoicalSign());
            Console.WriteLine(risza.AstrolgoicalSign());
            Console.WriteLine(bepo.AstrolgoicalSign());
            Console.WriteLine(zero.AstrolgoicalSign());
        }
    }
}