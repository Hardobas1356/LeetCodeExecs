public static class Solution
{
    public static int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();

        foreach (var operation in tokens)
        {
            switch (operation)
            {
                case "+":
                    int a = stack.Pop();
                    int b = stack.Pop();
                    stack.Push(a + b);
                    break;
                case "-":
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b - a);
                    break;
                case "*":
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(a * b);
                    break;
                case "/":
                    a = stack.Pop();
                    b = stack.Pop();
                    stack.Push(b / a);
                    break;
                default:
                    stack.Push(int.Parse(operation));
                    break;
            }
        }

        return stack.Pop();
    }
}