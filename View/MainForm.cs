using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using Model;


namespace View
{
    public partial class MainForm : Form
    {
       // Список объектов.
       public List<Calc> lst_objs = new List<Calc>();
        

       public MainForm()
       {
            // Инициализация компонентов.
            InitializeComponent();

            // Вывод названий столбцов в таблице.
            dataGridView.Columns.AddRange
                (
                    new DataGridViewTextBoxColumn()
                    {
                        Name = "Object", 
                        HeaderText = "Object", 
                        DataPropertyName = "Object"
                    },

                    new DataGridViewTextBoxColumn()
                    {
                        Name = "S", 
                        HeaderText = "S", 
                        DataPropertyName = "S"
                    },

                    new DataGridViewTextBoxColumn() 
                    {
                        Name = "I",
                        HeaderText = "I",
                        DataPropertyName = "I" 
                    }
                 );

            // Текущие рабочие каталоги.
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            saveFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
        }


        /// <summary>
        /// Метод открытия формы для добавления нового объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddObjectToForm addShapeForm = new AddObjectToForm();
            addShapeForm.Show(this); 
        }


        /// <summary>
        /// Метод удаления объекта из таблицы и списка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.RowCount == 0)
            {
                MessageBox.Show("Внимание! Нет строк для удаления.",
                    "Сообщение программы", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }               
                
            int indx = dataGridView.CurrentRow.Index;
            lst_objs.RemoveAt(indx);

            dataGridView.Rows.RemoveAt(indx);
            dataGridView.Refresh();
        }


        /// <summary>
        /// Метод вызова сериализации по нажатию кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Serialization.Serializer(saveFileDialog.FileName, lst_objs);
                    MessageBox.Show("Данные успешно сохранены в файл: " + saveFileDialog.FileName.ToString(),
                        "Сообщение программы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл " + saveFileDialog.FileName.ToString() + " не найден.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }          
        }


        /// <summary>
        /// Метод вызова десериализация по нажатию кнопки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    lst_objs = Serialization.Deserializer(openFileDialog.FileName);
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Файл " + openFileDialog.FileName.ToString() + " не найден.",
                        "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dataGridView.Rows.Clear();

            foreach (Calc obj in lst_objs)
                dataGridView.Rows.Add(obj.Name(), obj.S.ToString(), obj.I.ToString());
        }


        /// <summary>
        /// Метод открытия формы для поиска объекта в списке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            searchForm.Show(this);
        }
    }
}
