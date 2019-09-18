using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsPract
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arList = new ArrayList();
            int ArListSize = 10;
            int avg = 0;
            Random random = new Random();
            for(int i = 0; i < ArListSize; i++)
            {
                arList.Add(random.Next(0, 100));
            }
            Console.WriteLine("Содержимое списка: ");
            foreach (int number in arList)
            {
                Console.Write(number + "  ");
                avg += number;
            }
            avg /= arList.Count;
            Console.WriteLine("\nЭлементы значение которых больше среднего значения коллекции: ");
            foreach (int number in arList)
            {
                if (number > avg)
                Console.Write(number + "  ");
            }
            for (int i = 0; i < arList.Count; i++)
            {
                if ((Math.Abs((int)arList[i])) % 2 == 1)
                {
                    arList.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine("\nСодержимое после удаления нечетных элементов: ");
            foreach (int number in arList)
            {
                Console.Write(number + "  ");
            }
            Console.ReadKey();
        }
    }
}
