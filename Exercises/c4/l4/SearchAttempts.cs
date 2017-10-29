using BasicSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.c4.l4
{
    public class SearchAttempts
    {
        public static void SearchImplementation() {
            int[] arr = new int[1000];

            for (int i = 0; i < arr.Length; i++) {
                arr[i] = i;
            }

            SequentialSearch search1 = new SequentialSearch(1000);
            search1.SearchSet = arr;
            search1.SearchReport(723);

            BinnarySearch search2 = new BinnarySearch(1000);
            search2.SearchSet = arr;
            search2.SearchReport(723);
        }
    }
}
