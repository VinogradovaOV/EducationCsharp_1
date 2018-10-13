using System;
using System.Collections.Generic;
using System.IO;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSample6
{
    /// <summary>
    /// Виноградова О.В.
    /// Задача 3. Пример использования коллекций
    /// </summary>
    class ExampleList
    {
        List<Students> listStudent = new List<Students>();
        string[] stud = File.ReadAllLines("Students.csv", Encoding.GetEncoding(1251));

        /// <summary>
        /// Заполнение списка студентами
        /// </summary>
        public ExampleList()
        {
            for (int i = 0; i < stud.Length; i++)
            {
                string[] st = stud[i].Split(';');
                listStudent.Add(new Students(st[0], st[1], st[2], st[3], st[4],
                    int.Parse(st[5]), int.Parse(st[6]), int.Parse(st[7]), st[8]));
            }

        }

        /// <summary>
        /// колличество студентов на курсе
        /// </summary>
        /// <param name="n"> номер курса</param>
        /// <returns></returns>
        public int CountCourse(int n)
        {
            int summ = 0;
            foreach (var item in listStudent)
            {
                if (item.course == n) summ++;
            }
            return summ;
        }

        /// <summary>
        /// колличество студентов на курсе
        /// </summary>
        /// <param name="n">возраст</param>
        /// <returns></returns>
        public int CountAge(int n)
        {
            int summ = 0;
            foreach (var item in listStudent)
            {
                if (item.age == n) summ++;
            }
            return summ;
        }

        /// <summary>
        /// колличество студентов на курсе
        /// </summary>
        /// <param name="n"> номер группы</param>
        /// <returns></returns>
        public int CountGroup(int n)
        {
            int summ = 0;
            foreach (var item in listStudent)
            {
                if (item.group == n) summ++;
            }
            return summ;
        }

        /// <summary>
        /// сортировка по возрасту
        /// </summary>
        public List<Students> SortlistAge()
        {
            Students st;
            for (int i = 0; i < listStudent.Count - 1; i++)
            {
                for (int j = 0; j < listStudent.Count - 1; j++)
                {
                    if (listStudent[j].age > listStudent[j + 1].age)
                    {
                        st = listStudent[j];
                        listStudent[j] = listStudent[j + 1];
                        listStudent[j + 1] = st;
                    }
                }
            }
            return listStudent;
        }

        /// <summary>
        /// сортировка по курсу и возрасту
        /// </summary>
        public List<Students> sortListCourse()
        {
            listStudent = SortlistAge();

            Students st;
            for (int i = 0; i < listStudent.Count - 1; i++)
            {
                for (int j = 0; j < listStudent.Count - 1; j++)
                {
                    if (listStudent[j].course > listStudent[j + 1].course)
                    {
                        st = listStudent[j];
                        listStudent[j] = listStudent[j + 1];
                        listStudent[j + 1] = st;
                    }
                }
            }
            return listStudent;
        }

        /// <summary>
        /// частотный массив по курсу и возрасту через dictionary
        /// </summary>
        public Dictionary<int, int> Dict()
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            //Сортировка по курсу
            sortListCourse();

            for (int i = 0; i < listStudent.Count; i++)
            {
                    if (!dictionary.ContainsKey(listStudent[i].course))
                    {
                        dictionary.Add(listStudent[i].course, 0);
                    }

                if (listStudent[i].age >= 18 && listStudent[i].age <= 20)
                {
                    if (dictionary.ContainsKey(listStudent[i].course))
                    {
                        ++dictionary[listStudent[i].course];
                    }
                }
            }
            return dictionary;
        }

        /// <summary>
        /// Метод считающий колличество студентов по параметру через делегат
        /// </summary>
        /// <param name="CS">Метод int(int)</param>
        /// <param name="n">курс, возраст, группа</param>
        /// <returns></returns>
        public int Delegate(CountStudents CS, int n)
        {
           return CS(n);
        }
    }

    public delegate int CountStudents(int n);

}

