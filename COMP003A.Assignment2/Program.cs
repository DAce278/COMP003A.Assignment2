/*
 * Author: Deegan Acevedo
 * Course: COMP003A
 * Faculty: Jonathan Cruz
 * Purpose:
 */
namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            // Introduce variables
            string firstName;
            string lastName;
            int age;
            double price;
            bool isStudent;


            // Introductory title
            Console.WriteLine("*************************************\n" +
                                "Welcome to the Discount Calculator!\n" +
								"*************************************");

            // asks user for first name
            Console.Write("What is your first name? ");
            firstName = Console.ReadLine();

            // asks user for last name
            Console.Write("What is your last name? ");
            lastName = Console.ReadLine();

            // asks user for age
            Console.Write("What is your age? ");
            age = int.Parse(Console.ReadLine());

            // asks user for product price
            Console.Write("What is the price of the item you're interested in? ");
            price = double.Parse(Console.ReadLine());

            // asks user if they are a student
            Console.Write("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine());


            // conversion of values
            int newAge;
            newAge = age + 5;

            double studentPrice;
            studentPrice = price * 0.9; // applying discount
           

            double seniorPrice;
            seniorPrice = price * 0.8; // applying discount

            // output of information
            Console.WriteLine($"\n\n\n*************************************\n" +
                $"Hello {firstName} {lastName}!\n" + // Welcomes user by name
                $"Your current age is {age}.\n" + // Outputs users age
                $"In 5 years, you will be {newAge}.\n" + // Outputs users age in 5 years
                $"The original price of the item is ${price.ToString("N")}."); // Outputs price of item


            // output depending on user info

            if (isStudent) // output depending on if user is student (would be/is)
            {
                Console.WriteLine($"As a student, your discounted price is {studentPrice.ToString("N")}.");
            }
            else
            {
                Console.WriteLine($"As a student, your discounted price would be {studentPrice.ToString("N")}.");
            }

            if (age >= 60) // output depending on if user is a senior citizen (would be/is)
            {
                Console.WriteLine($"As a Senior, your discounted price is {seniorPrice.ToString("N")}.");
            }
            else
            {
                Console.WriteLine($"As a Senior, your discounted price would be {seniorPrice.ToString("N")}.");
            }

            Console.WriteLine("*************************************");











        }
    }
}
