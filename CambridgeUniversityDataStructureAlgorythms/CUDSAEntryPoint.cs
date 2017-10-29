using BasicSearch;
using BasicSort;
using System;

namespace CambridgeUniversityDataStructureAlgorythms
{
    class CUDSAEntryPoint
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 72, 54, 59, 30, 31, 78, 2, 77, 82, 72 };
            //int[] arr = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 };
            SequentialSearch search = new SequentialSearch(arr.Length);
            search.SearchSet = arr;
            bool searchResults = search.SearchSecond(72);
            if (searchResults) Console.WriteLine("Value {0} is found for {1}", 72, search.Attempts);
            if (!searchResults) Console.WriteLine("No value {0} in search results", 72, search.Attempts);
            searchResults = search.SearchSecond(77);
            if (searchResults) Console.WriteLine("Value {0} is found for {1}", 77, search.Attempts);
            if (!searchResults) Console.WriteLine("No value {0} in search results", 77, search.Attempts);
            searchResults = search.SearchSecond(99);
            if (searchResults) Console.WriteLine("Value {0} is found for {1}", 99, search.Attempts);
            if (!searchResults) Console.WriteLine("No value {0} in search results", 99, search.Attempts);


            searchResults = search.SearchLast(72);
            if (searchResults) Console.WriteLine("Value {0} is found for {1}", 72, search.Attempts);
            if (!searchResults) Console.WriteLine("No value {0} in search results", 72, search.Attempts);
            searchResults = search.SearchLast(77);
            if (searchResults) Console.WriteLine("Value {0} is found for {1}", 77, search.Attempts);
            if (!searchResults) Console.WriteLine("No value {0} in search results", 77, search.Attempts);
            searchResults = search.SearchLast(99);
            if (searchResults) Console.WriteLine("Value {0} is found for {1}", 99, search.Attempts);
            if (!searchResults) Console.WriteLine("No value {0} in search results", 99, search.Attempts);

            //Console.WriteLine("Min value is {0}", search.GetMin());
            //Console.WriteLine("Max value is {0}", search.GetMax());

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
