using System;

namespace BasicSearch
{
    public abstract class AbstractSearch : ISearch
    {
        public int[] SearchSet { get; set; }
        public int Attempts { get; set; }
        public abstract bool Search(int value);

        public void SearchReport(int value){
            bool searchResults = Search(value);
            if (searchResults) Console.WriteLine("Value {0} is found for {1}", value, Attempts);
            if (!searchResults) Console.WriteLine("No value {0} in search results", value, Attempts);
        }

       
    }
}