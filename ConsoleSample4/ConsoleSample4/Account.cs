using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleSample4
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 3. Структура Аккаунт
    /// </summary>
    public struct Account
    {
        public string login;
        public string password;

        string[] logs;
        string[] pass;    
         
        /// <summary>
        /// Метод считывания из файла
        /// </summary>
        void Inizialize()
        {
            logs = File.ReadAllText(@"..\ConsoleSample4\ConsoleSample4\Logins.txt").Split(' ');
            pass = File.ReadAllText(@"..\ConsoleSample4\ConsoleSample4\Passwords.txt").Split(' ');
        }

        /// <summary>
        /// Метод создания аккаунта и записи его в файл
        /// </summary>
        public void CreateAccount()
        {
            string path = @"..\ConsoleSample4\ConsoleSample4\Logins.txt";
            string path1 = @"..\ConsoleSample4\ConsoleSample4\Passwords.txt";

            if (login != null)
            {
                File.AppendAllText(path , " " + login);
            }
            if (password != null)
            {
                File.AppendAllText(path1, " " + password);
            }

            this.Inizialize();
        }

        /// <summary>
        /// Метод проверки аккаунта
        /// </summary>
        /// <param name="login">логин</param>
        /// <param name="password">пароль</param>
        /// <returns></returns>
        public bool Chek(string login, string password)
        {
            bool flag = true;
            for (int i = 0; i < logs.Length; i++)
            {
                if (login == logs[i])
                {
                    if (password == pass[i])
                    {
                        flag = false;                       
                    }
                }
            }
            if (flag)
                return false;
            else return true;
        }
    }
}
