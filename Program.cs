using System;

class Program 
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(123);
        stack.Push(456);
        stack.Push(13453);
        stack.Push(0);

        int[] MyStackData = new int[stack.Count];
        stack.CopyTo(MyStackData);

        foreach (int i in MyStackData)
        {
            Console.WriteLine(i);
        }
    }
}


class Stack<T>
{
    private List<T> _stack = new List<T>();
    public int Count { get { return _stack.Count; } }
    public void Push(T value)
    {
        _stack.Add(value);
    }

    public T Pop()
    {
        T value = _stack.Last();
        _stack.Remove(_stack.Last());
        return value;
    }

    public void Clear()
    {
        _stack.Clear();
    }

    public T Peek()
    {
        return _stack.Last();
    }
    public T[] CopyTo(T[] array)
    {
        T[] stackArray = _stack.ToArray();
        Array.Reverse(stackArray);

        for (int i = stackArray.Length - 1; i >= 0; i--)
        {
            array[i] = stackArray[i];
        }

        return array;
    }
}