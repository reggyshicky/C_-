namespace Reggy;

public class University:BaseModel
{
    public string Location {get; set;}
    public List<School> List_Schools {get; set;} = new List<School>();
}