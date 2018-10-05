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
    /// Задача 2. Разработать класс Message, 
    /// содержащий следующие статические методы для обработки текста:
    /// </summary>
    class Message
    {
        /// <summary>
        /// Метод, возвращающий все слова в сообщении не больше n длиной
        /// </summary>
        /// <param name="n">максимальная длина слова</param>
        /// <param name="text">текст</param>
        /// <returns>тект из слов длиной не больше n</returns>
        static public string Word(int n, string text)
        {
            string str = String.Empty;
            string regular = "\\b\\w{1," + n + "}\\b";
            Regex reg = new Regex(@regular);

            for (int i = 0; i < reg.Matches(text).Count; i++)
            {
                str += reg.Matches(text)[i] + " ";
            }
            return str;
        }

        /// <summary>
        /// Метод, удаляет из текста слова оканчивающиеся на символ n
        /// </summary>
        /// <param name="n">любой символ</param>
        /// <param name="text">текст</param>
        /// <returns>отформатированный текст</returns>
        static public string RemuveWord(string n, string text)
        {
            string str = text;
            //выделяет слово (оканчивающееся на букву)
            string regular = "(\\b\\w{0,}[" + n + "]{1}\\b)";
            Regex reg = new Regex(@regular);
            if (reg.Matches(text).Count == 0)
            {
                //или(на любой символ)
                regular = "(\\w{1,}[" + n + "])";
                reg = new Regex(@regular);
            }

            for (int i = 0; i < reg.Matches(text).Count; i++)
            {
                str = str.Replace(reg.Matches(text)[i].Value, "");
            }
            return str;
        }

        /// <summary>
        /// Метод, возвращает самое длинное слово в тексте
        /// </summary>
        /// <param name="text">текст</param>
        /// <returns>самое длинное слово</returns>
        static public string LongWord(string text)
        {
            string[] arr = TextArray(text);

            string str = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > str.Length)
                    str = arr[i];
            }
            return str;
        }

        /// <summary>
        /// Метод, возвращает строку из самых длинных слов
        /// </summary>
        /// <param name="text">текст</param>
        /// <returns>строка типа StringBuilder</returns>
        static public StringBuilder BilderWord(string text)
        {
            StringBuilder sb = new StringBuilder();
            string[] arr = TextArray(text);
            int len = LongWord(text).Length;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == len)
                    sb.Append(arr[i] + " ");
            }
            return sb;
        }

        /// <summary>
        /// Метод, возвращает массив слов без знаков пунктуации
        /// </summary>
        /// <param name="text">текст</param>
        /// <returns>массив слов</returns>
        static string[] TextArray(string text)
        {
            string[] arr = text.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                if (Char.IsPunctuation(arr[i], arr[i].Length - 1))
                {
                    arr[i] = arr[i].Remove(arr[i].Length - 1);
                }
            }
            return arr;
        }

    }
}
