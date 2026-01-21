using System;

class Program
{
	static void Main()
	{
		int[] marks = {100, 23, 34, 56, 23, 86, 76, 54, 43, 98, 87, 98, 100};
		int passMarks = 40;

		int totalStudents = 0;
		int passedStudents = 0;

		int gradeAPlus = 0;
		int gradeA = 0;
		int gradeB = 0;
		int gradeC = 0;
		int gradeD = 0;
		int gradeF = 0;

		foreach(int mark in marks)
		{
			totalStudents++;

			string grade = GetGrade(mark);
			bool isPassed = IsPassed(mark, passMarks);

			PrintStudentReport(mark, grade);

			if(isPassed) passedStudents++;

			UpdateGradeCount(grade, 
			ref gradeAPlus, ref gradeA, ref gradeB, ref gradeC, ref gradeD, ref gradeF);
		}

		PrintSummary(totalStudents, passedStudents, gradeAPlus, gradeA, gradeB, gradeC, gradeD, gradeF);
	}

	// determines grade
	static string GetGrade(int marks)
	{
		if (marks >= 90) return "A+";
		if (marks >= 85) return "A";
		if (marks >= 75) return "B";
		if (marks >= 60) return "C";
		if (marks >= 45) return "D";
		return "F";
	}

	// checks pass/fail
	static bool IsPassed(int marks, int passMarks)
	{
		return marks >= passMarks;
	}

	// prints individual student result
	static void PrintStudentReport(int marks, string grade)
	{
		Console.WriteLine($"Student's mark: {marks}, Student's grade: {grade}");
	}

	// updates grade counters
	static void UpdateGradeCount(string grade, 
	ref int aPlus, ref int a, ref int b, ref int c, ref int d, ref int f)
	{
		switch(grade)
		{
			case "A+" : aPlus++; break;
			case "A" : a++; break;
			case "B" : b++; break;
			case "C" : c++; break;
			case "D" : d++; break;
			case "F" : f++; break;
		}
	}

	// prints final summary
	static void PrintSummary(
		int total, int passed, int aPlus, int a, int b, int c, int d, int f)
		{
			Console.WriteLine("\n---Summary---");
			Console.WriteLine($"Total Students: {totalStudents}");
			Console.WriteLine($"Passed Students: {passedStudents}");
			Console.WriteLine($"A+: {aPlus}, A: {a}, B: {b}, C: {c}, D: {d}, F: {f}");
		}
}
