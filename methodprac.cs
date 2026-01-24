class Program
{
	static void Main(string[] args)
	{
		MyMet("Jack");
		Console.WriteLine(MyIntMet(10));
	}

	static void MyMet(string fname = "John", string lname = "Doe")
	{
		// code to execute
		Console.WriteLine("Hello World!");
		Console.WriteLine($"Hello {fname} {lname}...");
	}

	// returning int
	static int MyIntMet(int xnum)
	{
		return (5 * xnum) / 2; // 25
	}
}