using ParseToRoman;
using System;

namespace Algorithmie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t===== Parse to Roman =====\n");
            Console.Write("Enter a number to convert : ");
            Console.Write("Enter a number to convert : ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number + " in roman = " + RomanParser.Parse(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad value");
            }
        }
    }
}
