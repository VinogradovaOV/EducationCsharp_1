using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample6
{
    class Program
    {       
        static void Main(string[] args)
        {
            //Задача 1.
            Console.WriteLine("Задача 1/n"); 
            Function.Table(Function.Sin, 1, 5, 10);
           
            Console.WriteLine();

            //Задача 2.
            Console.WriteLine("Задача 2/n");
            MinFunction.Print();

            Console.WriteLine();

            // Задача 3.
            Console.WriteLine("Задача 3/n");

            ExampleList ls = new ExampleList();
            //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
            int n = ls.CountCourse(5) + ls.CountCourse(6);
            Console.WriteLine("количество студентов учащихся на 5 и 6 курсах = " + n);
            Console.WriteLine();
            //б) подсчитать сколько студентов в возрасте от 18 до 20 лет
            //на каком курсе учатся(частотный массив);
            foreach (var item in ls.Dict())
            {
                Console.WriteLine("курс: " + item.Key + " студентов: " + item.Value);
            }
            Console.WriteLine();
            //в) отсортировать список по возрасту студента;
            foreach (var item in ls.SortlistAge())
            {
                Console.WriteLine(item.lastname + " " + item.age);
            }
            Console.WriteLine();
            //г) *отсортировать список по курсу и возрасту студента;
            foreach (var item in ls.sortListCourse())
            {
                Console.WriteLine(item.lastname + " " + item.course + " " + item.age);
            }
            Console.WriteLine();
            //д) разработать единый метод подсчета количества студентов по различным параметрам
            // выбора с помощью делегата
            Console.WriteLine(ls.Delegate(ls.CountGroup, 200));

            Console.ReadLine();
        }
    }
    
}
