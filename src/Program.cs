using FizzBuzz.Interface;
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
            IFizzBuzzHandler fizzBuzzHandler = new Classes.FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzzHandler.Handle(i));
            }
            Console.ReadKey();
        }
    }
}
