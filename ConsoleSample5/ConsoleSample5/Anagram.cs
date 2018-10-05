using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample5
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 3. 3. *Для двух строк написать метод, определяющий,
    /// является ли одна строка перестановкой другой. Регистр можно не учитывать
    /// </summary>
    class Anagram
    {
        /// <summary>
        /// Метод, определяющий является ли одна строка перестановкой другой без учета регистра
        /// а) с использованием методов C#
        /// </summary>
        /// <param name="str1">первая строка</param>
        /// <param name="str2">вторая строка</param>
        /// <returns>true, если является перестановкой</returns>
        public static bool AnagramWord(string str1, string str2)
        {
            int i = -1;
            if (str1.Length == str2.Length)
            {
                char[] arr1 = str1.ToLower().ToCharArray();
                char[] arr2 = str2.ToLower().ToCharArray();
                Array.Sort(arr1);
                Array.Sort(arr2);
                str1 = new string(arr1);
                str2 = new string(arr2);
                i = String.Compare(str1, str2);
            }
            return (i == 0);
        }

        /// <summary>
        /// Метод, определяющий является ли одна строка перестановкой другой без учета регистра
        /// б) *разработав собственный алгоритм.
        /// </summary>
        /// <param name="str1">первая строка</param>
        /// <param name="str2">вторая строка</param>
        /// <returns>true, если является перестановкой</returns>

        public static bool MyAnagramWord(string str1, string str2)
        {
            bool flag = false;
            if (str1.Length == str2.Length)
            {
                str1 = str1.ToLower();
                str2 = str2.ToLower();
                for (int i = 0; i < str1.Length; i++)
                {
                    for (int j = 0; j < str2.Length; j++)
                    {
                        if (str2[j] == str1[i])
                        {
                            str1 = str1.Remove(str1.IndexOf(str1[i]), 1);
                            str2 = str2.Remove(str2.IndexOf(str2[j]), 1);
                            j = str2.Length;
                            i = -1;
                        }
                    }
                }
                if (str1.Length == 0 && str2.Length == 0)
                    flag = true;
            }
            return flag;
        }
    }
}
