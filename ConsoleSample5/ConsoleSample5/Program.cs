using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample5
{
    class Program
    {


        static void Main(string[] args)
        {
            //// Задача 1.Вывод логина без регулярных выражений IsLoginA
            ////и с регулярными выражениями IsLoginB
            //Login log = new Login();
            //Console.WriteLine(log.IsLoginA("AAAA2"));
            //Console.WriteLine(log.IsLoginB("dfhjdhf"));

            ////Задача 2. Статические методы для обработки текста
            //string path = @"text.txt";
            //string text = File.ReadAllText(path, Encoding.GetEncoding(1251));
            ////Выводит все слова длиной не более n
            //Console.WriteLine(Message.Word(2, text));
            //Console.WriteLine();
            ////Удаляет все слова оканчивающиеся на любой символ n
            //Console.WriteLine(Message.RemuveWord("я", text));
            //Console.WriteLine();
            ////Возвращает самое длинное слово в тексте
            //Console.WriteLine(Message.LongWord(text));
            //Console.WriteLine();
            ////Возвращает StringBuilder строку из самых длинных слов
            //Console.WriteLine(Message.BilderWord(text));
            //Console.WriteLine();

            ////Задача 3. Является ли строка перестановкой другой без учета регистра
            //Console.WriteLine(Anagram.AnagramWord("mamapopozuzu", "ompauzOmzapu"));
            //Console.WriteLine(Anagram.MyAnagramWord("mamapopozuzu", "ompauzOmzapu"));

            ////Задача 4. Вывести из текстогово файла имена учеников
            ////с тремя наихудшими результатами
            //string[] str = File.ReadAllLines("USE.txt", Encoding.GetEncoding(1251));
            //USE use = new USE(str);
            //use.Name();

            ////Задача 5. игра Верю-Неверю
            //Questions.QuestionGame();

            Console.ReadLine();
        }
    }
}
