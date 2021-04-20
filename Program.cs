using System;
using System.Collections.Generic;
using System.Linq;

namespace CombinationOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputedNumber;
            Console.WriteLine("Enter your desired string: ");
            string inputedString = Console.ReadLine();
            Console.WriteLine("Enter the number of desired length: ");
            if ((int.TryParse(Console.ReadLine(), out inputedNumber)) != true) {
                Console.WriteLine("The number is not valid.");
            }
            Console.WriteLine();

            var inputedChar = inputedString.ToCharArray().Select(c => c.ToString()).ToList();
            var cnumber = inputedNumber + "-" + inputedChar.Count;
            recursiveFunction(cnumber, inputedChar);
        }

        private static int recursiveFunction(string cnumber, List<string> inputedChar)
        {
            var lengthOfString = inputedChar.Count;
            var TempChar = inputedChar;
            string outputstr = "";
            var cnumberDiv = cnumber.Split('-');

            if (int.Parse(cnumberDiv[1])<=0)
            {
                return 0;
            }
            else
            {
                for (int i = 1; i <= lengthOfString; i++)
                {
                    outputstr = outputstr + inputedChar[i - 1];
                    if (i == int.Parse(cnumberDiv[0]))
                    {
                        TempChar.Add(TempChar[0]);
                        TempChar.RemoveAt(0);
                        Console.WriteLine(outputstr);
                        break;
                    }
                }
                return recursiveFunction(cnumber[0] + "-" + (int.Parse(cnumberDiv[1]) - 1), TempChar );
            }
        }
    }
}
