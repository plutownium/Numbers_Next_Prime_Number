using System;
using System.Collections;
using System.Collections.Generic;

namespace Numbers_Next_Prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // ### finds prime numbers until the user stops asking for the next one.
            List<int> foundPrimes = new List<int>();
            // *** *** *** ***
            // a prime is a number that is only divisible by itself. 
            // so all the numbers smaller than it mustyield floats.
            // *** *** *** ***
            var userWantsToContinue = true;
            while (userWantsToContinue)
            {
                var locatedPrime = 10;
                foundPrimes.Add(locatedPrime);
                // the magic happens...
                Console.WriteLine(locatedPrime);

                // prime found, prompt user, "do u want next prime found?"
                Console.WriteLine("Find the next prime?");
                string feedback = Console.ReadLine();
                if (feedback == "n" || feedback == "no" || feedback == "N" || feedback == "No")
                {
                    userWantsToContinue = false;
                } else
                {
                    continue;
                }
            }
            //foundPrimes.Add(1);
            //foundPrimes.Add(3);
            //foundPrimes.Add(7);

            //foreach (int item in foundPrimes)
            //{
            //    Console.WriteLine(item);
            //}

            //var p = new Program();
            //var k = p.Five(3);
            //Console.WriteLine(k);
            //Console.WriteLine(Charles("abc"));

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
