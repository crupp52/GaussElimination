using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussElimination
{
    public static class DisplayTools
    {
        public static void ToConsole(double[,] matrix)
        {
            int x = matrix.GetLength(1);
            int y = matrix.GetLength(0);
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j < x - 1)
                    {
                        Console.Write("{0}\t", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("|\t{0}\n", matrix[i, j]);
                    }
                }
            }
        }
    }
}
