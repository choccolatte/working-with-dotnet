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
		
		// int[] marks = {20, 30, 40, 56, 67, 78, 89, 90, 12, 23, 34, 54, 76, 87, 89, 100};

		foreach(int mark in marks)
		{
			string grade = GetGrade(mark);
			Console.WriteLine($"Mark: {mark}, Grade: {grade}");
			gradeCounter[grade]++;
		}

		Console.WriteLine("\n-----Grade Summary-----");
		foreach(var kvp in gradeCounter)
		{
			Console.WriteLine($"{kvp.Key}: {kvp.Value}");
		}
	}
}