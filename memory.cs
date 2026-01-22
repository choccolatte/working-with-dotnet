int[] marks = { 20, 23, 45, 67, 89, 87, 98, 95};

// foreach (int value in  marks)
// {
// 	Console.WriteLine(value);
// }

// dict 
Dictionary<string, int> gradeCounts = new Dictionary<string, int>()
{
	{"A+", 0},
	{"A", 0},
	{"B", 0},
	{"C", 0},
	{"D", 0},
	{"F", 0}
};


// gradeCounts[grade]++;

// looping through dict
for (int i = 0; i < marks.Length; i++)
{
	string grade  = GetGrade(marks[i]);
	Console.WriteLine($"{i+1}: Marks = {marks[i]}, Grade = {grade}");
	gradeCounts[grade]++;
}

Console.WriteLine("\n---Grade Summary---");

foreach(var entry in gradeCounts)
{
	Console.WriteLine($"{entry.key}: {entry.value}");
}