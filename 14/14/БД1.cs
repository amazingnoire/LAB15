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
    public partial class БД1 : Form
    {

        OleDbDataAdapter adapter;
        DataSet dataset;

        public БД1()
        {
            InitializeComponent();
        }

        private void БД1_Load(object sender, EventArgs e)
        {
            adapter = new OleDbDataAdapter("Select * from Владельцы", new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + @"БД.mdb"));
            dataset = new DataSet();
            adapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }
    }
}
