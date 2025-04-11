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
using System.Xml.Linq;

namespace AirlineSystem
{
    public partial class CancellationTbl : Form
    {
        public CancellationTbl()
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
            string query = "select Cid as 'Cancel ID',Tid as 'Ticket ID',Fcode as 'Flight Code',Cdate as 'Cancel Date' from CancelTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            TicketCancelgridview.DataSource = dataset.Tables[0];
            conn.Close();
        }
        private void fillTickedID()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select Tid from TicketTbl", conn);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Tid", typeof(string));
            dataTable.Load(sqlDataReader);
            ticketID.ValueMember = "Tid";
            ticketID.DataSource = dataTable;
            conn.Close();
        }
        private void fetchfcode()
        {
            conn.Open();
            string query = "select * from TicketTbl where Tid = " + ticketID.SelectedValue + " ";
            SqlCommand cmd = new SqlCommand(query, conn);
            DataTable dateTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dateTable);
            foreach (DataRow dr in dateTable.Rows)
            {
                flightcode.Text = dr["Fcode"].ToString();
            }
            conn.Close();
        }
        private void CancellationTbl_Load(object sender, EventArgs e)
        {
            fillTickedID();
            fetchfcode();
            populate();
        }

        private void ticketID_SelectedIndexChanged(object sender, EventArgs e)
        {
            fetchfcode();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            cancelId.Clear();
            flightcode.Clear();
            date.Text = "";
            ticketID.SelectedIndex = 0;
        }
        private void deleteTicket()
        {
            try
            {
                conn.Open();
                string query = "delete from TicketTbl where Tid = '" + ticketID.SelectedValue.ToString() + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (cancelId.Text == "")
            {
                MessageBox.Show("Cancel ID is empty");
                ticketID.Focus();
            }
            else if (ticketID.SelectedIndex == -1)
            {
                MessageBox.Show("Choose Ticket ID");
                ticketID.Focus();
            }
            else if (flightcode.Text == "")
            {
                MessageBox.Show("Please fill Flight Code");
                flightcode.Focus();
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "insert into CancelTbl values(" + cancelId.Text.Trim().ToString() + "," + ticketID.SelectedValue.ToString() + ",'" + flightcode.Text.Trim().ToString() + "','" + date.Text.Trim().ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Cancelled Successfully");
                    conn.Close();
                    populate();
                    deleteTicket();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
