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
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
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
            string query = "Select pid as ID,pname as Name,passportno as PassportNo,paddress as Address,pnationality as Nationality,pgender as Gender,pphone as Phone from PassengerTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            passengergridview.DataSource = dataset.Tables[0];
            conn.Close();
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AddPassenger addPassenger = new AddPassenger();
            addPassenger.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(passengerId.Text == "")
            {
                MessageBox.Show("Enter the Passenger ID to delete.");
            }
            else
            {
                try
                {
                    conn.Open();
                    string query = "delete from PassengerTbl where pid = " + passengerId.Text + "";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Deleted Successfully");
                    conn.Close();
                    populate();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void passengergridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            passengerId.Text = passengergridview.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = passengergridview.SelectedRows[0].Cells[1].Value.ToString();
            passportNo.Text = passengergridview.SelectedRows[0].Cells[2].Value.ToString();
            address.Text = passengergridview.SelectedRows[0].Cells[3].Value.ToString();
            nationality.SelectedItem = passengergridview.SelectedRows[0].Cells[4].Value.ToString();
            gender.SelectedItem = passengergridview.SelectedRows[0].Cells[5].Value.ToString();
            phone.Text = passengergridview.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            passengerId.Clear();
            name.Clear();
            passportNo.Clear();
            address.Clear();
            nationality.SelectedIndex = 0;
            gender.SelectedIndex = 0;
            phone.Clear();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (passengerId.Text == "")
            {
                MessageBox.Show("Passenger ID is empty");
                passengerId.Focus();
            }
            else if (name.Text == "")
            {
                MessageBox.Show("Passenger Name is empty");
                name.Focus();
            }
            else if (passportNo.Text == "")
            {
                MessageBox.Show("Passport No is empty");
                passportNo.Focus();
            }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            else if (address.Text == "")
            {
                MessageBox.Show("Passenger Address is empty");
                address.Focus();
            }
#pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
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
                    string query = "update PassengerTbl set pname = '" + name.Text.Trim() + "',passportno = '" + passportNo.Text.Trim() + "',paddress = '" + address.Text.Trim() + "',pnationality = '" + nationality.SelectedItem.ToString() + "',pgender = '" + gender.SelectedItem.ToString() + "',pphone = " + phone.Text.Trim() + " where pid = " + passengerId.Text.Trim() + " ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");
                    conn.Close();
                    populate();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
#pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
        }
    }
}
