using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Console1
{
    class Program
    {
        private delegate string GetAstring();

        static void Main(string[] args)
        {
            char c = 'S';
            WriteLine($"Size of character is : {sizeof(char)} bytes");
            int x = 20;
            DoSomething(ref x);
            WriteLine($"Now, value of x : {x}");

            GetAstring firstString = x.ToString;

            WriteLine($"String is \"{firstString()}\"");


            // verbatim strings
            string file = @"C:\users\sanad\myfile.txt";
            string article = @"In the name of Allah, the most merciful, the most gracious
                first, greeting to all my muslim colleagues, and thanks for attending this 
                gathering.";
            WriteLine($"article is: {article}");
        }

        public static void DoSomething(ref int x)
        {
            WriteLine($"Value of x : {x}");
            x += 10;
        }
    }
}
