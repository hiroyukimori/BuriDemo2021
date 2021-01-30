using System;
using UnitGenerator;

namespace Demo02.SourceGenerator.ConsoleApp
{
    [UnitOf(typeof(int))]
    public readonly partial struct UserId { }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
