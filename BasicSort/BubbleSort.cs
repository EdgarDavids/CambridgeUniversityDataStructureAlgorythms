using System;

namespace BasicSort
{
    //The bubble sort is
    //one of the slowest sorting algorithms available, but it is also one of the simplest
    //sorts to understand and implement, which makes it an excellent candidate
    //for our first sorting algorithm.
    //The sort gets its name because values “float like a bubble” from one end of
    //the list to another. Assuming you are sorting a list of numbers in ascending
    //order, higher values float to the right whereas lower values float to the left.
    //This behavior is caused by moving through the list many times, comparing
    //adjacent values and swapping them if the value to the left is greater than the
    //value to the right.
    public class BubbleSort<T> : AbstractSort<T> where T : IComparable<T>
    {
        public BubbleSort(int size) {
            SortSet = new T[size];
        }

        public override void DoSort()
        {
            DisplayChanges();
            for (int i = SortSet.Length - 1; i > 0; i--) {
                for (int j = 0; j < i; j++) {
                    if (SortSet[j].CompareTo(SortSet[j + 1])>0)
                        BasicOperations.Basic.Swap(ref SortSet[j], ref SortSet[j + 1]);
                }
                //DisplayChanges();
            }
            DisplayChanges();
        }

        public override void DoReverseSort()
        {
            DisplayChanges();

            for (int i = SortSet.Length; i > 0; i--) {
                for (int j = 0; j < SortSet.Length-1; j++) { 
                    if (SortSet[j].CompareTo(SortSet[j + 1]) < 0) BasicOperations.Basic.Swap(ref SortSet[j], ref SortSet[j + 1]);
                }
                DisplayChanges();
            }
            DisplayChanges();
        }

    }
}
