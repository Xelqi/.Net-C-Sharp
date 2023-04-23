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
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number");
                b = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR : Input string was not in a correct format.");
                
            }
            selection = Menu();

            if (selection > 0 && selection < 5)
            {
                ans = Calculate(selection, a, b);
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine("Wrong Choice");
            };


            int Menu()
            {
                
                Console.WriteLine("Make your Choice:\nSum(1)\nSubtraction(2)\nMultiplication(3)\nDivision(4)");
                int.TryParse(Console.ReadLine(), out int selectionOfMenu);
                return  selectionOfMenu;
            }

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
                        System.Environment.Exit(1);
                    }
                    result = (float)x/ (float)y;
                    return result;
                }
            }
        }
    }
}
