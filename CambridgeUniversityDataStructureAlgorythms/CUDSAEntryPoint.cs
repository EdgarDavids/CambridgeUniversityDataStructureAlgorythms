using BasicSort;
using System;

namespace CambridgeUniversityDataStructureAlgorythms
{
    class CUDSAEntryPoint
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 72, 54, 59, 30, 31, 78, 2, 77, 82, 72 };
            InsertionSort<int> insertion = new InsertionSort<int>(arr.Length);
            insertion.SortSet = arr;
            insertion.DoReverseSort();

            Console.ReadLine();

            //Exercises.c3.l1.StrSortHelper.DoSort();
            //Timing.Timing tObj = new Timing.Timing();
            //tObj.StartTime();
            //Exercises.c2.l3.GradeCalculator.Calculate();
            //int[] arr = new int[] { 72, 54, 59, 30, 31, 78, 2, 77, 82, 72};


            //Console.WriteLine("Enter a No. to reverse");
            //int Number = int.Parse(Console.ReadLine());
            //int Reverse = 0;
            //while (Number > 0)
            //{
            //    int remainder = Number % 10;
            //    Reverse = (Reverse * 10) + remainder;
            //    Number = Number / 10;
            //}
            //Console.WriteLine("Reverse No. is {0}", Reverse);
            //Console.ReadLine();
        }
    }
}
