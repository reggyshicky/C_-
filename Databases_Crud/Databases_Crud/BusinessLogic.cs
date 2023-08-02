using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Crud
{
    public class BusinessLogic
    {
        private SchoolDBContext _dbContext;
        //Stores all databases objects  such as tables, an instance of db

        public BusinessLogic()
        {
            _dbContext = new SchoolDBContext(); //initiliaze db context once for resource mngt
        }
        public void Add_Student(string Name, DateTime DateofBirth)
        {
            Student student = new Student(); //instance of class student
            student.Name = Name;
            student.DateofBirth = DateofBirth;
            _dbContext.Students.Add(student); //inserting students to student table
            _dbContext.SaveChanges(); //persist the data
        }
        public List<Student> GetStudents()
        {
            return _dbContext.Students.ToList(); //gets student from the db/ retrieves students data from db
        }
    }
}
