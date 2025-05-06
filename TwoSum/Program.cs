public static class Solution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];
            int targetRemainder = target - num;

            if (map.ContainsKey(targetRemainder))
            {
                result = new int[] { map.First(c => c.Key == targetRemainder).Value, i };
                break;
            }

            if (!map.ContainsKey(num))
            {
                map[num] = i;
            }
        }

        return result;
    }
}