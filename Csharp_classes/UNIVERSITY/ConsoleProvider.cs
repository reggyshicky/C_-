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
    private Courses Get_Courses()
    {
        Console.WriteLine("Enter course name ");
        string Name = Console.ReadLine();
        Console.WriteLine("Please enter your Id number");
        int Id = int.Parse(Console.ReadLine());
        Courses course = Egerton.Add_Courses(Name, Id);
        return Add_Students_To_Course_With_Info(course);
    }
    private Courses Add_Students_To_Course_With_Info(Courses courses)
    {
        Console.WriteLine("Please Enter number of students ");
        int Num = int.Parse(Console.ReadLine());
        for (int i = 0; i < Num; i++)
        {
            courses = Egerton.Add_Student_To_Course(courses, Get_Student_Info());
        }
        return courses;   
    }
    private Department Get_Department()
    {
        Console.WriteLine("Enter the deparrtment name ");
        string depart_name = Console.ReadLine();
        Console.WriteLine("Enter Department Id ");
        int Depart_Id = int.Parse(Console.ReadLine());
        Department department = Egerton.Add_Departments(depart_name, Depart_Id);
        return Add_Courses_To_Department_With_Info(department);
    }
    private Department Add_Courses_To_Department_With_Info(Department Depart)
    {
        Console.WriteLine("Enter number of courses in the department");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i < number; i++)
        {
            Depart = Egerton.Add_Course_To_Department(Depart, Get_Courses());
        }
        return Depart;
    }
    private School Get_School()
    {
        Console.WriteLine("Enter number of department ");
        string school_name = Console.ReadLine();
        Console.WriteLine("Enter school id ");
        int school_Id = int.Parse(Console.ReadLine());
        School schools = Egerton.Add_School(school_name, school_Id);
        return Add_Departments_To_School_With_Info(schools);
    }
    private School Add_Departments_To_School_With_Info(School schools)
    {
        Console.WriteLine("Enter number of departments ");
        int Num = int.Parse(Console.ReadLine());
        for (int i = 0; i < Num; i++)
        {
            schools = Egerton.Add_Department_To_School(Get_Department(), schools);
        }
        return schools;
    }
    private University Get_University()
    {
        Console.WriteLine("Enter the university name ");
        string university_name = Console.ReadLine();
        Console.WriteLine("Enter the univerisity Id");
        int university_Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the Location ");
        string Location = Console.ReadLine();
        University university = Egerton.Add_University(university_name, university_Id, Location);
        return Add_School_To_Univerisity_With_Info(university);
    }
    private University Add_School_To_Univerisity_With_Info(University uni)
    {
        Console.WriteLine("Enter number of schools in university");
        int Num = int.Parse(Console.ReadLine());
        for (int i = 0; i < Num; i++)
        {
            uni = Egerton.Add_School_To_University(Get_School(), uni);
        }
        return uni;
    }
    public void Data_Entry()
    {
        Egerton.Add_University_To_List(Get_University());
    }
    private void Print_Students(List<Students> students)
    {
        foreach (Students s in students)
        {
            Console.WriteLine($"Student's nam is {s.Name}, DOB is {s.Date_of_birth.ToLongDateString()}");
        }
    }
    private void Print_Courses(List<Courses> courses)
    {
        foreach (Courses c in courses)
        {
            Console.WriteLine($"Course name is {c.Name}, and its id is {c.Id}");
            Console.WriteLine("Below are the students");
            Print_Students(c.List_Students);
        }
    }
    private void Print_Departments(List<Department> departments)
    {
        foreach (Department d in departments)
        {
            Console.WriteLine($"Department name is {d.Name}, and its id is {d.Id}");
            Console.WriteLine("Below are the list of courses");
            Print_Courses(d.List_Courses);
        }
    }
    private void Print_Schools(List<School> schools)
    {
        foreach (School s in schools)
        {
            Console.WriteLine($"Schools name is {s.Name}, and its id is {s.Id}");
            Console.WriteLine("Below are the list of department");
            Print_Departments(s.List_Departments);
        }
    }
    private void Print_Universities(List<University> universities)
    {
        foreach (University u in universities)
        {
            Console.WriteLine($"Unverisity name is {u.Name}, and its id is {u.Id}");
            Console.WriteLine("Below are the list of schools");
            Print_Schools(u.List_Schools);
        }
    }
    public void PrintInformation()
    {
        Print_Universities(Egerton.GetUniversities());
    }
    public int number_of_universities() => Egerton.GetUniversities().Count;

}

