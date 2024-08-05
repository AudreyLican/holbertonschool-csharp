using System;
using System.Collections.Generic;

/*
    Write a method that returns a sorted list of all elements present in one or the other list but not both.
    Returns a new sorted list of all elements present in one or the other list but not both of the given lists
*/
class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> newlist1 = new List<int>();
        List<int> newlist2 = new List<int>();

        // find unique element in list 1
        foreach (int element in list1)
        {
            if (!list2.Contains(element))
                newlist1.Add(element);
        }

        // find unique elment in list 2
        foreach (int element in list2)
        {
            if (!list1.Contains(element))
                newlist2.Add(element);
        }

        // combine list 1 & 2
        List<int> diffEl = new List<int>();
        diffEl.AddRange(newlist1);
        diffEl.AddRange(newlist2);

        //sort the combined list
        diffEl.Sort();

        return diffEl;
    }
}