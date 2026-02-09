class Program
{
	static void Main()
	{
		var marks = FileReader.ReadMarks("marks.txt");
		var processor = new StudentProcessor(marks);

		Console.WriteLine($"Total Students: {processor.TotalStudents()}");
        Console.WriteLine($"Passed: {processor.PassedCount()}");
        Console.WriteLine($"Failed: {processor.FailedCount()}");
        Console.WriteLine($"Average Marks: {processor.AverageMarks()}");
		
		Console.WriteLine("\n-----Grade Summary-----");
		foreach(var kvp in processor.GetGradeSummary())
		{
			Console.WriteLine($"{kvp.Key}: {kvp.Value}");
		}
	}
}