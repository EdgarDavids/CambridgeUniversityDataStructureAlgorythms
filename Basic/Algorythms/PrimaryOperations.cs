using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace Basic.Algorythms
{
    /// <summary>
    /// Stack usage
    /// </summary>
    public static class PrimaryOperations
    {
        public static void Apply() {
            Stack nums = new Stack();
            Stack ops = new Stack();

            string expression = "5 + 10 + 15 + 20";

            Calculate(nums, ops, expression);
            Console.WriteLine("Summary {0} = {1}", expression, nums.Pop());
        }

        private static void Calculate(Stack N, Stack O, string expression) {
            string ch, token = string.Empty;
            for (int i = 0; i < expression.Length; i++) {
                ch = expression.Substring(i, 1);
                if (IsNumeric(ch)) token += ch;
                if ((ch == " ") || (i == (expression.Length - 1))) {
                    if (IsNumeric(token)) {
                        N.Push(token);
                        token = string.Empty;
                    }
                }
                if ((ch == "+") || (ch == "-") || (ch == "*") || (ch == "/")) O.Push(ch);

                if (N.Count == 2) Compute(N, O);
            }
        }

        private static void Compute(Stack n, Stack o)
        {
            int operand1 = Convert.ToInt32(n.Pop());
            int operand2 = Convert.ToInt32(n.Pop());
            string op1 = o.Pop().ToString();

            switch (op1) {
                case "+": n.Push(operand1 + operand2);
                    break;
                case "-":
                    n.Push(operand1 - operand2);
                    break;
                case "*":
                    n.Push(operand1 * operand2);
                    break;
                case "/":
                    n.Push(operand1 / operand2);
                    break;
                default: break;
            }
        }

        private static bool IsNumeric(string ch)
        {
            bool flag = true;
            string pattern = (@"^\d+$");
            Regex validate = new Regex(pattern);
            if (!validate.IsMatch(ch)) flag = false;
            return flag;
        }
    }
}
