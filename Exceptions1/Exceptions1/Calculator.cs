using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions1
{
    class Calculator
    {
        public void ComputeAverage()
        {
            List<int> numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or press enter to compute the average.");
                string input = Console.ReadLine();

                if (input == "")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));
            }

            // Input done, now compute average
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            double average = sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
    }
}
