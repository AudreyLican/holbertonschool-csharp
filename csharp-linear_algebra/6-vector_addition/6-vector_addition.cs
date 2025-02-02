using system;

/// <summary>
/// Class method vector math
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds 2 vectors and return the resulting vector
    /// </summary>
    /// <param name="vector1"></param>
    /// <param name="vector2"></param>
    /// <returns>resulting vector btw vector1 and vector2</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        //verify if vector is 2D or 3D
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3
        || vector2.Length < 2 || vector2.Length > 3)
        {
            return new double[] { -1 };
        }

        double[] result = new double[vector1.Length];

        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}
