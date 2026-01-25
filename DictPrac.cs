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

Dictionary<string, int> gradeCalc = new Dictionary<string, int>()
{
	{"A", 0},
	{"B", 0},
	{"C", 0},
	{"D", 0},
	{"F", 0}
};

// string keyi = "A";
// gradeCalc[keyi]++;

foreach(int items in gradeCalc)
{
	Console.Write(gradeCalc.key + ":" + gradeCalc.item);
}

if(!gradeCalc.ContainsKey("A")){
	gradeCalc["A"]++;
}


// new prac
Dictionary<string, int> gradePrac = new Dictionary<string, int>()
{
	{"A", 2},
	{"B", 1},
	{"C", 3},
	{"D", 0},
	{"F", 1}
};


//take an aray of marks
static int StudMarks(int marks)
{
	
}

// convert marks to grade


// stores count of each grade in a dict
UpdateGrades(Dictionary<string, int>, string grade)
{
	
}

// prints results
static void PrintRes(Dictionary<string, int>)
{
	
}

// Why is Dictionary better than multiple counters?
// coz using dict, we can store multiple key:value pairs in a single variable instead of using diff variables for all the variables we would use.

// What would break if grades change?
// the hardcoded values

// How would this work for 10,000 students?
// we have to remove the magic numbers and hardcoded stuff.