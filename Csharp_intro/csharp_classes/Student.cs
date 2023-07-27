namespace Regina
{
	public class Student
	{
		public int age {get; set;}
		public int id {get; set;}
		public string? grade {get; set;}
		public string? name {get; set;}

		public string print_student_details()
		{
			return $"The student who name is {name} is {age} years old and has a grade of {grade} with an an id of {id}";	
		}

		public void getting_info()
		{
			Console.WriteLine("Student age");
			age = int.Parse(Console.ReadLine());
			Console.WriteLine("Student's grade");
			grade = Console.ReadLine();
			Console.WriteLine("Student's name");
			name = Console.ReadLine();
			Console.WriteLine("Student's id");
			int id = int.Parse(Console.ReadLine());


		}

	}
}