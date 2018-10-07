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
    /// Задача 4. Написать класс для работы с двумерным массивом
    /// </summary>
    class TwoDimArray
    {
        int[,] arr;
        
        public int this[int i, int j]
        {
            get { return arr[i, j]; }
            set { arr[i, j] = value; }
        }

        /// <summary>
        /// Свойство, возвращающее минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] < min) min = arr[i, j];
                    }
                }
                return min;
            }
        }

        /// <summary>
        /// Свойство, возвращающее максимальный элемент массива
        /// </summary>
        public int Max
        {
            get
            {
                int max = arr[0, 0];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        if (arr[i, j] > max) max = arr[i, j];
                    }
                }
                return max;
            }
        }

        /// <summary>
        /// Конструктор двумерного массива со случайными значениями
        /// </summary>
        /// <param name="elem">колличество элементов массива</param>
        /// <param name="rnd">генератор случайных чисел</param>
        /// <param name="rand1">нижняя граница случайных чисел</param>
        /// <param name="rand2">верхняя гранца случайных чисел</param>
        public TwoDimArray(int rows, int collumns, Random rnd, int rand1, int rand2)
        {
            arr = new int[rows, collumns];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(rand1, rand2);
                }
            }
        }

        /// <summary>
        /// Конструктор, считывающий значения из файла с разделителем ','
        /// </summary>
        /// <param name="path">путь к файлу</param>
        public TwoDimArray(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                arr = new int[lines.Length, lines[0].Split(',').Length - 1];
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] column = lines[i].Split(',');
                    for (int j = 0; j < column.Length - 1; j++)
                        arr[i, j] = Int32.Parse(column[j]);
                }
            }
            catch { Console.WriteLine("Неверно указан путь для чтения"); }
        }

        /// <summary>
        /// Метод, возвращающий сумму элементов двумерного массива
        /// </summary>
        /// <returns>сумма элементов двумерного массива</returns>
        public int Summ()
        {
            int summ = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    summ += arr[i, j];
                }
            }
            return summ;
        }

        /// <summary>
        /// Метод, возвращающий сумму элементов массива больше заданного
        /// </summary>
        /// <param name="row">номер заданного элемента в строке</param>
        /// <param name="col">номер заданного элемента в столбце</param>
        /// <returns>сумма элементов больше заданного</returns>
        public int Summ(int row, int col)
        {
            int summ = 0;
            for (int i = row; i < arr.GetLength(0); i++)
            {
                for (int j = col; j < arr.GetLength(1); j++)
                {
                    summ += arr[i, j];
                }
            }
            return summ;
        }

        /// <summary>
        /// Метод, возвращающий номер максимального элемента в двумерном массиве
        /// </summary>
        /// <param name="row">номер элемента в строке</param>
        /// <param name="col">номер элемента в столбце</param>
        public void MaxNum(out int row, out int col)
        {
            int max = arr[0, 0];
            row = 0;
            col = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                        row = i;
                        col = j;
                    }
                }
            }
            
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
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    str = str + arr[i, j] + " ";
                }
                str = str + "\n";
            }
            return str;
        }

    }
}
