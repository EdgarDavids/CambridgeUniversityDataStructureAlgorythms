using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSort
{
    public abstract class AbstractSort<T> : ISort<T> where T : IComparable<T>
    {
        public T[] SortSet { get; set;}

        public abstract void DoSort();

        internal void DisplayChanges() {
            Console.WriteLine("");
            for (int i = 0; i < SortSet.Length; i++)
                Console.Write("{0} ", SortSet[i]);


        }
    }
}
