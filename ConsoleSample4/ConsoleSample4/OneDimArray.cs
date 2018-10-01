using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleSample4
{
    /// <summary>
    ///Виноградова О.В.
    /// Задача 1, 2. Класс для работы с одномерным массивом
    /// </summary>
    class OneDimArray
    {
        int[] arr;
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        /// <summary>
        /// Свойство возвращающее сумму элементов массива
        /// </summary>
        /// <returns>сумма элементов массива</returns>
        public int Summ
        {
            get { return arr.Sum(); }
        }

        /// <summary>
        /// Свойство определения длины массива
        /// </summary>
        /// <returns>длина массива</returns>
        public int Lenght
        {
            get { return arr.Length; }
        }
        
        /// <summary>
        /// конструктор массива
        /// </summary>
        /// <param name="elem">колличество элементов массива</param>
        public OneDimArray(int elem)
        {
            arr = new int[elem];
        }

        /// <summary>
        /// конструктор массива с начальным значением и шагом
        /// </summary>
        /// <param name="elem">колличество элементов массива</param>
        /// <param name="start">начальное значение</param>
        /// <param name="step">шаг</param>
        public OneDimArray(int elem, int start, int step)
        {
            arr = new int[elem];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = start + i * step;
            }
        }

        /// <summary>
        /// Конструктор массива со случайными значениями
        /// </summary>
        /// <param name="elem">колличество элементов массива</param>
        /// <param name="rnd">генератор случайных чисел</param>
        /// <param name="rand1">нижняя граница случайных чисел</param>
        /// <param name="rand2">верхняя гранца случайных чисел</param>
        public OneDimArray(int elem, Random rnd, int rand1, int rand2)
        {
            arr = new int[elem];           
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(rand1, rand2);
            }
        }

        /// <summary>
        /// Конструктор массива, который получает значения из файла
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public OneDimArray(string path)
        {
            try
            {
                string str = File.ReadAllText(path);
                string[] elem = str.Split(' ');
                arr = new int[elem.Length];
                for (int i = 0; i < elem.Length; i++)
                {
                    arr[i] = Int32.Parse(elem[i]);
                }
            }
            catch { Console.WriteLine("Неверно указан путь для чтения"); }
        }

        /// <summary>
        /// Метод заполнения массива значениями номера элемента
        /// </summary>
        public void Filling()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
        }

        /// <summary>
        /// Метод вычисления колличества пар делящихся на num 
        /// </summary>
        /// <param name="num">делитель</param>
        /// <returns></returns>
        public int Division(int num)
        { 
            int summ = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % num == 0 || arr[i + 1] % num == 0)
                {
                    summ++;
                }
            }           

            return summ;
        }       

        /// <summary>
        /// Метод инверсирующий значения массива
        /// </summary>
        /// <returns>массив с инверсными значениями</returns>
        public OneDimArray Inverse()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= -1;
            }
            return this;
        }

        /// <summary>
        /// Метод перемножающий элементы массива на factor
        /// </summary>
        /// <param name="factor">множитель</param>
        /// <returns>произведение массива на множитель</returns>
        public OneDimArray Multi(int factor)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= factor;
            }
            return this;
        }

        /// <summary>
        /// Метод возвращающий колличество максимальных элементов в массиве
        /// </summary>
        /// <returns>число максимальных элементов в массиве</returns>
        public int MaxCount()
        {
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr.Max())
                    maxCount++;
            }
            return maxCount;
        }
        
        /// <summary>
        /// Метод записи массива в файл
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public void WriteToFile(string path)
        {
            try
            {
                File.WriteAllText(path, this.ArrToString());
            }
            catch { Console.WriteLine("Неверно указан путь для записи"); }
        }

        /// <summary>
        /// Метод представляющий массив в виде строки
        /// </summary>
        /// <returns>строка элементов массива</returns>
        public string ArrToString()
        {
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str = str + arr[i] + " ";
            }
            return str;
        }
        
    }
}
