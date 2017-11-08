using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Algorythms
{
    //Решето Эрастофена - to find all the primes in som set of elements
    public static class SieveEratosthenes
    {
        public static void Apply() {
            int[] primes = new int[100];
            
            for (int i = 0; i < primes.Length; i++) {
                primes[i] = 1;
            }
            primes[0] = 1;
            SetPrimes(primes);
            Console.WriteLine("Set of primes between 1 and 100 : ");
            Console.WriteLine();
            ShowPrimes(primes);
            
        }

        private static void ShowPrimes(int[] primes)
        {
            
            for(int i=2; i<primes.Length; i++) if (primes[i] == 1) Console.Write("{0} ", i);
        }

        private static void SetPrimes(int[] primes)
        {
            for(int i=2; i<primes.Length; i++){
                for (int j = i + 1; j < primes.Length; j++) {
                    if (j % i == 0) primes[j] = 0;
                }
            }
        }
    }
}
