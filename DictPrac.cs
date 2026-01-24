Dictionary<string, int> gradeCount = new Dictionary<string, int>();
gradeCount["A"] = 0;
gradeCount["B"] = 0;
gradeCount["C"] = 0;

string grade = "A";

gradeCount[grade]++;
gradeCount[grade]++;

Console.WriteLine(gradeCount["A"]); // outputs 2

foreach(var item in gradeCount)
{
	Console.WriteLine(item.key + ":" + item.value);
}