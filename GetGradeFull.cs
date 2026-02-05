using System;
using System.Collections.Generic;
class Program
{
	// now, this method returns a Grade instead of string
	static Grade GetGrade(int marks)
	{
		if (marks >= 95) return Grade.APlus;
		else if (marks >= 85) return Grade.A;
		else if (marks >= 70) return Grade.B;
		else if (marks >= 55) return Grade.C;
		else if (marks >= 40) return Grade.D;
		else return Grade.F;
	}

	// defining grades in enum - CONSTANTS
	// why enums? “Enums make the code safer and more maintainable by restricting values at compile time and eliminating magic strings.”
	enum Grade{
		APlus,
		A,
		B,
		C,
		D,
		F
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

	// Grade counter method
	static Dictionary<Grade, int> GradeCounter(List<int> marks)
	{
		if(marks == null || marks.Count == 0)
		{
			throw new ArgumentException("List cannot be empty. Enter valid list of marks.");
		}

		Dictionary<Grade, int> gradeCounter = Enum.GetValues<Grade>().ToDictionary(global => global, global => 0);
		
		// new Dictionary<Grade, int>()
        // {
        //     { Grade.APlus, 0 },
        //     { Grade.A, 0 },
        //     { Grade.B, 0 },
        //     { Grade.C, 0 },
        //     { Grade.D, 0 },
        //     { Grade.F, 0 }
        // };

		foreach(var mark in marks)
		{
			Grade grade = GetGrade(mark);
			gradeCounter[grade]++;
		}

		// returns a dictionary
		return gradeCounter;
	}

	// Print Student Result method 
	static void PrintStudentResult(List<int> marks)
	{
		
		// what if list is empty
		if(marks == null || marks.Count == 0)
		{
			throw new ArgumentException("No student data available.");
		}

		Console.WriteLine("\n-----Summary-----");
		foreach(var mark in marks)
		{
			Grade grade = GetGrade(mark);
			string result = IsPassed(mark)? "Pass":"Fail";

			Console.WriteLine($"Marks: {mark}, Grade: {grade}, Result: {result}");
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
		marks.Add(9);
		marks.Add(95);
		marks.Add(19);
		marks.Add(49);

		PrintStudentResult(marks);
		PrintSummary(marks);

		// calling dictionary method
		Dictionary<Grade, int> gradeSummmary = GradeCounter(marks);

		// printing dictionary
		Console.WriteLine("\n-----Grade Distribution-----");
		foreach(var kvp in gradeSummmary)
		{
			Console.WriteLine($"{kvp.Key}: {kvp.Value}");
		}

		Console.WriteLine("\nProgram finished successfully!");

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