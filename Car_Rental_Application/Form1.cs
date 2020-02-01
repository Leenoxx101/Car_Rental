using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CustomerName = cus_name.Text;
                double Cost = Convert.ToDouble(cost.Text);
                var DateRented = Rental_Date.Value;
                var DateReturned = Return_Date.Value;

                //Use the keyword var to declare a more simple generic variable
                //whose data type is determined by the value being assigned

                var TypeOfCar = Type_Of_Car.Text;

                //Adding validation to the form

                var isValid = true;

                if (string.IsNullOrEmpty(CustomerName)
                     || DateRented == null
                     || string.IsNullOrEmpty(TypeOfCar))

                {
                    isValid = false;
                    MessageBox.Show("Incomplete Application");
                }

                if (DateRented > DateReturned)

                {
                    isValid = false;
                    MessageBox.Show("Invaild Date Entered for Return Date");

                    //
                    if (isValid);
                }
                MessageBox.Show($"Customer Name: {CustomerName}\n\r" +
                    $"Cost: {Cost}\n\r" +
                    $"Date Rented: {DateRented}\n\r +" +
                    $"Date Return: {DateReturned}\n\r +" +
                    $"Type of Car: {TypeOfCar}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
            
              
             
        }
    }
}
