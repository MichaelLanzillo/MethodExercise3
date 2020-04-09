using System;

namespace MethodExercise3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberPrinter();
            //Console.ReadLine();
            //TriplePrinter();
            //TheEqualizer(5, 10);
            //EvenOrOdd(7);
            PosOrNeg(-11);
        }

        static void NumberPrinter()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        static void TriplePrinter()
        {
            for (int i = 3; i < 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        static void TheEqualizer(int a, int b)
        {
            bool isTrue = (a == b);
            Console.WriteLine($"{a} = {b} : {isTrue} ");

        }
        static void EvenOrOdd(int a)
        {
            //if (a % 2 == 0)
            //{
            //    Console.WriteLine($"{a} is even");
            //}
            //else
            //{
            //    Console.WriteLine($"{a} is odd");
            //}

            string message = a % 2 == 0 ? $"{a} is even" : $"{a} is odd";
            Console.WriteLine(message);
        }

        static void PosOrNeg(int a)
        {
            if (a > 0)
            {
                Console.WriteLine($"{a} is positive");
            }
            else
            {
                Console.WriteLine($"{a} is negative");
            }
            
            //string message = a > 0 ? $"{a} is positive" : $"{a} is negative";
            //Console.WriteLine(message);
        }
    }
}
