using System;
using Ro.Fitnesse.Library;

namespace Ro.Fitnesse.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var hw = new HelloWorld();
            Console.WriteLine(hw.Concatenate());
        }
    }
}
