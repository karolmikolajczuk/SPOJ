using System;

namespace PRIME
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UInt32 numofcases = Convert.ToUInt32(Console.ReadLine());

            for (int i = 0; i < numofcases; i++)
            {
                ulong number = Convert.ToUInt64(Console.ReadLine());   
                CheckPrime.isPrime(number);
            }
        }
    }
}
