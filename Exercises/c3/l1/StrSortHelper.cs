using BasicSort;
using System;
using System.IO;

namespace Exercises.c3.l1
{
    public static class StrSortHelper
    {
        public static void DoSort() {
            string path = @"D:\gen_text.txt";
            BasicFile.BasicFileOperation.CreateGenericContent(path);

            string[] content = BasicFile.BasicFileOperation.ReadFile(path).Split(' ');
            //BasicFile.BasicFileOperation.DeleteFile(path);

            Timing.Timing tObj = new Timing.Timing();
            tObj.StartTime();

            BubbleSort<string> bubbleSort = new BubbleSort<string>(content.Length);
            bubbleSort.SortSet = content;
            bubbleSort.DoSort();

            tObj.StopTime();
            Console.WriteLine("Bubble - Totally {0} seconds ", tObj.GetDuration().Seconds);
            Console.ReadLine();

            tObj = new Timing.Timing();
            tObj.StartTime();

            SelectionSort<string> selectionSort = new SelectionSort<string>(content.Length);
            selectionSort.SortSet = content;
            selectionSort.DoSort();

            tObj.StopTime();
            Console.WriteLine("Selection - Totally {0} seconds ", tObj.GetDuration().Seconds);
            Console.ReadLine();

            tObj = new Timing.Timing();
            tObj.StartTime();

            InsertionSort<string> insertionSort = new InsertionSort<string>(content.Length);
            insertionSort.SortSet = content;
            insertionSort.DoSort();

            tObj.StopTime();
            Console.WriteLine("Insertion Totally {0} seconds ", tObj.GetDuration().Seconds);
            Console.ReadLine();

        }
    }
}
