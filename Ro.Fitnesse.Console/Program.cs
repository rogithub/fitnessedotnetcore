using System;
using Ro.Fitnesse.Library;

namespace Ro.Fitnesse.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var div = new Division();
            div.SetNumerator(10);
            div.SetDenominator(2);
            System.Console.WriteLine(div.Quotient());
            System.Console.Read();
        }
    }
}
