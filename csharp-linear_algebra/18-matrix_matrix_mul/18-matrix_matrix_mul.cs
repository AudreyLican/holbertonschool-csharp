using System;
/// <summary>
/// class matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method that multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Check if the number of columns of matrix1 is equal to the number of rows of matrix2
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
            return new double[,] { { -1 } };

        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Resulting matrix will have the number of rows from matrix1 and the number of columns from matrix2
        double[,] result = new double[rows1, cols2];

        for (int i = 0; i < rows1; i++)
            for (int j = 0; j < cols2; j++)
                // Calculate dot product of the i-th row of matrix1 and the j-th column of matrix2
                for (int k = 0; k < cols1; k++)
                    result[i, j] += matrix1[i, k] * matrix2[k, j];

        return result;
    }
}
