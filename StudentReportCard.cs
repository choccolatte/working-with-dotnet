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

// a loop for subjects/array of marks
// looping through marks array
for (int i = 0; i <= marks.Length; i++)
{
	string gradeStd = GetGradeNew1(marks[i]);
	Console.WriteLine($"Student's marks: {marks[i]}, Student's grde: {gradeStd}");
}

Console.WriteLine("Finished grading!");

// another loop to count how many A/B/C/D grades there

