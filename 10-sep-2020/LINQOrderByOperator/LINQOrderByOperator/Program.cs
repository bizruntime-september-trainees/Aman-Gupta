using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string Name { get; set; }
    public string Gender { get; set; }
    public List<string> Subjects { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> Objstudent = new List<Student>(){
            new Student() { Name = "Suresh Dasari", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
            new Student() { Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },
            new Student() { Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },
            new Student() { Name = "Sateesh Chandra", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },
            new Student() { Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }
        };
        var studentname = Objstudent.OrderBy(x => x.Name);
        foreach (var student in studentname)
        {
            Console.WriteLine(student.Name);
        }
    }
}