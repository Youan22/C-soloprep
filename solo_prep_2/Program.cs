using System;

namespace solo_prep_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your grade: "); 
            String gradeFromUser = Console.ReadLine();

            int grade = int.Parse(gradeFromUser);
           

            if (grade >= 90)
            {
                Console.WriteLine("Your letter grade is: A");
            }
            else if (grade >= 80) 
            {
                Console.WriteLine("Your letter grade is: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your letter grade is: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("Your letter grade is: D");
            }
            else
            {
                Console.WriteLine("Your letter grade is: F");
            }
            if (grade >= 70)
            {
                Console.WriteLine("Congratulations! You passed the class.");
            }
            else
            {
                Console.WriteLine("Please, take your studies more serious in the future!");
            }

        }
    }
}        