using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Part1
{
    class Program
    {
        static void Main(string[] args)
        {

            String inputOne;
            Console.WriteLine("Enter a 3 digit number between 100 and 999!");
            inputOne = Console.ReadLine();

            int numberOne;
            bool successfulNumber = (int.TryParse(inputOne, out numberOne));

            while (successfulNumber == false)
            {

                if (successfulNumber == false)
                {

                    {

                        Console.WriteLine("Enter a 3 digit number between 100 and 999!");

                        inputOne = Console.ReadLine();

                        successfulNumber = (int.TryParse(inputOne, out numberOne));

                        if (successfulNumber == true)

                        {

                            successfulNumber = true;

                        }

                        if (successfulNumber == true)

                            break;

                    }

                }

            }

            if (numberOne > 999 || numberOne < 100)
            {

                while (numberOne > 999 || numberOne < 100)

                {

                    Console.WriteLine("Enter a 3 digit number between 100 and 999!");

                    inputOne = Console.ReadLine();

                    int.TryParse(inputOne, out numberOne);

                    if (numberOne <= 999 && numberOne >= 100)
                    {
                        break;
                    }
                }



            }
            else { }

            Console.WriteLine("Enter another 3 digit number between 100 and 999!");
            string inputTwo = Console.ReadLine();

            int numberTwo;
            bool succesfulNumberTwo = (int.TryParse(inputTwo, out numberTwo));

            while (succesfulNumberTwo == false)
            {
                if (succesfulNumberTwo == false)
                {
                    {
                        Console.WriteLine("Enter a 3 digit number between 100 and 999!");
                        inputTwo = Console.ReadLine();
                        succesfulNumberTwo = (int.TryParse(inputTwo, out numberTwo));

                        if (succesfulNumberTwo == true)
                        {
                            succesfulNumberTwo = true;
                        }

                        if (succesfulNumberTwo == true)
                            break;
                    }
                }
            }



            if (numberTwo > 999 || numberTwo < 100)
            {
                while (numberTwo > 999 || numberTwo < 100)
                {

                    Console.WriteLine("Enter another 3 digit number between 100 and 999!");
                    inputTwo = Console.ReadLine();
                    int.TryParse(inputTwo, out numberTwo);
                    if (numberTwo <= 999 && numberTwo >= 100)
                    {
                        break;
                    }
                }
            }

            else { }
    
            if (NumberCalc(inputOne, inputTwo))  {
                Console.WriteLine("True");
                Console.ReadLine();          
            } else
            {
                Console.WriteLine("False");
                Console.ReadLine();
            }




        }

        public static bool NumberCalc(string valueOne, string valueTwo)
        {
            int[] inputOneBreakdown = new int[valueOne.Length];

            for (int i = 0; i < inputOneBreakdown.Length; i++)
            {
                inputOneBreakdown[i] = Int32.Parse(valueOne[i].ToString());
            }


            int numberOneHundreds = inputOneBreakdown[0];
            int numberOneTens = inputOneBreakdown[1];
            int numberOneSingle = inputOneBreakdown[2];


            int[] inputTwoBreakdown = new int[valueTwo.Length];

            for (int i = 0; i < inputTwoBreakdown.Length; i++)
            {
                inputTwoBreakdown[i] = Int32.Parse(valueTwo[i].ToString());
            }

            int numberTwoHundreds = inputTwoBreakdown[0];
            int numberTwoTens = inputTwoBreakdown[1];
            int numberTwoSingle = inputTwoBreakdown[2];


            /*Console.WriteLine("Number one is " + numberOneHundreds + " number two is " + numberOneTens + " last number is " + numberOneSingle +
                " number two is " + numberTwoHundreds + " number two.two " + numberTwoTens + " number two.three " + numberTwoSingle);
            Console.ReadLine(); */

            if ((numberOneHundreds + numberTwoHundreds) == (numberOneTens + numberTwoTens) == (numberOneSingle == numberTwoSingle))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
