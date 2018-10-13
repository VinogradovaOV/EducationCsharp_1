using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample6
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 1. Переделать функцию, чтобы она принимала делегат double(double, double)
    /// </summary>  
    class Function
    {
        /// <summary>
        /// Метод для вывода таблицы значений функции
        /// </summary>
        /// <param name="F">функция</param>
        /// <param name="x">yначальное значение x</param>
        /// <param name="a">параметр а/param>
        /// <param name="b">конечное значение x</param>
        public static void Table(Fun F, double x, double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
                x++;
            }
        }

        /// <summary>
        /// квадрат числа
        /// </summary>
        /// <param name="a">параметр</param>
        /// <param name="x">число</param>
        /// <returns></returns>
        public static double Sqrt(double a, double x)
        {
            return a * x * x;
        }

        /// <summary>
        /// Синус числа
        /// </summary>
        /// <param name="a">параметр</param>
        /// <param name="x">число</param>
        /// <returns></returns>
        public static double Sin(double a, double x)
        {
            return a * Math.Sin(x);
        }
    }

    public delegate double Fun(double a, double x);
}
