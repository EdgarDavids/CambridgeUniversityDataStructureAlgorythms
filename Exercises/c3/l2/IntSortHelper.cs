using BasicSort;
using System;

namespace Exercises.c3.l2
{
    public static class IntSortHelper
    {
        public static void DoSort() {
            int[] arr, barr, sarr, iarr;
            arr = BasicOperations.Basic.Random(100, 1000);
            barr = new int[1000];
            for (int i = 0; i < barr.Length; i++) barr[i] = arr[i];
            sarr = new int[1000];
            for (int i = 0; i < sarr.Length; i++) sarr[i] = arr[i];
            iarr = new int[1000];
            for (int i = 0; i < iarr.Length; i++) iarr[i] = arr[i];

            Timing.Timing tObj = new Timing.Timing();
            tObj.StartTime();

            BubbleSort<int> bubbleSort = new BubbleSort<int>(1000);
            bubbleSort.SortSet = barr;
            bubbleSort.DoSort();

            tObj.StopTime();
            Console.WriteLine("Bubble - Totally {0} seconds ", tObj.GetDuration().Seconds);
            Console.ReadLine();

            tObj = new Timing.Timing();
            tObj.StartTime();

            SelectionSort<int> selectionSort = new SelectionSort<int>(1000);
            selectionSort.SortSet = sarr;
            selectionSort.DoSort();

            tObj.StopTime();
            Console.WriteLine("Selection - Totally {0} seconds ", tObj.GetDuration().Seconds);
            Console.ReadLine();

            tObj = new Timing.Timing();
            tObj.StartTime();

            InsertionSort<int> insertionSort = new InsertionSort<int>(1000);
            insertionSort.SortSet = iarr;
            insertionSort.DoSort();

            tObj.StopTime();
            Console.WriteLine("Insertion Totally {0} seconds ", tObj.GetDuration().Seconds);
            Console.ReadLine();
        }
    }
}
