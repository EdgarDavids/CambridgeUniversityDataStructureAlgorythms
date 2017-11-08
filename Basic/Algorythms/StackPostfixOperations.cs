using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Basic.Algorythms
{
    public static class StackPostfixOperations
    {
        public static void Apply() {
            Stack operands = new Stack();
            Stack operators = new Stack();
            string expression = "5++";
            Calculate(operands, operators, expression);

            operands = new Stack();
            operators = new Stack();
            expression = "5--";
            Calculate(operands, operators, expression);

            operands = new Stack();
            operators = new Stack();
            expression = "5-+";
            Calculate(operands, operators, expression);

            operands = new Stack();
            operators = new Stack();
            expression = "-5+";
            Calculate(operands, operators, expression);

            operands = new Stack();
            operators = new Stack();
            expression = "--5";
            Calculate(operands, operators, expression);
        }

        private static void Calculate(Stack operands, Stack operators, string expression)
        {
            string token = string.Empty;
            string operator_token = string.Empty;
            string operandToken = string.Empty;
            foreach (char i in expression)
            {
                if (IsNumeric(i.ToString()))
                {
                    token += i;
                    if (operator_token != string.Empty) operators.Push(operator_token);
                    operator_token = string.Empty;
                }
                if ((!IsNumeric(i.ToString()))&&((i=='+')|| (i == '-')))
                {
                    operator_token += i;
                    if (token != string.Empty) operands.Push(token);
                    token = string.Empty;
                }
                if (operator_token.Length == 2) operators.Push(operator_token);
                if ((!IsNumeric(i.ToString())) && ((i != '+')&&(i != '-'))) Console.WriteLine("An expression {0} is not valid", expression);
                if ((!IsNumeric(i.ToString())) && ((i != '+') && (i != '-'))) return;

                DoOperation(operands, operators,expression);
            }
        }

        private static void DoOperation(Stack operands, Stack operators, string expression)
        {
            if ((operators.Count > 0) && (operands.Count == 0)) Console.WriteLine("An expression {0} is not valid", expression);
            if ((operators.Count > 0) && (operands.Count == 0)) return;
            if (operators.Count == 0) return;
            if (operators.Peek().ToString().Length < 2) return;
            int operand = Convert.ToInt32(operands.Pop());
            string op = Convert.ToString(operators.Pop());
            switch (op){
                case "++":
                    Console.WriteLine("{0} gives result {1}", expression, operand + 1);
                    break;
                case "--":
                    Console.WriteLine("{0} gives result {1}", expression, operand - 1);
                    break;
                default:
                    Console.WriteLine("An expression {0} is not valid", expression);
                    break;
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
