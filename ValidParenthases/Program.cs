using System.Net.Http.Headers;

public static class Solution
{
    public static bool IsValid(string s)
    {
        Stack<char> leftParenthases = new Stack<char>();

        foreach (char item in s)
        {
            switch (item)
            {
                case '(' or '[' or '{':
                    leftParenthases.Push(item);
                    break;

                case ')':
                    if (leftParenthases.TryPeek(out char p) && p == '(')
                    {
                        leftParenthases.Pop();
                    }
                    else return false;
                    break;

                case '}':
                    if (leftParenthases.TryPeek(out p) && p == '{')
                    {
                        leftParenthases.Pop();
                    }
                    else return false;
                    break;

                case ']':
                    if (leftParenthases.TryPeek(out p) && p == '[')
                    {
                        leftParenthases.Pop();
                    }
                    else return false;
                    break;

                default:
                    break;
            }
        }

        if (leftParenthases.Count == 0)
        {
            return true;
        }
        else return false;
    }
}