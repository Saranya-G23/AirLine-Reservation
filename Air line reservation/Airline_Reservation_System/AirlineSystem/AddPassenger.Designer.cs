namespace AirlineSystem
{
    partial class AddPassenger
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
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passengerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passportNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nationality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.resetBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.recordBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.passengerAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.idpassenger = new Guna.UI2.WinForms.Guna2TextBox();
            this.passengerid = new System.Windows.Forms.Label();
            this.viewPassengerBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BackBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(703, 8);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 34);
            this.exit.TabIndex = 21;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(278, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 64);
            this.label1.TabIndex = 20;
            this.label1.Text = "Record Passengers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(301, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 64);
            this.label3.TabIndex = 19;
            this.label3.Text = "SkyJet Airline";
            // 
            // passengerName
            // 
            this.passengerName.Animated = true;
            this.passengerName.AutoRoundedCorners = true;
            this.passengerName.BackColor = System.Drawing.Color.Transparent;
            this.passengerName.BorderRadius = 19;
            this.passengerName.BorderThickness = 2;
            this.passengerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passengerName.CustomizableEdges.BottomLeft = false;
            this.passengerName.CustomizableEdges.BottomRight = false;
            this.passengerName.CustomizableEdges.TopLeft = false;
            this.passengerName.CustomizableEdges.TopRight = false;
            this.passengerName.DefaultText = "";
            this.passengerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passengerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passengerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passengerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passengerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerName.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.passengerName.Location = new System.Drawing.Point(362, 189);
            this.passengerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passengerName.Name = "passengerName";
            this.passengerName.PasswordChar = '\0';
            this.passengerName.PlaceholderText = "";
            this.passengerName.SelectedText = "";
            this.passengerName.Size = new System.Drawing.Size(259, 40);
            this.passengerName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passengerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(102, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 27);
            this.label2.TabIndex = 33;
            this.label2.Text = "Passenger Name";
            // 
            // passportNo
            // 
            this.passportNo.Animated = true;
            this.passportNo.AutoRoundedCorners = true;
            this.passportNo.BackColor = System.Drawing.Color.Transparent;
            this.passportNo.BorderRadius = 19;
            this.passportNo.BorderThickness = 2;
            this.passportNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passportNo.CustomizableEdges.BottomLeft = false;
            this.passportNo.CustomizableEdges.BottomRight = false;
            this.passportNo.CustomizableEdges.TopLeft = false;
            this.passportNo.CustomizableEdges.TopRight = false;
            this.passportNo.DefaultText = "";
            this.passportNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passportNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passportNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passportNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passportNo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passportNo.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.passportNo.Location = new System.Drawing.Point(362, 264);
            this.passportNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passportNo.Name = "passportNo";
            this.passportNo.PasswordChar = '\0';
            this.passportNo.PlaceholderText = "";
            this.passportNo.SelectedText = "";
            this.passportNo.Size = new System.Drawing.Size(259, 40);
            this.passportNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passportNo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(102, 277);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 27);
            this.label5.TabIndex = 35;
            this.label5.Text = "Passport Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(102, 353);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 27);
            this.label6.TabIndex = 37;
            this.label6.Text = "Passenger Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(102, 430);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 27);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nationality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(102, 506);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 27);
            this.label8.TabIndex = 41;
            this.label8.Text = "Gender";
            // 
            // phone
            // 
            this.phone.Animated = true;
            this.phone.AutoRoundedCorners = true;
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.BorderRadius = 19;
            this.phone.BorderThickness = 2;
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.CustomizableEdges.BottomLeft = false;
            this.phone.CustomizableEdges.BottomRight = false;
            this.phone.CustomizableEdges.TopLeft = false;
            this.phone.CustomizableEdges.TopRight = false;
            this.phone.DefaultText = "";
            this.phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.phone.Location = new System.Drawing.Point(362, 571);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.PlaceholderText = "";
            this.phone.SelectedText = "";
            this.phone.Size = new System.Drawing.Size(259, 40);
            this.phone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.phone.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(102, 584);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 27);
            this.label9.TabIndex = 43;
            this.label9.Text = "Phone";
            // 
            // nationality
            // 
            this.nationality.BackColor = System.Drawing.Color.Transparent;
            this.nationality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.nationality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationality.FocusedColor = System.Drawing.Color.Navy;
            this.nationality.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.nationality.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.nationality.ItemHeight = 30;
            this.nationality.Items.AddRange(new object[] {
            "CHOOSE NATIONALITY",
            "INDIA",
            "USA",
            "UK",
            "RUSSIA",
            "SRILANKA",
            "BANGLADESH",
            "CANADA",
            "UAE"});
            this.nationality.Location = new System.Drawing.Point(362, 421);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(259, 36);
            this.nationality.StartIndex = 0;
            this.nationality.TabIndex = 5;
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.Transparent;
            this.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FocusedColor = System.Drawing.Color.Navy;
            this.gender.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gender.ItemHeight = 30;
            this.gender.Items.AddRange(new object[] {
            "CHOOSE GENDER",
            "MALE",
            "FEMALE"});
            this.gender.Location = new System.Drawing.Point(362, 497);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(259, 36);
            this.gender.StartIndex = 0;
            this.gender.TabIndex = 6;
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
            this.resetBtn.Location = new System.Drawing.Point(252, 653);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(122, 45);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
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
            this.recordBtn.Location = new System.Drawing.Point(107, 653);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(128, 45);
            this.recordBtn.TabIndex = 8;
            this.recordBtn.Text = "Record";
            this.recordBtn.Click += new System.EventHandler(this.recordBtn_Click);
            // 
            // passengerAddress
            // 
            this.passengerAddress.Animated = true;
            this.passengerAddress.AutoRoundedCorners = true;
            this.passengerAddress.BackColor = System.Drawing.Color.Transparent;
            this.passengerAddress.BorderRadius = 19;
            this.passengerAddress.BorderThickness = 2;
            this.passengerAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passengerAddress.CustomizableEdges.BottomLeft = false;
            this.passengerAddress.CustomizableEdges.BottomRight = false;
            this.passengerAddress.CustomizableEdges.TopLeft = false;
            this.passengerAddress.CustomizableEdges.TopRight = false;
            this.passengerAddress.DefaultText = "";
            this.passengerAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passengerAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passengerAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passengerAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passengerAddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerAddress.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.passengerAddress.Location = new System.Drawing.Point(362, 340);
            this.passengerAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passengerAddress.Name = "passengerAddress";
            this.passengerAddress.PasswordChar = '\0';
            this.passengerAddress.PlaceholderText = "";
            this.passengerAddress.SelectedText = "";
            this.passengerAddress.Size = new System.Drawing.Size(259, 40);
            this.passengerAddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passengerAddress.TabIndex = 4;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.exit);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(741, 56);
            this.guna2GradientPanel1.TabIndex = 50;
            // 
            // idpassenger
            // 
            this.idpassenger.Animated = true;
            this.idpassenger.AutoRoundedCorners = true;
            this.idpassenger.BackColor = System.Drawing.Color.Transparent;
            this.idpassenger.BorderRadius = 19;
            this.idpassenger.BorderThickness = 2;
            this.idpassenger.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idpassenger.CustomizableEdges.BottomLeft = false;
            this.idpassenger.CustomizableEdges.BottomRight = false;
            this.idpassenger.CustomizableEdges.TopLeft = false;
            this.idpassenger.CustomizableEdges.TopRight = false;
            this.idpassenger.DefaultText = "";
            this.idpassenger.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idpassenger.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idpassenger.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idpassenger.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idpassenger.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpassenger.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.idpassenger.Location = new System.Drawing.Point(362, 124);
            this.idpassenger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idpassenger.Name = "idpassenger";
            this.idpassenger.PasswordChar = '\0';
            this.idpassenger.PlaceholderText = "";
            this.idpassenger.SelectedText = "";
            this.idpassenger.Size = new System.Drawing.Size(259, 40);
            this.idpassenger.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.idpassenger.TabIndex = 1;
            // 
            // passengerid
            // 
            this.passengerid.AutoSize = true;
            this.passengerid.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerid.ForeColor = System.Drawing.Color.Teal;
            this.passengerid.Location = new System.Drawing.Point(102, 137);
            this.passengerid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passengerid.Name = "passengerid";
            this.passengerid.Size = new System.Drawing.Size(154, 27);
            this.passengerid.TabIndex = 1;
            this.passengerid.Text = "Passenger ID";
            // 
            // viewPassengerBtn
            // 
            this.viewPassengerBtn.BackColor = System.Drawing.Color.Transparent;
            this.viewPassengerBtn.BorderRadius = 8;
            this.viewPassengerBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.viewPassengerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewPassengerBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewPassengerBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewPassengerBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewPassengerBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewPassengerBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewPassengerBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.viewPassengerBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.viewPassengerBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.viewPassengerBtn.ForeColor = System.Drawing.Color.White;
            this.viewPassengerBtn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.viewPassengerBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(234)))), ((int)(((byte)(228)))));
            this.viewPassengerBtn.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(213)))));
            this.viewPassengerBtn.Location = new System.Drawing.Point(387, 653);
            this.viewPassengerBtn.Name = "viewPassengerBtn";
            this.viewPassengerBtn.Size = new System.Drawing.Size(234, 45);
            this.viewPassengerBtn.TabIndex = 10;
            this.viewPassengerBtn.Text = "View Passenger";
            this.viewPassengerBtn.Click += new System.EventHandler(this.viewPassengerBtn_Click);
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
            this.BackBtn.Location = new System.Drawing.Point(289, 718);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(160, 45);
            this.BackBtn.TabIndex = 55;
            this.BackBtn.Text = "Back";
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // AddPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 801);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.viewPassengerBtn);
            this.Controls.Add(this.idpassenger);
            this.Controls.Add(this.passengerid);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.passengerAddress);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passportNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passengerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPassenger";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passengerName;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox passportNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox phone;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox nationality;
        private Guna.UI2.WinForms.Guna2ComboBox gender;
        private Guna.UI2.WinForms.Guna2GradientButton resetBtn;
        private Guna.UI2.WinForms.Guna2GradientButton recordBtn;
        private Guna.UI2.WinForms.Guna2TextBox passengerAddress;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox idpassenger;
        private System.Windows.Forms.Label passengerid;
        private Guna.UI2.WinForms.Guna2GradientButton viewPassengerBtn;
        private Guna.UI2.WinForms.Guna2GradientButton BackBtn;
    }
}