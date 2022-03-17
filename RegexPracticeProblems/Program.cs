using System;
using System.Text.RegularExpressions;

namespace RegexPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regex UC 2 First Name");
           
            Console.WriteLine("Enter Last Name");

            string last = Console.ReadLine();
            
            if (Regex.Match(last, "^[A-Z][a-z]{1,3}$").Success)
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
