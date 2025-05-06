using System.Numerics;

Console.WriteLine(Solution.IsAnagram("ggii", "eekk"));

public static class Solution
{
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> map =
            new Dictionary<char, int>();

        foreach (char item in s)
        {
            if (!map.ContainsKey(item))
            {
                map.Add(item, 1);
                continue;
            }

            map[item]++;
        }

        foreach (char item in t)
        {
            if (!map.ContainsKey(item)) return false;
            map[item]--;

            if (map[item] < 0) return false;
        }

        return true;
    }

}