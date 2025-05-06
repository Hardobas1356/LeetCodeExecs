Console.WriteLine(Solution.MajorityElement([3, 2, 3]));

public static class Solution
{
    public static int MajorityElement(int[] nums)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!count.ContainsKey(num))
            {
                count.Add(num, 1);
                continue;
            }

            count[num]++;
        }

        return count.MaxBy(c => c.Value).Key;
    }

    public static int MajorityElementAlt(int[] nums)
    {
        int result = 0;
        int count = 0;

        foreach (int num in nums.OrderBy(n => n))
        {
            if (count == 0)
            {
                result = num;
                count++;
                continue;
            }

            if (num == result)
            {
                count++;
                continue;
            }

            count--;
        }

        return result;
    }
}