using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compulsory_Assignment
{
    class PrimeGenerator
    {
        private readonly static object locker = new();
        public static List<long> GetPrimesSequential(long first, long last)
        {
            List<long> primes = new List<long>();
            for (long i = first; i <= last; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        public static List<long> GetPrimesParallel(long first, long last)
        {
            List<long> primes = new List<long>();

            Parallel.ForEach(Partitioner.Create(first, last + 1),
                (range) =>
                {
                    List<long> partialList = new List<long>();
                    for (long i = range.Item1; i < range.Item2; i++)
                    {
                        if (IsPrime(i))
                        {
                            partialList.Add(i);
                        }
                    }
                    lock (locker)
                    {
                        for (int j = 0; j < partialList.Count; j++)
                        {
                            primes.Add(partialList[j]);
                        }
                    }
                });
            primes.Sort();
            return primes;
        }

        public static bool IsPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            int i = 6; 
            while (i <= boundary)
            {
                if (number % (i + 1) == 0 || number % (i + 5) == 0)
                    return false;

                i += 6;
            }

            return true;
        }

    }
}
