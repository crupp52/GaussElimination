using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussElimination
{
    public static class DisplayTools
    {
        public static string abc = "abcdefghijklmnopqrstuvwxyz";
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
                        Console.Write("{0:N3}\t", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("|\t{0:N3}\n", matrix[i, j]);
                    }
                }
            }
            Console.WriteLine();
        }

        public static void ToConsole(double[] matrix)
        {
            
            int r = matrix.GetLength(0);
            for (int i = 0; i < r; i++)
            {
                Console.Write($"{abc[i].ToString().ToUpper()}= {matrix[i]:N3}\t");
            }
        }

        public static void ShowResult(double[,] matrix)
        {
            int x = matrix.GetLength(1);
            int y = matrix.GetLength(0);

            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j == 0)
                    {
                        Console.Write($"{Math.Abs(matrix[i, j]):N3}{abc[j].ToString().ToUpper()}");
                    }
                    else if (j < x - 1)
                    {
                        if (matrix[i, j] >= 0)
                        {
                            Console.Write($" + {Math.Abs(matrix[i, j]):N3}{abc[j].ToString().ToUpper()}");
                        }
                        else
                        {
                            Console.Write($" - {Math.Abs(matrix[i, j]):N3}{abc[j].ToString().ToUpper()}");
                        }
                    }
                    else
                    {
                        if (matrix[i, j] > 0)
                        {
                            Console.Write($" = {Math.Abs(matrix[i, j]):N3}");
                        }
                        else
                        {
                            Console.Write($" = -{Math.Abs(matrix[i, j]):N3}");
                        }
                        
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }

    
}
