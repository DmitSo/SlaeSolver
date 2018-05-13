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
            FindLU(slae, out double[][] L, out double[][] U);
            var Y = CalcY(slae, L);
            var X = CalcX(slae, U, Y);
            return X;
        }

        private static void FindLU(Slae slae, out double[][] L, out double[][] U)
        {
            double[][] Ltmp = new double[slae.N][];
            double[][] Utmp = new double[slae.N][];

            Parallel.For(0, slae.N, (i) =>
            {
                Ltmp[i] = new double[slae.N];
                Utmp[i] = new double[slae.N];
                System.Array.Copy(slae.Matrix[i], Utmp[i], slae.N);
            });

            Parallel.For(0, slae.N, i =>
            {
                for (int j = i; j >= 0; j--)
                    Ltmp[j][i] = Utmp[j][i] / Utmp[i][i];
            });
            

            Parallel.For(1, slae.N, k =>
            {
                for (int i = 0; i < slae.N; i++)
                    for (int j = i; j >= 0; j--)
                        Ltmp[j][i] = Utmp[j][i] / Utmp[i][i];

                for (int i = k; i < slae.N; i++)
                    for (int j = k - 1; j < slae.N; j++)
                        Utmp[i][j] = Utmp[i][j] - Ltmp[i][k - 1] * Utmp[k - 1][j];
            });
            L = Ltmp;
            U = Utmp;
        }
        
        // non paralleled
        private static double[] CalcY(Slae slae, double[][] L)
        {
            double[] Y = new double[slae.N];
            for(int i = 0; i < slae.N; i++)
            {
                double sum = 0;

                for (int j = 0; j < i; j++)                
                    sum += L[i][j] * Y[j];
                
                Y[i] = (slae.B[i] - sum) / L[i][i];
            }

            return Y;
        }

        // not paralleled
        private static double[] CalcX(Slae slae, double[][] U, double[] Y)
        {
            double[] X = new double[slae.N];

            for(int i = slae.N-1; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < slae.N; j++)
                    sum += U[i][j] * X[j];

                X[i] = (Y[i] - sum) / U[i][i];
            }

            return X;
        }
        
        public override string ToString()
        {
            return "LU-Decomposition (multithread)";
        }
    }
}
