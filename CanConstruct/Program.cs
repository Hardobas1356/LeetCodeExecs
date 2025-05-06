Console.WriteLine(Solution.CanConstruct("aa","aab"));

public static class Solution
{

    public static bool CanConstruct(string ransomNote, string magazine)
    {
        if (ransomNote.Length > magazine.Length) return false;

        Dictionary<char, int> magazineMap =
            new Dictionary<char, int>();

        foreach (char item in magazine)
        {
            if (!magazineMap.ContainsKey(item))
            {
                magazineMap.Add(item, 1);
                continue;
            }

            magazineMap[item]++;
        }

        foreach (char item in ransomNote)
        {
            if (!magazineMap.ContainsKey(item))
            {
                return false;
            }

            magazineMap[item]--;

            if (magazineMap[item] < 0)
            {
                return false;
            }    
        }

        return true;
    }
}