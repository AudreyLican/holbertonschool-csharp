using System;
/// <summary>
/// class Matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    ///  method that multiplies a matrix and a scalar and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <param name="scalar"></param>
    /// <returns></returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        //check if matrix is 2D or 3D
        if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
            return new double[,] { {-1}};

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Create a new matrix to store the result of multiplicatio
        double[,] result = new double[rows, cols];

        // Multiply each element of the matrix by the scalar
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = matrix[i, j] * scalar;

        return result;
    }
}