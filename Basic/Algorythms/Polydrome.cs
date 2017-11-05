using System;

namespace Basic.Algorythms
{
    /// <summary>
    /// Stack usage
    /// </summary>
    public static class Polydrome
    {
        public static void Apply() {
            UserStack stack = new UserStack();

            string polydrome = "madam";
            foreach (char ch in polydrome) stack.Push(ch);
            Console.WriteLine("{0} is polydrome : {1}", polydrome, isPolydrome(polydrome, stack));
            polydrome = "sees";
            foreach (char ch in polydrome) stack.Push(ch);
            Console.WriteLine("{0} is polydrome : {1}", polydrome, isPolydrome(polydrome, stack));
            polydrome = "table";
            foreach (char ch in polydrome) stack.Push(ch);
            Console.WriteLine("{0} is polydrome : {1}", polydrome, isPolydrome(polydrome, stack));

        } 

        private static bool isPolydrome(string palydrome, UserStack stack) {
            bool isPolydrome = true;
            int pos = 0;
            while (stack.Count > 0)
            {
                char ch = (char)stack.Pop();
                if (ch != palydrome[pos]) return false;

                pos++;
            }

            return isPolydrome;
        }
    }
}
