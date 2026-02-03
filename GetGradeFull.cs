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

	// highest mark in list
	static int HighestMark(List<int> marks)
	{
		// in case the marks list is empty or null
		if(marks == null || marks.Count == 0) throw new ArgumentException("Marks list cannot be empty.");

		int highestMark = marks[0];
		
		foreach(int mark in marks)
		{
			if(mark > highestMark)
			{
				highestMark = mark;
			}
		}

		return highestMark;
	}

	// lowest mark in list
	static int LowestMark(List<int> marks)
	{
		// in case the marks list is empty or null
		if(marks == null || marks.Count == 0) throw new ArgumentException("Marks list cannot be empty.");

		int lowestMark = marks[0];

		foreach (int mark in marks)
		{
			if(mark < lowestMark) {
				lowestMark = mark;
			};
		}

		return lowestMark;
	}

	// average marks of the list
	static double AverageMarks(List<int> marks)
	{
		if(marks == null || marks.Count ==0) throw new ArgumentException("Marks List cannot be empty.");

		int totalMarks = 0;
		// double avgMarks; 

		foreach(int mark in marks)
		{
			totalMarks += mark;
		}
		
		return (double)totalMarks/marks.Count;

		// return avgMarks;
	}

	// Print Student Result method 
	static void PrintStudentResult(List<int> marks)
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

		// what if list is empty
		if(marks == null || marks.Count == 0)
		{
			throw new ArgumentException("No student data available.");
		}

		Console.WriteLine("\n-----Summary-----");
		foreach(var mark in marks)
		{
			string grade = GetGrade(mark);
			string result = IsPassed(mark)? "Pass":"Fail";

			Console.WriteLine($"Marks: {mark}, Grade: {grade}, Result: {result}");

			// incrementing gradecounter
			if (gradeCounter.ContainsKey(grade))
			{
				gradeCounter[grade]++;
			}
		}
	}

	// print summary method
	static void PrintSummary(List<int> marks)
	{
		// 1. If marks list is null or empty, print message and return
		if(marks == null || marks.Count == 0)
		{
			throw new ArgumentException("List cannot be empty.");
		}

		Console.WriteLine("\n----------Mark Summary----------");
		
		// 2. Calculate total students
		int total = TotalStudents(marks);
		Console.WriteLine($"Total Students: {total}");

		// 3. Calculate passed students
		int passStudents = PassStudents(marks);
		Console.WriteLine($"Passed Students: {passStudents}");

		// 4. Calculate failed students
		int failStudents = FailStudents(marks);
		Console.WriteLine($"Failed Students: {failStudents}");

		// 5. Calculate average marks
		double averageMark = AverageMarks(marks);
		Console.WriteLine($"Average Marks: {averageMark}");

		// 6. Find highest mark
		int highestMark = HighestMark(marks);
		Console.WriteLine($"Highest Mark: {highestMark}");

		// 7. Find lowest mark
		int lowestMark = LowestMark(marks);
		Console.WriteLine($"Lowest Mark: {lowestMark}");

		// 8. Print all values in a clean format
		// printed already above
	}


	// Main method starts here
	static void Main(string[] args)
	{
		
		// Dictionary<string, int> gradeCounter = new Dictionary<string, int>()
        // {
        //     { "A+", 0 },
        //     { "A", 0 },
        //     { "B", 0 },
        //     { "C", 0 },
        //     { "D", 0 },
        //     { "F", 0 }
        // };

		List<int> marks = new List<int>()
		{
			20, 30, 40, 56, 2, 67, 78, 89, 90, 12, 23, 34, 54, 76, 87, 89, 100
		};

		marks.Add(99);

		PrintSummary(marks);
		PrintStudentResult(marks);

		// highest and lowest variables method call
		// int highestStudentMark = HighestMark(marks);
		// int lowestStudentMark = LowestMark(marks);

		// // declaring pass/fail variables
		// int passStudentsNumber = PassStudents(marks);
		// int failStudentsNumber = FailStudents(marks);
		
		// int[] marks = {20, 30, 40, 56, 67, 78, 89, 90, 12, 23, 34, 54, 76, 87, 89, 100};

		// foreach(int mark in marks)
		// {
		// 	bool passedOrNot = IsPassed(mark);
		// 	string grade = GetGrade(mark);

		// 	Console.WriteLine($"Mark: {mark}, Grade: {grade}, Status: {(passedOrNot? "Pass" : "Fail")}");
			
		// 	if(gradeCounter.ContainsKey(grade)){
		// 		gradeCounter[grade]++;
		// 	}
		// }

		// highest and lowest marks in class
		// Console.WriteLine($"Highest marks in class: {highestStudentMark}");
		// Console.WriteLine($"Lowest marks in class: {lowestStudentMark}");

		// Console.WriteLine("\n---Total Students---");
		// int studentnum = TotalStudents(marks);
		// Console.WriteLine(studentnum);

		// Console.WriteLine("\n---Passed/Failed Students---");
		// Console.WriteLine($"Passed Students: {passStudentsNumber}");
		// Console.WriteLine($"Failed Students: {failStudentsNumber}");

// 		Console.WriteLine("\n-----Grade Summary-----");
// 		foreach(var kvp in gradeCounter)
// 		{
// 			Console.WriteLine($"{kvp.Key}: {kvp.Value}");
// 		}
	}
}