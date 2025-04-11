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
    public partial class Ticket : Form
    {
        public Ticket()
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
            string query = "Select Tid as 'Ticket ID',Fcode as 'Flight Code',Pname as 'Passenger Name',Pnationality as Nationality,Ppassport as 'Passport No',Tamount as 'Ticket Amount' from TicketTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            ticketbookinggridview.DataSource = dataset.Tables[0];
            conn.Close();
        }
        private void fillPassenger()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select pid from PassengerTbl",conn);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("pid", typeof(int));
            dataTable.Load(sqlDataReader);
            passengerId.ValueMember = "pid";
            passengerId.DataSource = dataTable;
            conn.Close();   
        }
        private void fillFlightCode()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl", conn);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Fcode", typeof(string));
            dataTable.Load(sqlDataReader);
            flightCode.ValueMember = "Fcode";
            flightCode.DataSource = dataTable;
            conn.Close();
        }

        string pname, ppass, pnat;
        private void fetchpassenger()
        {
            conn.Open();
            string query = "select * from PassengerTbl where pid = " + passengerId.SelectedValue + " ";
            SqlCommand cmd = new SqlCommand(query,conn);
            DataTable dateTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dateTable);
            foreach(DataRow dr in dateTable.Rows)
            {
                pname = dr["pname"].ToString();
                ppass = dr["passportno"].ToString();
                pnat = dr["pnationality"].ToString(); 

                name.Text = pname;
                passport.Text = ppass;
                nationality.Text = pnat;
            }
            conn.Close();
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            if (ticketID.Text == "")
            {
                MessageBox.Show("Ticket ID is empty");
                ticketID.Focus();
            }
            else if (flightCode.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose Flight Code");
                flightCode.Focus();
            }
            else if (passengerId.SelectedIndex == -1)
            {
                MessageBox.Show("Please Choose Passenger ID");
                passengerId.Focus();
            }
            else if (name.Text == "")
            {
                MessageBox.Show("Name is empty");
                name.Focus();
            }
            else if (passport.Text == "")
            {
                MessageBox.Show("Passport No is empty");
                passport.Focus();
            }
            else if (nationality.Text == "")
            {
                MessageBox.Show("Nationality is empty");
                nationality.Focus();
            }
            else if (amount.Text == "")
            {
                MessageBox.Show("Amount is empty");
                amount.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into TicketTbl values(" + ticketID.Text.Trim().ToString() + ",'"+ flightCode.SelectedValue.ToString()+"',"+ passengerId.SelectedValue.ToString() +",'"+ name.Text.Trim().ToString()+ "','"+ nationality.Text.Trim().ToString()+"','" + passport.Text.Trim().ToString() +"',"+ amount.Text.Trim().ToString() +")";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    conn.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ticketID.Clear();
            flightCode.SelectedIndex = 0;
            passengerId.SelectedIndex = 0;
            name.Clear();
            passport.Clear();
            nationality.Clear();
            amount.Clear(); 
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fetchpassenger();
            fillFlightCode();
            populate();
        }

        private void passengerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchpassenger();
        }
    }
}
