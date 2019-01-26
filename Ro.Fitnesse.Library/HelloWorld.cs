using System;

namespace Ro.Fitnesse.Library
{
    public class HelloWorld : fit.ColumnFixture
    {
        public string string1;
        public string string2;
        public string Concatenate()
        {
            return string1 + " " + string2;
        }
    }
}
