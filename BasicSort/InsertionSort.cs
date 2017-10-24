using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSort
{
    //The Insertion sort has two loops.The outer loop moves element by element
    //through the array whereas the inner loop compares the element chosen in the
    //outer loop to the element next to it in the array. If the element selected by the
    //outer loop is less than the element selected by the inner loop, array elements
    //are shifted over to the right to make room for the inner loop element, just as
    //described in the preceding example.

    public class InsertionSort<T> : AbstractSort<T> where T : IComparable<T>
    {
        public InsertionSort(int size) {
            SortSet = new T[size];
        }

        public override void DoSort()
        {
            T temp;
            int j = 0;
            DisplayChanges();
            for (int i = 1; i < SortSet.Length; i++) {
                temp = SortSet[i];
                j = i;
                while (j > 0 && SortSet[j - 1].CompareTo(temp) > 0) {
                    SortSet[j] = SortSet[j - 1];
                    j--;
                }
                SortSet[j] = temp;
                //DisplayChanges();
            }
            DisplayChanges();
        }
    }
}
