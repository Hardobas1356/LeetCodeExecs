namespace Minimum_Equal_Sum_of_Two_Arrays_After_Replacing_Zeros;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.MinSum([12, 14, 25, 12, 3], [3, 26, 0, 21, 22]));
    }
    public static class Solution
    {
        public static long MinSum(int[] nums1, int[] nums2)
        {
            int sum1 = 0;
            int sum2 = 0;
            int zero1Count = 0;
            int zero2Count = 0;

            foreach (int num in nums1)
            {
                if (num != 0)
                {
                    sum1 += num;
                }
                else
                {
                    zero1Count++;
                }
            }

            foreach (int num in nums2)
            {
                if (num != 0)
                {
                    sum2 += num;
                }
                else
                {
                    zero2Count++;
                }
            }

            int minSum1 = sum1 + zero1Count;
            int minSum2 = sum2 + zero2Count;

            if (zero1Count == 0 && minSum1 < minSum2) return -1;
            if (zero2Count == 0 && minSum2 < minSum1) return -1;

            int target = Math.Max(minSum1, minSum2);

            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums1[i] == 0)
                {
                    if (zero1Count > 1)
                    {
                        nums1[i] = 1;
                        sum1++;
                    }
                    else
                    {
                        nums1[i] = target-sum1;
                        sum1 += nums1[i];
                    }
                    zero1Count--;
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums2[i] == 0)
                {
                    if (zero2Count > 1)
                    {
                        nums2[i] = 1;
                        sum2++;
                    }
                    else
                    {
                        nums2[i] = target - sum2;
                        sum2 += nums2[i];
                    }
                    zero2Count--;
                }
            }

            return target;
        }
    }
}
