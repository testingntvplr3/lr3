using System;
using System.Windows.Forms;
using Model;


namespace View
{
    public partial class AddObjectToForm : Form
    {
        public AddObjectToForm()
        {
            // Инициализация компонентов.
            InitializeComponent();

            // Если не был выбран режим Debug.
            #if !DEBUG
                buttonCRD.Visible = false;
            #endif
        }


        /// <summary>
        /// Метод нажатия на кнопку для генерации псевдослучайных значений.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCRD_Click(object sender, EventArgs e)
        {
            // Инициализация объекта для генерации псевдослучайных значений.
            Random rnd = new Random();

            // Для почасовой оплаты.
            if (radioButton1.Checked)
            {
                textBoxParam1.Text = Math.Round(rnd.NextDouble() * 1000 + 250, 2).ToString();
                textBoxParam2.Text = Math.Round(rnd.NextDouble() * 100 + 1, 0).ToString();
            }
            // Для оплаты по окладу и ставке.
            else
            {
                textBoxParam1.Text = Math.Round(rnd.NextDouble() * 50000 + 5000, 2).ToString();
                textBoxParam2.Text = Math.Round(rnd.NextDouble() * 25000 + 2500, 2).ToString();
            }
        }


        /// <summary>
        /// Метод добавления объекта в список объектов с отображением в таблице.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Owner;

            if (!Double.TryParse(textBoxParam1.Text, out double buf_S))
            {
                MessageBox.Show("Невозможно преобразовать строку в действительное число (S).",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (!Double.TryParse(textBoxParam2.Text, out double buf_I))
            {
                MessageBox.Show("Невозможно преобразовать строку в действительное число (I).",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (radioButton1.Checked)
            {
                try
                {
                    Hourly obj = new Hourly
                    {
                        S = buf_S,
                        I = buf_I
                    };
                
                    mainForm.lst_objs.Add(obj);
                    mainForm.dataGridView.Rows.Add(obj.Name(), obj.S.ToString(), obj.I.ToString());
                }
                catch (ArgumentException)
                {
                    _ = MessageBox.Show("Недопустимое значение (S > 0, I > 0).",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    RateSalary obj = new RateSalary
                    {
                        S = buf_S,
                        I = buf_I
                    };

                    mainForm.lst_objs.Add(obj);
                    mainForm.dataGridView.Rows.Add(obj.Name(), obj.S.ToString(), obj.I.ToString());
                }
                catch (ArgumentException)
                {
                    _ = MessageBox.Show("Недопустимое значение (S > 0, I > 0).",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            Close();
        }


        /// <summary>
        /// Метод закрытия формы добавления объекта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Метод выбора первого переключателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelParam1.Text = "Ставка в рублях за час:";
            labelParam2.Text = "Количество часов:";
        }


        /// <summary>
        /// Метод выбора второго переключателя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            labelParam1.Text = "Оклад в рублях:";
            labelParam2.Text = "Ставка в рублях:";
        }

        /// <summary>
        /// Метод при показе форме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddObjectToForm_Shown(object sender, EventArgs e)
        {
            // Вызов метода выбора первого переключателя.
            RadioButton1_CheckedChanged(sender, e);
        }
    }
}
