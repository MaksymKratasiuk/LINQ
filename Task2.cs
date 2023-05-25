using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Task2
    {
        public static void task2()
        {
            List<string> cities = new List<string> { "London", "Paris", "New York", "Tokyo", "Amsterdam", "Berlin", "Madrid" };

            // Отримати весь масив міст
            var allCities = cities.ToList();
            Console.WriteLine("All Cities:");
            Console.WriteLine(string.Join(" ",cities));
            Console.WriteLine();



            int nameLength = 6;
            // Отримати міста з довжиною назви, що дорівнює заданому
           
            Console.WriteLine("Cities with name length equal to " + nameLength + ":");
            Console.WriteLine(string.Join(" ", cities.Where(x => x.Length == nameLength).ToList()));
            Console.WriteLine();



            // Отримати міста, назви яких починаються з літери A
           
            Console.WriteLine("Cities starting with letter A:");
            Console.WriteLine(string.Join(" ", cities.Where(x => x.StartsWith("A")).ToList()));
            Console.WriteLine();



            // Отримати міста, назви яких закінчуються літерою M
            
            Console.WriteLine("Cities ending with letter M:");
            Console.WriteLine(string.Join(" ", cities.Where(x => x.EndsWith("m")).ToList()));
            Console.WriteLine();



            // Отримати міста, назви яких починаються з літери N і закінчуються літерою K
            
            Console.WriteLine("Cities starting with letter N and ending with letter K:");
            Console.WriteLine(string.Join(" ", cities.Where(x => x.StartsWith("N") && x.EndsWith("k")).ToList()));
            Console.WriteLine();

            // Отримати міста, назви яких починаються з Ne. Результат відсортувати за спаданням
           
            Console.WriteLine("Cities starting with 'Ne' (descending order):");
            Console.WriteLine(string.Join(" ", cities.Where(x => x.StartsWith("Ne")).OrderByDescending(x => x).ToList()));
            Console.WriteLine();
        }
    }
}
