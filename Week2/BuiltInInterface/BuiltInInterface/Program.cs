using System;

namespace BuiltinInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Class MyBootcamp = new Class();
            MyBootcamp.AddStudent(new Student { Name = "Bahar", Id = 1, Age = 25 });
            MyBootcamp.AddStudent(new Student { Name = "Büşra", Id = 2, Age = 23 });
            MyBootcamp.AddStudent(new Student { Name = "Türkay", Id = 3, Age = 41 });

            var sortedStudents =  MyBootcamp.SortStudent();
            foreach (var item in sortedStudents)
            {
                Console.WriteLine("Student name = {0}\nStudent id = {1}\nStudent age = {2}",item.Name,item.Id,item.Age);
            }
            Console.WriteLine("!");
        }
    }
}
