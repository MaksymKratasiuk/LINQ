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
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();



            var evenNumbers = list.Where(x => x % 2 == 0).ToList();
            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Отримати непарні цілі
            var oddNumbers = list.Where(x => x % 2 != 0).ToList();
            Console.WriteLine("Odd Numbers:");
            foreach (var number in oddNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();



            int threshold = 5;
            // Отримати значення більше заданого
            var greaterThanThreshold = list.Where(x => x > threshold).ToList();
            Console.WriteLine("Numbers greater than " + threshold + ":");
            foreach (var number in greaterThanThreshold)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            int minRange = 3;
            int maxRange = 8;
            // Отримати числа в заданому діапазоні
            var numbersInRange = list.Where(x => x >= minRange && x <= maxRange).ToArray();
            Console.WriteLine("Numbers in the range [" + minRange + ", " + maxRange + "]:");
            foreach (var number in numbersInRange)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Отримати числа, кратні семи, відсортовані за зростанням
            var multiplesOfSeven = list.Where(x => x % 7 == 0).OrderBy(x => x).ToArray();
            Console.WriteLine("Multiples of seven (ascending order):");
            foreach (var number in multiplesOfSeven)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Отримати числа, кратні восьми, відсортовані за спаданням
            var multiplesOfEight = list.Where(x => x % 8 == 0).OrderByDescending(x => x).ToArray();
            Console.WriteLine("Multiples of eight (descending order):");
            foreach (var number in multiplesOfEight)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

        }

    }
}
