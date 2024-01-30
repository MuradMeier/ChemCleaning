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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\murad\source\repos\Химчистка\Cleaner.mdf;Integrated Security=True") ;
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT Role FROM Login WHERE Username='{txtLogin.Text}' AND Password='{txtPass.Text}'", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            { 
                object[] login = table.Rows[0].ItemArray;
                  
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Логин или пароль неверен");
                txtLogin.Text = "";
                txtPass.Text = "";
                txtLogin.Focus();
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
