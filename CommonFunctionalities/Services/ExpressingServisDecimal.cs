using CommonFunctionalities.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctionalities.Services
{
    public class ExpressingServisDecimal : IExpressionService
    {
        public string ProcessExpression(string expression)
        {
            // throw new NotImplementedException();
            var result = CreateNumberSubstring(expression);
            return result.ToString();
        }

        private string CreateNumberSubstring(string expresion)
        {
            List<decimal> numbers = new List<decimal>();
            List<char> operations = new List<char>();
            var numberBuilder = new StringBuilder();
            //expresion = expresion.Replace(',', '.');// w wersji angielskiej gdy są kropki
            var expresionArray = expresion.ToCharArray();

            for (int i = 0; i < expresionArray.Length; i++)
            {
                if (Char.IsDigit(expresionArray[i]) || expresionArray[i] == ',')
                {
                    numberBuilder.Append(expresionArray[i]);
                }
                else
                {
                    var number = Convert.ToDecimal(numberBuilder.ToString());
                    numberBuilder.Clear();
                    numbers.Add(number);
                    operations.Add(expresionArray[i]);
                }
            }
            var result = PerformOperations(numbers, operations);
            return result.ToString();
        }

        private decimal PerformOperations(List<decimal> numbers, List<char> operations)
        {
            var result = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                result = PerformOperation(operations[i - 1], result, numbers[i]);
            }
            return result;
        }
        private decimal PerformOperation(char operationChar, decimal x, decimal y)
        {
            switch (operationChar)
            {
                case '+':
                    return x + y;
                    break;

                case '-':
                    return x - y;
                    break;
                case '*':
                    return x * y;
                    break;
                case '/':
                    return x / y;
                    break;
                default:
                    return x;
                    break;

            }
        }
    }
}
