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
            int x = 20;
            DoSomething(ref x);
            WriteLine($"Now, value of x : {x}");

            GetAstring firstString = x.ToString;

            WriteLine($"String is \"{firstString()}\"");

        }

        public static void DoSomething(ref int x)
        {
            WriteLine($"Value of x : {x}");
            x += 10;
        }
    }
}
