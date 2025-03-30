using System;
/// <summary> Class : Base. </summary>
public abstract class Base
{
    /// <summary> Name of the object. </summary>
    public string name{get; set; };

    /// <summary> Override string </summary>
    /// <returns>formatted string </returns>
    public override string ToString()
    {
        return $"{name} is a {GetType()}";
    }
}
