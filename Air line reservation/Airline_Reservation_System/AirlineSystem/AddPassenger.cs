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

namespace AirlineSystem
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AirlineDB;Integrated Security=True");
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void recordBtn_Click(object sender, EventArgs e)
        {
            if (idpassenger.Text == "")
            {
                MessageBox.Show("Passenger ID is empty");
                idpassenger.Focus();
            }
            else if (passengerName.Text == "")
            {
                MessageBox.Show("Passenger Name is empty");
                passengerName.Focus();
            }
            else if(passportNo.Text == "")
            {
                MessageBox.Show("Passport No is empty");
                passportNo.Focus();
            }
            else if (passengerAddress.Text == "")
            {
                MessageBox.Show("Passenger Address is empty");
                passengerAddress.Focus();
            }
            else if (nationality.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Nationality");
                nationality.Focus();
            }
            else if (gender.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Gender");
                gender.Focus();
            }
            else if (phone.Text == "")
            {
                MessageBox.Show("Phone No is empty");
                phone.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into PassengerTbl values("+ idpassenger.Text.Trim() +", '" + passengerName.Text.Trim() + "','"+ passportNo.Text.Trim()+"','" + passengerAddress.Text.Trim() + "','" + nationality.SelectedItem.ToString() + "','" + gender.SelectedItem.ToString() + "'," + phone.Text.Trim() + ")";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recordered Successfully");
                    conn.Close(); 
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            idpassenger.Clear();
            passengerName.Clear();
            passportNo.Clear();
            passengerAddress.Clear();
            nationality.SelectedIndex = 0;
            gender.SelectedIndex = 0;
            phone.Clear();
        }

        private void viewPassengerBtn_Click(object sender, EventArgs e)
        {
            ViewPassenger viewPassenger = new ViewPassenger();
            viewPassenger.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
