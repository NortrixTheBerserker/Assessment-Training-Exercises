using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Count even numbers

            //EvenCounter evenCounter = new EvenCounter("1,2,3,4,5,6,7,8,9,10,11,12,100,987,562174");
            //Console.WriteLine("number of even numbers: " + evenCounter.Count + "\n");

            //Count odd numbers

            //OddCounter oddCounter = new OddCounter("1,2,3,4,5,6,7,8,9,10,11,12,100,987,562174");
            //Console.WriteLine("number of odd numbers: " + oddCounter.Count + "\n");

            //Move character to the beginning of string

            //string str = "#Hello#World#!#######Hello#World#!###";
            //string str = "HeLLo%World%How%Are%YOu%?";
            //int sizeStr = str.Length;
            //MoveChar moveChar = new MoveChar(str,sizeStr,'%');
            //Console.WriteLine("String is: " + moveChar.result);

            //Count consecutive characters in a string

            //string str = "aaabbbcccdddeeefffggghhhiiijjjkkk";
            //string str = "abbbbbcccccccccccdddddddeeffffffghhhhiiijjjjjjjjjjk";
            //string str = "abcdefghijklmnopqrstuvwxyz";
            //CountStringCharsConsecutive countChars = new CountStringCharsConsecutive(str);
            //Console.WriteLine("new string is: " + countChars.result);

            //count number of all characters in a string

            //string str = "abcdefghijklmnopqrstuvwxyz";
            //string str = "abbbbbcccccccccccdddddddeeffffffghhhhiiijjjjjjjjjjk";
            //string str = "klojsdokjfghasdoiputmgvbadsro+pitubnmjseroikljwdrhngoiusdfhbngliasudfhnglsiundfhngçusdihfgupnviçdshfgpuisdnmbfiugbhsndfuiçgbshdu gsduifthgnv wpsaidfu hp+9uqerd htg+9arusdf hg'9audf hga'9ushdfg9uas'dfgt";
            //CountStringCharsNoOrder countChars = new CountStringCharsNoOrder(str);
            //Console.WriteLine("new string is: " + countChars.result);


            //Order a 2D Matrix in a spiral output string
            Console.WriteLine("Input the number of lines: ");
            string lines = Console.ReadLine();
            Console.WriteLine("Input the number of Columns: ");
            string columns = Console.ReadLine();
            bool validL = int.TryParse(lines, out int nLines);
            bool validC = int.TryParse(columns, out int nCols);

            if (validC && validL)
            {
                Matrix values = new Matrix(nLines, nCols);
                values.OrderResultInSpiral();
                Console.WriteLine("Resulting string of spiral read: " + values.result.ToString());
            }
            else
            {
                Console.WriteLine("\ninvalid characters, must be a number\n");
            }










            Console.ReadKey(true);
        }
    }
}
