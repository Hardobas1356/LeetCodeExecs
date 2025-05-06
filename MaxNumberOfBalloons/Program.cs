Console.WriteLine(Solution.MaxNumberOfBalloonsAlt("loonbalxballpoon"));

public static class Solution
{
    public static int MaxNumberOfBalloons(string text)
    {
        if (text.Length < 7) return 0;

        Dictionary<char, int> map = new Dictionary<char, int>()
        {
            {'b',0 },
            {'a',0 },
            {'l',0 },
            {'o',0 },
            {'n',0 },
        };

        foreach (char item in text)
        {
            if (map.ContainsKey(item))
            {
                map[item]++;
            }
        }

        map['l'] /= 2;
        map['o'] /= 2;

        return map.Min(c=>c.Value);
    }

    public static int MaxNumberOfBalloonsAlt(string text)
    {
        if (text.Length < 7) return 0;

        short[] balon = new short[5];

        foreach (char item in text)
        {
            switch (item)
            {
                case 'b':
                    balon[0]++;
                    break;
                case 'a':
                    balon[1]++;
                    break;
                case 'l':
                    balon[2]++;
                    break;
                case 'o':
                    balon[3]++;
                    break;
                case 'n':
                    balon[4]++;
                    break;
                default:
                    break;
            }
        }

        balon[2] /= 2;
        balon[3] /= 2;

        return balon.Min();
    }
}
