namespace Regina{
	public class Student
	{
		public int Age {get; set;}
		public int Id  {get; set;}
		public string Name {get; set;}
		public string Grade {get; set;}

		public string student_details()
		{
			return @$"The student whose name is {Name} and id is {Id} is {Age} years old and has a grade of {Grade}";
		}
	}
}
