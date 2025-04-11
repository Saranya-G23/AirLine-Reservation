using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FlightBtn_Click(object sender, EventArgs e)
        {
            FlightTbl flightTbl = new FlightTbl();
            flightTbl.Show();
            this.Hide();
        }

        private void PassengerBtn_Click(object sender, EventArgs e)
        {
            AddPassenger addPassenger = new AddPassenger();
            addPassenger.Show();
            this.Hide();
        }

        private void TicketsBtn_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket();
            ticket.Show();
            this.Hide();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancellationTbl cancellationTbl = new CancellationTbl();
            cancellationTbl.Show();
            this.Hide();
        }
    }
}
