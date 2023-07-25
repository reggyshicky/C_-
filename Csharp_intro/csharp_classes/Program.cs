// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
// // I love C sharp
using Regina;

Console.WriteLine("What is his name");
string name = Console.ReadLine();

Console.WriteLine("What is his age");
int age = int.Parse(Console.ReadLine());

Console.WriteLine("What is his grade");
string grade = Console.ReadLine();

Console.WriteLine("What is his id");
int id = int.Parse(Console.ReadLine());

 Student Shikanda = new Student();
 Shikanda.Name = name;
 Shikanda.Age = age;
 Shikanda.Grade = grade;
 Shikanda.Id = id;
Console.WriteLine(Shikanda.student_details());
//
// 
