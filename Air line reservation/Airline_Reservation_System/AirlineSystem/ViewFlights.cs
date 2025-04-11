using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AirlineSystem
{
    public partial class ViewFlights : Form
    {
        public ViewFlights()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AirlineDB;Integrated Security=True");
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            conn.Open();
            string query = "Select Fcode as 'Flight Code',Fsrc as Source,Fdest as Destination,Fdate as 'Take of Date',Fseats as 'No.of Seats' from FlightTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            viewFlightsgridview.DataSource = dataset.Tables[0];
            conn.Close();
        }

        private void ViewFlights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            FlightTbl flightTbl = new FlightTbl();
            flightTbl.Show();
            this.Hide();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            flightCode.Clear();
            source.SelectedIndex = 0;
            destination.SelectedIndex = 0;
            takeofDate.Text = "";
            noofseats.Clear();
        }

        private void viewFlightsgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            flightCode.Text = viewFlightsgridview.SelectedRows[0].Cells[0].Value.ToString();
            source.SelectedItem = viewFlightsgridview.SelectedRows[0].Cells[1].Value.ToString();
            destination.SelectedItem = viewFlightsgridview.SelectedRows[0].Cells[2].Value.ToString();
            takeofDate.Text = viewFlightsgridview.SelectedRows[0].Cells[3].Value.ToString();
            noofseats.Text = viewFlightsgridview.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (flightCode.Text == "")
            {
                MessageBox.Show("Enter Flight to delete.");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from FlightTbl where Fcode = '" + flightCode.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flights Deleted Successfully");
                    conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
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
            else if (noofseats.Text == "")
            {
                MessageBox.Show("No of Seats is empty");
                noofseats.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "update FlightTbl set Fsrc = '" + source.SelectedItem.ToString() + "',Fdest = '" + destination.SelectedItem + "',Fdate = '" + takeofDate.Text.ToString() + "',Fseats = " + noofseats.Text.Trim() + " where Fcode = '" + flightCode.Text.Trim() + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flights Updated Successfully");
                    conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

       
    }
}
