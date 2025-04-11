namespace AirlineSystem
{
    partial class ViewFlights
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
            this.destination = new Guna.UI2.WinForms.Guna2ComboBox();
            this.source = new Guna.UI2.WinForms.Guna2ComboBox();
            this.takeofDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.noofseats = new Guna.UI2.WinForms.Guna2TextBox();
            this.flightCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.updateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.backBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.resetBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.viewFlightsgridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFlightsgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(902, 8);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 34);
            this.exit.TabIndex = 18;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            this.destination.Location = new System.Drawing.Point(641, 208);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(256, 36);
            this.destination.TabIndex = 4;
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
            this.source.Location = new System.Drawing.Point(641, 129);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(256, 36);
            this.source.TabIndex = 2;
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
            this.takeofDate.Location = new System.Drawing.Point(185, 200);
            this.takeofDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.takeofDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.takeofDate.Name = "takeofDate";
            this.takeofDate.Size = new System.Drawing.Size(256, 44);
            this.takeofDate.TabIndex = 3;
            this.takeofDate.UseTransparentBackground = true;
            this.takeofDate.Value = new System.DateTime(2023, 11, 20, 21, 8, 46, 50);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(16, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 27);
            this.label7.TabIndex = 34;
            this.label7.Text = "Take of Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(481, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 27);
            this.label6.TabIndex = 33;
            this.label6.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(481, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 32;
            this.label2.Text = "Source";
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
            this.noofseats.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.noofseats.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.noofseats.Location = new System.Drawing.Point(467, 273);
            this.noofseats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.noofseats.Name = "noofseats";
            this.noofseats.PasswordChar = '\0';
            this.noofseats.PlaceholderText = "";
            this.noofseats.SelectedText = "";
            this.noofseats.Size = new System.Drawing.Size(256, 40);
            this.noofseats.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.noofseats.TabIndex = 5;
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
            this.flightCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightCode.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.flightCode.Location = new System.Drawing.Point(185, 129);
            this.flightCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flightCode.Name = "flightCode";
            this.flightCode.PasswordChar = '\0';
            this.flightCode.PlaceholderText = "";
            this.flightCode.SelectedText = "";
            this.flightCode.Size = new System.Drawing.Size(256, 40);
            this.flightCode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.flightCode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(299, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 27);
            this.label5.TabIndex = 29;
            this.label5.Text = "No. of Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(16, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "Flight Code";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BorderRadius = 8;
            this.deleteBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.deleteBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.deleteBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.deleteBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.deleteBtn.Location = new System.Drawing.Point(315, 342);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(160, 45);
            this.deleteBtn.TabIndex = 39;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BorderRadius = 8;
            this.updateBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.updateBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.updateBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.updateBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.updateBtn.Location = new System.Drawing.Point(123, 342);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(160, 45);
            this.updateBtn.TabIndex = 38;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.backBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.backBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.backBtn.Location = new System.Drawing.Point(694, 342);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(160, 45);
            this.backBtn.TabIndex = 41;
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
            this.resetBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.resetBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.resetBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.resetBtn.Location = new System.Drawing.Point(499, 342);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(160, 45);
            this.resetBtn.TabIndex = 40;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
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
            this.guna2GradientPanel1.Size = new System.Drawing.Size(949, 56);
            this.guna2GradientPanel1.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(357, 0);
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
            this.label9.Location = new System.Drawing.Point(293, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(335, 64);
            this.label9.TabIndex = 53;
            this.label9.Text = "View Scheduled Flights";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.Navy;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 737);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(949, 18);
            this.guna2Panel1.TabIndex = 72;
            // 
            // viewFlightsgridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.viewFlightsgridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewFlightsgridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewFlightsgridview.ColumnHeadersHeight = 30;
            this.viewFlightsgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewFlightsgridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewFlightsgridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewFlightsgridview.Location = new System.Drawing.Point(21, 420);
            this.viewFlightsgridview.Name = "viewFlightsgridview";
            this.viewFlightsgridview.RowHeadersVisible = false;
            this.viewFlightsgridview.RowHeadersWidth = 51;
            this.viewFlightsgridview.RowTemplate.Height = 24;
            this.viewFlightsgridview.Size = new System.Drawing.Size(905, 290);
            this.viewFlightsgridview.TabIndex = 73;
            this.viewFlightsgridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.viewFlightsgridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.viewFlightsgridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.viewFlightsgridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.viewFlightsgridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.viewFlightsgridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.viewFlightsgridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewFlightsgridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.viewFlightsgridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.viewFlightsgridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFlightsgridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.viewFlightsgridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.viewFlightsgridview.ThemeStyle.HeaderStyle.Height = 30;
            this.viewFlightsgridview.ThemeStyle.ReadOnly = false;
            this.viewFlightsgridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.viewFlightsgridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.viewFlightsgridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewFlightsgridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewFlightsgridview.ThemeStyle.RowsStyle.Height = 24;
            this.viewFlightsgridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.viewFlightsgridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.viewFlightsgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewFlightsgridview_CellContentClick);
            // 
            // ViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 755);
            this.Controls.Add(this.viewFlightsgridview);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.destination);
            this.Controls.Add(this.source);
            this.Controls.Add(this.takeofDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noofseats);
            this.Controls.Add(this.flightCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewFlights";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewFlights";
            this.Load += new System.EventHandler(this.ViewFlights_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewFlightsgridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label exit;
        private Guna.UI2.WinForms.Guna2ComboBox destination;
        private Guna.UI2.WinForms.Guna2ComboBox source;
        private Guna.UI2.WinForms.Guna2DateTimePicker takeofDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox noofseats;
        private Guna.UI2.WinForms.Guna2TextBox flightCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientButton deleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton updateBtn;
        private Guna.UI2.WinForms.Guna2GradientButton backBtn;
        private Guna.UI2.WinForms.Guna2GradientButton resetBtn;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView viewFlightsgridview;
    }
}