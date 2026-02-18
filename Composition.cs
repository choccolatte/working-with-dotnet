// a normal address classs
class Address
{
	public string city {get; set;}
}

// student has an address - thats composition. 

class Student
{
	public string Name{get; set;}
	public Address Address{get; set;}
}