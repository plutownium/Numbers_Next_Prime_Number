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
            var tester = new Program();

            var userWantsToContinue = true;
            while (userWantsToContinue)
            {
                int largestPrimeSoFar;
                if (foundPrimes.Count == 0) // for initial condition, where we haven't found any primes yet
                {
                    largestPrimeSoFar = 0;
                } else
                {
                    largestPrimeSoFar = foundPrimes[foundPrimes.Count - 1];
                }
                // start looking for primes larger than largestPrimeSoFar
                var lookingForNextPrime = true;
                var currentNumberToCheck = largestPrimeSoFar;
                while (lookingForNextPrime)
                {
                    currentNumberToCheck++;
                    // the magic happens...
                    var numberIsPrime = tester.CheckIfPrime(currentNumberToCheck);

                    if (numberIsPrime)
                    {
                        break;
                    }
                }
                var locatedPrime = currentNumberToCheck;
                foundPrimes.Add(locatedPrime);
                // output the magic
                Console.WriteLine(locatedPrime); // expect 1, 2, 3, 5, 7, 11, 13, 17...

                // prime found, prompt user, "do u want next prime found?"
                Console.WriteLine("Find the next prime?");
                string feedback = Console.ReadLine();
                if (feedback == "n" || feedback == "no" || feedback == "N" || feedback == "No")
                {
                    userWantsToContinue = false;
                } 
            }
        }

        public bool CheckIfPrime(int numberToCheck)
        {
            var divisor = 1;
            while (divisor < numberToCheck)
            {
                double isWholeNumber = (double)numberToCheck / (double)divisor;
                bool divisibleNumberFound = isWholeNumber == Math.Floor(isWholeNumber);

                if (divisibleNumberFound)
                {
                    return false;
                }
            }
            return true;
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
