// a method to find out Grade
// student grade report
int[] marks = {100, 23, 34, 56, 23, 86, 76, 54, 43, 98, 87, 98, 100};

static string GetGradeNew1(int marks)
{
	if(marks >= 90) return "A+";
	else if(marks >= 85) return "A";
	else if(marks >= 65) return "B";
	else if(marks >= 55) return "C";
	else if(marks >= 40) return "D";
	else return "F";
}

int stdNo = 0;
int passMarks = 40;
int stdPassed = 0;

// a loop for subjects/array of marks
// looping through marks array
for (int i = 0; i < marks.Length; i++)
{
	string gradeStd = GetGradeNew1(marks[i]);
	Console.WriteLine($"Student's marks: {marks[i]}, Student's grade: {gradeStd}");

	// adding to students
	stdNo++;

	// no. of stuents passed
	if(marks > passMarks)
	{
		stdPassed++;		
	}
}

Console.WriteLine("Finished grading!");

// counting students
Console.WriteLine($"No. of students: {stdNo}");

// another loop to count how many A/B/C/D grades there

// counting how many passed
Console.WriteLine($"No. of Students passed: {stdPassed}");
