int size = int.Parse(Console.ReadLine());
int sumD1 = 0;
int sumD2  = 0;

int[,] matrix = new int[size, size];

for (int row = 0; row < size; row++)
{
    int[] newRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

	for (int col = 0; col < size; col++)
	{
		matrix[row, col] = newRow[col];

		if (row == col)
		{
			sumD1 += matrix[row, col];
		}
    }
}

for (int row = 0; row < size; row++)
{
    sumD2 += matrix[row, size - 1 - row];
}

Console.WriteLine(Math.Abs(sumD1 - sumD2));