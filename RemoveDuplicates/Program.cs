namespace RemoveDuplicates;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.RemoveDuplicates([1, 2]));
    }

    public static class Solution
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;

            int leftPointer = 0;
            int rightPointer = 0;
            int count = 1;

            while (rightPointer < nums.Length - 1 && leftPointer < nums.Length)
            {
                while (rightPointer < nums.Length - 1 && nums[leftPointer] == nums[rightPointer])
                {
                    rightPointer++;
                }

                nums[++leftPointer] = nums[rightPointer];

                if (nums[leftPointer - 1] != nums[leftPointer])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
