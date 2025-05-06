using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

IList<IList<string>> test = Solution.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
foreach (IList<string> list in test)
{
    Console.WriteLine(String.Join(' ',list));
}

public static class Solution
{
    public static IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            string? sortedStr = String.Join(string.Empty, str.ToCharArray().OrderBy(c => c));

            if (!anagrams.ContainsKey(sortedStr))
            {
                anagrams.Add(sortedStr, new List<string>() { str });
                continue;
            }

            anagrams[sortedStr].Add(str);
        }

        List<IList<string>> result = new List<IList<string>>();
        foreach (KeyValuePair<string, List<string>> list in anagrams)
        {
            result.Add(list.Value);
        }

        return result;
    }
}