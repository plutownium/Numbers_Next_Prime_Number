using System;
using System.Collections;
using System.Collections.Generic;

namespace Numbers_Next_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // finds prime numbers until the user stops asking for the next one.
            List<int> foundPrimes = new List<int>();
            foundPrimes.Add(1);
            foundPrimes.Add(3);
            foundPrimes.Add(7);
            
            foreach (int item in foundPrimes)
            {
                Console.WriteLine(item);
            }

            var p = new Program();
            var k = p.Five(3);
            Console.WriteLine(k);
            Console.WriteLine(Charles("abc"));

        }
        public int Five(int x)
        {
            return x;
        }

        static string Charles(string charlie)
        {
            return charlie + charlie;
        }
    }
}
