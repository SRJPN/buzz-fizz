using FizzBuzz.Interface;
using FizzBuzz.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using src.Classes;

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
            var fizzBuzzHandlers = new List<IFizzBuzzHandler>(){
                new Classes.FizzBuzz(),
                new Fizz(),
                new Buzz(),
                new Dummy()
            };

            for (int i = 1; i <= 100; i++)
            {
                var handler = fizzBuzzHandlers.FirstOrDefault(handler => handler.IsDivisible(i));
                Console.WriteLine(handler.Handle(i));
            }
            Console.ReadKey();
        }
    }
}
