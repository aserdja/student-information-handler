using StudentInformationHandler.Models;

List<Student> students = Student.Fill().ToList();


foreach (Student student in students)
{
	student.SetSubjects(Subject.Fill(student.Id));
	student.AverageGrade = student.CalculateAverageGrade();
	student.SetGrand();
}


foreach (Student student in students)
{
	Console.WriteLine(new string('-', 15));

	Console.WriteLine($"Id: {student.Id} \nFirst name: {student.FirstName} \nLast name: {student.LastName} \nAge: {student.Age} \nAverage grade: {student.AverageGrade} " +
		$"\nGrant: {student.Grant}");
	Console.WriteLine($"Subjects:");
	foreach (var subject in student.Subjects)
	{
		Console.WriteLine($"Id: {subject.Id}; Name: {subject.Name}; Grade: {subject.Grade}; Date: {subject.Date}");
	}

	Console.WriteLine(new string('-', 15));
}