using Basic;
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
    }
}
