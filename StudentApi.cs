namespace StudentApi.Models;

public class Student
{
	public int Id{ get; }
	public string Name{ get; }
	public int Marks{ get; }
	public Grade Grade{ get; }
	public bool IsPassed{ get; }

	public Student(int id, string name, int marks)
	{
		Id = id;
		Name = name;
		Marks = marks;
		Grade = GradeCalculator.GetGrade(marks);
		IsPassed = marks >= 40;
	}
}