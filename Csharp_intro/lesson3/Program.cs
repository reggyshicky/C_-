// See https://aka.ms/new-console-template for more information
string name = "reginah";
string name2 = "shicky";
Console.WriteLine("Hello " + name);

//string interpolation
Console.WriteLine($"Hello {name} and {name2}");
Console.WriteLine($"The name {name} has {name.Length} and the name {name2} has {name2.Length}");


//Triming whitespaces using TrimStart(). TrimEnd() and Trim()
string greeting = "    Hello Reginah    ";
Console.WriteLine(greeting.TrimStart());
Console.WriteLine(greeting.TrimEnd());
Console.WriteLine(greeting.Trim());

//use of Replace in string
string sayHello = "Hello World";
Console.WriteLine(sayHello);

sayHello = sayHello.Replace("Hello", "Habari");
Console.WriteLine(sayHello);
