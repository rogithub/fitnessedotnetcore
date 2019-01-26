using System;
using Ro.Fitnesse.Library;

namespace Ro.Fitnesse.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = new HelloWorld();
            System.Console.WriteLine(hw.Concatenate());
            System.Console.Read();
        }
    }
}
