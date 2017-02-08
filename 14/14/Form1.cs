using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace _14
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            //Example
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewTextBoxCell());
            newRow.Cells.Add(new DataGridViewTextBoxCell());
            newRow.Cells.Add(new DataGridViewTextBoxCell());
            dataGridView1.Rows.Add(newRow);
            dataGridView1.Rows[0].Cells[0].Value = "Чернышов";
            dataGridView1.Rows[0].Cells[1].Value = "Александр";
            dataGridView1.Rows[0].Cells[2].Value = "Алексеевич";

            DataGridViewRow newRow2 = new DataGridViewRow();
            newRow2.Cells.Add(new DataGridViewTextBoxCell());
            newRow2.Cells.Add(new DataGridViewTextBoxCell());
            newRow2.Cells.Add(new DataGridViewTextBoxCell());
            dataGridView1.Rows.Add(newRow2);
            dataGridView1.Rows[1].Cells[0].Value = "Крылов";
            dataGridView1.Rows[1].Cells[1].Value = "Максим";
            dataGridView1.Rows[1].Cells[2].Value = "Григорьевич";

            //Ex1
            int n = 5;
            string[] links = new string[n];
            links[0] = "https://vk.com/rogue_noire";
            links[1] = "https://vk.com/veronikaustinova";
            links[2] = "https://vk.com/avoiddance";
            links[3] = "https://vk.com/skripka.tomsk";
            links[4] = "https://vk.com/id13254872";

            for (int ir = 0; ir < n; ir++)
            {
                DataGridViewRow newR = new DataGridViewRow();
                newR.Cells.Add(new DataGridViewButtonCell());
                newR.Cells.Add(new DataGridViewCheckBoxCell());
                newR.Cells.Add(new DataGridViewComboBoxCell());
                newR.Cells.Add(new DataGridViewImageCell());
                newR.Height = 100;
                Image i = Image.FromFile((ir + 1) + ".jpg");
                newR.Cells.Add(new DataGridViewLinkCell());
                newR.Cells.Add(new DataGridViewTextBoxCell());

                dataGridView2.Rows.Add(newR);
                dataGridView2.Rows[ir].Cells[0].Value = "Button " + (ir+1);
                dataGridView2.Rows[ir].Cells[1].Value = true;
                DataGridViewComboBoxCell comboCell = (DataGridViewComboBoxCell)dataGridView2.Rows[ir].Cells[2];
                for(int ic=0;ic< n;ic++) comboCell.Items.Add("Value " + (ic + 1));
                dataGridView2.Rows[ir].Cells[2].Value = "Value " + (ir + 1);
                dataGridView2.Rows[ir].Cells[3].Value = i;
                dataGridView2.Rows[ir].Cells[4].Value = links[ir];
                dataGridView2.Rows[ir].Cells[5].Value = "Text" + (ir + 1);
            }


            //Ex2
            StreamReader file = new StreamReader("Владельцы.txt");
            string s;
            s = file.ReadToEnd();
            string[] words = s.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            file.Close();

            for (int count=0;count<(words.Length/3); count++)
            {
                DataGridViewRow newR2 = new DataGridViewRow();
                dataGridView3.Rows.Add(newR2);
            }

            int x = 0;
            for (int count2 = 0; count2 < (words.Length / 3); count2++)
            {
                dataGridView3.Rows[count2].Cells[0].Value = words[x];
                dataGridView3.Rows[count2].Cells[1].Value = words[x + 1];
                dataGridView3.Rows[count2].Cells[2].Value = words[x + 2];
                x += 3;
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                    if (e.ColumnIndex == 0 && e.RowIndex == j)
                {
                        string button = dataGridView2[0, j].Value.ToString();
                        MessageBox.Show("Вы нажали кнопку " + button);
                }
                    if (e.ColumnIndex == 3 && e.RowIndex == j)
                    {
                        Process.Start("mspaint.exe", (j+1)+".jpg");
                    }
                    if (e.ColumnIndex == 4 && e.RowIndex == j)
                    {
                        string link = dataGridView2[4, j].Value.ToString();
                        Process.Start("chrome.exe", link);
                    }
            }
        }
    }
}
