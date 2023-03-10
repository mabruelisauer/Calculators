using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class StringCalculator {

        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            string[] numberStrings = numbers.Split(new char[] { ',', '\n' });

            int sum = 0;

            foreach (string numberString in numberStrings)
            {
                int number;
                if (int.TryParse(numberString, out number))
                {
                    sum += number;
                }
                else
                {
                    throw new ArgumentException("Invalid number format");
                }
            }

            return sum;
        }

    }
}
