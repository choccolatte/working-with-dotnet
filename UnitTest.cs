using System.Reflection;

public class GradeCalculatorTests
{
	public void Marks_Above_95_Returns_Aplus()
	{
		var grade = GradeCalculator.GetGrade(98);
		Assert.Equal(grade.Aplus, grade);
	}
}