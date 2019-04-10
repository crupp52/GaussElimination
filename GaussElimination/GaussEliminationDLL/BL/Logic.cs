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

        public void Process()
        {
            Console.WriteLine("Kiinduló állapot:");
            DisplayTools.ToConsole(Matrix);
            int n = Matrix.GetLength(1);
            int m = Matrix.GetLength(0);
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = i + 1; j < m; j++)
                {
                    double t = Matrix[j, i] / Matrix[i, i];
                    for (int k = 0; k <= m; k++)
                    {
                        Matrix[j, k] -= Matrix[i, k] * t;
                    }
                    Matrix[j, i] = 0;
                }
            }
            Console.WriteLine("Átalakítás utáni állapot:");
            DisplayTools.ToConsole(Matrix);
        }

        public double[] CalculateResult()
        {
            double[] res = new double[Matrix.GetLength(0)];

            int c = Matrix.GetLength(1);
            int r = Matrix.GetLength(0);

            for (int i = r - 1; i >= 0; i--)
            {
                res[i] = Matrix[i, r];
                for (int j = i + 1; j < r; j++)
                {
                    res[i] -= Matrix[i, j] * res[j];
                }
                res[i] /= Matrix[i, i];
            }

            return res;
        }
    }
}
