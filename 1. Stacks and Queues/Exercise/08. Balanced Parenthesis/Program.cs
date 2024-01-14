char[] sequence = Console.ReadLine().ToCharArray();

if (sequence.Length % 2 != 0)
{
    Console.WriteLine("NO");
    return;
}

Stack<char> stack = new Stack<char>();

foreach (char c in sequence)
{
    if ("{[(".Contains(c))
    {
        stack.Push(c);
    }

    else if (c == ')' && stack.Peek() == '(')
    {
        stack.Pop();
    }

    else if (c == ']' && stack.Peek() == '[')
    {
        stack.Pop();
    }

    else if (c == '}' && stack.Peek() == '{')
    {
        stack.Pop();
    }

}

Console.WriteLine(stack.Any() ? "NO" : "YES");