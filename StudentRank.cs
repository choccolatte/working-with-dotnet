public class StudentRank{
	public static List<Student> RankStudents(List<StudentRank> students)
	{
		return students
			.OrderByDescending(s => s.Marks)
			.ToList();
	}
}

// how to use it?
// var ranked = RankStudnts(students);

// int rank = 1;
// foreach(var s in ranked)
// {
// 	Console.WriteLine($"Rank {rank}: {s.Name} ({s.Marks})");
// 	rank++;
// }