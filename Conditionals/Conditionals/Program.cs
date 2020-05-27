using System;
using System.Xml.Serialization;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Day 2 Conditionals\n\n");
                Console.WriteLine("Select a procedure to run");
                Console.WriteLine("1 - Grading scale");
                Console.WriteLine("2 - Hello Words");
                Console.WriteLine("3 - Ride the Raptor... or not");
                Console.WriteLine("4 - Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        GetGrade();
                        break;
                    case 2:
                        HelloWorlds();
                        break;
                    case 3:
                        RideTheRaptor();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again\n");
                        break;
                }
            }
            while (choice != 4);
        }

        static void GetGrade()
        {
            int percent = 0;
            string continueChoice = "y";

            Console.WriteLine("Welcome to the Letter Grade Converter\n");

            do
            {
                Console.WriteLine("Enter a numerical grade");
                if ((int.TryParse(Console.ReadLine(), out percent)) && (percent <= 100) && (percent >= 0))
                {
                    Console.Write("Letter Grade: ");
                    if ((percent >= 88) && (percent <= 100))
                    {
                        Console.WriteLine("A");
                    }
                    else if (percent >= 80)
                    {
                        Console.WriteLine("B");
                    }
                    else if(percent >= 67)
                    {
                        Console.WriteLine("C");
                    }
                    else if(percent >= 60)
                    {
                        Console.WriteLine("D");
                    }
                    else
                        Console.WriteLine("F");

                }
                else
                {
                    Console.WriteLine("Invalid percent grade. Please try again\n");
                }
                Console.WriteLine("Continue? [y/n]");
                continueChoice = Console.ReadLine();
            }
            while (continueChoice.Trim().ToLower() != "n");
        }

        static void HelloWorlds()
        {
            string language = "";
            string continueChoice = "y";

            do
            {
                Console.WriteLine("Enter a language");
                language = Console.ReadLine().Trim().ToLower();
                switch (language)
                {
                    case "english":
                        Console.WriteLine("Hello World");
                        break;
                    case "spanish":
                        Console.WriteLine("¡Hola Mundo!");
                        break;
                    case "dutch":
                        Console.WriteLine("Hallo wereld!");
                        break;
                    default:
                        Console.WriteLine("Invalid language.\n");
                        break;
                }
 
                Console.WriteLine("Would you like to continue? [y/n]");
                continueChoice = Console.ReadLine();
            }
            while (continueChoice.Trim().ToLower() != "n");

        }

        static void RideTheRaptor()
        {
            double height = 0.0;
            string continueChoice = "y";

            do
            {
                Console.Write("Enter your height in inches: ");
                if (double.TryParse(Console.ReadLine(), out height))
                {
                    if (height >= 54.0)
                    {
                        Console.WriteLine("Great, you can ride the Raptor!");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, you cannot ride the raptor. You need {String.Format("{0:0.00}",(54.0 - height))} more inches");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid height. Please try again\n");
                }

                Console.WriteLine("Would you like to continue? [y/n]");
                continueChoice = Console.ReadLine();
            }
            while (continueChoice.Trim().ToLower() != "n");
        }
    }
}
