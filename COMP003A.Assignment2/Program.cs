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
            studentPrice.ToString("F2");
           

            double seniorPrice;
            seniorPrice = price * 0.8; // applying discount

            // outputs information
            Console.WriteLine($"\n\n\n*************************************\n" +
                $"Hello {firstName} {lastName}!\n" + // Welcomes user by name
                $"Your current age is {age}\n" + // Outputs users age
                $"In 5 years, you will be {newAge}\n" + // Outputs users age in 5 years
                $"The original price of the item is ${price}.\n" + // Outputs price of item
                $"As a student, your discounted price is ${studentPrice}\n" + // Outputs student discount
                $"As a senior, your discounted price would be {seniorPrice}"); // Outputs senior discount


            


           

        }
    }
}
