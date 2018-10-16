using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSample8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        // База данных с вопросами
        TrueFalse database;

        #region Кнопки и numericUpDown

        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
        }

        //Обработчик кнопки Да
        private void btnYes_Click(object sender, EventArgs e)
        {
            if (database[(int)nudNumber.Value - 1].TrueFalse == true)
            {
                Correct("Правильно!!!");
            }
            else Correct("Неправильно!!!");
        }

        //Обработчик кнопки Нет
        private void btnNo_Click(object sender, EventArgs e)
        {
            if (database[(int)nudNumber.Value - 1].TrueFalse == false)
            {
                Correct("Правильно!!!");
            }
            else Correct("Неправильно!!!");
        }

        #endregion

        #region Меню

        //Обработчик пункта меню Играть
        private void PlayMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile("Resources\\Questins.xml");
        }

        //Обработчик пункта меню Открыть
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenFile(ofd.FileName);
            }
        }

        //Обработчик пункта меню Выход
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion


        /// <summary>
        /// Метод открытия файла
        /// </summary>
        /// <param name="fileName">имя файла</param>
        private void OpenFile(string fileName)
        {
            database = new TrueFalse(fileName);
            database.Load();
            nudNumber.Minimum = 1;
            nudNumber.Maximum = database.Count;
            nudNumber.Value = 1;
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
        }

        /// <summary>
        /// Метод ответа правильно-неправильно, игра окончена
        /// </summary>
        /// <param name="answer"></param>
        private void Correct(string answer)
        {
            MessageBox.Show(answer);

            if (nudNumber.Value < database.Count)
                nudNumber.Value = (int)nudNumber.Value + 1;
            else MessageBox.Show("Игра окончена!");
        }
    }
}
