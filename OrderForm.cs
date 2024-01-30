using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Химчистка
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        
        DataSet set = new DataSet();
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\repos\ChimChi\Cleaner.mdf;Integrated Security=True");
        string command = (@"");     //команда для выбора заказов

        private void Zapolnenie(String table)
        {
            using (SqlDataAdapter adapter = new SqlDataAdapter(command, connection))
            {
                adapter.Fill(set, table);
                dataGridView1.DataSource = set.Tables[table];
                dataGridView1.Columns[0].ReadOnly = true;
                dataGridView1.Columns[1].ReadOnly = true;
                dataGridView1.Columns[2].ReadOnly = true;
                dataGridView1.Columns[3].ReadOnly = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
