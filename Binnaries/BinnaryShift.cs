using System.Text;

namespace Binnaries
{
    internal static class BinnaryShift
    {
        internal static StringBuilder Convert(int value) {

            int mask = 1<<31;
            StringBuilder buffer = new StringBuilder(35);
            for (int i = 1; i <= 32; i++) {
                if ((value&mask) == 0) buffer.Append("0");
                if ((value&mask) != 0) buffer.Append("1");
                value <<= 1;
                if (i % 8 == 0) buffer.Append(" ");
            }
            
            return buffer;

        }
    }
}
