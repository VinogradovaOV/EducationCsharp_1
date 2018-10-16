using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WFSample8
{
    /// <summary>
    ///  Класс для хранения списка вопросов. 
    ///  А также для сериализации в XML и десериализации из XML
    /// </summary>
    class TrueFalse
    {
        string fileName;
        List<Question> list;

        public string FileName
        {
            set { fileName = value; }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="fileName">имя файла</param>
        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }

        /// <summary>
        /// Метод для добавления вопроса и ответа в список
        /// </summary>
        /// <param name="text">вопрос</param>
        /// <param name="trueFalse">ответ</param>
        public void Add(string text, bool trueFalse)
        {
            list.Add(new Question(text, trueFalse));
        }

        /// <summary>
        /// Метод для удаления записи из списка вопросов
        /// </summary>
        /// <param name="index">номер записи</param>
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get { return list[index]; }
        }

        /// <summary>
        /// Метод для сериализации
        /// </summary>
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }

        /// <summary>
        /// метод для десериализации
        /// </summary>
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            try
            {
                Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                try
                {
                    list = (List<Question>)xmlFormat.Deserialize(fStream);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ошибка:" + ex);
                    list = new List<Question>();
                    list.Add(new Question("Файл не открылся, попробуйте еще раз!", true));
                }
                fStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ошибка:" + ex);
                list = new List<Question>();
                list.Add(new Question("Файл не найден!!!", true));
            }
        }

        /// <summary>
        /// колличество элементов в списке
        /// </summary>
        public int Count
        {
            get { return list.Count; }
        }
    }
}
