using System.Runtime.Intrinsics.Arm;

Console.WriteLine(Solution.MaxArea([1, 2, 4, 3]));

public static class Solution
{
    public static int MaxArea(int[] height)
    {
        int leftPointer = 0;
        int rightPointer = height.Length - 1;
        int maxArea = 0;

        while (leftPointer < rightPointer)
        {
            int currentArea = Math.Min(height[leftPointer], height[rightPointer]) * (rightPointer - leftPointer);

            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            do
            {
                if (height[leftPointer] < height[rightPointer])
                {
                    leftPointer++;
                }
                else
                {
                    rightPointer--;
                }
            }
            while (leftPointer < rightPointer
            && maxArea > Math.Min(height[leftPointer], height[rightPointer]) * (rightPointer - leftPointer));
        }

        return maxArea;
    }
}