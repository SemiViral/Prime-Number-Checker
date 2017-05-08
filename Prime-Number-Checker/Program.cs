#region usings

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace PrimeChecker {
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine(DeterminePrime(AcceptInput()));
            Console.ReadLine();
        }

        private static long AcceptInput() {
            long parsed = 0;

            while (parsed / 1 == 0)
                long.TryParse(Console.ReadLine(), out parsed);

            return parsed;
        }

        private static bool DeterminePrime(long number) {
            return number == 2 || number.ToArray()
                       .All(listedNumber => number % listedNumber != 0);
        }
    }

    internal static class Extensions {
        public static IEnumerable<long> ToArray(this long instance) {
            for (long i = 2; i < instance; i++)
                yield return i;
        }
    }
}