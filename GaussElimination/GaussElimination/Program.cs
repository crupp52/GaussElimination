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
            double[,] matrix =
            {
                {1, -2, 5, 9},
                {1, -1, 3, 2},
                {3, -6, -1, 25}
            };

            DisplayTools.ToConsole(matrix);

            Logic l = new Logic();

            Console.ReadKey();
        }
    }
}
