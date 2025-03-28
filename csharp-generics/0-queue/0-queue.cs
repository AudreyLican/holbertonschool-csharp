﻿using System;

/// <summary>
/// A generic queue class that give the type of T
/// </summary>
/// <typeparam name="T">the type of element in the queue</typeparam>
public class Queue<T> // Generic class
{
    /// <summary>
    /// return the type of the element stored in queue
    /// </summary>
    /// <returns>the type of the element in queue</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
