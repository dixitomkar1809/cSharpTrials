using System;

namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            //string name = "Omkar Dixit";
            //int age = 24;
            //Console.WriteLine("{0} is {1}", name, age);

            getAppInfo();

            greetUser();

            while (true) { 
                // Set correct number
                // int correctNumber = 7;

                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init guess variable
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                // Runs till the user doesn't guess the number
                while (guess != correctNumber) {
                    string input = Console.ReadLine();
                    if(!int.TryParse(input, out guess))
                    {
                        printColorMessage(ConsoleColor.Red, "Please Enter a Number!");
                        continue;
                    }
                    guess = Int32.Parse(input);
                    if (guess != correctNumber) {
                        printColorMessage(ConsoleColor.Red, "Wrong! Try Again!");
                    }
                }

                printColorMessage(ConsoleColor.Green, "Correct!");

                Console.WriteLine("Play Again? [Y or N]");
                string ans = Console.ReadLine().ToUpper();
                if( ans == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }

        }

        static void getAppInfo()
        {

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Omkar Nandkumar Dixit";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }

        static void greetUser()
        {
            Console.WriteLine("What is your Name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void printColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
