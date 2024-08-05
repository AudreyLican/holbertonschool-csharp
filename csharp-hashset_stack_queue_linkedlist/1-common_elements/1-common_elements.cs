using System;
using System.Collections.Generic;

/*
    Write a method that returns a sorted list of common elements in two lists.
    return a new sorted list of common elements in two given lists
*/
class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> commonEl = new List<int>();

        foreach (int element in list1)
        {
            if (list2.Contains(element) && !commonEl.Contains(element))
                commonEl.Add(element);
        }

        return commonEl;
    }
}