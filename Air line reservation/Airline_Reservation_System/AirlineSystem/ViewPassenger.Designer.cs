namespace AirlineSystem
{
    partial class ViewPassenger
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
            this.gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.nationality = new Guna.UI2.WinForms.Guna2ComboBox();
            this.phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passportNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passengerId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.passengergridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.backBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.resetBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.deleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.updateBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.exit = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            ((System.ComponentModel.ISupportInitialize)(this.passengergridview)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.gender.Location = new System.Drawing.Point(595, 252);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(243, 36);
            this.gender.TabIndex = 6;
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
            this.nationality.Location = new System.Drawing.Point(199, 252);
            this.nationality.Name = "nationality";
            this.nationality.Size = new System.Drawing.Size(243, 36);
            this.nationality.TabIndex = 5;
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
            this.phone.Location = new System.Drawing.Point(450, 312);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.PlaceholderText = "";
            this.phone.SelectedText = "";
            this.phone.Size = new System.Drawing.Size(243, 40);
            this.phone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.phone.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(359, 325);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 27);
            this.label9.TabIndex = 59;
            this.label9.Text = "Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(473, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 27);
            this.label8.TabIndex = 58;
            this.label8.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(29, 261);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 27);
            this.label7.TabIndex = 57;
            this.label7.Text = "Nationality";
            // 
            // address
            // 
            this.address.Animated = true;
            this.address.AutoRoundedCorners = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.BorderRadius = 19;
            this.address.BorderThickness = 2;
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.CustomizableEdges.BottomLeft = false;
            this.address.CustomizableEdges.BottomRight = false;
            this.address.CustomizableEdges.TopLeft = false;
            this.address.CustomizableEdges.TopRight = false;
            this.address.DefaultText = "";
            this.address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.address.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.address.Location = new System.Drawing.Point(595, 187);
            this.address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.address.Name = "address";
            this.address.PasswordChar = '\0';
            this.address.PlaceholderText = "";
            this.address.SelectedText = "";
            this.address.Size = new System.Drawing.Size(243, 40);
            this.address.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.address.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(473, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 27);
            this.label6.TabIndex = 55;
            this.label6.Text = "Address";
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
            this.passportNo.Location = new System.Drawing.Point(199, 187);
            this.passportNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passportNo.Name = "passportNo";
            this.passportNo.PasswordChar = '\0';
            this.passportNo.PlaceholderText = "";
            this.passportNo.SelectedText = "";
            this.passportNo.Size = new System.Drawing.Size(243, 40);
            this.passportNo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passportNo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(29, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 27);
            this.label5.TabIndex = 53;
            this.label5.Text = "Passport";
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
            this.name.Location = new System.Drawing.Point(595, 123);
            this.name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "";
            this.name.SelectedText = "";
            this.name.Size = new System.Drawing.Size(243, 40);
            this.name.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(473, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "Name";
            // 
            // passengerId
            // 
            this.passengerId.Animated = true;
            this.passengerId.AutoRoundedCorners = true;
            this.passengerId.BackColor = System.Drawing.Color.Transparent;
            this.passengerId.BorderRadius = 19;
            this.passengerId.BorderThickness = 2;
            this.passengerId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passengerId.CustomizableEdges.BottomLeft = false;
            this.passengerId.CustomizableEdges.BottomRight = false;
            this.passengerId.CustomizableEdges.TopLeft = false;
            this.passengerId.CustomizableEdges.TopRight = false;
            this.passengerId.DefaultText = "";
            this.passengerId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passengerId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passengerId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passengerId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passengerId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengerId.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.passengerId.Location = new System.Drawing.Point(199, 123);
            this.passengerId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passengerId.Name = "passengerId";
            this.passengerId.PasswordChar = '\0';
            this.passengerId.PlaceholderText = "";
            this.passengerId.SelectedText = "";
            this.passengerId.Size = new System.Drawing.Size(243, 40);
            this.passengerId.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.passengerId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(29, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 27);
            this.label4.TabIndex = 49;
            this.label4.Text = "Passenger ID";
            // 
            // passengergridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.passengergridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passengergridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.passengergridview.ColumnHeadersHeight = 30;
            this.passengergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passengergridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.passengergridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.passengergridview.Location = new System.Drawing.Point(34, 437);
            this.passengergridview.Name = "passengergridview";
            this.passengergridview.RowHeadersVisible = false;
            this.passengergridview.RowHeadersWidth = 51;
            this.passengergridview.RowTemplate.Height = 24;
            this.passengergridview.Size = new System.Drawing.Size(905, 290);
            this.passengergridview.TabIndex = 67;
            this.passengergridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.passengergridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.passengergridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.passengergridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.passengergridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.passengergridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.passengergridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.passengergridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Navy;
            this.passengergridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.passengergridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengergridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.passengergridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.passengergridview.ThemeStyle.HeaderStyle.Height = 30;
            this.passengergridview.ThemeStyle.ReadOnly = false;
            this.passengergridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.passengergridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.passengergridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passengergridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.passengergridview.ThemeStyle.RowsStyle.Height = 24;
            this.passengergridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.passengergridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.passengergridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.passengergridview_CellContentClick);
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
            this.backBtn.Location = new System.Drawing.Point(700, 374);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(160, 45);
            this.backBtn.TabIndex = 66;
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
            this.resetBtn.Location = new System.Drawing.Point(508, 374);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(160, 45);
            this.resetBtn.TabIndex = 65;
            this.resetBtn.Text = "Reset";
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(324, 374);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(160, 45);
            this.deleteBtn.TabIndex = 64;
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
            this.updateBtn.Location = new System.Drawing.Point(132, 374);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(160, 45);
            this.updateBtn.TabIndex = 63;
            this.updateBtn.Text = "Update";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(926, 8);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(34, 34);
            this.exit.TabIndex = 68;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.exit);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Blue;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(964, 56);
            this.guna2GradientPanel1.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(388, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 64);
            this.label3.TabIndex = 19;
            this.label3.Text = "SkyJet Airline";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Javanese Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(373, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(242, 64);
            this.label10.TabIndex = 69;
            this.label10.Text = "View Passengers";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.FillColor = System.Drawing.Color.Navy;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 755);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(964, 18);
            this.guna2Panel1.TabIndex = 71;
            // 
            // ViewPassenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 773);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.passengergridview);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.nationality);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passportNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passengerId);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewPassenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPassenger";
            this.Load += new System.EventHandler(this.ViewPassenger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passengergridview)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox gender;
        private Guna.UI2.WinForms.Guna2ComboBox nationality;
        private Guna.UI2.WinForms.Guna2TextBox phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox address;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox passportNo;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox passengerId;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView passengergridview;
        private Guna.UI2.WinForms.Guna2GradientButton backBtn;
        private Guna.UI2.WinForms.Guna2GradientButton resetBtn;
        private Guna.UI2.WinForms.Guna2GradientButton deleteBtn;
        private Guna.UI2.WinForms.Guna2GradientButton updateBtn;
        private System.Windows.Forms.Label exit;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}