using System;
using System.Diagnostics;

namespace project_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2 , addday;
            Console.Write(" Enter Number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            addday = num1 + num2;
            
                switch (addday)
                {
                    case 1:
                        Console.WriteLine("The day is Monday");
                        break;
                    case 2:
                        Console.WriteLine("The day is Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("The day is Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("The day is Thursday");
                        break;
                    case 5:
                        Console.WriteLine("The day is Friday");
                        break;
                    case 6:
                        Console.WriteLine("The day is Saturday");
                        break;
                    case 7:
                        Console.WriteLine("The day is Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                
            }
        }
    }

}
