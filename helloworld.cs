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