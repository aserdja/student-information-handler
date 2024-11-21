namespace StudentInformationHandler.Models
{
	public class Student
	{
		public Guid Id { get; set; }
		public string FirstName { get; set; } = string.Empty;
		public string LastName { get; set; } = string.Empty;
		public int Age { get; set; }
		public List<Subject> Subjects { get; set; } = new();
		public float AverageGrade { get; set; }
		public Grant Grant { get; set; }


		public static IEnumerable<Student> Fill()
		{
			Random r = new();
			int studentsCount = r.Next(2, 5);

			var firstNamesArray = new string[5] { "Alex", "John", "Michael", "Oleg", "Stas" };
			var lastNamesArray = new string[5] { "Carter", "Kravchenko", "Shevchenko", "Camel", "Myers" };

			for (int i = 0; i < studentsCount; i++)
			{
				yield return new Student
				{ 
					Id = Guid.NewGuid(),
					FirstName = firstNamesArray[r.Next(4)],
					LastName = lastNamesArray[r.Next(4)],
					Age = r.Next(16, 25)
				};
			}
		}

		public void SetSubjects(IEnumerable<Subject> subjects)
		{
			Subjects = subjects.ToList();
		}

		public float CalculateAverageGrade()
		{
			return (float)Subjects.Average(s => s.Grade);
		}

		public void SetGrand()
		{
			if (AverageGrade < 60)
			{
				Grant = Grant.None;
			}
			else if (AverageGrade >= 60 && AverageGrade < 90)
			{
				Grant = Grant.Regular;
			}
			else if (AverageGrade >= 90)
			{
				Grant = Grant.Increased;
			}
		}
	}
}
