namespace _02._Average_Student_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] grades = Console.ReadLine().Split();

                if (!students.ContainsKey(grades[0]))
                {
                    students[grades[0]] = new List<decimal>();
                }
                students[grades[0]].Add(decimal.Parse(grades[1]));
            }

            foreach (var student in students)
            {
                string grades = string.Join(", ", student.Value);
                Console.Write($"{student.Key} -> ");
                Console.Write(string.Join(" ", student.Value.Select(x => $"{x:f2}")) + " ");
                Console.WriteLine($"(avg: {student.Value.Average():f2})");
            }
        }
    }
}
