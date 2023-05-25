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
            Console.WriteLine("All Students:");
            Console.WriteLine(string.Join(" ", students));
            Console.WriteLine();

            // Отримати список студентів з ім'ям Boris
            
            Console.WriteLine("Students with first name Boris:");
            Console.WriteLine(string.Join(" ", students.Where(x => x.FirstName == "Boris").ToList()));
            Console.WriteLine();

            // Отримати список студентів з прізвищем, яке починається з Bro
           
            Console.WriteLine("Students with last name starting with Bro:");
            Console.WriteLine(string.Join(" ", students.Where(x => x.LastName.StartsWith("Bro")).ToList()));
            Console.WriteLine();

            // Отримати список студентів, старших 19 років
           
            Console.WriteLine("Students older than 19 years:");
            Console.WriteLine(string.Join(" ", students.Where(x => x.Age > 19).ToList()));
            Console.WriteLine();

            // Отримати список студентів, старших 20 років і молодших 23 років
            
            Console.WriteLine("Students between 20 and 23 years:");
            Console.WriteLine(string.Join(" ", students.Where(x => x.Age > 20 && x.Age < 23).ToList()));
            Console.WriteLine();

            // Отримати список студентів, які навчаються в MIT
           
            Console.WriteLine("Students from MIT:");
            Console.WriteLine(string.Join(" ", students.Where(x => x.School == "MIT").ToList()));
            Console.WriteLine();

            // Отримати список студентів, які навчаються в Oxford, і вік яких старше 18 років. Результат відсортуйте за віком, за спаданням
            
            Console.WriteLine("Students from Oxford older than 18 years (descending order):");
            Console.WriteLine(string.Join(" ", students
                                                .Where(x => x.School == "Oxford" && x.Age > 18)
                                                .OrderByDescending(x => x.Age)
                                                .ToList()));
            Console.WriteLine();
        }

    }
}
