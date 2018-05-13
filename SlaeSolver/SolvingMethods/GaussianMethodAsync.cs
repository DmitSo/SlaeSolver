using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlaeSolver
{
    public class GaussianMethod : ISlaeSolvingMethod
    {
        public double[] Solve(Slae slae)
        {
            // Preparation : copying arrays of slae
            // cuz, u know, it changes data in Slae 
            // object if we'll use data from slae object properly
            double[][] A = new double[slae.N][];
            Parallel.For(0, slae.N, (i) =>
            {
                A[i] = new double[slae.N];
                System.Array.Copy(slae.Matrix[i], A[i], slae.N);
            });

            double[] B = new double[slae.N];
            Array.Copy(slae.B, B, slae.N);

            ForwardElimination(A, B, slae.N);
            return BackSubstitution(A,B,slae.N);
        }

        // прямой ход
        private static void ForwardElimination(double[][] A, double[] B, int n)
        {
            for (int k = 0; k < n; k++) 
            {
                Parallel.For(k + 1, n, j =>
                {
                    double d = A[j][k] / A[k][k];

                    for (int i = k; i < n; i++)
                    {
                        A[j][i] = A[j][i] - d * A[k][i];
                    }

                    B[j] = B[j] - d * B[k];
                });
            }
        }

        // обратный ход
        private static double[] BackSubstitution(double[][] A, double[] B, int n)
        {
            double[] X = new double[n];

            for (int k = n - 1; k >= 0; k--) 
            {
                double d = 0;

                for (int j = k + 1; j < n; j++)
                {
                    double s = A[k][j] * X[j];
                    d = d + s;
                }

                X[k] = (B[k] - d) / A[k][k];
            }

            return X;
        }


        public override string ToString()
        {
            return "Gaussian (miltithread)";
        }
    }
}
