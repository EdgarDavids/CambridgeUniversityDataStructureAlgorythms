using System;

namespace BasicSort
{
    //Selection Sort
    //The next sort to examine is the Selection sort.This sort works by starting at
    //the beginning of the array, comparing the first element with the other elements
    //in the array.The smallest element is placed in position 0, and the sort then
    //begins again at position 1. This continues until each position except the last
    //position has been the starting point for a new loop.
    public class SelectionSort<T>: AbstractSort<T> where T : IComparable<T>
    {
        public SelectionSort(int size) {
            SortSet = new T[size];
        }

        public override void DoSort()
        {
            int min = 0;
            DisplayChanges();
            for (int i = 0; i < SortSet.Length; i++) {
                min = i;
                for (int j = 1; j < SortSet.Length; j++) {
                    if (SortSet[j].CompareTo(SortSet[min]) < 0) {
                        min = j;
                    }
                }
                BasicOperations.Basic.Swap<T>(ref SortSet[min], ref SortSet[i]);
                //DisplayChanges();
            }
            DisplayChanges();
        }

        public override void DoReverseSort()
        {
            int max = 0;

            DisplayChanges();
            for (int i = 0; i < SortSet.Length; i++) {
                max = i;
                for (int j = i+1; j < SortSet.Length; j++) { 
                    if (SortSet[j].CompareTo(SortSet[max]) > 0) max = j;
                }
                BasicOperations.Basic.Swap(ref SortSet[max], ref SortSet[i]);
                DisplayChanges();
            }
            DisplayChanges();
        }
    }
    
}
