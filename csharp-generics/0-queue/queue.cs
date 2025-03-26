using System;

/// <summary>
/// A generic queue class that provides the type of T
/// This class does not inherit from any collections or interfaces.
/// </summary>
/// <typeparam name="T">the type of element in the queue</typeparam>
public class Queue<T> // Generic class
{
    /// <summary>Returns the type of elements stored in the queue as a string</summary>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
