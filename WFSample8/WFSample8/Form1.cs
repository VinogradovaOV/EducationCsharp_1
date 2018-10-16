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
    /// <summary>
    /// Форма создания вопросника
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // База данных с вопросами
        TrueFalse database;

        #region Кнопки  и numericUpDown

        // Обработчик события изменения значения numericUpDown
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }

        // Обработчик кнопки Добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count + 1).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        // Обработчик кнопки Удалить
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }      

        // Обработчик кнопки Сохранить (вопрос)
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }
        #endregion

        #region Меню

        // Обработчик пункта меню Новый
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }

        // Обработчик пункта меню Открыть
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            }
        }

        // Обработчик пункта меню Сохранить
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        //Обработчик меню Сохранить как
        private void miSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd1 = new SaveFileDialog();
            if (sfd1.ShowDialog() == DialogResult.OK)
            {
                database.FileName = sfd1.FileName;
                if (database != null) database.Save();
                else MessageBox.Show("База данных не создана");
            }
        }

        //Обработчик пункта меню О программе
        private void miProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Разработчик GeekBrains совместно с Виноградовой О.В.");
        }

        //Обработчик пункта меню Выход
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}

