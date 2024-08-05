using System;
using System.Collections.Generic;

// Write a method that prints a dictionary by ordered keys.

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keys = new List<string>(myDict.keys)
        //SortedList<string, string> keys = new SortedList<string, string>(myDict);
        keys.Sort();

        foreach (string ikey in keys)
        {
            Console.WriteLine("{0}: {1}", ikey, myDict[key]);
        }
    }
}
