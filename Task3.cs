using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string School { get; set; }
    }

    internal class Task3
    {
        


        public static void task3()
        {
           List<Student> students = new List<Student> {
                new Student { FirstName = "John", LastName = "Doe", Age = 18, School = "MIT" },
                new Student { FirstName = "Jane", LastName = "Smith", Age = 20, School = "Oxford" },
                new Student { FirstName = "Boris", LastName = "Johnson", Age = 22, School = "Oxford" },
                new Student { FirstName = "Brody", LastName = "Brown", Age = 19, School = "Harvard" },
                new Student { FirstName = "Alice", LastName = "Williams", Age = 21, School = "MIT" }
            };

            // Отримати весь масив студентів
            var allStudents = students.ToArray();
            Console.WriteLine("All Students:");
            foreach (var student in allStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            // Отримати список студентів з ім'ям Boris
            var studentsWithFirstNameBoris = students.Where(x => x.FirstName == "Boris").ToList();
            Console.WriteLine("Students with first name Boris:");
            foreach (var student in studentsWithFirstNameBoris)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            // Отримати список студентів з прізвищем, яке починається з Bro
            var studentsWithLastNameStartingWithBro = students.Where(x => x.LastName.StartsWith("Bro")).ToList();
            Console.WriteLine("Students with last name starting with Bro:");
            foreach (var student in studentsWithLastNameStartingWithBro)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            // Отримати список студентів, старших 19 років
            var studentsOlderThan19 = students.Where(x => x.Age > 19).ToList();
            Console.WriteLine("Students older than 19 years:");
            foreach (var student in studentsOlderThan19)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            // Отримати список студентів, старших 20 років і молодших 23 років
            var studentsBetween20And23 = students.Where(x => x.Age > 20 && x.Age < 23).ToList();
            Console.WriteLine("Students between 20 and 23 years:");
            foreach (var student in studentsBetween20And23)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            // Отримати список студентів, які навчаються в MIT
            var studentsFromMIT = students.Where(x => x.School == "MIT").ToList();
            Console.WriteLine("Students from MIT:");
            foreach (var student in studentsFromMIT)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine();

            // Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років. Результат відсортуйте за віком, за спаданням
            var studentsFromOxfordOlderThan18 = students
                .Where(x => x.School == "Oxford" && x.Age > 18)
                .OrderByDescending(x => x.Age)
                .ToList();
            Console.WriteLine("Students from Oxford older than 18 years (descending order):");
            foreach (var student in studentsFromOxfordOlderThan18)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " - Age: " + student.Age);
            }
            Console.WriteLine();
        }

    }
}
