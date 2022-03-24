using System;
using System.Text.RegularExpressions;

namespace RegexPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regex UC 2 Last Name");
           
            Console.WriteLine("Enter Last Name");

            string last = Console.ReadLine();
            
            if (Regex.Match(last, "^[A-Z][a-z]{3,}$").Success)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Failed");
            }
        }
    }
}
