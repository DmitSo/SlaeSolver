namespace SlaeSolver
{
    public class LuDecomposition : ISlaeSolvingMethod
    {
        public double[] Solve(Slae slae)
        {
            FindLU(slae, out double[][] LU);
            var Y = FindY(slae, LU);
            var X = FindX(slae, LU, Y);
            return X;
        }

        private static void FindLU(Slae slae, out double[][] LU)
        {
            LU = new double[slae.N][];
            for (int i = 0; i < LU.Length; i++)
                LU[i] = new double[slae.N];

            double sum = 0;

            for (int i = 0; i < slae.N; i++)
            {
                for (int j = i; j < slae.N; j++)
                {
                    sum = 0;
                    for (int k = 0; k < i; k++)
                        sum += LU[i][k] * LU[k][j];
                    LU[i][j] = slae.Matrix[i][j] - sum;
                }

                for (int j = i + 1; j < slae.N; j++)
                {
                    sum = 0;
                    for (int k = 0; k < i; k++)
                        sum += LU[j][k] * LU[k][i];
                    LU[j][i] = (1 / LU[i][i]) * (slae.Matrix[j][i] - sum);
                }
            }
        }

        private double[] FindY(Slae slae, double[][] LU)
        {
            double[] y = new double[slae.N];
            double sum = 0;

            for (int i = 0; i < slae.N; i++)
            {
                sum = 0;
                for (int k = 0; k < i; k++)
                    sum += LU[i][k] * y[k];
                y[i] = slae.B[i] - sum;
            }

            return y;
        }

        public double[] FindX(Slae slae, double[][] LU, double[] y)
        {
            double[] x = new double[slae.N];
            double sum = 0;

            for (int i = slae.N - 1; i >= 0; i--)
            {
                sum = 0;
                for (int k = i + 1; k < slae.N; k++)
                    sum += LU[i][k] * x[k];
                x[i] = (y[i] - sum) / LU[i][i];
            }

            return x;
        }

        public override string ToString()
        {
            return "LU-Decomposition";
        }
    }
}
