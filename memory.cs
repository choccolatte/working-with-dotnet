int[] marks = { 20, 23, 45, 67, 89, 87, 98, 95};

// foreach (int value in  marks)
// {
// 	Console.WriteLine(value);
// }

for (int i = 0; i < marks.Length; i++)
{
	Console.WriteLine($"{i+1}: {marks[i]}");
}