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

       
        public void AddInformation()
        {
            Console.WriteLine("Please Enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                AddStudentinfo();
            }

        }
        private void AddStudentinfo()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your DOB");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            W.Add_Student(name, dob);
        }
        public void print_info()
        {
            foreach (Student s in W.GetStudents())
            {
                Console.WriteLine($"The student name is {s.Name} and DOB is {s.DateofBirth}");
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
