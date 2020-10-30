using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1
    {
        /// Функция находит номер столбца с минимальным произведением
        public static void Znach(DataGridView table, out int outColumn, out int outComposition)
        {
            int proizMin=45735737, proiz,
                column = 1;

            outColumn = column;
            outComposition = 0;
            for (int i = 0; i < table.ColumnCount; i++)
            {
                // в начале внутреннего цикла сбрасываем произведение, т.к. я считаю его для каждого столбца
                proiz = 1;
                for (int j = 0; j < table.RowCount; j++)
                {
                    // проверка конвертации
                    if (Int32.TryParse((table[i, j].Value).ToString(), out int mr))
                    {
                        proiz *= mr;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка конвертации");
                        return;
                    }
                }

                // проверяем, меньше ли произведение текущего столбца чем предыдущее найденное минимально произведение
                if (proiz < proizMin)
                {
                    proizMin = proiz;
                    column = i + 1;
                }

            }

            // вывод конечного результата
            outColumn = column;
            outComposition = proizMin;
        }
    }
        }
    
