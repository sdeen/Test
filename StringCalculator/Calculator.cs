using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculator
{
    public static class Calculator
    {
        public static int AddNumber(string number)
        {
            int result = 0;
            try
            {
               
                var arrayNumber = number.Split(new Char[] { ',', '\n' });
                Regex pattern = new Regex(@"([a-zA-Z])");
                //Step #1
                if (string.IsNullOrEmpty(number))
                {
                    result = 0;
                }
                else if (number.Contains("-"))
                {
                    return 1;
                }
                else if (number.Contains(",") && !pattern.IsMatch(number))
                {
                    result = arrayNumber.Sum(n => int.Parse(n));
                }
                else if (pattern.IsMatch(number))
                {
                    var getNumber = number.Where(x => char.IsDigit(x)).ToArray();
                    result = getNumber.Sum(n => int.Parse(n.ToString()));
                }
                else
                {
                    result = int.Parse(number);
                }

            }
            catch (Exception e)
            {
                throw new NotImplementedException();
            }
            return result;
           
        }
    }
}