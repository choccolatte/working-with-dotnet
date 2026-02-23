public interface IStudentRepo
{
	List<Student> GetAll();
	Student? GetById(int Id);
	void Add(Student student);
}