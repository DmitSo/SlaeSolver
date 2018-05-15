using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SlaeSolver
{
    public static class SlaeIO
    {
        static Encoding encoding = Encoding.UTF8;

        public static Slae Read(Stream stream)
        {
            // warn: big files may not be read?
            byte[] data = new byte[(int)stream.Length];
            stream.Read(data, 0, (int)stream.Length);
            return ParseSlaeString(encoding.GetString(data));
        }

        /// <summary>
        /// Parsing input string to SLAE
        /// </summary>
        /// <param name="slaeString">String which contains elements of slae</param>
        private static Slae ParseSlaeString(string slaeString)
        {
            System.Text.RegularExpressions.Regex rowSplitter = new
                System.Text.RegularExpressions.Regex(@"\r?\n");// \\d+\\.?\\d?\\s

            var rows = rowSplitter.Split(slaeString).Where(r => r.Length != 0).ToList();
            double[][] Matrix = new double[rows.Count][];
            double[] B = new double[rows.Count];

            for (int i = 0; i < rows.Count; i++)
            {
                string[] elements = rows[i].Split(' ');
                if (rows.Count + 1 == elements.Length)
                {
                    List<double> readValues = new List<double>();
                    for (int j = 0; j < elements.Length - 1; j++)
                        readValues.Add(Double.Parse(elements[j]));

                    var b = Double.Parse(elements[elements.Length - 1]);
                    Matrix[i] = readValues.ToArray();
                    B[i] = b;
                }
                else
                    throw new ArgumentException();
            }

            return new Slae(Matrix, B);
        }

        public static void Write(Slae slae, Stream stream)
        {
            Write(slae.GetSLAEString(), stream);
        }

        public static void Write(double[][] matrix, double[] b, Stream stream)
        {
            Write(Slae.GetSLAEString(matrix, b), stream);
        }

        public static void Write(double[] decisions, Stream stream)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var d in decisions)
                sb.Append($"{d} ");
            Write(sb.ToString(), stream);
        }

        private static void Write(string str, Stream stream)
        {
            var bytes = encoding.GetBytes(str);
            stream.Write(bytes, 0, bytes.Length);
        }
    }
}
