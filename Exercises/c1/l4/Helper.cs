using Basic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.c1.l4
{
    public static class Helper
    {
        public static void BasicOperationsCollectionExercise()
        {
            GenericUserCollection<string> names = new GenericUserCollection<string>();
            names.Add("David");
            names.Add("Bernica");
            names.Add("Raymond");
            names.Add("Clayton");
            Console.WriteLine("Initial list of names:");
            foreach (string name in names) Console.WriteLine(name);
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
