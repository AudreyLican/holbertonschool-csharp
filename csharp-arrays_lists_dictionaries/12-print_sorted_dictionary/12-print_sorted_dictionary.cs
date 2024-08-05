using System;
using System.Collections.Generic;

// Write a method that prints a dictionary by ordered keys.

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        SortedList<string, string> keyS = new SortedList<string, string>(myDict);

        foreach (KeyValuePair<string, string> i in keyS)
        {
            Console.WriteLine("{0}: {1}", i.Key, i.Value);
        }
    }
}
