static class StudentFileReader
{
	public static List<Student> ReadStudents(string path)
	{
		var lines = File.ReadAllLines(path);
		var students = new List<Students>();

		foreach(var line in lines)
		{
			var parts = line.Split(',');

			int id = int.Parse(parts[0]);
			string name = parts[1];
			int marks = int.Parse(parts[2]);

			students.Add(new Students(id, name, marks));
		}

		return students;
	}
}

// here, we are reading the file, breaking each line and converting raw text data into real objects.
