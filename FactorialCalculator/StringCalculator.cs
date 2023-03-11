using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class StringCalculator {

        private static int calledCount = 0;

        public static int CalledCount
        {
            get { return calledCount; }
        }

        public static int Add(string numbers)
        {
            calledCount++;
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            char separator = ',';
            if (!char.IsDigit(numbers[0]))
            {
                separator = numbers[0];
                numbers = numbers.Substring(1);
            }

            string[] numberStrings = numbers.Split(new char[] { separator, '\n' });

            int sum = 0;
            List<int> negativeNumbers = new List<int>();

            foreach (string numberString in numberStrings)
            {
                int number;
                if (int.TryParse(numberString, out number))
                {
                    if (number < 0)
                    {
                        negativeNumbers.Add(number);
                    }
                    else
                    {
                        if (number<=100)
                        {
                            sum += number;
                        }
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid number format");
                }
            }

            if (negativeNumbers.Count > 0)
            {
                throw new InvalidOperationException($"Negatives not allowed: {string.Join(", ", negativeNumbers)}");
            }

            return sum;
        }

    }
}
