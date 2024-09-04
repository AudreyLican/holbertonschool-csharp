using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// check is derivedType is a subclass of baseType
    /// </summary>
    /// <param name="derivedType">element to check</param>
    /// <param name="baseType">class to identify</param>
    /// <returns>True if object is a subclass of baseType, and False if not</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
