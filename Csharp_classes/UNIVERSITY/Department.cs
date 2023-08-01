namespace Reggy;

public class Department:BaseModel
{
    public List<Courses> List_Courses {get; set;} = new List<Courses>();
}