
MinStack obj = new MinStack();
obj.Push(3);
obj.Pop();
int param_3 = obj.Top();
int param_4 = obj.GetMin();

public class MinStack
{
    Stack<(int val, int minVal)> stack;
    int min = int.MaxValue;
    public MinStack()
    {
        stack = new Stack<(int, int)>();
    }

    public void Push(int val)
    {
        if (val < min)
        {
            min = val;
        }
        stack.Push((val,min));
    }

    public void Pop()
    {
        stack.Pop();
        if (stack.Count>0)
        {
            min = stack.Peek().minVal;
        }
        else
        {
            min = int.MaxValue;
        }
    }

    public int Top()
    {
        return stack.Peek().val;
    }

    public int GetMin()
    {
        return min;
    }
}

