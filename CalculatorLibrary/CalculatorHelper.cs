using System;

namespace CalculatorLibrary
{
    public class CalculatorHelper
    {
        public static decimal Calculate(decimal left, decimal right,
            char operationOperator)
        {
            decimal result = 0;
            switch (operationOperator)
            {
                case '+':
                    result = left + right;
                    break;
                case '-':
                    result = left - right;
                    break;
                case '*':
                    result = left * right;
                    break;
                case '/':
                    ValidateRightNotZero(right);
                    result = left / right;
                    break;
                case '%':
                    ValidateRightNotZero(right);
                    result = left % right;
                    break;
            }

            return result;
        }

        private static void ValidateRightNotZero(decimal right)
        {
            if(right == 0)
            {
                throw new DivideByZeroException();
            }
        }
    }
}
