Console.WriteLine(String.Join(" ", Solution.TwoSum([2, 7, 11, 15], 9)));

public static class Solution
{
    public static int[] TwoSum(int[] numbers, int target)
    {
        int left = 0;
        int right = numbers.Length - 1;

        while (left<right)
        {
            int tempSum = numbers[left] + numbers[right];

            if (tempSum == target)
            {
                break;
            }

            if (tempSum > target)
            {
                right--;
            }

            if (tempSum < target)
            {
                left++;
            }
        }

        return [left+1, right+1];
    }
}