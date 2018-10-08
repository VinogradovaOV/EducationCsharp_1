using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample6
{
    public delegate double Func(double x, double a = 1);
    /// <summary>
    /// Виноградова О.В.
    /// Задача 2.Модифицировать программу нахождения минимума функции так,
    /// чтобы можно было передавать функцию в виде делегата
    /// </summary>
    class MinFunction
    {
        /// <summary>
        /// Меню общения с пользователем, вывод минимума функции
        /// </summary>
        public static void Print()
        {
            double start;
            double end;
            double h;
            Console.WriteLine("Выберите функцию: 0 - Sqrtx, 1 - Cubex, 2 - Sinx, 3 - Cosx");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите через пробел начало отрезка, конец отрезка и шаг");
            string str = Console.ReadLine();
            string[] st = str.Split(' ');
            start = int.Parse(st[0]);
            end = int.Parse(st[1]);
            h = int.Parse(st[2]);

            //массив делегатов
            Func[] delegates = new Func[4];
            delegates[0] = new Func(Sqrt);
            delegates[1] = new Func(Cube);
            delegates[2] = new Func(Sin);
            delegates[3] = new Func(Cos);

            Console.WriteLine("Минимум функции = " + PrintFun(delegates[num], start, end, h));
        }

        /// <summary>
        /// Минимум функции
        /// </summary>
        /// <param name="f">функция</param>
        /// <param name="start">начальное значение</param>
        /// <param name="end">конечное значение</param>
        /// <param name="h">шаг</param>
        /// <returns>минимум</returns>
        public static double PrintFun(Func f, double start, double end, double h)
        {
            double min = double.MaxValue;
            while(start<=end)
            {
                if (f(start) < min) min = f(start);
                start += h;
            }
            return min;
        }

        /// <summary>
        /// квадрат числа
        /// </summary>
        /// <param name="a">параметр</param>
        /// <param name="x">число</param>
        /// <returns></returns>
        public static double Sqrt(double x, double a = 1)
        {
            return a * x * x;
        }

        /// <summary>
        /// Синус числа
        /// </summary>
        /// <param name="a">параметр</param>
        /// <param name="x">число</param>
        /// <returns></returns>
        public static double Sin(double x, double a = 1)
        {
            return a * Math.Sin(x);
        }

        /// <summary>
        /// куб числа
        /// </summary>
        /// <param name="a">параметр</param>
        /// <param name="x">число</param>
        /// <returns></returns>
        public static double Cube(double x, double a = 1)
        {
            return a * x * x*x;
        }

        /// <summary>
        /// Косинус числа
        /// </summary>
        /// <param name="a">параметр</param>
        /// <param name="x">число</param>
        /// <returns></returns>
        public static double Cos(double x, double a = 1)
        {
            return a * Math.Cos(x);
        }
    }

}
