using System;

namespace BasicOperations
{
    public class Basic
    {
        public static void Swap<T>(ref T value1, ref T value2) {
            T temp;

            temp = value1;
            value1 = value2;
            value2 = temp;
        }

        public static int[] Random(int num, int arrsize) {
            Random rnd = new Random(num);
            int[] nums = new int[arrsize];
            for (int i = 0; i < arrsize; i++)
                nums[i]=(int)(rnd.NextDouble() * 100);

            return nums;
        }
    }
}
