using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibMas;
using ClassLibrary1;

namespace Практическая_работа_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //О программе
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Ефимкина Марина ИСП-31. Вариант №5:" +
                "Дана матрица размера M × N.Найти номер ее столбца с наименьшим произведением элементов и вывести" +
                "данный номер, а также значение наименьшего произведения. ");
        }

        //Выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Открыть
        private void открытьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibMas.Class1.OpenFile(DataGridView);
        }

        //Сохранить
        private void сохранитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibMas.Class1.SaveFile(DataGridView);
        }

        //Рассчитать
        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int column,
                composition;
            ClassLibrary1.Class1.Znach(DataGridView, out column, out composition);
            textBox1.Text= column.ToString();
            textBox2.Text = composition.ToString();
        }

        //Заполнить
        private void заполнитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibMas.Class1.Fill(DataGridView, Convert.ToInt32(diapazon.Value));
        }

        //Очистить
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibMas.Class1.Clear(DataGridView);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridView.ColumnCount = 4;
            DataGridView.RowCount = 3;
        }

        //изменяем кол-во строк
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            DataGridView.RowCount = Convert.ToInt32(numericUpDown2.Value);
        }

        //изменяем кол-во столбцов
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            DataGridView.ColumnCount = Convert.ToInt32(numericUpDown1.Value);
        }

    }
}
