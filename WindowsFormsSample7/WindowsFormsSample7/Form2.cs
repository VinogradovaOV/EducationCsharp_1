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
    /// 2. Используя Windows Forms, разработать игру «Угадай число». 
    /// Компьютер загадывает число от 1 до 100, 
    /// а человек пытается его угадать за минимальное число попыток. 
    /// Для ввода данных от человека используется элемент TextBox.
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Num();
        }

        #region Параметры
        /// <summary>
        /// Случайное число
        /// </summary>
        int num = 0;
        /// <summary>
        /// Число введенное пользователем
        /// </summary>
        int entNum;
        /// <summary>
        /// Колличество попыток
        /// </summary>
        int count = 0;
        #endregion

        #region Кнопки
        /// <summary>
        /// Кнопка Ввод
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterNumbtn_Click(object sender, EventArgs e)
        {
            entNum = int.Parse(txbEnterNum.Text);

            if (entNum < num) lblCompare.Text = "Ваше число меньше";
            if (entNum > num) lblCompare.Text = "Ваше число больше";
            if (entNum == num) lblCompare.Text = "равно!!!";
            count++;
            lblCountTry.Text = count.ToString();
        }
       
        /// <summary>
        /// кнопка Обновить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {
            num = new Random().Next(1, 101);
            count = 0;
            lblCountTry.Text = count.ToString();
            txbEnterNum.Text = string.Empty;
            lblCompare.Text = string.Empty;
        }
        #endregion

        /// <summary>
        /// Метод получения случайного числа
        /// </summary>
        public void Num()
        {
            num = new Random().Next(1, 101);
        }

    }
}
