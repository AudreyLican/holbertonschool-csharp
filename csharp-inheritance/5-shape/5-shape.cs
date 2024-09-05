using System;
using System.Collections.Generic;

/// <summary>class Shape</summary>
class Shape
{
    /// <summary>
    /// virtual method Area that throw a NotImplementedException
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}
