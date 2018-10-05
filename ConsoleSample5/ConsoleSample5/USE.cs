using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleSample5
{
    /// <summary>
    /// Виноградова О.В.
    /// 4. Задача ЕГЭ.
    /// </summary>

    class USE
    {
        string[] str;
        int N;
        Students[] Student;  
        
        /// <summary>
        /// конструктор экземпляра класса
        /// </summary>
        /// <param name="path">путь к тексту (Фамилия Имя 1 2 3)</param>
        public USE(string[] path)
        {
            str = path;
            N = Convert.ToInt32(str[0]);
            Student = new Students[N];
        }

        public void Name()
        {
            InfoStudenys();

            MinMidle();

            PrintStudent();
        }

        /// <summary>
        /// метод для вывода на печать студентов с тремя наименьшими средними баллами
        /// </summary>
        private void PrintStudent()
        {
            int j = 1;
            Console.WriteLine(Student[0].FIO + " " + Student[0].Midle);
            for (int i = 1; i < N; i++)
            {
                Console.WriteLine(Student[i].FIO + " " + Student[i].Midle);
                if (Student[i].Midle != Student[i - 1].Midle)
                {
                    j++;
                    if (j == 3) break;
                }
            }
        }

        /// <summary>
        /// Метод для сортировки студентов по наименьшему среднему баллу
        /// </summary>
        private void MinMidle()
        {
            Students st;
            for (int k = 0; k < N; k++)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    if (Student[i].Midle > Student[i + 1].Midle)
                    {
                        st = Student[i];
                        Student[i] = Student[i + 1];
                        Student[i + 1] = st;
                    }
                }
            }
        }

        /// <summary>
        /// Метод заполнения массива структур Студент - средний балл
        /// </summary>
        private void InfoStudenys()
        {
            for (int i = 1; i <= N; i++)
            {
                string[] info = str[i].Split(' ');
                Student[i - 1].FIO = info[0] + " " + info[1];
                Student[i - 1].Midle = Math.Round((Convert.ToDouble(info[2]) + Convert.ToDouble(info[3])
                    + Convert.ToDouble(info[4])) / 3, 2);
            }
        }
    }

    /// <summary>
    /// Структура для хранения информации о студентах
    /// </summary>
    struct Students
    {
        /// <summary>
        /// ФИО студента
        /// </summary>
        public string FIO;

        /// <summary>
        /// Средний балл студента
        /// </summary>
        public double Midle;
    }
}
