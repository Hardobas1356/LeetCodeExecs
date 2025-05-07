using System.Linq;

Console.WriteLine(String.Join(' ', Solution.DailyTemperatures([75, 71, 69, 72, 76])));

public static class Solution
{
    public static int[] DailyTemperatures(int[] temperatures)
    {
        Stack<int> indices = new Stack<int>();
        int[] result = new int[temperatures.Length];

        for (int i = 0; i < temperatures.Length; i++)
        {
            while (indices.Count != 0 && temperatures[i] > temperatures[indices.Peek()])
            {
                int index = indices.Pop();
                result[index] = i - index;
            }
            indices.Push(i);
        }

        return result;
    }
}