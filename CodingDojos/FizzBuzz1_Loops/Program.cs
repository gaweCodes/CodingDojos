using System;

namespace FizzBuzz1_Loops
{
    internal class Program
    {
        private const int MaxValue = 100;
        private const int ValueToPrintFizz = 5;
        private const int ValueToPrintBuzz = 7;
        private static void Main()
        {
            Solutijon1();
            Solutijon2();
        }
        private static void Solutijon1()
        {
            Console.WriteLine("Solution 1");
            for (var number = 1; number < MaxValue; number++)
            {
                if (IsFizzBuzz(number))
                    Console.WriteLine($"{number}: fizzbuzz");
                else if (IsFizz(number))
                    Console.WriteLine($"{number}: fizz");
                else if (IsBuzz(number))
                    Console.WriteLine($"{number}: buzz");
            }
        }
        private static void Solutijon2()
        {
            Console.WriteLine("Solution 2");
            for (var number = 1; number < MaxValue; number++)
            {
                Console.Write($"{number}:");
                if (IsFizz(number))
                    Console.Write("fizz");
                if (IsBuzz(number))
                    Console.Write("buzz");
                Console.WriteLine();
            }
        }
        private static bool IsFizz(int number) => number % ValueToPrintFizz == 0;
        private static bool IsBuzz(int number) => number % ValueToPrintBuzz == 0;
        private static bool IsFizzBuzz(int number) => IsFizz(number) && IsBuzz(number);
    }
}
