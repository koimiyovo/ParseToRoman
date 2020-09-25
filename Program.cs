using System;
using System.Text;

namespace Algorithmie
{
    class Program
    {
        public static string ParseToRoman(int number)
        {
            StringBuilder result = new StringBuilder();

            int[] decimalArray = new int[] { 1000, 500, 100, 50, 10, 5, 1 };
            string[] romanArray = new string[] { "M", "D", "C", "L", "X", "V", "I" };

            for (int i = 0; i < decimalArray.Length; i++)
            {
                while (number % decimalArray[i] < number)
                {
                    number -= decimalArray[i];
                    result.Append(romanArray[i]);
                }
            }

            return result.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t===== Parse to Roman =====\n");
            Console.Write("Enter a number to convert : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number + " in roman = " + ParseToRoman(number));
        }
    }
}
