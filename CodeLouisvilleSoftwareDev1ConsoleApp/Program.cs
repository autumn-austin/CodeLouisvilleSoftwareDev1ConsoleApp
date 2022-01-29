using System;
using System.Linq;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                keepRunning = MainMenu();
            }
            // go back to menu
            //   go back to beginning
            // unless choice is exit
            //   exit application

        }

        public static bool MainMenu()
        {
            // show user a menu
            Console.WriteLine("Main Menu:");

            //  offer options to user
            //   - ADD TWO NUMBERS
            Console.WriteLine("1. Add two numbers");
            //   - SUBTRACT TWO NUMBERS
            Console.WriteLine("2. Subtract two numbers");
            //   - remove whitespace from a string
            Console.WriteLine("3. Remove whitespace from a string");
            //   - reverse a string
            Console.WriteLine("4. Reverse a string");
            //  ATTEMPT ERROR HANDLING (user does something i am not expecting)
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            // ask for their choice
            char userChoice = Console.ReadKey().KeyChar;

            Console.Clear();
            // do their choice
            switch (userChoice)
            {
                case '1':
                    AddTwoNumbers();
                    break;
                case '2':
                    SubtractTwoNumbers(); 
                    break;
                case '3':
                    RemoveWhiteSpace();
                    break;
                case '4':
                    ReverseString();
                    break;
                case '5':
                    return false;
            }
            Console.WriteLine("Press n to exit program");
            Console.WriteLine("Press any other key to return to main menu");
                
            userChoice = Console.ReadKey().KeyChar;
            if (userChoice == 'n')
            {
                return false;
            }

            Console.Clear();
            return true;
        }

        public static void AddTwoNumbers()
        {
            Console.WriteLine("Your choice was to add two numbers!");
            int Number1, Number2;
            Console.Write("Please enter first number: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter second number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Result;
            Result = Number1 + Number2;
            Console.WriteLine("Sum of two Numbers:" + Result.ToString());
            Console.WriteLine("");
        }

        public static void SubtractTwoNumbers()
        {
            Console.WriteLine("Your choice was to add two numbers!");
            int Number1, Number2;
            Console.Write("Please enter first number: ");
            Number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter second number: ");
            Number2 = Convert.ToInt32(Console.ReadLine());
            int Result;
            Result = Number1 - Number2;
            Console.WriteLine("Difference of two Numbers:" + Result.ToString());
            Console.WriteLine("");
        }

        public static void RemoveWhiteSpace()
        {
            Console.WriteLine("Your choice was to remove whitespace from a string!");
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter your middle name or initial: ");
            string middleName = Console.ReadLine();

            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("You entered '{0}', '{1}', and '{2}'.",
                            firstName, middleName, lastName);

            string name = ((firstName.Trim() + " " + middleName.Trim()).Trim() + " " +
                        lastName.Trim()).Trim();
            Console.WriteLine("The result is " + name + ".");
        }

        public static void ReverseString()
        {
            Console.WriteLine("Your choice was to reverse a string!");
            Console.WriteLine("Enter the string to reverse: ");
            string name = Console.ReadLine();
            string output = new string(name.ToCharArray().Reverse().ToArray());
            Console.WriteLine(output);
        }
    }
}
