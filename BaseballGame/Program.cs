using System.Security.Cryptography.X509Certificates;

Console.WriteLine(Solution.CalPoints(["5", "2", "C", "D", "+"]));

public static class Solution
{
    public static int CalPoints(string[] operations)
    {
        Stack<string> stack = new Stack<string>();

        foreach (string operation in operations)
        {
            switch (operation)
            {
                case "D":
                    stack
                    .Push((2 * int
                         .Parse(stack
                            .Peek()))
                         .ToString());
                    break;

                case "C":
                    stack.TryPop(out string? t);
                    break;

                case "+":
                    int newValue = int.Parse(stack.Pop());
                    int temp = int.Parse(stack.Peek());

                    stack.Push(newValue.ToString());

                    newValue += temp;
                    stack.Push(newValue.ToString());
                    break;

                default:
                    stack.Push(operation);
                    break;
            }
        }

        int sum = 0;
        foreach (var item in stack)
        {
            sum += int.Parse(item);
        }

        return sum;
    }
}