﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSearch
{
    public class SequentialSearch : AbstractSearch
    {
        public SequentialSearch(int size) {
            SearchSet = new int[size];
        }
        public override bool Search(int value)
        {
            Attempts = 0;
            for(int i=0; i < SearchSet.Length; i++){
                Attempts++;
                if (SearchSet[i] == value) return true;
            }
            return false;
        }

        public int GetMax() {
            int max = int.MinValue;
            for (int i = 0; i < SearchSet.Length; i++){
                if (SearchSet[i] > max) max=SearchSet[i];
            }
            return max;
        }

        public int GetMin(){
            int min = int.MaxValue;
            for (int i = 0; i < SearchSet.Length; i++)
            {
                if (SearchSet[i] < min) min = SearchSet[i];
            }
            return min;
        }
    }
}
