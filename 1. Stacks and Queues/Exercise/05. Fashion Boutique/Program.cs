Stack<int> delivery = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

int capacity = int.Parse(Console.ReadLine());
int usedRacks = 0;
int currentRackCapacity = capacity;

if (delivery.Any())
{
    usedRacks++;
}

while (delivery.Any())
{
	if (delivery.Peek() <= currentRackCapacity)
	{
		currentRackCapacity -= delivery.Pop();
	}

    else
    {
        usedRacks++;
        currentRackCapacity = capacity;
    }
}

Console.WriteLine(usedRacks);