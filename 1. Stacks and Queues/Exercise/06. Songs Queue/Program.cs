string[] initalSongs = Console.ReadLine().Split(", ").ToArray();

Queue<string> songs = new Queue<string>(initalSongs);

while (songs.Any())
{
    string[] input = Console.ReadLine().Split(' ').ToArray();

	if (input[0] == "Play")
	{
		songs.Dequeue();
	}

	else if (input[0] == "Show")
	{
        Console.WriteLine(string.Join(", ", songs));
    }

	else if (input[0] == "Add")
	{
		string songName = string.Join(' ', input.Skip(1));

		if (songs.Contains(songName))
		{
            Console.WriteLine($"{songName} is already contained!");
        }

		else
		{
			songs.Enqueue(songName);
        }
	}
}

Console.WriteLine("No more songs!");