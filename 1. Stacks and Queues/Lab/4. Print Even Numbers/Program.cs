﻿int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> queue = new Queue<int>(input);

int count = queue.Count();

for (int i = 0; i < count; i++)
{
    if (queue.Peek() % 2 == 1)
    {
        queue.Dequeue();
    }
    else
    {
        queue.Enqueue(queue.Dequeue());
    }

}
Console.WriteLine(string.Join(", ", queue));
