using System;
using System.Collections;

namespace Basic.Algorythms
{
    public static class RadixSort
    {
        private enum Digits { ones, tens };
        public static void Sort() {
            int[] nums = new int[] { 91, 46, 13, 85, 15, 92, 35, 7, 31, 22 };

            Queue[] bins = new Queue[10];

            for (int i = 0; i<bins.Length ; i++) bins[i] = new Queue();

            DisplayArray(nums, "Initial aray is : ");

            RSort(bins, nums, Digits.ones);
            BuildArray(bins, nums);
            DisplayArray(nums, "Step one passed : ");
            RSort(bins, nums, Digits.tens);
            BuildArray(bins, nums);
            DisplayArray(nums, "Final sort is : ");
        }

        private static void BuildArray(Queue[] bins, int[] nums)
        {
            int i = 0;
            foreach (Queue bin in bins) {
                while (bin.Count > 0) {
                    nums[i] = Convert.ToInt32(bin.Dequeue());
                    i++;
                }
            }
        }

        private static void RSort(Queue[] bins, int[] nums, Digits digits)
        {
            int token = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (digits == Digits.ones) token = nums[i] % 10;
                if (digits == Digits.tens) token = nums[i] / 10;

                bins[token].Enqueue(nums[i]);
            }
        }

        private static void DisplayArray(int[] nums, string title)
        {
            Console.WriteLine(title);
            foreach (int i in nums) Console.Write("{0} ",i);
            Console.ReadLine();
        }
    }
}
