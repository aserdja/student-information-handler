namespace StudentInformationHandler.Models
{
	public class Subject
	{
		public Guid Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public Guid StudentId { get; set; }
		private int grade;
		public int Grade
		{
			get
			{
				return grade;
			}
			set
			{
				if (value > 0 && value <= 100)
				{
					grade = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException();
				}
			}
		}
		public DateOnly Date { get; set; }


		public static IEnumerable<Subject> Fill(Guid studentId)
		{
			Random r = new();
			var subjectsCount = r.Next(5, 10);

			var subjectNames = new string[10] { "Math", "Chemistry", "Physics", "IT", "English", "Ukrainian", "Geography", "Sport", "Literature", "PM" };

			for (int i = 0; i < subjectsCount; i++)
			{
				yield return new Subject
				{
					Id = Guid.NewGuid(),
					Name = subjectNames[i],
					Grade = r.Next(1, 100),
					StudentId = studentId,
					Date = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
				};
			}
		}

		public static IEnumerable<Subject> GetByStudentId(List<Subject> subjects, Guid studentId)
		{
			return subjects.Where(s => s.StudentId == studentId);
		}
	}
}
