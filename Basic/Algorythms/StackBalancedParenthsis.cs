using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic.Algorythms
{
    public static class StackBalancedParenthsis
    {
        public static void Apply() {
            Check("(1+4)8*5");
            Check("((1+4)8*5");
            Check("()1+4)8*5");
            Check(")(1+48*5");
        }

        private static void Check(string str) {
            bool balanced = true;
            Stack stack = new Stack();
            foreach (char ch in str) {
                if (!balanced) break;
                if (ch == '(') stack.Push(ch);
                if (ch != ')') continue;
                if (stack.Count == 0) balanced = false;
                if (stack.Count == 0) continue;
                stack.Pop();
            }

            if (!balanced) Console.WriteLine("{0} - The parenthesis are not balanced",str);
            if (stack.Count>0) Console.WriteLine("{0} -The parenthesis are not balanced",str);
            if ((balanced)&&(stack.Count == 0)) Console.WriteLine("{0} -The parenthesis are balanced",str);
        }
    }
}
