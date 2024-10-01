using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTraining
{
    internal class MoveChar
    {
        /// <summary>
        /// Stored result of the constructor
        /// </summary>
        public string result { get; set; }

        /// <summary>
        /// moves all occurrences of character to the beginning of the string
        /// </summary>
        /// <param name="str"> string passed to be processed</param>
        /// <param name="n">size of the string passed</param>
        /// <param name="split">character to move to the beginning of the string</param>
        public MoveChar(string str, int n, char split)
        {
            result = ""; //initialize the result string as an empty string
            string[] subdvd = str.Split(split); //split the input string into a string array by the character stored in variable split
            for (int i = 0; i < subdvd.Length-1; i++) //adds to the start of the result string the number of times the character was found in the string
            {
                result += split;
            }

            Console.WriteLine("Special Character is: " + split +"\nNumber of Special Characters is: " + result.Length); // debug


            for(int j=0; j < subdvd.Length; j++) //adds to result the content of string str in the original order
            {
                result += subdvd[j];
            }
        }
    }
}
