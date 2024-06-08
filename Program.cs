using System;
using System.Diagnostics;

namespace project_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int day, day2 , addday;
            // input user //
            Console.Write(" Enter Number 1 to 7:");
            day = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter Number must <=7 :");
            day2= Convert.ToInt32(Console.ReadLine());

            addday = day+ day2;

            //processs
            DayCalculation(day, addday);
               
        }
        public static void DayCalculation(int day, int addday)
        {
             switch (addday)
                {
                    case 1:
                    //output
                    Monday();
                        break;
                    case 2:
                    Tuesday();
                        break;
                    case 3:
                    Wednesday();
                        break;
                    case 4:
                    Thursday();
                        break;
                    case 5:
                    Friday();
                    break;
                    case 6:
                    Saturday();
                        break;
                    case 7:
                    Sunday();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                
                }
            
        }
        public static void Monday()
        {
            Console.WriteLine("The day is Monday");
        }
        public static void Tuesday()
        {
            Console.WriteLine("The day is Tuesday");
        }

        public static void Wednesday()
        {
            Console.WriteLine("The day is Wednesday");
        }

        public static void Thursday()
        {
            Console.WriteLine("The day is Thursday");
        }
        public static void Friday()
        {
            Console.WriteLine("The day is Friday");
        }

        public static void Saturday()
        {
            Console.WriteLine("The day is Saturday");
        }

        public static void Sunday()
        {
            Console.WriteLine("The day is Sunday");
        }


    }

}
