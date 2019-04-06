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
                Matrix[rowID, i] = Matrix[rowID, i] * constant;
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

        public void Process()
        {
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                for (int j = i; j < Matrix.GetLength(0); j++)
                {

                }
            }
        }
    }
}
