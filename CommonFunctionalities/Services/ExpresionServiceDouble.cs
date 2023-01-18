using CommonFunctionalities.Services.Interfaces;
using System.Buffers;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CommonFunctionalities.Services
{
    public class ExpressionServiceDecimal : IExpressionService
    {
        public string ProcessExpression(string expression)
        {
            // throw new NotImplementedException();
            var result = CreateNumberSubstring(expression);
            return result.ToString();
        }

        private string CreateNumberSubstring(string expresion)
        {
            List<double> numbers = new List<double>();
            List<char> operations = new List<char>();
            var numberBuilder = new StringBuilder();
            //expresion = expresion.Replace(',', '.');// w wersji angielskiej gdy są kropki
            var expresionArray = expresion.ToCharArray();
            
            for (int i = 0; i < expresionArray.Length; i++)
            {
                if(Char.IsDigit(expresionArray[i]) || expresionArray[i]==',')
                {
                    numberBuilder.Append(expresionArray[i]);
                }
                else
                {
                    var number = Convert.ToDouble(numberBuilder.ToString());
                    numberBuilder.Clear();
                    numbers.Add(number);
                    operations.Add(expresionArray[i]);
                }
            }
           var result = PerformOperations(numbers, operations);
          return result.ToString();
        }

        private double PerformOperations(List<double> numbers, List<char> operations)
        {
            var result = numbers[0];
            for(int i=1; i<numbers.Count;i++)
            {
                result = PerformOperation(operations[i - 1], result, numbers[i]);
            }
            return result;
        }
        private double PerformOperation(char operationChar, double x, double y)
        {
            switch(operationChar)
            {
                case '+':
                    return x+ y;
                    break;

                case '-':
                    return x- y;
                    break;
                case '*':
                    return x*y;
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

