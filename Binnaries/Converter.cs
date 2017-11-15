using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binnaries
{
    public static class Converter{
        public static StringBuilder ConvertToBits(int val) {
            int mask = 1 << 31;
            StringBuilder buffer = new StringBuilder(35);
            for (int i = 1; i <= 32; i++)
            {
                var k = 1;
                if (i == 25)
                    k = 3;
                if ((val & mask) == 0) buffer.Append("0");
                if ((val & mask) != 0) buffer.Append("1");

                val <<= 1; 
                if ((i % 8) == 0) buffer.Append(" ");
            }
            return buffer;
        }
    }
}
