using System;
/// <summary>
/// class Matrix Math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method that adds two matrices and returns the resulting matrix
    /// </summary>
    /// <param name="matrix1"></param>
    /// <param name="matrix2"></param>
    /// <returns></returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Check if both matrices are 2D or 3D and if dimensions match
        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1) ||
            (matrix1.GetLength(0) != 2 && matrix1.GetLength(0) != 3) || (matrix2.GetLength(0) != 2 && matrix2.GetLength(0) != 3))
            return new double[,] { { -1 } };

        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);

        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = matrix1[i, j] + matrix2[i, j];

        return result;
    }
}
