using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChimChi;

namespace Химчистка
{
    public partial class NewOrder : Form
    {
        /*
        ClassSQL data = new ClassSQL();
        public NewOrder()
        {
            InitializeComponent();
            
        }
        */
        public bool DataVerification()
        {
            if (txtSurname != null || txtName != null || txtPatronymic != null || txtNumber != null)
            {
                if (radioButton2.Checked)
                {
                    if (txtCity != null || txtStreet != null || txtHouse != null || txtApartment != null) 
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void AddProduct()
        {
            /*
            string surname, name, patronymic, number;
            string city, street, house, apartment;
            bool radio = radioButton1.Checked;
            int id = 0;
            if (DataVerification())
            {
                surname = txtSurname.Text;
                name = txtName.Text;
                patronymic = txtPatronymic.Text;
                number = txtNumber.Text;
                if (radioButton2.Checked)
                {
                    city = txtCity.Text;
                    street = txtStreet.Text;
                    house = txtHouse.Text;
                    apartment = txtApartment.Text;
                    id = data.AddOrder(surname, name, patronymic, number, radio, city, street, house, apartment);
                }
                else
                {
                    id = data.AddOrder(surname, name, patronymic, number, radio, "", "", "", "");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
                id = 0;
                return id;
            }
            return id;
        }

        private void btAddOrder_Click_1(object sender, EventArgs e)
        {
            if (AddProduct() != 0)
            {
                MessageBox.Show("Данные успешно записаны");
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
