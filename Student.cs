using System.Diagnostics;
using System.Runtime.CompilerServices;

class Student
{
	public int Id { get ; }

	public string Name { get; }
	public int Marks{ get; }
	public Grade Grade{ get; }
	public bool IsPassed{ get; }

	public Student(int id, string name, int marks)
	{
		// protecting student from negative or wrong markings.
		if(marks < 0 || marks > 100)
		{
			throw new ArgumentException("Marks must be between 0 and 100.");
		}

		Id = id;
		Name = name;
		Marks = marks;
		Grade = GradeCalculator.GetGrade(marks);
		IsPassed = marks >= 40;
	}
}

// here it says, a student has an ID, a name, a marks, a grade and pass/fail status.

// creating a new student obj
// var student = new Student(1, "John", 78);

// Console.WriteLine(student.Name);
// Console.WriteLine(student.Marks);
// Console.WriteLine(student.Id);
// Console.WriteLine(student.Grade);
// Console.WriteLine(student.IsPassed);