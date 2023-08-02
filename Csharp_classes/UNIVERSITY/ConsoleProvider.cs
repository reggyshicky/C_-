namespace Reggy;

public class Console_Provider
{
    private University_Data_Access_Layer Egerton = new University_Data_Access_Layer();
    private Students Get_Student_Info()
    {
        Console.WriteLine("Please enter name ?");
        string Name = Console.ReadLine();
        Console.WriteLine("Please enter your date of bith in the format yyyy-mm-dd");
        DateTime Date_of_birth = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Please Enter your id number");
        int Id = int.Parse(Console.ReadLine());
        return Egerton.Add_Student(Name, Id, Date_of_birth);
    }
    private Course Get_Course()
    {
        Console.WriteLine("Enter course name ");
        string Name = Console.ReadLine();
        Console.WriteLine("Please enter your Id number");
        
    }
}