using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Algorythms
{
    public static class DecimalToMulbase
    {
        public static void Apply() {
            Console.WriteLine("Input decimal number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input base : ");
            int base_num = Convert.ToInt32(Console.ReadLine());
            Mulbase(num, base_num);
        }

        private static void Mulbase(int num, int base_num)
        {
            Stack Digits = new Stack();
            do
            {
                Digits.Push(num % base_num);
                num /= base_num;
            }
            while (num != 0);
            Console.WriteLine("Convert decimal {0} to base {1} : ", num, base_num);
            while (Digits.Count > 0) Console.Write(Digits.Pop());
        }
    }
}
