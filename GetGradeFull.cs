using System;
using System.Collections.Generic;
class Program
{
	static string GetGrade(int marks)
	{
		if (marks >= 95) return "A+";
		else if (marks >= 85) return "A";
		else if (marks >= 70) return "B";
		else if (marks >= 55) return "C";
		else if (marks >= 40) return "D";
		else return "F";
	}

	// finding total number of student 
	static int TotalStudents(List<int> students)
	{
		return students.Count;
	}

	// pass or fail
	static bool IsPassed(int mark)
	{
		return mark <= 40;
	}

	// pass/fail counter
	static int PassStudents(List<int> marks)
	{
		int passcount = 0;

		foreach(int mark in marks){
			if(mark >= 40) passcount++;		
		}

		return passcount;
	}

	static int FailStudents(List<int> marks)
	{
		int failcount = 0;

		foreach(int mark in marks){
			if(mark < 40) failcount++;			
		}

		return failcount;
	}

	static void Main(string[] args)
	{
		
		Dictionary<string, int> gradeCounter = new Dictionary<string, int>()
        {
            { "A+", 0 },
            { "A", 0 },
            { "B", 0 },
            { "C", 0 },
            { "D", 0 },
            { "F", 0 }
        };

		List<int> marks = new List<int>()
		{
			20, 30, 40, 56, 67, 78, 89, 90, 12, 23, 34, 54, 76, 87, 89, 100
		};

		marks.Add(99);

		// declaring pass/fail variables
		int passStudentsNumber = PassStudents(marks);
		int failStudentsNumber = FailStudents(marks);
		
		// int[] marks = {20, 30, 40, 56, 67, 78, 89, 90, 12, 23, 34, 54, 76, 87, 89, 100};

		foreach(int mark in marks)
		{
			bool passedOrNot = IsPassed(mark);
			string grade = GetGrade(mark);

			Console.WriteLine($"Mark: {mark}, Grade: {grade}, Status: {(passedOrNot? "Pass" : "Fail")}");
			
			if(gradeCounter.ContainsKey(grade)){
				gradeCounter[grade]++;
			}
		}

		Console.WriteLine("\n---Total Students---");
		int studentnum = TotalStudents(marks);
		Console.WriteLine(studentnum);

		Console.WriteLine("\n---Passed/Failed Students---");
		Console.WriteLine($"Passed Students: {passStudentsNumber}");
		Console.WriteLine($"Failed Students: {failStudentsNumber}");

		Console.WriteLine("\n-----Grade Summary-----");
		foreach(var kvp in gradeCounter)
		{
			Console.WriteLine($"{kvp.Key}: {kvp.Value}");
		}
	}
}