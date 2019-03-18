using System;

namespace PRIME
{
    static public class CheckPrime
    {
        static public void isPrime(ulong number) 
        {
            if (number < 2)
            {
                Console.WriteLine("NIE");
                return;
            }

            try 
            {
                for (ulong div = 2; div <= number / 2; div++) 
                {
                    if (number%div==0) 
                    {
                        Console.WriteLine("NIE");
                        return;
                    }
                }

                Console.WriteLine("TAK");
            }
            catch(NotFiniteNumberException wrongParam)
            {
                Console.WriteLine("NIE");
                //Console.WriteLine(wrongParam.Message);
            }
        }
    }
}
