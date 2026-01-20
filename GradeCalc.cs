// grade calculator
static string GetGrade(int marks)
{
	// ask for student's marks
	// Console.Write("Enter your marks: ");

	// read marks
	// int marks = Console.Readline();

	if(marks >= 90) return "A";
	else if (marks >= 75) return "B";
	else if (marks >= 60) return "C"; 
	else return "D";
}

int[] stdMarks = { 95, 82, 67, 54, 76, 88, 91, 23, 33, 14 };

// string res = GetGrade(marks);
// Console.WriteLine(res);

for (int i = 0; i < stdMarks.Length; i++)
{
	string grade = GetGrade(stdMarks[i]);
	Console.WriteLine($"Std's Marks: {stdMarks[i]}, Std's Grade:{grade}");
}