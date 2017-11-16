using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binnaries
{
    public static class BitHelper
    {
        public static void Apply() {
            int i1 = 5;
            int i2 = 20;

            Console.WriteLine("{0} is converted from {1}", Converter.ConvertToBits(i1), i1);
            Console.WriteLine("{0} is converted from {1}", Converter.ConvertToBits(i2), i2);

            Console.WriteLine("{0} is AND between {1} and {2}", Converter.ConvertToBits(i1 & i2), i1, i2);
            Console.WriteLine("{0} is OR between {1} and {2}", Converter.ConvertToBits(i1 | i2), i1, i2);
            Console.WriteLine("{0} is XOR between {1} and {2}", Converter.ConvertToBits(i1 ^ i2), i1, i2);
        }

        public static void ShiftApply()
        {
            int i1 = 5;
            int i2 = 20;
            int shiftL = 7;
            int shiftR = 4;

            Console.WriteLine("{0} is converted from {1}", BinnaryShift.Convert(i1), i1);
            Console.WriteLine("{0} is left shifted for {1} positions", BinnaryShift.Convert(i1 << shiftL), shiftL);

            Console.WriteLine("{0} is converted from {1}", BinnaryShift.Convert(i2), i2);
            Console.WriteLine("{0} is right shifted for {1} positions", BinnaryShift.Convert(i2 >> shiftR), shiftR);
        }
    }
}
