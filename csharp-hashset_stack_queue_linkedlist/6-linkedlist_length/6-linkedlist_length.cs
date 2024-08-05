using System;
using System.Collections.Generic;
class LList
{
    // Main - entry point
    public static int Length(LinkedList<int> myLList)
    {
        int lenList = 0;
        foreach (int i in myLList)
            lenList += 1;

        return lenList;
    }
}
