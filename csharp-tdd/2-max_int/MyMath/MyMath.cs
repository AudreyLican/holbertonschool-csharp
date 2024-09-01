using System;

namespace MyMath
{
    /// <summary>
    /// method that return the max integer in a list of integers.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// compare a list of intergers
        /// </summary>
        /// <param name="nums">List of itegers</param>
        /// <returns>the hightest numbers</returns>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count <= 0)
                return (0);

            int isMax= nums[0];

            foreach (int nbr in nums)
                if (nbr > isMax)
                    isMax = nbr;

            return (isMax);
        }
    }
}
