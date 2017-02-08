using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _14
{
    public partial class БД2 : Form
    {
        public БД2()
        {
            InitializeComponent();
        }

        private void БД2_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Kod", "Код");
            dataGridView1.Columns.Add("Sername", "Фамилия");
            dataGridView1.Columns.Add("Name", "Имя");
            dataGridView1.Columns.Add("Secondname", "Отчество");
            dataGridView1.Columns.Add("Cod_ul", "Код_улицы");
            dataGridView1.Columns.Add("n_dom", "Номер_дома");
            dataGridView1.Columns.Add("dr_n", "Дробная_часть_номера");
            dataGridView1.Columns.Add("tel", "Телефон");

            //В качестве провайдера для СУБД ACCESS также можно

            //задать значение Microsoft.Jet.OLEDB.4.0;

            string conn_param = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"БД.mdb";
            OleDbConnection connection = new OleDbConnection(conn_param);
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "select * from Владельцы";
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            int i = 0;

            try
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add();

                    for (int i2 = 0; i2 < 8; i2++) dataGridView1[i2, i].Value = reader.GetValue(i2);

                    ++i;
                }
            }

            finally
            {
                reader.Close();
                connection.Close();
            }
        }
    }
}
