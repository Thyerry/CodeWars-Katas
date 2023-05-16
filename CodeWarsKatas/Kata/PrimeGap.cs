namespace CodeWarsKatas.Kata
{
    public class PrimeGap
    {
        public static long[]? Run(int g, long m, long n)
        {
            var primes = Primes(m, n).ToArray();
            
            for (int i = 0; i < primes.Count() - 1; i++)
            {
                if (primes[i + 1] - primes[i] == g)
                    return new long[] { primes[i], primes[i+1] };
            }

            return null;
        }

        private static IEnumerable<long> Primes(long m, long n)
        {
            var numberRange = LongRange(m, n);
            var result = new List<long>();
            foreach (var number in numberRange)
            {
                var isPrime = true;
                for (long i = 2; i <= number / 2; i += 2)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                    result.Add(number);
            }
            return result;
        }

        private static IEnumerable<long> LongRange(long m, long n)
        {
            for (long i = m; i <= n; i++)
                yield return i;
        }
        public static bool IsP(long n)
        {
            if (n % 2 == 0) return false;
            for (long i = 3; i <= Math.Sqrt(n); i += 2) if (n % i == 0) return false;
            return true;
        }
        public static long[] Gap(int g, long m, long n)
        {
            long p = 0;
            for (; m <= n; m++)
            {
                if (IsP(m))
                {
                    if (m - p == g) return new long[] { p, m };
                    p = m;
                }
            }
            return null;
        }
    }

}
