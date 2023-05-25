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
            foreach (var city in allCities)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();



            int nameLength = 6;
            // Отримати міста з довжиною назви, що дорівнює заданому
            var citiesWithNameLength = cities.Where(x => x.Length == nameLength).ToList();
            Console.WriteLine("Cities with name length equal to " + nameLength + ":");
            foreach (var city in citiesWithNameLength)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();



            // Отримати міста, назви яких починаються з літери A
            var citiesStartingWithA = cities.Where(x => x.StartsWith("A")).ToList();
            Console.WriteLine("Cities starting with letter A:");
            foreach (var city in citiesStartingWithA)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();



            // Отримати міста, назви яких закінчуються літерою M
            var citiesEndingWithM = cities.Where(x => x.EndsWith("m")).ToList();
            Console.WriteLine("Cities ending with letter M:");
            foreach (var city in citiesEndingWithM)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();



            // Отримати міста, назви яких починаються з літери N і закінчуються літерою K
            var citiesStartingWithNAndEndingWithK = cities.Where(x => x.StartsWith("N") && x.EndsWith("k")).ToList();
            Console.WriteLine("Cities starting with letter N and ending with letter K:");
            foreach (var city in citiesStartingWithNAndEndingWithK)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();

            // Отримати міста, назви яких починаються з Ne. Результат відсортувати за спаданням
            var citiesStartingWithNeDescending = cities.Where(x => x.StartsWith("Ne")).OrderByDescending(x => x).ToList();
            Console.WriteLine("Cities starting with 'Ne' (descending order):");
            foreach (var city in citiesStartingWithNeDescending)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();
        }
    }
}
