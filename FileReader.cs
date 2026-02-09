static class FileReader
{
	public static List<int> ReadMarks(string path)
	{
		return File.ReadAllLines(path)
		.Select(int.Parse)
		.ToList();
	}
}