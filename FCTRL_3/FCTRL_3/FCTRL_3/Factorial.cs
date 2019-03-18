using System;

namespace FCTRL_3
{
    static public class Factorial
    {
        static public void firstTwoNumbers(UInt64 number)
        {
            if (number<0)
            {
                Console.WriteLine("Liczba mniejsza od 0");
                return;
            }

            UInt64 factorial = 1;

            switch(number)
            {
                case 0:
                case 1:
                    factorial = 1;
                    break;
                default:
                    for (UInt64 i = 1; i <= number; i++) 
                    {
                        factorial *= i;
                    }
                    break;
            }
            Console.WriteLine("{0} {1}", factorial%100/10, factorial%10);
        }
    }
}
