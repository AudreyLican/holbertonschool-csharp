using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return "None";

        string highestScore = "";
        int biggestInt = 0;

        foreach (KeyValuePair<string, int> i in myList)
        {
            if (i.Value >= biggestInt)
            {
                biggestInt = i.Value;
                highestScore = i.Key;
            }
        }

        return highestScore;
    }
}
