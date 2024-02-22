int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int rows = sizes[0];
int cols = sizes[1];
int counter = 0;

string[] previousRow = null;

for (int row = 0; row < rows; row++)
{
    string[] currentRow = Console.ReadLine().Split(' ');

	if (row > 0)
	{
		for (int col = 0; col < cols - 1; col++)
		{
			if (currentRow[col] == previousRow[col] 
				&& previousRow[col + 1] == currentRow[col] 
				&& currentRow[col + 1] == previousRow[col])
			{
				counter++;
			}
		}

	}

    previousRow = currentRow;
}

Console.WriteLine(counter);