using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathMethods2 math1 = new MathMethods2();

            Console.WriteLine(math1.MathOp(7));

            Console.WriteLine(math1.MathOp(7.3m));

            Console.WriteLine(math1.MathOp("7"));

            Console.ReadLine();
        }
    }
}