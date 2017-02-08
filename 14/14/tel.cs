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
    public partial class tel : Form
    {
        public tel()
        {
            InitializeComponent();
        }

        private void tel_Load(object sender, EventArgs e)
        {
            string conn_param = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"БД.mdb";
            OleDbConnection connection = new OleDbConnection(conn_param);
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "select Телефон from Владельцы";
            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            int i = 0;

            try
            {
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetValue(0));
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
