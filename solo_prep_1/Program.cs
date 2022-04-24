using System;

namespace solo_prep_1
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("This is solo prep 1");
            Console.WriteLine();
            Console.Write("What is your first name? ");
            String fName = Console.ReadLine();

            Console.Write("What is your last name? ");
            String lName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"Your name is {fName},{fName} {lName}.");
            Console.WriteLine();
            // Write your code here
        }
    }
}
