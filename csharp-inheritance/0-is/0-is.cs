using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// Check if number is a int
    /// </summary>
    /// <param name="obj">Element to check</param>
    /// <returns>True if int or false if not</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
