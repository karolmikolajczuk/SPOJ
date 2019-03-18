using System;

namespace FCTRL_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            UInt16 tests = Convert.ToUInt16(Console.ReadLine());
            for (int i = 0; i < tests; i++)
            {
                Factorial.firstTwoNumbers(Convert.ToUInt64(Console.ReadLine()));
            }
        }
    }
}
