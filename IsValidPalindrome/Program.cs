Console.WriteLine(Solution.IsPalindrome(" "));

public static class Solution
{
    public static bool IsPalindrome(string s)
    {
        char[] arr = s.ToLower().ToCharArray().Where(c => Char.IsAsciiLetterOrDigit(c)).ToArray();

        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            if (arr[left] != arr[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}