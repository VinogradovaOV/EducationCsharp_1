using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace ConsoleSample5
{  /// <summary>
   /// Виноградова О.В.
   /// Задача 1 а), б). 1. Создать программу, которая будет проверять корректность ввода логина. 
   /// Корректным логином будет строка от 2 до 10 символов, 
   /// содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
   /// а) без использования регулярных выражений;
   ///б) с использованием регулярных выражений.
   /// </summary>
    class Login
    {
        /// <summary>
        /// Метод для определения корректности ввода логина, а) без регулярных выражений
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns>true, если логин введен верно</returns>
        public bool IsLoginA(string login)
        {
           
            bool flag = false;
            if (login.Length <= 10 && login.Length >= 2 && !char.IsDigit(login[0]))
            {
                for (int i = 0; i < login.Length; i++)
                {
                    if (Char.IsLetterOrDigit(login[i]) && System.Convert.ToInt32(login[i]) <= 128)
                        flag = true;
                    else { flag = false; break; }
                }
            }
            return flag;
        }

        /// <summary>
        /// Метод для определения корректности ввода логина, б) с регулярными выражениями
        /// </summary>
        /// <param name="login">Логин</param>
        /// <returns>true, если логин введен верно</returns>
        public bool IsLoginB(string login)
        {
            string regular = @"\b[A-Za-z]{1}[A-Za-z0-9]{" + Length(login) + "}";
            Regex reg = new Regex(regular);

            return reg.IsMatch(login);
        }


        /// <summary>
        /// Метод для определения длины строки
        /// </summary>
        /// <param name="login">строка</param>
        /// <returns>длина строки - 1</returns>
        int Length(string login)
        {
            int a = 0;
            if (login.Length <= 10 && login.Length >= 2)
            {
                a = login.Length;
            }
            else { a = 0; }
            return (a-1);
        }

    }
}
