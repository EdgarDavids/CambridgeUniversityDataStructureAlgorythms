using System;

namespace BasicSearch
{
    public class BinnarySearch : AbstractSearch
    {
        public BinnarySearch(int size) {
            SearchSet = new int[size];
        }
        public override bool Search(int value)
        {
            int low = SearchSet[0];
            int up = SearchSet[SearchSet.Length - 1];
            Attempts = 0;
            int mid = 0;

            while (low < up) {
                Attempts++;
                mid = (low + up) / 2;
                if (value > mid) low = mid;
                if (value < mid) up = mid;
                if (value == mid) return true;
            }

            return false;
        }

        public bool RecursiveSearch(int value)
        {
            int low = SearchSet[0];
            int up = SearchSet[SearchSet.Length - 1];
            Attempts = 0;

            if (value < low) return false;
            if (value > up) return false;
            return Recursive(value, low, up);
            
            
        }

        private bool Recursive(int value, int low, int up) {
            int mid = 0;
            if (low > up) Attempts=-1;
            if (Attempts == -1) return false;
            
                Attempts++;
                mid = (low + up) / 2;
                if (value > mid) Recursive(value, mid, up);
                if (value < mid) Recursive(value, low, mid);
                if (value == mid) return true;

            return Attempts == -1 ? false : true;
        }

        public void RecursiveSearchReport(int value)
        {
            bool searchResults = RecursiveSearch(value);
            if (searchResults) Console.WriteLine("Value {0} is found for {1}", value, Attempts);
            if (!searchResults) Console.WriteLine("No value {0} in search results", value, Attempts);
        }
    }
}
