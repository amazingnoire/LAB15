using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            StreamReader file = new StreamReader("Владельцы.txt");
            string s;
            s = file.ReadToEnd();
            string[] words = s.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            file.Close();

            StreamReader file2 = new StreamReader("Телефоны.txt");
            string s2;
            s2 = file2.ReadToEnd();
            string[] words2 = s2.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            file2.Close();

            for (int count = 0; count < (words.Length / 3)+1; count++)
            {
                if (count == 0) dataGridView1.Columns.Add("C1", "Фамилия");
                if (count == 1) dataGridView1.Columns.Add("C2", "Имя");
                if (count == 2) dataGridView1.Columns.Add("C3", "Отчество");
                if (count == 3) dataGridView1.Columns.Add("C3", "Телефон");
                if (count < 3)
                {
                    DataGridViewRow newR2 = new DataGridViewRow();
                    dataGridView1.Rows.Add(newR2);
                }
            }

            int x = 0;
            int y = 0;
            for (int count2 = 0; count2 < (words.Length / 3); count2++)
            {
                dataGridView1.Rows[count2].Cells[0].Value = words[x];
                dataGridView1.Rows[count2].Cells[1].Value = words[x + 1];
                dataGridView1.Rows[count2].Cells[2].Value = words[x + 2];
                dataGridView1.Rows[count2].Cells[3].Value = words2[y];
                x += 3;
                y++;
            }

        }
    }
}
