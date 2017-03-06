using System;
using static System.Console;

namespace c4clr
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("C4CLR syntax checker 0.0.1");
                WriteLine("c4clr file.c");
                return;
            }

            var fileName = args[0];
            var parser = new SyntaxChecker(fileName);
            if (parser.Parse())
            {
                Console.WriteLine("Syntax is ok");
            }
            else
            {
                WriteLine("Incorrect syntax");
            }
        }
    }
}
