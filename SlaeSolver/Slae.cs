﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SlaeSolver
{
    public class Slae
    {
        public int N { get { return B.Length; } }
        private double[][] matrix;
        public double[][] Matrix
        {
            get { return matrix; }
            private set
            {
                matrix = value;
            }
        }
        public double[] B { get; private set; }

        
        public bool IsCorrect(double[] decision, double epsillon = 1)
        {
            bool isCorrect = true;
            for (int i = 0; i < N && isCorrect; i++)
            {
                double s = 0;
                for (int j = 0; j < N; j++)
                {
                    s += decision[j] * Matrix[i][j];
                }
                double difference = Math.Abs(Math.Abs(s) - Math.Abs(B[i]));
                if (difference > epsillon)
                {
                    System.Diagnostics.Debug.WriteLine($"{Math.Abs(s)} - {Math.Abs(B[i])}" +
                        $" = {difference} AT row [{i}]");
                    isCorrect = false;
                }
            }
            return isCorrect;
        }

        public bool IsCorrect(double[] decision, out int errorIndex, double epsillon = 1)
        {
            bool isCorrect = true;
            errorIndex = -1;
            for (int i = 0; i < N && isCorrect; i++)
            {
                double s = 0;
                for (int j = 0; j < N; j++)
                {
                    s += decision[j] * Matrix[i][j];
                }
                double difference = Math.Abs(Math.Abs(s) - Math.Abs(B[i]));
                if (difference > epsillon)
                {
                    System.Diagnostics.Debug.WriteLine($"{Math.Abs(s)} - {Math.Abs(B[i])}" +
                        $" = {difference} AT row [{i}]");
                    isCorrect = false;
                    errorIndex = i;
                }
            }
            return isCorrect;
        }

        public double this[int i, int j]
        {
            // can return B[i] as there's Matrix[N;N+1]
            get { return j == N ? B[i] : Matrix[i][j]; }
        }

        /// <summary>
        /// Initializing Slae with matrix and array of right part
        /// </summary>
        /// <param name="matrix">matrix of the SLAE A</param>
        /// <param name="b">matrix of free coeffs B</param>
        public Slae(double[][] matrix, double[] b)
        {
            if (matrix.Length == b.Length)
            {
                Matrix = matrix;
                B = b;
            }
            else
                throw new ArgumentException();
        }
        
        /// <summary>
        /// Creates random slae with size of NxN
        /// </summary>
        /// <param name="N">Size of the matrix NxN</param>
        public Slae(int N)
        {
            Random random = new Random();
            Matrix = new double[N][];
            for (int i = 0; i < N; i++)
            {
                Matrix[i] = new double[N];
                Matrix[i][i] = 1;
            }
            B = new double[N];

            for (int i = 0; i < N; i++)
            {
                var next = random.Next();
                double k0 = ((next % (N + 1)) - 250) / 100.0;
                int k1 = random.Next() % N;
                int k2 = random.Next() % N;

                for (int j = 0; j < i; j++)
                {
                    Matrix[j][i] = Matrix[i][j] = random.NextDouble() * k0 % 25;
                    B[i] += (j * (k0 * (k1 + k2)) * random.NextDouble()) % 25;
                }
            }

            for (int i = 0; i < N; i++)
                B[i] = (B[i] + random.Next()) % 25;
        }
        
        public string GetSLAEString()
        {
            return GetSLAEString(Matrix, B);
        }

        public static string GetSLAEString(double[][] values, double[] b)
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values[0].Length; j++)
                    stringBuilder.Append($"{ values[i][j] } ");

                stringBuilder.Append($"{b[i]}\r\n");
            }

            return stringBuilder.ToString();
        }
    }
}
