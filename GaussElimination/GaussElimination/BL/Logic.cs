using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussElimination
{
    public class Logic
    {
        public double[,] Matrix { get; private set; }

        public Logic(double[,] Matrix)
        {
            this.Matrix = Matrix;
        }

        public void ChangeRows(int firstRowID, int secondRowID)
        {
            double[] temp = new double[Matrix.GetLength(1)];
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                temp[i] = Matrix[firstRowID, i];
                Matrix[firstRowID, i] = Matrix[secondRowID, i];
                Matrix[secondRowID, i] = temp[i];
            }
        }

        public void AddARowToAnotherRow(int toRowID, int fromRowID, double constant)
        {
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                Matrix[toRowID, i] += Matrix[fromRowID, i] * constant;
            }
        }

        public void MultiplicateARowWithConstant(int rowID, double constant)
        {
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                Matrix[rowID, i] *= constant;
            }
        }

        public int SerachZeroInColumn(int column)
        {
            int row = column;
            int n = Matrix.GetLength(0) - 1;

            while (Matrix[row, column] != 0 && row < n)
            {
                row++;
            }

            if (row<n)
            {
                return row;
            }
            else
            {
                return -1;
            }
        }

        public int SerachNonZeroInColumn(int column)
        {
            int row = column;
            int n = Matrix.GetLength(0);

            while (Matrix[row, column] == 0 && row < n)
            {
                row++;
            }

            if (row < n)
            {
                return row;
            }
            else
            {
                return -1;
            }
        }

        public bool OnlyZerosFromRow(int row, int column)
        {
            while (Matrix[row, column] == 0 && row < Matrix.GetLength(0) - 1)
            {
                row++;
            }

            if (row == Matrix.GetLength(0) - 1)
            {
                return true;
            }

            return false;
        }

        public void Process()
        {
            Console.WriteLine("Kiinduló állapot:");
            DisplayTools.ToConsole(Matrix);
            int n = Matrix.GetLength(1);
            int m = Matrix.GetLength(0);
            for (int i = 0; i < m; i++)
            {
                if (!OnlyZerosFromRow(i, i))
                {
                    if (Matrix[i, i] == 0)
                    {
                        ChangeRows(i, SerachNonZeroInColumn(i));
                    }
                    if (!OnlyZerosFromRow(i + 1, i))
                    {
                        for (int j = i; j < m; j++)
                        {
                            double t = Matrix[j, i];
                            for (int k = i; k < n; k++)
                            {
                                Matrix[j, k] = Matrix[j, k] / t;
                            }
                        }
                        for (int j = i + 1; j < m; j++)
                        {
                            for (int k = i; k < n; k++)
                            {
                                Matrix[j, k] = Matrix[j, k] - Matrix[i, k];
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Átalakítás utáni állapot:");
            DisplayTools.ToConsole(Matrix);
        }

        double[,] CalculateResult()
        {
            double[,] res = new double[Matrix.GetLength(0), Matrix.GetLength(1)];
            

            

            return res;
        }
    }
}
