using System;
using System.Collections.Generic;

// Write a method that prints a dictionary by ordered keys.

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> keys = new SortedList<string, string>(myDict);

        foreach (KeyValuePair<string, string> i in keys)
        {
            Console.WriteLine("{0}: {1}", i.Key, i.Value);
        }
    }
}
