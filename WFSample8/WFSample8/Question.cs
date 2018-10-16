
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
namespace WFSample8
{
    /// <summary>
    ///   Класс для вопросов и ответов 
    /// </summary>
    [Serializable]
    public class Question
    {
        private string text;       // Текст вопроса
        private bool trueFalse;// Правда или нет

        public string Text { get => text; set => text = value; }
        public bool TrueFalse { get => trueFalse; set => trueFalse = value; }

        public Question()
        {
        }

        public Question(string text, bool trueFalse)
        {
            this.text = text;
            this.trueFalse = trueFalse;
        }

        #region Блок создания xml файла Вопросов из txt

        /// <summary>
        /// Считывание из txt и сохранение в Xml
        /// </summary>
        static public void QuestionSave()
        {
            string[] str = File.ReadAllLines(@"question.txt", Encoding.GetEncoding(1251));
            
            List<Question> list = new List<Question>();

            Regex regY = new Regex(@"[(]Да[)]$");
            Regex regN = new Regex(@"[(]Нет[)]$");

            for (int j = 0; j < str.Length; j++)
            {
                if (regY.Match(str[j]).Length != 0)
                    list.Add(new Question(str[j].Remove(regY.Match(str[j]).Index,
                        regY.Match(str[j]).Length), true));
                if (regN.Match(str[j]).Length != 0)
                    list.Add(new Question(str[j].Remove(regN.Match(str[j]).Index,
                        regN.Match(str[j]).Length), false));
            }

            Save(list);
            
        }

        /// <summary>
        /// сохранение в Xml
        /// </summary>
        /// <param name="list">Список вопросов</param>
        public static void Save(List<Question> list)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream("Questins.xml", FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        #endregion

    }

}

