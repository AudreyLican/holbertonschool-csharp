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

/// <summary>
/// Derived class Rectangle that inherits from Shape.
/// </summary>
class Rectangle: Shape
{
    private int width;
    private int height;

/// <summary> public property Width </summary>
    public int Width
    {
        get {return width;}

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

/// <summary> public property Height </summary>
    public int Height
    {
        get {return height;}

        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }

/// <summary>
/// override the Area() method from Shape class
/// </summary>
    public new int Area()
    {
        return height * width;
    }


/// <summary>
/// override the ToString() method
/// </summary>
    public override string ToString()
    {
        return (string.Format("[Rectangle] {0} / {1}", width, height));
    }
}

/// <summary>
/// Derived class Square that inherits from Rectangle.
/// </summary>
class Square : Rectangle
{
    private int size;

    public int Size
    {
        get {return size;}

        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Height = size;
            Width= size;
        }
    }
}