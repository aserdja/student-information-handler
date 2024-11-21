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
	}
}
