namespace AirBnB;

public class BizLogic
{
    private List<City> CityList {get; set;}
    private List<State> StateList {get; set;}
    private List<Amenities> AmenitiesList {get; set;}

public BizLogic()
{
    //Parameterless constructor
    //Initialzing empty list
    CityList = new List<City>();
    StateList = new List<State>();
    AmenitiesList = new List<Amenities>();
}  

//Constructor with parameters
public BizLogic(List<City> ListofCities, List<State> ListofStates, List<Amenities> ListofAmenities)
{
    CityList = ListofCities;
    StateList = ListofStates;
    AmenitiesList = ListofAmenities;
}

//method to allow create new instance of a City
public void Add_City(string name, int id, State state)
{
    City new_City = new City();
    new_City.Name = name;
    new_City.Id = id;
    new_City.CityState = state;
    CityList.Add(new_City);
}

//Method to return a list of Cities
public List<City> Get_Cities()
{
    return CityList;
}

//Method to add State
public State Add_State(string name, int id)
{
    State new_State = new State();
    new_State.Name = name;
    new_State.Id = id;
    StateList.Add(new_State);
    return new_State;
}

//method to return a list of states
public List<State> Get_States()
{
    return StateList;
}

//Method to Add Amenities
public void Add_Amenities(string name, int id)
{
    Amenities new_amenities = new Amenities();
    new_amenities.Name = name;
    new_amenities.Id = id;
    AmenitiesList.Add(new_amenities);
}

//method to return a list of Amenities
public List<Amenities> Get_Amenities()
{
    return AmenitiesList;
}

}
