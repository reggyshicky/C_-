using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databases_Crud
{
    public class Student: BaseModel
    {
        [ForeignKey("Teacher")] //specifies that this teacherid is a foreign id to the students table
        public int? TeacherId { get; set; } //?for nullable
        public Teacher Teachers { get; set; }
    }
}
