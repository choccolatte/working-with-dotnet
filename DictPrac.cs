Dictionary<string, int> gradeCount = new Dictionary<string, int>(){
// initialize with collections {} - modify with indexers - []
{"A", 0}, // gradeCount["A"] = 0;
{"B", 0}, // gradeCount["B"] = 0;
{"C", 0}, // gradeCount["C"] = 0;
{"D", 0}, // gradeCount["D"] = 0;
{"F", 0}// gradeCount["F"] = 0;
};
string[] grades = {"A", "B", "C", "D", "F"};

foreach(string grade in grades)
{
	gradeCount[grade]++;
}

foreach(var entry in gradeCount)
{
	Console.WriteLine(entry.key + ":" + entry.value);
}

if(!gradeCount.ContainsKey("A"))
{
	gradeCount["A"]++;
}

// string grade = "A";

// gradeCount[grade]++;
// gradeCount[grade]++;

// Console.WriteLine(gradeCount["A"]); // outputs 2

// foreach(var item in gradeCount)
// {
// 	Console.WriteLine(item.key + ":" + item.value);
// }