using System;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            // Инициализация компонентов.
            InitializeComponent();
        }


        /// <summary>
        /// Метод запуска поиска.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRunSearch1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;

            // Очистка списка.
            listBox1.Items.Clear();

            // Флаг найденного объекта.
            bool is_searched = false;

            // Поиск объектов в списке.
            foreach (Calc obj in mainForm.lst_objs)
                // Если объект был найден.
                if (obj.S.ToString() == textBoxParam1.Text)
                {
                    // Добавить имя объекта в список.
                    listBox1.Items.Add(obj.Name());

                    // Установить флаг.
                    is_searched = true;
                }

            // Если объекты не были найдены.
            if (!is_searched)
                MessageBox.Show("Объекты не были найдены.",
                    "Сообщение программы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonRunSearch2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;

            // Очистка списка.
            listBox1.Items.Clear();

            // Флаг найденного объекта.
            bool is_searched = false;

            // Поиск объектов в списке.
            foreach (Calc obj in mainForm.lst_objs)
                // Если объект был найден.
                if (obj.I.ToString() == textBoxParam2.Text)
                {
                    // Добавить имя объекта в список.
                    listBox1.Items.Add(obj.Name());

                    // Установить флаг.
                    is_searched = true;
                }

            // Если объекты не были найдены.
            if (!is_searched)
                MessageBox.Show("Объекты не были найдены.",
                    "Сообщение программы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
