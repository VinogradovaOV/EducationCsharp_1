using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSample7
{
    /// <summary>
    /// 1. а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
    ///б) Добавить меню и команду «Играть». 
    ///При нажатии появляется сообщение, какое число должен получить игрок.
    ///Игрок должен постараться получить это число за минимальное количество ходов.
    ///в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Параметры        
        /// <summary>
        /// Число, которое надо получить
        /// </summary>
        int thisNum;
        /// <summary>
        /// Полученное число
        /// </summary>
        int num = 0;
        /// <summary>
        /// колличество отданных команд
        /// </summary>
        int count = 0;
        /// <summary>
        /// Вспомогательная переменная для отмены хода
        /// </summary>
        int cansel;
        #endregion

        #region Кнопки
        /// <summary>
        /// кнопка +1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            cansel = num;
            num = int.Parse(lblNum.Text) + 1;
            lblNum.Text = num.ToString();
            count++;
            Summ();
        }

        /// <summary>
        /// кнопка *2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMult_Click(object sender, EventArgs e)
        {
            cansel = num;
            num = int.Parse(lblNum.Text) * 2;
            lblNum.Text = num.ToString();
            count++;
            Summ();
        }

        /// <summary>
        /// Кнопка Сброс, начать игру с начала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        /// <summary>
        /// Кнопка Играть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, EventArgs e)
        {
            thisNum = new Random().Next(1, 21);
            lblThisNum.Text = thisNum.ToString();
        }

        /// <summary>
        /// кнопка Отмена последнего хода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCansel_Click(object sender, EventArgs e)
        {
            num = cansel;
            lblNum.Text = num.ToString();
        }

        #endregion

        #region Меню
        /// <summary>
        /// Дублирование кнопки Играть в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thisNum = new Random().Next(1, 21);
            lblThisNum.Text = thisNum.ToString();
        }

        /// <summary>
        /// Дублирование кнопки Отмена в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            num = cansel;
            lblNum.Text = num.ToString();
        }

        /// <summary>
        /// Дублирование кнопки Сброс в меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion

        /// <summary>
        /// метод Сброс, для обнуления игры
        /// </summary>
        public void Reset()
        {
            count = 0;
            cansel = 0;
            num = 0;
            lblThisNum.Text = num.ToString();
            lblNum.Text = num.ToString();
        }      

        /// <summary>
        /// Проверка на совпадение чисел
        /// </summary>
        public void Summ()
        {
            if (num != 0 && thisNum != 0)
            {
                if (num == thisNum)
                {
                    MessageBox.Show("Победа! Число ходов:" + count);
                    Reset();
                }
            }
        }
    }
}
