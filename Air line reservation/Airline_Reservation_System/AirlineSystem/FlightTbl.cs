using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSystem
{
    public partial class FlightTbl : Form
    {
        public FlightTbl()
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
            if (flightCode.Text == "")
            {
                MessageBox.Show("Flight Code is empty");
                flightCode.Focus();
            }
            else if (source.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Source");
                source.Focus();
            }
            else if (destination.SelectedIndex == 0)
            {
                MessageBox.Show("Please Choose Destination");
                destination.Focus();
            }
            else if (takeofDate.Text == "")
            {
                MessageBox.Show("Please Choose Date");
                takeofDate.Focus();
            }
            else if (noofseats.Text == "")
            {
                MessageBox.Show("Please Fill Seats");
                noofseats.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into FlightTbl values('" + flightCode.Text.Trim() + "' ,'" + source.SelectedItem.ToString() + "','" + destination.SelectedItem.ToString() + "','"+ takeofDate.Text +"'," + noofseats.Text.Trim() + ")";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recordered Successfully");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                } 
            }
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            flightCode.Clear();
            source.SelectedIndex = 0;
            destination.SelectedIndex = 0;
            takeofDate.Text = "";
            noofseats.Clear();
        }

        private void viewFlightsBtn_Click(object sender, EventArgs e)
        {
            ViewFlights viewFlights = new ViewFlights();
            viewFlights.Show();
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
