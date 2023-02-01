using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            Console.WriteLine("Reversed string: " + Reverse(input));
        }

        /// <summary>
        /// Reverses the input string
        /// </summary>
        /// <param name="input">The input string to be reversed</param>
        /// <returns>The reversed string</returns>
        static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
