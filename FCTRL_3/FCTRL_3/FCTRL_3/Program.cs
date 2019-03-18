using System;

namespace FCTRL_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ushort tests = Convert.ToUInt16(Console.ReadLine());
            for (ushort i = 0; i < tests; i++)
            {
                Factorial.firstTwoNumbers(Convert.ToUInt64(Console.ReadLine()));
            }
        }
    }
}
