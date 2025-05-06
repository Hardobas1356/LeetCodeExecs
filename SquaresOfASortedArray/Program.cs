Console.WriteLine(String.Join(' ', Solution.SortedSquares([-7, -3, 2, 3, 11])));

public static class Solution
{
    public static int[] SortedSquares(int[] nums)
    {
        int count = nums.Length - 1;
        int leftPointer = 0;
        int rightPointer = nums.Length - 1;
        int[] answer = new int[nums.Length];

        while (leftPointer <= rightPointer)
        {
            int leftNum = (int)Math.Pow(nums[leftPointer], 2);
            int rightNum = (int)Math.Pow(nums[rightPointer], 2);

            if (leftNum > rightNum)
            {
                answer[count--] = leftNum;
                leftPointer++;
            }
            else
            {
                answer[count--] = rightNum;
                rightPointer--;
            }
        }

        return answer;
    }
}