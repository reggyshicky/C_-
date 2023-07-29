using AirBnB;

BizLogic X = new BizLogic(); //global variable

StateCityInfo();
Print_states();
Print_Cities();

//function to get from user the number of states, and for each state the number of cities

void StateCityInfo()
{
    Console.WriteLine("Enter the number of states: ");
    int number = int.Parse(Console.ReadLine());
for (int i = 0; i < number; i++)
{
    State state = Ask_ForStateInfo();
    Console.WriteLine("Enter the number of Cities: ");
    int nums = int.Parse(Console.ReadLine());
    for (int j=0; j < nums; j++)
    {
        Ask_ForCityInfo(state);
    }
}
}
State Ask_ForStateInfo()
{
    Console.WriteLine("Give the state name");
    string name = Console.ReadLine();
    Console.WriteLine("Give state ID: ");
    int Id = int.Parse(Console.ReadLine());

    return X.Add_State(name, Id);
}
void Ask_ForCityInfo(State state)
{
    Console.WriteLine("Give City Name: ");
    string name = Console.ReadLine();
    Console.WriteLine("Give City Id: ");
    int Id = int.Parse(Console.ReadLine());
    X.Add_City(name, Id, state);
}

void Print_Cities()
{
    //List<City> cities = X.Get_Cities();(alternative)
    foreach (City city in X.Get_Cities())
    {
        Console.WriteLine($"Name of City:{city.Name}, Id:{city.Id}, State:{city.CityState.Name}");   
    }
}

void Print_states()
{
    foreach (State state in X.Get_States())
    {
        Console.WriteLine($"Name of State: {state.Name}, Id:{state.Id}");
    }
}

