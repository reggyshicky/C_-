using Regina;
using Shicky;

List<Student> hi_list = new List<Student>();

List<Student> terry_list = new List<Student>();

/*
The overall purpose of this code seems to be to create instances of student objects, store them in a list, 
and then assign that list to a teacher object. This way, the teacher object (Kelvin) will have a list of 
students associated with them.Student Reginah = new Student();
Reginah.name = "Kiki";
Reginah.age = 22;
Reginah.id = 8989;
Reginah.grade = "E";

//declaring and initializing a new student object called Omondi
Student Omondi = new Student();
Omondi.name = "Nigel";
Omondi.age = 28;
Omondi.id = 7655;
Omondi.grade = "E";


Student Kilonzo = new Student();
Kilonzo.name = "Winnie";
Kilonzo.age = 24;
Kilonzo.Id = 7655;
Kilonzo.grade = "E";

//Adding students to list

terry_list.Add(Reginah);
terry_list.Add(Omondi);
terry_list.Add(Kilonzo);

Teacher Kelvin = new Teacher();
Kelvin.name = "Kim";
Kelvin.height = 7;
Kelvin.List_of_Students = terry_list; //this is assiging our created list to number of students of the teacher*/

Teacher Alianda = new Teacher();
Alianda.teacher_info();
Alianda.print_teacher_details();
