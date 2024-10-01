using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTraining
{
    internal class EvenCounter
    {
        /// <summary>
        /// Stored result of the constructor
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Receives a string to containing int numbers seperated by , counts how many even numbers there are in the string
        /// </summary>
        /// <param name="toCount">String with ints to count how many even numbers there are</param>
        public EvenCounter(string toCount) 
        {
            string[] numbers = toCount.Split(','); // separate all ints into a string array and removes the ,
            for (int i = 0; i < numbers.Length; i++) // loops the string array
            {
                if (int.Parse(numbers[i]) % 2  == 0) // if modulus of number by 2 is 0 then number is even
                {
                    Count++;
                }
            }
        }
    }
}
