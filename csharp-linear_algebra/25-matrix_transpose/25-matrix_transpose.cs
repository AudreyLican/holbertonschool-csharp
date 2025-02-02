using System;
/// <summary>
/// class matrix math
/// </summary>
class MatrixMath
{
    /// <summary>
    /// method to transpose a matrix and return the resulting matrix.
    /// </summary>
    /// <param name="matrix"></param>
    /// <returns></returns>
    public static double[,] Transpose(double[,] matrix)
    {
        // Check if the matrix is empty
        if (matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
            return new double[0, 0]; // Return an empty matrix if the original matrix is empty

        // Get the dimensions of the original matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Create a new matrix for the transposed result
        double[,] transposedMatrix = new double[cols, rows];

        // Loop through the original matrix and transpose it
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
            {
                // Transpose the element
                transposedMatrix[j, i] = matrix[i, j];
            }

        return transposedMatrix;
    }
}
