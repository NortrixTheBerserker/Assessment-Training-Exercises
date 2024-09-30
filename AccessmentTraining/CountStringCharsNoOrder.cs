using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessmentTraining
{
    internal class CountStringCharsNoOrder
    {
        public string result { get; set;}
        public CountStringCharsNoOrder(string str) 
        {
            Dictionary<char, int> strCharsValues = new Dictionary<char, int>();
            foreach (char c in str)
            {

                if (strCharsValues.TryGetValue(c, out int value))
                    strCharsValues[c] = value + 1;
                else
                {
                    strCharsValues.Add(c, 1);
                }
            }

            Dictionary<char, int>.KeyCollection keys = strCharsValues.Keys;

            for(int i  = 0; i < keys.Count; i++)
            {
                result += keys.ElementAt(i).ToString() + strCharsValues[keys.ElementAt(i)].ToString();
            }
        }
    }
}
