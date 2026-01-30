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


// multidimensional arrays - 2D array
int[,] nums2d = {{1, 2, 4}, {9, 8, 6}};
Console.WriteLine(nums2d[0, 2]);

// changing 3rd element of 2nd array
nums2d[1, 2] = 99;
Console.WriteLine(nums2d[1, 2]);

// looping through a multidimensional arrays - 2D array
foreach(int i in nums2d)
{
	Console.WriteLine(i);
}

//or
for(int i = 0; i < nums2d.GetLength(0); i++)
{
	for(int j = 0; j<nums2d.GetLength(1); j++)
	{
		Console.WriteLine(nums2d[i, j]);
	}
}


// classes and objects - if fruit is a class, then apple, banana, ananas are objects of fruit class - in other words, classes are template for objects, and an object is an instance of a class.

// creating a class
class House
{
	public string color = "Red";
	publicint doors = 10;
	public int windows = 20;
	public int rooms = 8;
	public string owner = "John Doe";

	public string Owner(string name)
	{
		return "Owner of this house is: " + name;
	}
}

class Program
{
	static void Main(string[] args)
	{
		House house = new House();
		Console.WriteLine(house.color);

		string houseOwner = House.Owner("Jill Doe");
		Console.WriteLine(houseOwner);
	}
}


// getGrade skeleton
// get a dict and add grade counters to 0
Dictionary<string, int> gradeCounts = new Dictionary<string, int>
{
	{"A", 0},
	{"B", 0},
	{"C", 0},
	{"D", 0},
	{"F", 0}
};

// define marks
int[] marks = {54, 43, 65, 76, 87, 98, 89, 23, 34};


// loop for marks and grade them and store them into gradeCount dict
foreach(int mark in marks)
{
	string grade = GetGrade(mark);
	gradeCounts[grade]++;
}


// GetGrade function
// input
// output
// steps

class Program
{
	public static string GetGrade(int marks)
	{
		if(marks > 95) return "A+";
		else if(marks >= 90) return "A";
		else if(marks >= 80) return "B";
		else if(marks >= 65) return "C";
		else if(marks >= 50) return "D";
		else return "F";
	}

	public static void Main(string[] args)
	{
		Dictionary<string, int> gradeDict = new Dictionary<string, int>
		{
			{"A+" : 0},
			{"A" : 0},
			{"B" : 0},
			{"C" : 0},
			{"D" : 0},
			{"F" : 0},
		};

		int[] marks = {23, 34, 45, 56, 67, 78, 89, 98, 97, 46, 21, 24};

		// looping through marks and incrementing dict
		foreach(int mark in marks)
			{
				string gottenGrade = GetGrade(mark);
				if (gradeDict.ContainsKey(gottenGrade))
				{
					gradeDict[gottenGrade]++;
				}

				Console.WriteLine($"Student's marks: {mark}, Student's grade: {gottenGrade}");
			}

		Console.WriteLine("Finished grading!");

		foreach (var kvp in gradeDict)
		{
			Console.WriteLine($"{kvp.Key}:{kvp.Value}");
		}
	}
}


// class members
class MyCls
{
	// field member
	string color = "red";
	int year = 2026;

	// method member
	public void MyMet()
	{
		Console.WriteLine($"{color}:{year}");
	}
}

// static = exists before objects
// instance = exists because of objects
// Main = entry point → must be static

// class = blueprint
// constructor = setup crew
// instance = finished house ready to live in


// Constructors = different entry doors
// Object = built once
// Fields = set once
// Overloading ≠ overwriting
// Chaining = clean & safe
// constructors - special method used to initialize objects


// Constructors = doors
// this(...) = redirect to another door
// Only one door actually builds the object

class Car2
{
	public string Model; // creates a field - initializing

	public Car2(string model){ // class constructor for car2 class - notice no return type - not even void
		Model = model; // set the initial value for field - value assigning
	}

	static void Main(string[] args)
	{
		Car2 Ford = new Car2("Mustang"); // creates an object of the Car2 class - this will also call the constructor
		Console.WriteLineI(Ford.model);
	}
}


// in constructor overloading, only one constructor will run per object/instance
// here, we use constructor chaining

class Car3
{
	public string Color;
	public int Year;
	public string Brand;

	public Car3(): this("Red", 2026, "Toyota") // runs when no args is given - it means - if someone created a Car3 without providing arguments, it’ll forward that request to the more detailed constructor, using default values
	{
		// since no arguments were given, so there's no need to define anything here as we already have default values above - this body runs AFTER the other constructor
	}

	public Car3(string color): this(color, 2025) // runs when one arg is given
	{
	}

	public Car3(string color, int year) // runs when two args is given 
	{
		Color = color;
		Year = year;
	}

	public Car3(string color, int year, string brand)
	{
		Color = color;
		Year = year;
		Brand = brand;
	}
}

class Program
{
	static void Main(string[] args)
	{
		Car3 nCar26 = new Car3();
		Console.WriteLine(nCar26.Brand = "Ford");
	}
}


// access modifiers
// public - teh ccode is acessible for all classes.
// private - the code is not accessible within the same class.
// protected - theh code is accessible within the same class, or in a class that is inherited from that class. 
// internal - the code is oinly accesible within its own assembly, but not from another assembly.


// properties(get and set) - encapsulation
// - encapsulation is hiding sensitive data from users.- 1st declare fields/methods as private, then provide public get and set methods, through properties, to access and upadte the value of a private field.

class Person
{
	private string name; // field

	public string Name{get; set;} // property - associated with the name field
	// {
	// 	get {return name;} // get method - returns the value of the variable name
	// 	set {name = value;} // set methods - assigns a value to the name variable. the value keyword here represents teh value we assign to the property.
	// }
}

class Program
{
	static void Main(string[] args)
	{
		Person myObj = new Person();
		myObj.Name = "John";
		Console.WriteLine(myObj.Name);
	}
}


// shorthand - automatic properties

class Person2
{
	public string Name{get; set;}
}


// inheritance - derived(child class) and base class(parent class)
// inheriting a class

class Vehicle // base class
{
	public string brand = "Ford";
	
	public void honk()
	{
		Console.WriteLine("toot tooooot!!!");
	}
}

class Car: Vehicle // derived class
{
	public string modelName = "Mustang"; // car field
}

class Program
{
	static void Main(string[] args)
	{
		// create a myCar obj
		Car myCar = new Car();

		// call the base class's honk method on myCar obj
		myCar.honk();

		// display the value of the brand field and teh value of modelName from Car class
		Console.WriteLine(myCar.brand + " " + myCar.modelName);
	}
}

