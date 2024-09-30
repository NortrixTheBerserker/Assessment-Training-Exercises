using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AssessmentTraining
{
    internal class Matrix
    {
        //public
        public string result { get; set; }

        //private
        private int[,] mat;

        public Matrix(int lines, int cols) 
        {
            int tmpVal = 1;
            mat = new int[lines,cols];
            string original = "";

            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    mat[i,j] = tmpVal;
                    original += tmpVal.ToString()+ " "; 
                    tmpVal++;
                }
            }
            Console.WriteLine("Original matrix in a sequence: " + original);
        }

        public void OrderResultInSpiral()
        {
            int l = mat.GetLength(0);
            int c = mat.GetLength(1);
            int auxL = 0;
            int auxC = 0;
            int modifyLorC = 2; // 1 modify lines positive, 2 modify columns positive, -1 modify lines negative, -2 modify columns negative
            int maxL = l;
            int minL = 0;
            int maxC = c;
            int minC = 0;
            bool startLoop = true;

            for (int i = 0; i < l * c; i++)
            {
                result += mat.GetValue(auxL, auxC) + " " ;
                switch (modifyLorC)
                {
                    case 1:
                        auxL++;
                        if (auxL >= maxL - 1)
                        {
                            modifyLorC = -2;
                            minL++;
                        }
                        break;
                    case 2: //start case
                        auxC++;
                        if (auxC >= maxC - 1)
                        {
                            if(!startLoop)
                                minC++;
                            modifyLorC = 1;
                            startLoop = false;
                        }
                        break;
                    case -1:
                        auxL--;
                        if (auxL <= minL)
                        {
                            modifyLorC = 2;
                            maxL--;
                        }
                        break;
                    case -2:
                        auxC--;
                        if (auxC <= minC)
                        {
                            modifyLorC = -1;
                            maxC--;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
