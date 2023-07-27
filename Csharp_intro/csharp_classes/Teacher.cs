using Regina;

namespace Shicky
{
	public class Teacher
	{
		public int height {get; set;}
		public string name {get; set;}

		public List<Student> List_of_Students {get; set;}

		public void teacher_info()
		{
			Console.WriteLine("Teacher height");
			int height = int.Parse(Console.ReadLine());
			Console.WriteLine("Teacher name");
			name = (Console.ReadLine());
			Console.WriteLine("Teacher number of students");
			int number = int.Parse(Console.ReadLine());

		List_of_Students = new List<Student>();
			for (int i = 0; i < number; i++)
			{
				Student new_student = new Student();
				new_student.getting_info();
				List_of_Students.Add(new_student);
			}


		}

		public void print_Studentlist()
		{
			for (int j = 0; j < List_of_Students.Count; j++)
			{
				Console.WriteLine(List_of_Students[j].print_student_details());

			}
		}

		public void  print_teacher_details()
		{
			Console.WriteLine($"The teacher's name is {name} and the height is {height}");
			print_Studentlist();

		}
	}
}