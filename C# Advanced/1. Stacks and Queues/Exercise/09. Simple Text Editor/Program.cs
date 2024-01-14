﻿Stack<string> stack = new Stack<string>();

string text = "";
int count = int.Parse(Console.ReadLine());

for (int i = 0; i < count; i++)
{
    string[] input = Console.ReadLine().Split(' ').ToArray();

	if (input[0] == "1")
	{
		stack.Push(text);
		text += input[1];
	}

	else if (input[0] == "2")
	{
		int index = int.Parse(input[1]);
		stack.Push(text);
		text = text.Substring(0, text.Length - index);
	}

	else if (input[0] == "3")
	{
        int index = int.Parse(input[1]);
		Console.WriteLine(text[index - 1]);
    }

	else if (input[0] == "4")
	{
		text = stack.Pop();
	}
}