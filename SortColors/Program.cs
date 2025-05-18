namespace SortColors;

internal class Program
{
    static void Main(string[] args)
    {
        Solution.SortColors([0, 1, 1, 2, 0, 1, 2]);
    }

    public static class Solution
    {
        public static void SortColors(int[] nums)
        {


            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                    map[num]++;
                else map[num] = 1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                while (map.ContainsKey(0) && map[0] > 0)
                {
                    nums[i++] = 0;
                    map[0]--;
                }
                while (map.ContainsKey(1) && map[1] > 0)
                {
                    nums[i++] = 1;
                    map[1]--;
                }
                while (map.ContainsKey(2) && map[2] > 0)
                {
                    nums[i++] = 2;
                    map[2]--;
                }
            }
        }
    }
}
