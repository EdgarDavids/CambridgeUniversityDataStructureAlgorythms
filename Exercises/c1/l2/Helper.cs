using Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.c1.l2
{
    public static class Helper
    {
        public static void BasicOperationsCollectionExercise()
        {
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
            names.Add("David");
            names.Add("Bernica");
            names.Add("Raymond");
            names.Add("Clayton");
            Console.WriteLine("Initial list of names:");
            foreach (object name in names) Console.WriteLine(name);
            Console.WriteLine("Number of names: {0}", names.Count());
            Console.WriteLine("Insert Eduard:");
            names.Insert(1, "Eduard");
            Console.WriteLine("Number of names: {0}", names.Count());
            Console.WriteLine("Contains Clayton: {0}", names.Contains("Clayton"));
            Console.WriteLine("Contains Boris: {0}", names.Contains("Boris"));
            Console.WriteLine("Raymond index is : {0}", names.IndexOf("Raymond"));
            Console.WriteLine("Remove index 2:");
            names.RemoveAt(2);
            Console.WriteLine("Number of names: {0}", names.Count());
        }
    }
}
