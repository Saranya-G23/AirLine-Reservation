namespace AirlineSystem
{
    partial class Ticket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.exit = new System.Windows.Forms.Label();
            this.flightCode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.amount = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passport = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nationality = new Guna.UI2.WinForms.Guna2TextBox();
            this.passengerId = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketbookinggridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.backBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.resetBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.bookBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookinggridview)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(943, 8);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 34);
            this.exit.TabIndex = 90;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // flightCode
            // 
            this.flightCode.BackColor = System.Drawing.Color.Transparent;
            this.flightCode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.flightCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flightCode.FocusedColor = System.Drawing.Color.Navy;
            this.flightCode.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.flightCode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.flightCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.flightCode.ItemHeight = 30;
            this.flightCode.Location = new System.Drawing.Point(657, 129);
            this.flightCode.Name = "flightCode";
            this.flightCode.Size = new System.Drawing.Size(243, 36);
            this.flightCode.TabIndex = 2;
            // 
            // amount
            // 
            this.amount.Animated = true;
            this.amount.AutoRoundedCorners = true;
            this.amount.BackColor = System.Drawing.Color.Transparent;
            this.amount.BorderRadius = 19;
            this.amount.BorderThickness = 2;
            this.amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount.CustomizableEdges.BottomLeft = false;
            this.amount.CustomizableEdges.BottomRight = false;
            this.amount.CustomizableEdges.TopLeft = false;
            this.amount.CustomizableEdges.TopRight = false;
            this.amount.DefaultText = "";
            this.amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.amount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.amount.Location = new System.Drawing.Point(505, 311);
            this.amount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.amount.Name = "amount";
            this.amount.PasswordChar = '\0';
            this.amount.PlaceholderText = "";
            this.amount.SelectedText = "";
            this.amount.Size = new System.Drawing.Size(243, 40);
            this.amount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.amount.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(369, 324);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 27);
            this.label9.TabIndex = 81;
            this.label9.Text = "Amount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(495, 265);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 27);
            this.label7.TabIndex = 79;
            this.label7.Text = "Passport";
            // 
            // name
            // 
            this.name.Animated = true;
            this.name.AutoRoundedCorners = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.BorderRadius = 19;
            this.name.BorderThickness = 2;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.CustomizableEdges.BottomLeft = false;
            this.name.CustomizableEdges.BottomRight = false;
            this.name.CustomizableEdges.TopLeft = false;
            this.name.CustomizableEdges.TopRight = false;
            this.name.DefaultText = "";
            this.name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.name.Location = new System.Drawing.Point(657, 189);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "";
            this.name.SelectedText = "";
            this.name.Size = new System.Drawing.Size(243, 40);
            this.name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.name.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(500, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 27);
            this.label6.TabIndex = 77;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(65, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 27);
            this.label5.TabIndex = 75;
            this.label5.Text = "Passenger ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(500, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 73;
            this.label2.Text = "Flight Code";
            // 
            // ticketID
            // 
            this.ticketID.Animated = true;
            this.ticketID.AutoRoundedCorners = true;
            this.ticketID.BackColor = System.Drawing.Color.Transparent;
            this.ticketID.BorderRadius = 19;
            this.ticketID.BorderThickness = 2;
            this.ticketID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ticketID.CustomizableEdges.BottomLeft = false;
            this.ticketID.CustomizableEdges.BottomRight = false;
            this.ticketID.CustomizableEdges.TopLeft = false;
            this.ticketID.CustomizableEdges.TopRight = false;
            this.ticketID.DefaultText = "";
            this.ticketID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ticketID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ticketID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ticketID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ticketID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketID.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.ticketID.Location = new System.Drawing.Point(227, 125);
            this.ticketID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ticketID.Name = "ticketID";
            this.ticketID.PasswordChar = '\0';
            this.ticketID.PlaceholderText = "";
            this.ticketID.SelectedText = "";
            this.ticketID.Size = new System.Drawing.Size(243, 40);
            this.ticketID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ticketID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(65, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 27);
            this.label4.TabIndex = 71;
            this.label4.Text = "Ticket ID";
            // 
            // passport
            // 
            this.passport.Animated = true;
            this.passport.AutoRoundedCorners = true;
            this.passport.BackColor = System.Drawing.Color.Transparent;
            this.passport.BorderRadius = 19;
            this.passport.BorderThickness = 2;
            this.passport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passport.CustomizableEdges.BottomLeft = false;
            this.passport.CustomizableEdges.BottomRight = false;
            this.passport.CustomizableEdges.TopLeft = false;
            this.passport.CustomizableEdges.TopRight = false;
            this.passport.DefaultText = "";
            this.passport.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passport.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passport.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.passport.Location = new System.Drawing.Point(657, 261);
            this.passport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passport.Name = "passport";
            this.passport.PasswordChar = '\0';
            this.passport.PlaceholderText = "";
            this.passport.SelectedText = "";
            this.passport.Size = new System.Drawing.Size(243, 40);
            this.passport.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passport.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(449, 443);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 27);
            this.label11.TabIndex = 93;
            this.label11.Text = "Bookings";
            // 
            // nationality
            // 
            this.nationality.Animated = true;
            this.nationality.AutoRoundedCorners = true;
            this.nationality.BackColor = System.Drawing.Color.Transparent;
            this.nationality.BorderRadius = 19;
            this.nationality.BorderThickness = 2;
            this.nationality.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nationality.CustomizableEdges.BottomLeft = false;
            this.nationality.CustomizableEdges.BottomRight = false;
            this.nationality.CustomizableEdges.TopLeft = false;
            this.nationality.CustomizableEdges.TopRight = false;
            this.nationality.DefaultText = "";
            this.nationality.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nationality.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nationality.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationality.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nationality.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationality.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.nationality.Location = new System.Drawing.Point(227, 252);
            this.nationality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nationality.Name = "nationality";
            this.nationality.PasswordChar = '\0';
            this.nationality.PlaceholderText = "";
            this.nationality.SelectedText = "";
            this.nationality.Size = new System.Drawing.Size(243, 40);
            this.nationality.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.nationality.TabIndex = 6;
            // 
            // passengerId
            // 
            this.passengerId.BackColor = System.Drawing.Color.Transparent;
            this.passengerId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.passengerId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.passengerId.FocusedColor = System.Drawing.Color.Navy;
            this.passengerId.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.passengerId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.passengerId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.passengerId.ItemHeight = 30;
            this.passengerId.Location = new System.Drawing.Point(227, 193);
            this.passengerId.Name = "passengerId";
            this.passengerId.Size = new System.Drawing.Size(243, 36);
            this.passengerId.TabIndex = 3;
            this.passengerId.SelectedIndexChanged += new System.EventHandler(this.passengerId_SelectedIndexChanged);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label12);
            this.guna2GradientPanel1.Controls.Add(this.exit);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(981, 56);
            this.guna2GradientPanel1.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(401, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 64);
            this.label12.TabIndex = 19;
            this.label12.Text = "SkyJet Airline";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(388, 56);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(227, 64);
            this.label13.TabIndex = 96;
            this.label13.Text = "Ticket Booking";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(70, 265);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 98;
            this.label1.Text = "Nationality";
            // 
            // ticketbookinggridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ticketbookinggridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ticketbookinggridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ticketbookinggridview.ColumnHeadersHeight = 30;
            this.ticketbookinggridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ticketbookinggridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.ticketbookinggridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ticketbookinggridview.Location = new System.Drawing.Point(38, 488);
            this.ticketbookinggridview.Name = "ticketbookinggridview";
            this.ticketbookinggridview.RowHeadersVisible = false;
            this.ticketbookinggridview.RowHeadersWidth = 51;
            this.ticketbookinggridview.RowTemplate.Height = 24;
            this.ticketbookinggridview.Size = new System.Drawing.Size(905, 260);
            this.ticketbookinggridview.TabIndex = 103;
            this.ticketbookinggridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ticketbookinggridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ticketbookinggridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ticketbookinggridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ticketbookinggridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ticketbookinggridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ticketbookinggridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ticketbookinggridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.ticketbookinggridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ticketbookinggridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketbookinggridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ticketbookinggridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ticketbookinggridview.ThemeStyle.HeaderStyle.Height = 30;
            this.ticketbookinggridview.ThemeStyle.ReadOnly = false;
            this.ticketbookinggridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ticketbookinggridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ticketbookinggridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketbookinggridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ticketbookinggridview.ThemeStyle.RowsStyle.Height = 24;
            this.ticketbookinggridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ticketbookinggridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BorderRadius = 8;
            this.backBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.backBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.backBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.backBtn.Location = new System.Drawing.Point(610, 381);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(160, 45);
            this.backBtn.TabIndex = 102;
            this.backBtn.Text = "Back";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.BorderRadius = 8;
            this.resetBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.resetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.resetBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.resetBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.resetBtn.Location = new System.Drawing.Point(418, 381);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(160, 45);
            this.resetBtn.TabIndex = 101;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookBtn.BorderRadius = 8;
            this.bookBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.bookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.bookBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bookBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBtn.ForeColor = System.Drawing.Color.White;
            this.bookBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.bookBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.bookBtn.Location = new System.Drawing.Point(234, 381);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(160, 45);
            this.bookBtn.TabIndex = 100;
            this.bookBtn.Text = "Book";
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.Navy;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 787);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(981, 18);
            this.guna2Panel1.TabIndex = 104;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.FillColor = System.Drawing.Color.Navy;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 769);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(981, 18);
            this.guna2Panel2.TabIndex = 105;
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 805);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.ticketbookinggridview);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.bookBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.passengerId);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.passport);
            this.Controls.Add(this.flightCode);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketID);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ticketbookinggridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private Guna.UI2.WinForms.Guna2ComboBox flightCode;
        private Guna.UI2.WinForms.Guna2TextBox amount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox ticketID;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox passport;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox nationality;
        private Guna.UI2.WinForms.Guna2ComboBox passengerId;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView ticketbookinggridview;
        private Guna.UI2.WinForms.Guna2GradientButton backBtn;
        private Guna.UI2.WinForms.Guna2GradientButton resetBtn;
        private Guna.UI2.WinForms.Guna2GradientButton bookBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
    }
}