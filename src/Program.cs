using FizzBuzz.Classes;
using System;

namespace FizzBuzz.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * When Number can be divisable 3 then print Fizz
             * When Number can be divisable 5 then print Buzz
             * When Number can be divisable both 3 & 5 then print FizzBuzz
             * else print the number
             */
            var buzz = new Buzz();
            var fizz = new Fizz(buzz);
            var fizzBuzz = new Classes.FizzBuzz(fizz);

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.Handle(i));
            }
            Console.ReadKey();
        }
    }
}
