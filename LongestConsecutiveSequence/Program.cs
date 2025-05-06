using System;

public static class Solution
{
    public static int LongestConsecutive(int[] nums)
    {
        HashSet<int> set = nums.ToHashSet();
        int count = 0;

        foreach (int num in set)
        {
            if (set.Contains(num - 1)) continue;

            int length = 0;
            while (set.Contains(num + length)) length++;

            count = Math.Max(count, length);
        }

        return count;
    }
}