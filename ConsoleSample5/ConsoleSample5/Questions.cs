using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleSample5
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 5. *** Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ,
    /// правда это или нет.
    /// </summary>
    class Questions
    {
        /// <summary>
        /// Игра верю-неверю.
        /// Ответы в оригинальном тексте были заключены в скобки.
        /// От них зависит правильная работа регулярных выражений!
        /// </summary>
        static public void QuestionGame()
        {
            string[] str = File.ReadAllLines(@"question.txt", Encoding.GetEncoding(1251));
            int sum = 0;

            Regex regY = new Regex(@"[(]Да[)]$");
            Regex regN = new Regex(@"[(]Нет[)]$");

            Console.WriteLine("Ответьте - Да, Нет");

            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                int j = rnd.Next(0, str.Length);

                if (regY.Match(str[j]).Length != 0)
                    Console.WriteLine(str[j].Remove(regY.Match(str[j]).Index, 
                        regY.Match(str[j]).Length));
                if (regN.Match(str[j]).Length != 0)
                    Console.WriteLine(str[j].Remove(regN.Match(str[j]).Index, 
                        regN.Match(str[j]).Length));

                string answer = Console.ReadLine();
                if ("(" + answer + ")" == regY.Match(str[j]).ToString() ||
                    "(" + answer + ")" == regN.Match(str[j]).ToString())
                {
                    Console.WriteLine("Правильный ответ!");
                    sum += 1;
                }
                else Console.WriteLine("Неверно!");
            }

            Console.WriteLine("Игра окончена! Баллы = " + sum);
        }
    }
}
