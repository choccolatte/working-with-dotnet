Console.WriteLine("hello world!");

string name = "Kush";
int age = 20;
bool leaning = true;

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Leaning C#: {leaning}");

if (age >= 20){
	Console.WriteLine("Adult mode activated!")
} else {
	Console.WriteLine("Young blood!!!")
}


class BankAcc
{
	public static void CalcInterest()
	{
		Console.WriteLine("Enter amount: ");
	}
}

BankAcc.CalcInterest();

// using a simple logic

int num = 15;

if (num > 10)
{
	Console.WriteLine("Num big enough.");
} else if (num > 5) {
	Console.WriteLine("Num is mid.");
} else {
	Console.WriteLine("Small num.");
}

// for loops

for (int i = 1; i <= 5; i++){
	Console.WriteLine($"Count: {i}");
}

// while loop
int i  = 1;
while (i <= 50){
	Console.WriteLine($"While counts: {i}");
	i++;
}


// printing a list of numbers - if counting - FOR. If waiting - WHILE
int i = 1;
while (i <= 5){
	Console.WriteLine($"{i}");
	i++;
}
Console.WriteLine("Done");

// methods are just named, reusable piece of thinking 
static void Greet()
{
	Console.WriteLine("Hello!");
}

Greet();

// methods with inputs
static void GreetPerson(string name)
{
	Console.WriteLine($"Hello! {name}");
}

Greet("John");


// methods returning values
static int Add(int a, int b)
{
	return a + b;
}

int result = Add(10, 20);
Console.WriteLine(result);


// grade calculator
static string GetGrade(int marks)
{
	if(marks >= 90) return "A";
	else if (marks >= 75) return "B";
	else if (marks >= 60) return "C"; 
	else return "D";
}

string res = GetGrade(85);
Console.WriteLine(res);


// combining methods + loops -> printing grades for multiple students

static string GetGradeNew(int marks)
{
	if (marks >= 90) return "A";
	else if (marks >= 75) return "B";
	else if (marks >= 60) return "C";
	else if (marks >= 40) return "D";
	else return "F";
}

int[] markList = {95, 85, 65, 33, 20, 40, 55, 99};

for (int i = 0; i < markList.Length; i++)
{
	string grade = GetGradeNew(markList[i]);
	Console.WriteLine($"Student's Marks: {markList[i]}, Student's Grade: {grade}");
}


// array deep dive
// they hold multiple values of the same type
// here, index starts at 0
// scores.Length - tells us how many items are there

int[] scores = { 88, 92, 76, 61, 45 };

// looping pattern
for (int i = 0; i < scores.Length; i++)
{
	Console.WriteLine(scores[i]);
}

// student grade report
int[] marks = {100, 23, 34, 56, 23, 86, 76, 54, 43, 98, 87, 98, 100};

static string GetGradeNew1(int marks)
{
	if(marks >= 90) return "A+";
	else if(marks >= 85) return "A";
	else if(marks >= 65) return "B";
	else if(marks >= 55) return "C";
	else if(marks >= 40) return "D";
	else return "F";
}

// looping through marks array
for (int i = 0; i <= marks.Length; i++)
{
	string gradeStd = GetGradeNew1(marks[i]);
	Console.WriteLine($"Student's marks: {marks[i]}, Student's grde: {gradeStd}");
}


// dictionary
Dictionary<string, int> gradeCounts = new Dictionary<string, int>();

gradeCounts["A+"] = 0;
gradeCounts["A"] = 0;
gradeCounts["B"] = 0;
gradeCounts["C"] = 0;
gradeCounts["D"] = 0;
gradeCounts["F"] = 0;

string grade  = GetGrade(mark);

gradeCounts[grade]++;


// using substring
string fulName = "John Doe";
int charPos = fulName.IndexOf("D");
string lName = fulName.Substring(charPos);
Console.WriteLine(lName); // Doe
Console.WriteLine(charPos); // 5


// testing boolean exp
int x = 9;
int y = 90;
Console.WriteLine(x > y); // false
Console.WriteLine(!(x > y)); // true coz of NOT - inversion


// while loop - sued when waiting
int i = 0;
while(i <=10)//while(condition)
{
	Console.WriteLine(i); // code block to execute
	i++;

	if(i == 5)
	{
		break;
	}
}

// do while loop
int i = 0;
do
{
	Console.WriteLine(i);
	i++;
}
while(i < 10);


// for loop - used when counting + nested loop
for(int i = 0; i<=10; i++)
{
	Console.WriteLine("Outer: " + i);

	// inner loop
	for (int j = 0; j <= i; j++)
	{
		Console.WriteLine("Inner: " + j);

		if(i == 5)
		{
			break;
		}
	}
}


// foreach - exclusively for array
string[] name = {"John", "Doe", "Jay", "Kush", "Rody"};
foreach(string i in name)
{
	Console.WriteLine(i);
}


// arrays in C#
int[] nums = {1, 22, 34, 54, 32, 76, 78, 98}; // {} - array literal

// accessing elements in arry
// int val = nums[5];
nums[5] = 96;
Console.WriteLine(val);

Console.WriteLine(nums.Length);


// other ways to create an array - using new keyword
int[] num1 = new int[5]; //this created an array of size 5 - we can append teh values later. 

// other ways to create an array - using new
int[] num2 = new int[3] {1, 3, 5}; // this created an array of size 3 and aded the values there only.

// other ways to create an array - using new
int[] num3 = new int[] {1, 3, 4,  6, 7, 89, 9}; // this created an array of free size but we added the values still

// other ways to create an array - without using new keyword and without specifyng size
int[] num4 = {1, 2, 3, 4, 5, 6, 7, 8, 9};


// Note that, if you create the array and initialize it later, always use teh new keyword for it.
int[] num5; // defining the array
num5 = new int[] {1, 2, 3, 4, 5}; // adding values to it using new keyword


// looping through arrays
for(int i = 0; i<nums4.Length; i++)
{
	Console.WriteLine(nums[i]);
}

foreach(int i in nums4)
{
	Console.WriteLine(i);
}


// sorting arrays
Array.Sort(nums4);
Console.WriteLine(nums4);