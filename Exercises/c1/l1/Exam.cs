using Basic;
using System;

namespace Exercises.c1.l1
{
    internal class Exam<T> where T:UserCollection
    {
        private UserCollection submittedTest;
        private UserCollection outForChecking;
        
        internal Exam() {
            submittedTest = new UserCollection();
            outForChecking = new UserCollection();
        }

        internal void TurnIn(string name) {
            submittedTest.Add(name);
        }

        internal void LookTest(string name){
            submittedTest.Remove(name);
            outForChecking.Add(name);
        }

        internal void ReturnTest(string name) {
            outForChecking.Remove(name);
            submittedTest.Add(name);  
        }

        internal void ShowSubmitted() {
            Console.WriteLine("Submitted Tests: ");
            foreach (string test in submittedTest) Console.Write("{0} ", test);
            Console.WriteLine();
        }

        internal void ShowOutChecking(){
            Console.WriteLine("Out For Checking: ");
            foreach (string test in outForChecking) Console.Write("{0} ", test);
            Console.WriteLine();
        }

        internal string GetName() {
            Console.WriteLine("Input name: ");
            return Console.ReadLine();

        }
    }
}
