using Basic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.c1.l3
{
    public static class Helper
    {
        public static ArrayList BuildArray(ArrayList arr)
        {
            for (long i = 0; i < 1000000; i++) arr.Add(i);

            return arr;
        }

        public static void GetArray(ArrayList arr)
        {
            foreach(long i in arr) Console.Write(string.Concat(i, " "));
        }

        public static UserCollection BuildArray(UserCollection arr)
        {
            for (long i = 0; i < 1000000; i++) arr.Add(i);

            return arr;
        }

        public static void GetArray(UserCollection arr)
        {
            foreach (long i in arr) Console.Write(string.Concat(i, " "));
        }
    }
}
