class StudentProcessor
{
	public List<StudentProcessor> Students { get;}

	public StudentProcessor(List<int> marks)
	{
		Students = marks.Select(m => new StudentProcessor(m)).ToList();
	}

	public Dictionary<Grade, int> GetGradeSummary()
	{
		return Students.GroupBy(s => s.Grade).ToDictionary(g => g.Key, g => g.Count());
	}

	public int TotalStudents() => Students.Count;

	public int PassedCount() => Students.Count( s =>s.IsPassed);

	public int FailedCount() => Students.Count(s => IsPassed);

	public double AverageMarks() => Students.Average( s => s.Marks);
}