namespace Finding_3_Digit_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(' ', Solution.FindEvenNumbersAlt([2, 2, 8, 8, 2])));
        }
    }

    public static class Solution
    {
        public static int[] FindEvenNumbers(int[] digits)
        {
            HashSet<int> result = new HashSet<int>();
            Array.Sort(digits);

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] == 0)
                    continue;

                for (int j = 0; j < digits.Length; j++)
                {
                    if (i == j) continue;

                    for (int k = 0; k < digits.Length; k++)
                    {
                        if (k == j || k == i) continue;

                        if (digits[k] % 2 == 0)
                        {
                            result.Add(digits[i] * 100 + digits[j] * 10 + digits[k]);
                        }
                    }
                }
            }

            return result.ToArray();
        }

        public static int[] FindEvenNumbersAlt(int[] digits)
        {
            HashSet<int> result = new HashSet<int>();
            Dictionary<int, int> digitsMap = new Dictionary<int, int>();

            for (int i = 0; i < digits.Length; i++)
            {
                if (!digitsMap.ContainsKey(digits[i]))
                {
                    digitsMap.Add(digits[i], 1);
                }
                else
                {
                    digitsMap[digits[i]]++;
                }
            }

            for (int i = 100; i < (digits.Max()+1)*100; i += 2)
            {
                Dictionary<int, int> tempMap = digitsMap.ToDictionary();
                int n1 = i / 100;
                int n2 = (i % 100) / 10;
                int n3 = i % 10;

                if (tempMap.ContainsKey(n1))
                    tempMap[n1]--;
                else continue;

                if (tempMap.ContainsKey(n2)) tempMap[n2]--;
                else continue;

                if (tempMap.ContainsKey(n3)) tempMap[n3]--;
                else continue;

                if (tempMap[n1] >= 0 && tempMap[n2] >= 0 && tempMap[n3] >= 0)
                {
                    result.Add(n1 * 100 + n2 * 10 + n3);
                }
            }

            return result.ToArray();
        }
    }
}
