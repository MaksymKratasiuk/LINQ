using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{


    internal class Task1
    {
        public static void task1()
        {
            


            List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,14};

            Console.WriteLine("All Numbers:");
           
            Console.WriteLine(string.Join(" ", list));
            
            Console.WriteLine();





           // var evenNumbers = list.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Even Numbers:");
           
            Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 0).ToList()));

            // Отримати непарні цілі
            
            Console.WriteLine("Odd Numbers:");
            Console.WriteLine(string.Join(" ", list.Where(x => x % 2 != 0).ToList()));
            Console.WriteLine();



            int threshold = 5;
            // Отримати значення більше заданого
      
            Console.WriteLine("Numbers greater than " + threshold + ":");
            Console.WriteLine(string.Join(" ", list.Where(x => x > threshold).ToList()));

            Console.WriteLine();

            int minRange = 3;
            int maxRange = 8;
            // Отримати числа в заданому діапазоні
            
            Console.WriteLine("Numbers in the range [" + minRange + ", " + maxRange + "]:");
            Console.WriteLine(string.Join(" ", list.Where(x => x >= minRange && x <= maxRange).ToArray()));
            Console.WriteLine();

            // Отримати числа, кратні семи, відсортовані за зростанням
            
            Console.WriteLine("Multiples of seven (ascending order):");
            Console.WriteLine(string.Join(" ", list.Where(x => x % 7 == 0).OrderBy(x => x).ToArray()));
            Console.WriteLine();

            // Отримати числа, кратні восьми, відсортовані за спаданням
           
            Console.WriteLine("Multiples of eight (descending order):");
            Console.WriteLine(string.Join(" ", list.Where(x => x % 8 == 0).OrderByDescending(x => x).ToArray()));
            Console.WriteLine();

        }

    }
}
