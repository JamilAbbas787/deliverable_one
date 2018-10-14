using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part2
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime dateOne = Console.ReadLine(); ;
            //DateTime dateTwo;

            ////DateTime.TryParseExact(Console.ReadLine(),"MM/dd/yyy", 
            //  //  CultureInfo.In);

            Console.WriteLine("Enter a date (mm/dd/yyyy)");
            DateTime dateOne;

            bool checkDateOne = DateTime.TryParse(Console.ReadLine(), out dateOne);
             
            while (checkDateOne == false)
            {
                if (checkDateOne == false)
                {
                    Console.WriteLine("Invalid date entry. Please use the following format (mm/dd/yyyy)");
                    checkDateOne = DateTime.TryParse(Console.ReadLine(), out dateOne);
                    if(checkDateOne == true)
                    {
                        break;
                    }
                }
                           
                }
                //Console.WriteLine ("The first date is " + dateOne);
                //Console.ReadLine();

            Console.WriteLine("Enter another date (mm/dd/yyyy)");
            DateTime dateTwo;

            bool checkDateTwo = DateTime.TryParse(Console.ReadLine(), out dateTwo);

            while (checkDateTwo == false)
            {
                Console.WriteLine("Invalied date entry. Please use the following format (mm/dd/yyyy)");
                checkDateTwo = DateTime.TryParse(Console.ReadLine(), out dateTwo);
                if (checkDateTwo ==true)
                {
                    break;
                }
            }

            Console.WriteLine("The first date is {0}.", dateOne);
            //Console.ReadLine();

            Console.WriteLine("The second date is {0}.", dateTwo);
            //Console.ReadLine();


            TimeSpan timeSpan;

            timeSpan = dateOne - dateTwo;
                

            double totalDays, totalHours, totalMinutes;
            totalDays = timeSpan.TotalDays;
            totalHours = timeSpan.TotalHours;
            totalMinutes = timeSpan.TotalMinutes;

            Console.WriteLine("The difference in days is {0}, in hours is {1}, and in minutes {2}.", Math.Abs(totalDays), Math.Abs(totalHours), Math.Abs(totalMinutes));
            Console.ReadLine();

        
        }         
        
    }
}

