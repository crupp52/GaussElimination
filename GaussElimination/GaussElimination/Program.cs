using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaussElimination
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[,] matrix =
            //{
            //    {1, -2, 5, 9},
            //    {1, -1, 3, 2},
            //    {3, -6, -1, 25}
            //};

            //double[,] matrix =
            //{
            //    {1, 2, 1, 8},
            //    {2, 1, -1, 1},
            //    {2, -1, 1, 3}
            //};

            double[,] matrix =
            {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 1},
                {2, 3, 5, 6, 7}
            };

            //double[,] matrix =
            //{
            //    {9, 3, 4, 7},
            //    {4, 3, 4, 8},
            //    {1, 1, 1, 3}
            //};

            //double[,] matrix =
            //{
            //    {1, -3, 1, 4},
            //    {2, -8, 8, -2},
            //    {-6, 3, -15, 9}
            //};
            
            Logic l = new Logic(matrix);
            l.Process();
            DisplayTools.ShowResult(matrix);
            DisplayTools.ToConsole(l.CalculateResult());

            Console.ReadKey();
        }
    }
}
