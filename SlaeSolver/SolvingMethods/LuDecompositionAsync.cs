using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SlaeSolver
{
    public class LuDecompositionAsync : ISlaeSolvingMethod
    {
        public double[] Solve(Slae slae)
        {
            FindLU(slae, out double[][] LU);
            var Y = FindY(slae, LU);
            var X = FindX(slae, LU, Y);
            return X;
        }

        private static void FindLU(Slae slae, out double[][] lu)
        {
            double[][] LU = new double[slae.N][];
            for (int i = 0; i < LU.Length; i++)
                LU[i] = new double[slae.N];
            
            for (int i = 0; i < slae.N; i++)
            {
                Parallel.For(i, slae.N, j =>
                {
                    double sum = 0;
                    for (int k = 0; k < i; k++)
                        sum += LU[i][k] * LU[k][j];
                    LU[i][j] = slae.Matrix[i][j] - sum;
                });

                Parallel.For(i + 1, slae.N, j =>
                {
                    double sum = 0;
                    for (int k = 0; k < i; k++)
                        sum += LU[j][k] * LU[k][i];
                    LU[j][i] = (slae.Matrix[j][i] - sum) / LU[i][i];
                });
            }
            //});
            lu = LU;
        }

        private double[] FindY(Slae slae, double[][] LU)
        {
            double[] y = new double[slae.N];

            for (int i = 0; i < slae.N; i++)
            {
                double sum = 0;

                for (int k = 0; k < i; k++)
                    sum += LU[i][k] * y[k];

                y[i] = slae.B[i] - sum;
            }

            return y;
        }

        public double[] FindX(Slae slae, double[][] LU, double[] y)
        {
            double[] x = new double[slae.N];

            for (int i = slae.N - 1; i >= 0; i--)
            {
                double sum = 0;

                for (int k = i + 1; k < slae.N; k++)
                    sum += LU[i][k] * x[k];

                x[i] = (y[i] - sum) / LU[i][i];
            }

            return x;
        }

        public override string ToString()
        {
            return "LU-Decomposition (multithread)";
        }
    }
}
