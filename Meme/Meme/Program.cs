using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meme
{
    class Program
    {
        static void Main(string[] args)
        {

            var numberOne = 459;

            var numberOneDigitOne = numberOne % 10;
            var numberOneDigitTwo = (((numberOne % 100) - numberOneDigitOne) / 10);
            var numberOneDigitThree = ((numberOne - (numberOneDigitTwo * 10) - numberOneDigitOne) / 100);
            Console.WriteLine(numberOneDigitOne);
            Console.WriteLine(numberOneDigitTwo);
            Console.Write(numberOneDigitThree);
         
            Console.ReadLine();



        }
    }
}
