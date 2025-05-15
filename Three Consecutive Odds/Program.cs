namespace Three_Consecutive_Odds;

internal class Program
{
    static void Main(string[] args)
    {
    }

    public class Solution
    {
        public bool ThreeConsecutiveOdds(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    count++;
                }
                else count = 0;

                if (count == 3)
                    return true;
            }

            return false;
        }
    }
}
