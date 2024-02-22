Queue<string> children = new Queue<string>(Console.ReadLine().Split());
int n = int.Parse(Console.ReadLine());
int tosses = 1;

while (children.Count != 1)
{
    string childWithHotPotato = children.Dequeue();
	if (tosses == n)
	{
        Console.WriteLine($"Removed {childWithHotPotato}");
		tosses = 0;
    }
	else
	{
		children.Enqueue(childWithHotPotato);
	}

	tosses++;
}

Console.WriteLine($"Last is {children.Dequeue()}");