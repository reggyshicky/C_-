namespace Reggy;
public class Courses:BaseModel
{
    public List<Students> List_Students {get; set;} = new List<Students>();
}