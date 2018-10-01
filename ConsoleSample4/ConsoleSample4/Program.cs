using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleSample4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. Дан целочисленный массив из 20 элементов. 
            //Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. 
            //Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.

            OneDimArray oneArray = new OneDimArray(12);
            oneArray.Filling();
            Console.WriteLine("Задача 1. Вывести колличество пар элементов, в которых хотя бы одно число делится на 3");
            Console.WriteLine("Массив: " + oneArray.ArrToString());
            Console.WriteLine("Колличество пар: " + oneArray.Division(3));
            Console.WriteLine();

            //Задача 2.а)
            //Дописать класс для работы с одномерным массивом.
            //Реализовать конструктор, создающий массив определенного размера
            //и заполняющий массив числами от начального значения с заданным шагом.
            //Создать свойство Sum, которое возвращает сумму элементов массива,
            //Метод Inverse, меняющий знаки у всех элементов массива,
            //Метод Multi, умножающий каждый элемент массива на определённое число,
            //Свойство MaxCount, возвращающее количество максимальных элементов. 

            Console.WriteLine("Задача 2. а)");
            OneDimArray oneArray2 = new OneDimArray(5, 10, 2);
            Console.WriteLine("Массив с начальным значением и шагом: " + oneArray2.ArrToString());
            Console.WriteLine("Сумма элементов массива = " + oneArray2.Summ);
            Console.WriteLine("Смена знаков массива : " + oneArray2.Inverse().ArrToString());
            Console.WriteLine("Умножение на определенной число = " + oneArray2.Multi(-5).ArrToString());
            Console.WriteLine("Колличество максимальных элементов = " + oneArray2.MaxCount());
            Console.WriteLine();

            //б)*Добавить конструктор и методы, которые загружают данные из файла
            //и записывают данные в файл.

            ////Console.WriteLine("Задача 2. б)");
            //string Wr_path = @"..\ConsoleSample4\ConsoleSample4\InText.txt"; // путь к файлу на запись
            //string R_path = @"..\ConsoleSample4\ConsoleSample4\OutText.txt"; // путь к файлу на чтение
            //Console.WriteLine(R_path);
            //OneDimArray oneArray3 = new OneDimArray(R_path);
            //Console.WriteLine("Массив, полученный из файла: " + oneArray3.ArrToString());
            //Console.WriteLine();
            ////Запись массива в файл:
            //oneArray3.WriteToFile(Wr_path);

            //Задача 4.
            //*а)
            //Реализовать класс для  работы с двумерным массивом.
            //Реализовать конструктор, заполняющий массив случайными числами.
            //Создать методы, которые возвращают сумму всех элементов массива,
            //сумму всех элементов массива больше заданного,
            //cвойство, возвращающее минимальный элемент массива,
            //свойство, возвращающее максимальный элемент массива,
            //метод, возвращающий номер максимального элемента массива
            //(через параметры, используя модификатор ref или out).

            TwoDimArray twoArray = new TwoDimArray(4, 4, new Random(), 0, 9);
            Console.WriteLine("Задача 4.");
            Console.WriteLine("Двумерный массив со случайными значениями \n" + twoArray.ArrToString());
            Console.WriteLine("Сумма всех элементов массива = " + twoArray.Summ());
            Console.WriteLine("Сумма всех элементов, больше заданного = " + twoArray.Summ(1, 1));
            Console.WriteLine("Минимальный элемент массива = " + twoArray.Min);
            Console.WriteLine("Максимальный элемент массива = " + twoArray.Max);
            int row;
            int col;
            twoArray.MaxNum(out row, out col);
            Console.WriteLine("Номер максимального элемента [" + row + ", " + col + "]");
            Console.WriteLine();

            ////Запись массива в файл:
            //string Wr_path1 = @"...ConsoleSample4\ConsoleSample4\TwoInText.txt"; // путь к файлу на запись            
            //twoArray.WriteToFile(Wr_path1);
            ////Чтение из файла
            //string R_path1 = @"...ConsoleSample4\ConsoleSample4\TwoOutText.txt"; // путь к файлу для чтения
            //TwoDimArray twoArrayRead = new TwoDimArray(R_path1);
            //Console.WriteLine("Чтение из файла: \n" + twoArrayRead.ArrToString());


            //Задача 3. Считывание и запись логинов и паролей
            //Account user1 = new Account();
            //user1.login = "mama";
            //user1.password = "papa";
            //user1.CreateAccount(); // Создание нового аккаунта

            //Console.WriteLine("введите логин");
            //string log = Console.ReadLine();
            //Console.WriteLine("введите пароль");
            //string pass = Console.ReadLine();
            //if (user1.Chek(log, pass))
            //{
            //    Console.WriteLine("Добро пожаловать");
            //}
            //else
            //{ Console.WriteLine("Неверный логин или пароль"); }

            Console.ReadLine();
            
        }
    }
}
