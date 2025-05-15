using System.Text;

namespace Total_Characters_in_String_After_Transformations_I;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.LengthAfterTransformations("abcyy", 2));
    }

    public static class Solution
    {
        private const int MOD = 1000000007;

        public static int LengthAfterTransformations(string s, int t)
        {
            long[] freq = new long[26];

            foreach (char ch in s)
            {
                freq[ch - 'a']++;
            }

            for (int step = 0; step < t; step++)
            {
                long[] nextFreq = new long[26];

                for (int i = 0; i < 25; i++)
                {
                    nextFreq[i + 1] = (nextFreq[i + 1] + freq[i]) % MOD;
                }

                nextFreq[0] = (nextFreq[0] + freq[25]) % MOD;
                nextFreq[1] = (nextFreq[1] + freq[25]) % MOD;

                freq = nextFreq;
            }

            long totalLength = 0;
            foreach (long count in freq)
            {
                totalLength = (totalLength + count) % MOD;
            }

            return (int)totalLength;
        }
    }
}
