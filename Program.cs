using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();

            var sum = Add(int.Parse(a), int.Parse(b));

            Console.WriteLine(sum);
        }

        static int Add(int a, int b) => a + b;
    }
}
