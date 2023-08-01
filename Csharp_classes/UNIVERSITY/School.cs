namespace Reggy;

public class School:BaseModel
{
    public List<Department> List_Departments {get; set;} = new List<Department>();
    
}