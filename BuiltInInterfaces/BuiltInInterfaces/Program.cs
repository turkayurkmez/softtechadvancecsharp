// See https://aka.ms/new-console-template for more information
using BuiltInInterfaces;

Console.WriteLine("Hello, World!");
Student student1 = new Student() {  Id=1, Age=27, Name="Funda Sarıkaya" };
Student student2 = new Student() { Id = 2, Age = 42, Name = "Türkay Ürkmez" };
Student student3 = new Student() { Id = 3, Age = 16, Name = "Emre Altuntaş" };


Student student4;

ClassRoom room = new ClassRoom();
room.Add(student1);
room.Add(student2);
room.Add(student3);

room.Sort();

foreach (Student student in room)
{
    Console.WriteLine($"{student.Id} - {student.Name} - {student.Age}");
}


