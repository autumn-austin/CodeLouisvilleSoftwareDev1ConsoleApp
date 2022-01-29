using System;

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

            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
            Console.WriteLine("Program exited");
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
                    Console.WriteLine("Your choice was to subtract two numbers");
                    break;
                case '3':
                    Console.WriteLine("Your choice was to remove whitespace from a string");
                    break;
                case '4':
                    Console.WriteLine("Your choice was to reverse a string");
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
            Console.WriteLine("Your choice was to add two numbers");
        }
    }
}
