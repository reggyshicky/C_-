// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Please what is your name?");
//string name = Console.ReadLine();
//Console.WriteLine("Please Enter your age?");
//string input = Console.ReadLine();
//int age = int.Parse(input);
//Console.WriteLine($"Her name is {name} and her age is {age}");
// string input = Console.Readline(int.Parse(input);
//Console.WriteLine("Please give the number of items in the array: ");
//string input = Console.ReadLine();
//int number = int.Parse(input);
//string  [] my_array = new string [number];

Console.WriteLine("Please give me your age: ");
string input = Console.ReadLine();
int age = int.Parse(input);

List<int> interger_list=new List<int>();

if (age >= 20 && age <= 30)
{
	Console.WriteLine("you are still young");
	interger_list.Add(age);
}

else if (age < 20)
{
	Console.WriteLine("You are a teenager");
	interger_list.Add(age);
}

else if (age > 30 && age <= 40)
{
	Console.WriteLine("Senior Bachelor");
}
else
Console.WriteLine("You are to old");
interger_list.Add(age);

for (int i = 0; i < interger_list.Count; i++)
{
	Console.WriteLine($"{interger_list[i]}");
}
