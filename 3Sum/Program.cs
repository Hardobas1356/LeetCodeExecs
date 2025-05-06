using System.Collections.Generic;

int[] test = [0, 0, 0];

IList<IList<int>> result = Solution.ThreeSum(test);
foreach (IList<int> List in result)
{
    Console.WriteLine(String.Join(' ', List));
}

public static class Solution
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1;
            int right = nums.Length - 1;
            int target = -1 * nums[i];

            while (left < right)
            {
                int leftNum = nums[left];
                int rightNum = nums[right];

                if (leftNum + rightNum == target)
                {
                    List<int> answer = [-1 * target, leftNum, rightNum];
                    result.Add(answer);

                    while (left < right && leftNum == nums[left])
                    {
                        ++left;
                    }
                    while (left < right && rightNum == nums[right])
                    {
                        --right;
                    }
                }
                else if (leftNum + rightNum < target)
                {
                    left++;
                }
                else if (leftNum + rightNum > target)
                {
                    right--;
                }
            }

        }

        return result;
    }
}