using System;

/// <summary>
/// A generic queue class that give the type of T
/// </summary>
/// <typeparam name="T">the type of element in the queue</typeparam>
public class Queue<T> // Generic class
{
    /// <summary>return the type of the element stored in queue</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
}
