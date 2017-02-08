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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            StreamReader file2 = new StreamReader("Телефоны.txt");
            string s2;
            s2 = file2.ReadToEnd();
            string[] words2 = s2.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            file2.Close();

            Item[] stuff = new Item[words2.Length];
            for(int i=0;i < words2.Length;i++) stuff[i] = new Item(words2[i]);

            dataGridView1.DataSource = stuff;
        }

        public class Item
        {
            public Item(string text)
            {
                _text = text;
            }
            public string Text
            {
                get { return _text; }
            }
            private string _text;
        }
    }
}
