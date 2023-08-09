using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Crud
{
    public class ConsoleProvider
    {
        BusinessLogic W = new BusinessLogic(); //instance of the business logic to add data to the db

       
        private void AddInformation(int TeacherId)
        {
            Console.WriteLine("Please Enter the number of students");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                AddStudentinfo(TeacherId);
            }

        }
        private void AddStudentinfo(int TeacherId)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your DOB");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            W.Add_Student(name, dob, TeacherId);
        }
        public void AddStudentWithTeachersInfo()
        {
            foreach (Teacher T in W.GetTeachers())
            {
                AddInformation(T.Id);
            }

        }
        
        public void print_info()
        {
            foreach (Student s in W.GetStudents())
            {
                Console.WriteLine($"The student name is {s.Name} and DOB is {s.DateofBirth} and teacher id is {s.TeacherId}");
            }
    
        }
        private void TeacherInfo()
        {
            Console.WriteLine("Enter name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the TSCNO");
            int TSCNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Year of Birth in the form yyyy-mm-dd");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            W.Add_Teacher(Name, dob, TSCNo);
        }
        public void GetTeachersNO()
        {
            Console.WriteLine("Enter the no of teacher");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                TeacherInfo();
            }
        }
        public void printTeacherInfo()
        {
            foreach (Teacher T in W.GetTeachers())
            {
                Console.WriteLine($"The teacher's name {T.Name} and TSCNO is {T.TSCNO} and and DOB is {T.DateofBirth}");
            }
        }
    }
}
