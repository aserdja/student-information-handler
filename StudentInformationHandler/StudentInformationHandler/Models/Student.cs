namespace StudentInformationHandler.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public int Age { get; set; }
		public List<Subject> Subjects { get; set; } = new();
		public float AverageGrade { get; set; }
		public Grant Grant { get; set; }
	}
}
