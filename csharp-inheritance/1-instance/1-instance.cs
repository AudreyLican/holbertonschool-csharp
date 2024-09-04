using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// method that verify if object is instance of type Array
    /// </summary>
    /// <param name="obj">object to check</param>
    /// <returns>True is instance id=f of type Array, or False if not</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
