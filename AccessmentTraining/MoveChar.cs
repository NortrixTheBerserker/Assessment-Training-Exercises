using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessmentTraining
{
    internal class MoveChar
    {
        public string result { get; set; }
        public MoveChar(string str, int n, char split)
        {
            result = "";
            string[] subdvd = str.Split(split);
            for (int i = 0; i < subdvd.Length-1; i++)
            {
                result += split;
            }
            Console.WriteLine("Special Character is: " + split +"\nNumber of Special Characters is: " + result.Length);

            for(int j=0; j < subdvd.Length; j++)
            {
                result += subdvd[j];
            }
        }
    }
}
