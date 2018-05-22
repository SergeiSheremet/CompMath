using System;
using System.Collections.Generic;

namespace CompMathLab1
{
	static class EquationsSystemSolver
    {
        public static double[] GaussMethod(double[][] matrix)
        {
            if (matrix.Length == 0) throw new Exception();

            foreach (var i in matrix)
            {
                if (i.Length != matrix.Length + 1) throw new Exception();
            }

            double[][] newMatrix = (double[][])matrix.Clone();

            ReductionToDiagonal(newMatrix);

            double[] solution = new double[newMatrix.Length];

            for (int i = 0; i < newMatrix.Length; i++)
            {
                solution[i] = newMatrix[i][newMatrix[i].Length - 1];
            }

            return solution;
        }

        public static void ReductionToDiagonal(double[][] matrix)
        {
            for (int i = 0; i < matrix[0].Length - 2; i++)
            {
                for (int j = i + 1; j < matrix.Length; j++)
                {
                    double coeff = matrix[j][i] / matrix[i][i];

                    for (int k = i; k < matrix[0].Length; k++)
                    {
                        matrix[j][k] -= matrix[i][k] * coeff;
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                double coeff = matrix[i][i];

                for (int j = 0; j < matrix[0].Length; j++)
                {
                    matrix[i][j] /= coeff;
                }
            }

            for (int i = matrix[0].Length - 2; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    double coeff = matrix[j][i];

                    for (int k = i; k < matrix[0].Length; k++)
                    {
                        matrix[j][k] -= matrix[i][k] * coeff;
                    }
                }
            }

        }

        private class ListComparer<T> : IComparer<T> where T : IList<IComparable>
        {
            int IComparer<T>.Compare(T x, T y)
            {
                if (x != null)
                {
                    if (x.Count > 0)
                    {
                        return (y?.Count > 0) ? x[0].CompareTo(y[0]) : 1;
                    }

                    return (y == null) ? 1 : x.Count.CompareTo(y.Count);
                }

                return (y == null) ? 0 : -1;
            }
        }
    }
}