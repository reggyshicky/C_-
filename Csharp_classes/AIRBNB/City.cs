namespace AirBnB;

public class City:BaseModel
{
    public State CityState {get; set;}
    //Indicates thst the CityState attribute will hold an object of the State type
    //CityState holds the name of the State that the city belongs to   
}