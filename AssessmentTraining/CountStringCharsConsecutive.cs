using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTraining
{
    internal class CountStringCharsConsecutive
    {
        /// <summary>
        /// Stored result of the constructor
        /// </summary>
        public string result {  get; set; }

        /// <summary>
        /// Counts how many equal and consecutive characters a string has, stores result in class property result in the following format [character and number of occurrences] "a4b6n2j7o3"
        /// </summary>
        /// <param name="strToCount">String to be parsed to count characters</param>
        public CountStringCharsConsecutive(string strToCount) 
        {
            char lastChar = strToCount[0]; //variable to store the last character found on string, is initialized with the first character of the string 
            int charCount = 1; //number of times the same character was found consecutivly in the string

            for (int i = 1; i < strToCount.Length; i++)  //loops entire string one character at a time
            {
                if (lastChar.CompareTo(strToCount[i]) == 0) //Compares if last character found is the same as the current one
                {
                    //lastChar = strToCount[i]; 
                    charCount++; // if the character is the same increment the counter
                }
                else //if character is different then last one
                {
                    result += lastChar + charCount.ToString(); // add to result the character and the number of times it appeared
                    lastChar = strToCount[i]; //stores the new character found
                    charCount = 1; //resets counter back to 1
                }
            }
            if(charCount == 1) // special case when the last character of the string only appears once to have it also on the result string
            {
                result += strToCount[strToCount.Length - 1] + charCount.ToString();
            }
        }
    }
}
