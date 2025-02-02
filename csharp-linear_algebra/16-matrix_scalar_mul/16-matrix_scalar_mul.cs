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
        if ((matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3) || (matrix.GetLength(1) != 2 && matrix.GetLength(1) != 3))
            return new double[,] { {-1}};

        // Create a new matrix to store the result of multiplicatio
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

        // Multiply each element of the matrix by the scalar
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                result[i, j] = matrix[i, j] * scalar;

        return result;
    }
}