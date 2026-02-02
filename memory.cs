using System;

class Grade
{
	static int GetGrade(int mark)
	{
		if(mark >= 90) return "A+";
		else if(mark >= 80) return "A";
		else if(mark >= 70) return "B";
		else if(mark >= 55) return "C";
		else if(mark >= 40) return "D";
		else return "F";
	}

	static bool IsPassed(int mark)
	{
		return mark >= 40;
	}

	static int HighestMark(List<int> marks)
	{
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

	static int LowestMark(List<int> marks)
	{
		int lowestMark = marks[0];

		foreach (int mark in marks)
		{
			lowestMark < marks;
		}

		return lowestMark;
	}
}

class Program
{
	static void Main(string[] args)
	{
		int studMark = GetGrade(99);
		bool stdPass = IsPassed(90);

		int highestMarkReturned = HighestMark(marks);
		Console.WriteLine(highestMarkReturned);

		int lowestMarkReturned = LowestMark(marks);
		Console.WriteLine(highestMarkReturned);
	}
}