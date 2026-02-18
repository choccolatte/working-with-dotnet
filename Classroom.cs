using System.Runtime.CompilerServices;

public class Classroom
{
	private readonly List<Studeent> student;
	public List<Student> students;

	public Classroom(List<Student> students)
	{
		this.students = students;
	}

	public double AvgMarks()
	{
		students.Average(s => s.Marks);
	}

	public Student Topper()
	{
		students.OrderByDescending(s => s.Marks).First();
	}

	public Dictionary<Grade, int> GradeSummary()
	{
		students.
		GroupBy(s => s.Grade)
		.ToDictionary(g => g.Key, g => g.Count());
	}
}