using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Dumagpi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input, reverse;

            Console.Write("Enter a String: ");
            input = Console.ReadLine();
            input = input.Replace(" ", "");

            char[] getVal = input.ToCharArray();
            Array.Reverse(getVal);

            reverse = new string(getVal);
            bool test = input.Equals(reverse, StringComparison.CurrentCultureIgnoreCase);

            if (test == true)
            {
                Console.WriteLine(input + " is a Palindrome");
            }
            else
            {
                Console.WriteLine(input + " is not a Palindrome");
            }
            Console.Read();
        }
    }
}
        