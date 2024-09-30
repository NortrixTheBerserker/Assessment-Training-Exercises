using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessmentTraining
{
    internal class OddCounter
    {
        public int Count { get; set; }
        public OddCounter(string toCount)
        {
            string[] numbers = toCount.Split(',');
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i])%2 != 0)
                {
                    Count++;
                }
            }
        }
    }
}
