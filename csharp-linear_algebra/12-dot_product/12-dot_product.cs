using System;
/// <summary>
/// class Vector math
/// </summary>
class VectorMath
{
    /// <summary>
    /// calculate dot product of either tw0 2D or two 3D vectors.
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns></returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        // checking if vector is 2D or 3D
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3
        || vector2.Length < 2 || vector2.Length > 3)
            return -1;

        double result = 0;

        for (int i = 0; i < vector1.Length; i++)
            result[i] += vector1[i] * vector2[i];

        return result;
    }
}
