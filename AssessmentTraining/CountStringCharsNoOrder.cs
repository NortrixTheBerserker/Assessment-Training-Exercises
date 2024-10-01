using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTraining
{
    internal class CountStringCharsNoOrder
    {
        /// <summary>
        /// Stored result of the constructor
        /// </summary>
        public string result { get; set;}

        /// <summary>
        /// Counts how many times each character in a string appears
        /// </summary>
        /// <param name="str">String to be parsed to count character</param>
        public CountStringCharsNoOrder(string str) 
        {
            Dictionary<char, int> strCharsValues = new Dictionary<char, int>(); // dictionary to store all occurences of each character in each pair <char, int> key is the character found and int is the number of times it was found
            foreach (char c in str) //loops the entire string
            {

                if (strCharsValues.TryGetValue(c, out int value)) //checks if the current character already exists in the dictionary, and outputs number of times it appeared in value
                    strCharsValues[c] = value + 1; //if current character exists adds one more occurrence to value and stores it again on the dictionary
                else
                {
                    strCharsValues.Add(c, 1); //if current character does not exist in the dictionary, add it to dictionary and sets the number of times it appeard to 1
                }
            }

            Dictionary<char, int>.KeyCollection keys = strCharsValues.Keys; // gets all the keys in the dictionary

            for(int i  = 0; i < keys.Count; i++) // loops by all the keys in the dictionary
            {
                result += keys.ElementAt(i).ToString() + strCharsValues[keys.ElementAt(i)].ToString(); // adds to result string each pair <key, value> from the dictionary
            }
        }
    }
}
