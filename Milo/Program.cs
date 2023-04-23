using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            float ans;
            int selection;
            try
            {
                Console.WriteLine("Enter your first number");
                // int.Parse converts the users input into a integer
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number");
                b = int.Parse(Console.ReadLine());
            }
            // Catch Format Exception checks if the user puts in a non numeric value
            catch (FormatException)
            {
                Console.WriteLine("ERROR : Input string was not in a correct format.");
                
            }
            // Passing the return value of menu into selection which is a int
            selection = Menu();

            // Based off menu function return value we do a if statement to check if the value was between 0 - 4
            if (selection > 0 && selection < 5)
            {
                // We put the selection value into the Calculate function by passing it and passing values a & b which were
                // entered at the start, the return from Calculate is passed into ans and printed
                ans = Calculate(selection, a, b);
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            };


            // This is the menu function that takes the users input and returns it as a int
            int Menu()
            {
                
                Console.WriteLine("Make your Choice:\nSum(1)\nSubtraction(2)\nMultiplication(3)\nDivision(4)");
                int.TryParse(Console.ReadLine(), out int selectionOfMenu);
                return  selectionOfMenu;
            }

            // Calculate function that takes the input which was given at start does maths based on those numbers
            float Calculate(int choice, int x, int y)
            {
                float result;
                if (choice == 1) 
                {
                    result = x + y;
                    return result;
                }
                else if (choice == 2)
                {
                    result = x - y;
                    return result;
                }
                else if (choice == 3)
                {
                    result = x * y;
                    return result;
                }
                else
                {   
                    if ( y == 0)
                    {
                        Console.WriteLine("You cannot divide by 0");

                        // Exit if the user uses 0 as a number to divide
                        System.Environment.Exit(1);
                    }
                    result = (float)x/ (float)y;
                    return result;
                }
            }
        }
    }
}
