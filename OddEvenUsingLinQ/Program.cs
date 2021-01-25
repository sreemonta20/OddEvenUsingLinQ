using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenUsingLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var even = new List<int>();

            Console.WriteLine("1st Way: \n");
            even =  numbers.Where(x => x % 2 == 0).ToList();
            even.ForEach(Console.WriteLine);

            Console.WriteLine("2nd Way: \n");
            numbers.Where(x => x % 2 == 0).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();
        }
    }
}
