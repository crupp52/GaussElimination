using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussElimination
{
    public class Logic
    {
        public void ChangeRows(double[,] matrix, int firstRowID, int secondRowID)
        {
            double[] temp = new double[matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                temp[i] = matrix[firstRowID, i];
                matrix[firstRowID, i] = matrix[secondRowID, i];
                matrix[secondRowID, i] = temp[i];
            }
        }
    }
}
