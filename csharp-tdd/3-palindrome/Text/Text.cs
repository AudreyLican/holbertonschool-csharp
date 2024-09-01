using System;
using System.Text.RegularExpressions;

namespace Text
{
    public class Str
    {
        /// <summary>
        /// method that
        /// </summary>
        /// <param name="s">element to define if its string</param>
        /// <returns>return true if its string</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
                return true;

            string s2 = s.ToLower();
            s2 = Regex.Replace(s2, @"[^a-zA-Z0-9]", "");
            int len = s2.Length;

            for (int i = 0; i < len /2; i++)
            {
                if (s2[i] != s2[len - 1 - i])
                    return false;
            }
            return true;
        }
    }
}

