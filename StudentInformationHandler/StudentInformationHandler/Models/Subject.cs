namespace StudentInformationHandler.Models
{
	public class Subject
	{
		public int Id { get; set; }
		public string Name { get; set; } = string.Empty;
		public int StudentId { get; set; }
		public int Grade
		{
			get
			{
				return Grade;
			}
			set
			{
				if (value > 0 && value <= 100)
				{
					Grade = value;
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
