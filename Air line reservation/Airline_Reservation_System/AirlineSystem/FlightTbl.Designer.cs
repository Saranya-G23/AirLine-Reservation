namespace AirlineSystem
{
    partial class FlightTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTbl));
            this.exit = new System.Windows.Forms.Label();
            this.resetBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.flightCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.noofseats = new Guna.UI2.WinForms.Guna2TextBox();
            this.recordBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.takeofDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.source = new Guna.UI2.WinForms.Guna2ComboBox();
            this.destination = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.viewFlightsBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BackBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(827, 8);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 34);
            this.exit.TabIndex = 14;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.resetBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.resetBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.resetBtn.Location = new System.Drawing.Point(240, 546);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(160, 45);
            this.resetBtn.TabIndex = 21;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // flightCode
            // 
            this.flightCode.Animated = true;
            this.flightCode.AutoRoundedCorners = true;
            this.flightCode.BackColor = System.Drawing.Color.Transparent;
            this.flightCode.BorderRadius = 19;
            this.flightCode.BorderThickness = 2;
            this.flightCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.flightCode.CustomizableEdges.BottomLeft = false;
            this.flightCode.CustomizableEdges.BottomRight = false;
            this.flightCode.CustomizableEdges.TopLeft = false;
            this.flightCode.CustomizableEdges.TopRight = false;
            this.flightCode.DefaultText = "";
            this.flightCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.flightCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.flightCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.flightCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.flightCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.flightCode.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.flightCode.Location = new System.Drawing.Point(240, 145);
            this.flightCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flightCode.Name = "flightCode";
            this.flightCode.PasswordChar = '\0';
            this.flightCode.PlaceholderText = "";
            this.flightCode.SelectedText = "";
            this.flightCode.Size = new System.Drawing.Size(256, 40);
            this.flightCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.flightCode.TabIndex = 1;
            // 
            // noofseats
            // 
            this.noofseats.Animated = true;
            this.noofseats.AutoRoundedCorners = true;
            this.noofseats.BackColor = System.Drawing.Color.Transparent;
            this.noofseats.BorderRadius = 19;
            this.noofseats.BorderThickness = 2;
            this.noofseats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noofseats.CustomizableEdges.BottomLeft = false;
            this.noofseats.CustomizableEdges.BottomRight = false;
            this.noofseats.CustomizableEdges.TopLeft = false;
            this.noofseats.CustomizableEdges.TopRight = false;
            this.noofseats.DefaultText = "";
            this.noofseats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.noofseats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.noofseats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noofseats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.noofseats.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noofseats.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.noofseats.Location = new System.Drawing.Point(240, 451);
            this.noofseats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noofseats.Name = "noofseats";
            this.noofseats.PasswordChar = '\0';
            this.noofseats.PlaceholderText = "";
            this.noofseats.SelectedText = "";
            this.noofseats.Size = new System.Drawing.Size(256, 40);
            this.noofseats.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.noofseats.TabIndex = 5;
            // 
            // recordBtn
            // 
            this.recordBtn.BackColor = System.Drawing.Color.Transparent;
            this.recordBtn.BorderRadius = 8;
            this.recordBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.recordBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.recordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.recordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.recordBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.recordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.recordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.recordBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.recordBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.recordBtn.ForeColor = System.Drawing.Color.White;
            this.recordBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.recordBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.recordBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.recordBtn.Location = new System.Drawing.Point(67, 546);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(160, 45);
            this.recordBtn.TabIndex = 18;
            this.recordBtn.Text = "Record";
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(76, 464);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 27);
            this.label5.TabIndex = 17;
            this.label5.Text = "No. of Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(76, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Flight Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(76, 224);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 22;
            this.label2.Text = "Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(76, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 27);
            this.label6.TabIndex = 23;
            this.label6.Text = "Destination";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(76, 381);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Take of Date";
            // 
            // takeofDate
            // 
            this.takeofDate.BackColor = System.Drawing.Color.Transparent;
            this.takeofDate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.takeofDate.Checked = true;
            this.takeofDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.takeofDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.takeofDate.ForeColor = System.Drawing.Color.Black;
            this.takeofDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.takeofDate.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.takeofDate.Location = new System.Drawing.Point(240, 373);
            this.takeofDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.takeofDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.takeofDate.Name = "takeofDate";
            this.takeofDate.Size = new System.Drawing.Size(256, 44);
            this.takeofDate.TabIndex = 4;
            this.takeofDate.UseTransparentBackground = true;
            this.takeofDate.Value = new System.DateTime(2023, 11, 20, 21, 8, 46, 50);
            // 
            // source
            // 
            this.source.BackColor = System.Drawing.Color.Transparent;
            this.source.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.source.FocusedColor = System.Drawing.Color.Navy;
            this.source.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.source.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.source.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.source.ItemHeight = 30;
            this.source.Items.AddRange(new object[] {
            "CHOOSE SOURCE",
            "CHENNAI",
            "BANGALORE",
            "KERALA",
            "BANGALORE",
            "MUMBAI",
            "HYDERABAD",
            "DELHI"});
            this.source.Location = new System.Drawing.Point(240, 224);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(256, 36);
            this.source.StartIndex = 0;
            this.source.TabIndex = 2;
            // 
            // destination
            // 
            this.destination.BackColor = System.Drawing.Color.Transparent;
            this.destination.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.destination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destination.FocusedColor = System.Drawing.Color.Navy;
            this.destination.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.destination.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.destination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.destination.ItemHeight = 30;
            this.destination.Items.AddRange(new object[] {
            "CHOOSE DESTINATION",
            "CHENNAI",
            "BANGALORE",
            "KERALA",
            "BANGALORE",
            "MUMBAI",
            "HYDERABAD",
            "DELHI"});
            this.destination.Location = new System.Drawing.Point(240, 295);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(256, 36);
            this.destination.StartIndex = 0;
            this.destination.TabIndex = 3;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(540, 145);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(321, 306);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 28;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Controls.Add(this.exit);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(874, 56);
            this.guna2GradientPanel1.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(326, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 64);
            this.label8.TabIndex = 19;
            this.label8.Text = "SkyJet Airline";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(297, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 64);
            this.label9.TabIndex = 51;
            this.label9.Text = "Record New Flights";
            // 
            // viewFlightsBtn
            // 
            this.viewFlightsBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewFlightsBtn.BorderRadius = 8;
            this.viewFlightsBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewFlightsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewFlightsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewFlightsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewFlightsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewFlightsBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewFlightsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewFlightsBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.viewFlightsBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.viewFlightsBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.viewFlightsBtn.ForeColor = System.Drawing.Color.White;
            this.viewFlightsBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.viewFlightsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.viewFlightsBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.viewFlightsBtn.Location = new System.Drawing.Point(406, 546);
            this.viewFlightsBtn.Name = "viewFlightsBtn";
            this.viewFlightsBtn.Size = new System.Drawing.Size(221, 45);
            this.viewFlightsBtn.TabIndex = 53;
            this.viewFlightsBtn.Text = "View Flights";
            this.viewFlightsBtn.Click += new System.EventHandler(this.viewFlightsBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BorderRadius = 8;
            this.BackBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.BackBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.BackBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.BackBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.BackBtn.Location = new System.Drawing.Point(643, 546);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 45);
            this.BackBtn.TabIndex = 54;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // FlightTbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 641);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.viewFlightsBtn);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.source);
            this.Controls.Add(this.takeofDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.flightCode);
            this.Controls.Add(this.noofseats);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightTbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlightTbl";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private Guna.UI2.WinForms.Guna2GradientButton resetBtn;
        private Guna.UI2.WinForms.Guna2TextBox flightCode;
        private Guna.UI2.WinForms.Guna2TextBox noofseats;
        private Guna.UI2.WinForms.Guna2GradientButton recordBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker takeofDate;
        private Guna.UI2.WinForms.Guna2ComboBox source;
        private Guna.UI2.WinForms.Guna2ComboBox destination;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2GradientButton viewFlightsBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BackBtn;
    }
}