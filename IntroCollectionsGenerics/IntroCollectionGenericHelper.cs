﻿using Basic;
using System;

namespace IntroCollectionsGenerics
{
    public class IntroCollectionGenericHelper
    {
        public static void BasicOperationsCollection() {
            UserCollection names = new UserCollection();
            names.Add("David");
            names.Add("Bernica");
            names.Add("Raymond");
            names.Add("Clayton");
            Console.WriteLine("Initial list of names:");
            foreach (object name in names) Console.WriteLine(name);
            Console.WriteLine("Number of names: {0}", names.Count());
            Console.WriteLine("Remove Raymond:");
            names.Remove("Raymond");
            Console.WriteLine("Number of names: {0}", names.Count());
            Console.WriteLine("Clear all left:");
            names.Clear();
            Console.WriteLine("Number of names: {0}", names.Count());
        }

        public static void DoSwap() {
            Console.WriteLine("int swap:");
            int intvalue1 = 100;
            int intvalue2 = 200;
            Console.WriteLine("Before swap : intvalue1={0}, intvalue2={1}", intvalue1, intvalue2);
            BasicOperations.Basic.Swap<int>(ref intvalue1, ref intvalue2);
            Console.WriteLine("After swap: intvalue1={0}, intvalue2={1}", intvalue1, intvalue2);

            Console.WriteLine("string swap:");
            string strvalue1 = "Sam";
            string strvalue2 = "Tom";
            Console.WriteLine("Before swap : strvalue1={0}, strvalue2={1}", strvalue1, strvalue2);
            BasicOperations.Basic.Swap<string>(ref strvalue1, ref strvalue2);
            Console.WriteLine("After swap: strvalue1={0}, strvalue2={1}", strvalue1, strvalue2);
        }
    }
}
