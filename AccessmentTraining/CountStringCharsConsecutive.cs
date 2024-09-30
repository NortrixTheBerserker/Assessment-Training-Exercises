using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessmentTraining
{
    internal class CountStringCharsConsecutive
    {
        public string result {  get; set; }

        public CountStringCharsConsecutive(string strToCount) 
        {
            char lastChar = strToCount[0];
            int charCount = 1;

            for (int i = 1; i < strToCount.Length; i++)
            {
                if (lastChar.CompareTo(strToCount[i]) == 0)
                {
                    lastChar = strToCount[i];
                    charCount++;
                }
                else
                {
                    result += lastChar + charCount.ToString();
                    lastChar = strToCount[i];
                    charCount = 1;
                }
            }
            if(charCount == 1)
            {
                result += strToCount[strToCount.Length - 1] + charCount.ToString();
            }
        }
    }
}
