int foodQuantity = int.Parse(Console.ReadLine());
int[] orders = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Queue<int> queue = new Queue<int>(orders);

if (orders.Any())
{
    Console.WriteLine(queue.Max());
}

while (queue.Any())
{

	if (foodQuantity >= queue.Peek())
	{
		foodQuantity -= queue.Dequeue();
	}
	else
	{
        Console.WriteLine($"Orders left: " + string.Join(' ', queue));
		return;
    }
}

Console.WriteLine("Orders complete");