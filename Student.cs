using System.Runtime.CompilerServices;

class Student
{
	public int Marks{ get; }
	public Grade Grade{ get; }
	public bool IsPassed{ get; }

	public Student(int marks)
	{
		Marks = marks;
		Grade = GradeCalculator.GetGrade(marks);
		IsPassed = marks >= 40;
	}
}