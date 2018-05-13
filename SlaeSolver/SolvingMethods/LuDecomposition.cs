namespace SlaeSolver
{
    public class LuDecomposition : ISlaeSolvingMethod
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
            L = new double[slae.N][];
            //U = (double[][])slae.Matrix.Clone();
            U = new double[slae.N][];
            for (int i = 0; i < slae.N; i++)
            {
                L[i] = new double[slae.N];
                U[i] = new double[slae.N];
                System.Array.Copy(slae.Matrix[i], U[i], slae.N);
            }
            
            for (int i = 0; i < slae.N; i++)
                for (int j = i; j >= 0; j--)
                    L[j][i] = U[j][i] / U[i][i];

            for (int k = 1; k < slae.N; k++)
            {
                for (int i = 0; i < slae.N; i++)
                    for (int j = i; j >= 0; j--)
                        L[j][i] = U[j][i] / U[i][i];

                for (int i = k; i < slae.N; i++)
                    for (int j = k - 1; j < slae.N; j++)
                        U[i][j] = U[i][j] - L[i][k - 1] * U[k - 1][j];
            }
        }

        private static double[] CalcY(Slae slae, double[][] L)
        {
            double[] Y = new double[slae.N];

            for (int i = 0; i < slae.N; i++)
            {
                double sum = 0;
                for (int j = 0; j < i; j++)
                    sum += L[i][j] * Y[j];
                Y[i] = (slae.B[i] - sum) / L[i][i];
            }

            return Y;
        }

        private static double[] CalcX(Slae slae, double[][] U, double[] Y)
        {
            double[] X = new double[slae.N];

            for (int i = slae.N - 1; i >= 0; i--)
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
            return "LU-Decomposition";
        }

    }
}
