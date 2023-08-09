using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Crud
{
    public class Teacher:BaseModel
    {
        public int TSCNO { get; set; }
        public ICollection<Student> CollectionOfStudents;//list of student
    }
}
//when you want to run the project , run the below commands
//Add-migration
//update-database