namespace HairSpaApp.Forms
{
    partial class Main_Form
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
            this.logout_Button = new System.Windows.Forms.Button();
            this.customers_DataGrid = new System.Windows.Forms.DataGridView();
            this.customers_Label = new System.Windows.Forms.Label();
            this.appointments_Label = new System.Windows.Forms.Label();
            this.appointments_DataGrid = new System.Windows.Forms.DataGridView();
            this.accounts_DataGrid = new System.Windows.Forms.DataGridView();
            this.employees_DataGrid = new System.Windows.Forms.DataGridView();
            this.employees_Label = new System.Windows.Forms.Label();
            this.accounts_Label = new System.Windows.Forms.Label();
            this.customersDelete_Button = new System.Windows.Forms.Button();
            this.customersEdit_Button = new System.Windows.Forms.Button();
            this.customersCreate_Button = new System.Windows.Forms.Button();
            this.appointmentsDelete_Button = new System.Windows.Forms.Button();
            this.appointmentsEdit_Button = new System.Windows.Forms.Button();
            this.appointmentsCreate_Button = new System.Windows.Forms.Button();
            this.appointmentsSearch_Button = new System.Windows.Forms.Button();
            this.customersSearch_Button = new System.Windows.Forms.Button();
            this.customersSearch_TextBox = new System.Windows.Forms.TextBox();
            this.appointmentsSearch_TextBox = new System.Windows.Forms.TextBox();
            this.reports_Button = new System.Windows.Forms.Button();
            this.employeesSearch_Button = new System.Windows.Forms.Button();
            this.employeesCreate_Button = new System.Windows.Forms.Button();
            this.employeesEdit_Button = new System.Windows.Forms.Button();
            this.employeesDelete_Button = new System.Windows.Forms.Button();
            this.accountsSearch_Button = new System.Windows.Forms.Button();
            this.accountsCreate_Button = new System.Windows.Forms.Button();
            this.accountsEdit_Button = new System.Windows.Forms.Button();
            this.accountsDelete_Button = new System.Windows.Forms.Button();
            this.employeesSearch_TextBox = new System.Windows.Forms.TextBox();
            this.accountsSearch_TextBox = new System.Windows.Forms.TextBox();
            this.customersSearch_ComboBox = new System.Windows.Forms.ComboBox();
            this.appointmentsSearch_ComboBox = new System.Windows.Forms.ComboBox();
            this.employeesSearch_ComboBox = new System.Windows.Forms.ComboBox();
            this.accountsSearch_ComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customers_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees_DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // logout_Button
            // 
            this.logout_Button.Location = new System.Drawing.Point(897, 569);
            this.logout_Button.Name = "logout_Button";
            this.logout_Button.Size = new System.Drawing.Size(125, 30);
            this.logout_Button.TabIndex = 0;
            this.logout_Button.Text = "Log Out";
            this.logout_Button.UseVisualStyleBackColor = true;
            this.logout_Button.Click += new System.EventHandler(this.logout_Button_Click);
            // 
            // customers_DataGrid
            // 
            this.customers_DataGrid.AllowUserToAddRows = false;
            this.customers_DataGrid.AllowUserToDeleteRows = false;
            this.customers_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customers_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customers_DataGrid.Location = new System.Drawing.Point(12, 35);
            this.customers_DataGrid.MultiSelect = false;
            this.customers_DataGrid.Name = "customers_DataGrid";
            this.customers_DataGrid.ReadOnly = true;
            this.customers_DataGrid.RowHeadersVisible = false;
            this.customers_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customers_DataGrid.ShowEditingIcon = false;
            this.customers_DataGrid.Size = new System.Drawing.Size(415, 250);
            this.customers_DataGrid.TabIndex = 1;
            this.customers_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customers_DataGrid_CellClick);
            // 
            // customers_Label
            // 
            this.customers_Label.AutoSize = true;
            this.customers_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_Label.Location = new System.Drawing.Point(8, 12);
            this.customers_Label.Name = "customers_Label";
            this.customers_Label.Size = new System.Drawing.Size(85, 21);
            this.customers_Label.TabIndex = 2;
            this.customers_Label.Text = "Customers";
            // 
            // appointments_Label
            // 
            this.appointments_Label.AutoSize = true;
            this.appointments_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointments_Label.Location = new System.Drawing.Point(538, 9);
            this.appointments_Label.Name = "appointments_Label";
            this.appointments_Label.Size = new System.Drawing.Size(108, 21);
            this.appointments_Label.TabIndex = 3;
            this.appointments_Label.Text = "Appointments";
            // 
            // appointments_DataGrid
            // 
            this.appointments_DataGrid.AllowUserToAddRows = false;
            this.appointments_DataGrid.AllowUserToDeleteRows = false;
            this.appointments_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.appointments_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointments_DataGrid.Location = new System.Drawing.Point(541, 35);
            this.appointments_DataGrid.MultiSelect = false;
            this.appointments_DataGrid.Name = "appointments_DataGrid";
            this.appointments_DataGrid.ReadOnly = true;
            this.appointments_DataGrid.RowHeadersVisible = false;
            this.appointments_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.appointments_DataGrid.ShowEditingIcon = false;
            this.appointments_DataGrid.Size = new System.Drawing.Size(415, 250);
            this.appointments_DataGrid.TabIndex = 4;
            this.appointments_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointments_DataGrid_CellClick);
            // 
            // accounts_DataGrid
            // 
            this.accounts_DataGrid.AllowUserToAddRows = false;
            this.accounts_DataGrid.AllowUserToDeleteRows = false;
            this.accounts_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accounts_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accounts_DataGrid.Location = new System.Drawing.Point(542, 343);
            this.accounts_DataGrid.MultiSelect = false;
            this.accounts_DataGrid.Name = "accounts_DataGrid";
            this.accounts_DataGrid.ReadOnly = true;
            this.accounts_DataGrid.RowHeadersVisible = false;
            this.accounts_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accounts_DataGrid.ShowEditingIcon = false;
            this.accounts_DataGrid.Size = new System.Drawing.Size(415, 215);
            this.accounts_DataGrid.TabIndex = 6;
            this.accounts_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accounts_DataGrid_CellClick);
            // 
            // employees_DataGrid
            // 
            this.employees_DataGrid.AllowUserToAddRows = false;
            this.employees_DataGrid.AllowUserToDeleteRows = false;
            this.employees_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employees_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employees_DataGrid.Location = new System.Drawing.Point(16, 343);
            this.employees_DataGrid.MultiSelect = false;
            this.employees_DataGrid.Name = "employees_DataGrid";
            this.employees_DataGrid.ReadOnly = true;
            this.employees_DataGrid.RowHeadersVisible = false;
            this.employees_DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employees_DataGrid.ShowEditingIcon = false;
            this.employees_DataGrid.Size = new System.Drawing.Size(415, 250);
            this.employees_DataGrid.TabIndex = 7;
            this.employees_DataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employees_DataGrid_CellClick);
            // 
            // employees_Label
            // 
            this.employees_Label.AutoSize = true;
            this.employees_Label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.employees_Label.Location = new System.Drawing.Point(12, 319);
            this.employees_Label.Name = "employees_Label";
            this.employees_Label.Size = new System.Drawing.Size(85, 21);
            this.employees_Label.TabIndex = 8;
            this.employees_Label.Text = "Employees";
            // 
            // accounts_Label
            // 
            this.accounts_Label.AutoSize = true;
            this.accounts_Label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.accounts_Label.Location = new System.Drawing.Point(538, 319);
            this.accounts_Label.Name = "accounts_Label";
            this.accounts_Label.Size = new System.Drawing.Size(73, 21);
            this.accounts_Label.TabIndex = 9;
            this.accounts_Label.Text = "Accounts";
            // 
            // customersDelete_Button
            // 
            this.customersDelete_Button.Location = new System.Drawing.Point(433, 111);
            this.customersDelete_Button.Name = "customersDelete_Button";
            this.customersDelete_Button.Size = new System.Drawing.Size(60, 30);
            this.customersDelete_Button.TabIndex = 11;
            this.customersDelete_Button.Text = "Delete";
            this.customersDelete_Button.UseVisualStyleBackColor = true;
            this.customersDelete_Button.Click += new System.EventHandler(this.customersDelete_Button_Click);
            // 
            // customersEdit_Button
            // 
            this.customersEdit_Button.Location = new System.Drawing.Point(433, 75);
            this.customersEdit_Button.Name = "customersEdit_Button";
            this.customersEdit_Button.Size = new System.Drawing.Size(60, 30);
            this.customersEdit_Button.TabIndex = 12;
            this.customersEdit_Button.Text = "Edit";
            this.customersEdit_Button.UseVisualStyleBackColor = true;
            this.customersEdit_Button.Click += new System.EventHandler(this.customersEdit_Button_Click);
            // 
            // customersCreate_Button
            // 
            this.customersCreate_Button.Location = new System.Drawing.Point(433, 39);
            this.customersCreate_Button.Name = "customersCreate_Button";
            this.customersCreate_Button.Size = new System.Drawing.Size(60, 30);
            this.customersCreate_Button.TabIndex = 13;
            this.customersCreate_Button.Text = "Create";
            this.customersCreate_Button.UseVisualStyleBackColor = true;
            this.customersCreate_Button.Click += new System.EventHandler(this.customersCreate_Button_Click);
            // 
            // appointmentsDelete_Button
            // 
            this.appointmentsDelete_Button.Location = new System.Drawing.Point(962, 111);
            this.appointmentsDelete_Button.Name = "appointmentsDelete_Button";
            this.appointmentsDelete_Button.Size = new System.Drawing.Size(60, 30);
            this.appointmentsDelete_Button.TabIndex = 14;
            this.appointmentsDelete_Button.Text = "Delete";
            this.appointmentsDelete_Button.UseVisualStyleBackColor = true;
            this.appointmentsDelete_Button.Click += new System.EventHandler(this.appointmentsDelete_Button_Click);
            // 
            // appointmentsEdit_Button
            // 
            this.appointmentsEdit_Button.Location = new System.Drawing.Point(962, 75);
            this.appointmentsEdit_Button.Name = "appointmentsEdit_Button";
            this.appointmentsEdit_Button.Size = new System.Drawing.Size(60, 30);
            this.appointmentsEdit_Button.TabIndex = 15;
            this.appointmentsEdit_Button.Text = "Edit";
            this.appointmentsEdit_Button.UseVisualStyleBackColor = true;
            this.appointmentsEdit_Button.Click += new System.EventHandler(this.appointmentsEdit_Button_Click);
            // 
            // appointmentsCreate_Button
            // 
            this.appointmentsCreate_Button.Location = new System.Drawing.Point(962, 39);
            this.appointmentsCreate_Button.Name = "appointmentsCreate_Button";
            this.appointmentsCreate_Button.Size = new System.Drawing.Size(60, 30);
            this.appointmentsCreate_Button.TabIndex = 16;
            this.appointmentsCreate_Button.Text = "Create";
            this.appointmentsCreate_Button.UseVisualStyleBackColor = true;
            this.appointmentsCreate_Button.Click += new System.EventHandler(this.appointmentsCreate_Button_Click);
            // 
            // appointmentsSearch_Button
            // 
            this.appointmentsSearch_Button.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.appointmentsSearch_Button.Location = new System.Drawing.Point(962, 8);
            this.appointmentsSearch_Button.Name = "appointmentsSearch_Button";
            this.appointmentsSearch_Button.Size = new System.Drawing.Size(60, 25);
            this.appointmentsSearch_Button.TabIndex = 17;
            this.appointmentsSearch_Button.Text = "Search";
            this.appointmentsSearch_Button.UseVisualStyleBackColor = true;
            this.appointmentsSearch_Button.Click += new System.EventHandler(this.appointmentsSearch_Button_Click);
            // 
            // customersSearch_Button
            // 
            this.customersSearch_Button.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.customersSearch_Button.Location = new System.Drawing.Point(433, 8);
            this.customersSearch_Button.Name = "customersSearch_Button";
            this.customersSearch_Button.Size = new System.Drawing.Size(60, 25);
            this.customersSearch_Button.TabIndex = 18;
            this.customersSearch_Button.Text = "Search";
            this.customersSearch_Button.UseVisualStyleBackColor = true;
            this.customersSearch_Button.Click += new System.EventHandler(this.customersSearch_Button_Click);
            // 
            // customersSearch_TextBox
            // 
            this.customersSearch_TextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.customersSearch_TextBox.Location = new System.Drawing.Point(327, 9);
            this.customersSearch_TextBox.Name = "customersSearch_TextBox";
            this.customersSearch_TextBox.Size = new System.Drawing.Size(100, 22);
            this.customersSearch_TextBox.TabIndex = 19;
            // 
            // appointmentsSearch_TextBox
            // 
            this.appointmentsSearch_TextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.appointmentsSearch_TextBox.Location = new System.Drawing.Point(857, 9);
            this.appointmentsSearch_TextBox.Name = "appointmentsSearch_TextBox";
            this.appointmentsSearch_TextBox.Size = new System.Drawing.Size(100, 22);
            this.appointmentsSearch_TextBox.TabIndex = 20;
            // 
            // reports_Button
            // 
            this.reports_Button.Location = new System.Drawing.Point(766, 569);
            this.reports_Button.Name = "reports_Button";
            this.reports_Button.Size = new System.Drawing.Size(125, 30);
            this.reports_Button.TabIndex = 21;
            this.reports_Button.Text = "Show Reports";
            this.reports_Button.UseVisualStyleBackColor = true;
            this.reports_Button.Click += new System.EventHandler(this.reports_Button_Click);
            // 
            // employeesSearch_Button
            // 
            this.employeesSearch_Button.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.employeesSearch_Button.Location = new System.Drawing.Point(437, 315);
            this.employeesSearch_Button.Name = "employeesSearch_Button";
            this.employeesSearch_Button.Size = new System.Drawing.Size(60, 25);
            this.employeesSearch_Button.TabIndex = 25;
            this.employeesSearch_Button.Text = "Search";
            this.employeesSearch_Button.UseVisualStyleBackColor = true;
            this.employeesSearch_Button.Click += new System.EventHandler(this.employeesSearch_Button_Click);
            // 
            // employeesCreate_Button
            // 
            this.employeesCreate_Button.Location = new System.Drawing.Point(437, 346);
            this.employeesCreate_Button.Name = "employeesCreate_Button";
            this.employeesCreate_Button.Size = new System.Drawing.Size(60, 30);
            this.employeesCreate_Button.TabIndex = 24;
            this.employeesCreate_Button.Text = "Create";
            this.employeesCreate_Button.UseVisualStyleBackColor = true;
            this.employeesCreate_Button.Click += new System.EventHandler(this.employeesCreate_Button_Click);
            // 
            // employeesEdit_Button
            // 
            this.employeesEdit_Button.Location = new System.Drawing.Point(437, 382);
            this.employeesEdit_Button.Name = "employeesEdit_Button";
            this.employeesEdit_Button.Size = new System.Drawing.Size(60, 30);
            this.employeesEdit_Button.TabIndex = 23;
            this.employeesEdit_Button.Text = "Edit";
            this.employeesEdit_Button.UseVisualStyleBackColor = true;
            this.employeesEdit_Button.Click += new System.EventHandler(this.employeesEdit_Button_Click);
            // 
            // employeesDelete_Button
            // 
            this.employeesDelete_Button.Location = new System.Drawing.Point(437, 418);
            this.employeesDelete_Button.Name = "employeesDelete_Button";
            this.employeesDelete_Button.Size = new System.Drawing.Size(60, 30);
            this.employeesDelete_Button.TabIndex = 22;
            this.employeesDelete_Button.Text = "Delete";
            this.employeesDelete_Button.UseVisualStyleBackColor = true;
            this.employeesDelete_Button.Click += new System.EventHandler(this.employeesDelete_Button_Click);
            // 
            // accountsSearch_Button
            // 
            this.accountsSearch_Button.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.accountsSearch_Button.Location = new System.Drawing.Point(962, 315);
            this.accountsSearch_Button.Name = "accountsSearch_Button";
            this.accountsSearch_Button.Size = new System.Drawing.Size(60, 25);
            this.accountsSearch_Button.TabIndex = 30;
            this.accountsSearch_Button.Text = "Search";
            this.accountsSearch_Button.UseVisualStyleBackColor = true;
            this.accountsSearch_Button.Click += new System.EventHandler(this.accountsSearch_Button_Click);
            // 
            // accountsCreate_Button
            // 
            this.accountsCreate_Button.Location = new System.Drawing.Point(962, 348);
            this.accountsCreate_Button.Name = "accountsCreate_Button";
            this.accountsCreate_Button.Size = new System.Drawing.Size(60, 30);
            this.accountsCreate_Button.TabIndex = 29;
            this.accountsCreate_Button.Text = "Create";
            this.accountsCreate_Button.UseVisualStyleBackColor = true;
            this.accountsCreate_Button.Click += new System.EventHandler(this.accountsCreate_Button_Click);
            // 
            // accountsEdit_Button
            // 
            this.accountsEdit_Button.Location = new System.Drawing.Point(962, 384);
            this.accountsEdit_Button.Name = "accountsEdit_Button";
            this.accountsEdit_Button.Size = new System.Drawing.Size(60, 30);
            this.accountsEdit_Button.TabIndex = 28;
            this.accountsEdit_Button.Text = "Edit";
            this.accountsEdit_Button.UseVisualStyleBackColor = true;
            this.accountsEdit_Button.Click += new System.EventHandler(this.accountsEdit_Button_Click);
            // 
            // accountsDelete_Button
            // 
            this.accountsDelete_Button.Location = new System.Drawing.Point(962, 420);
            this.accountsDelete_Button.Name = "accountsDelete_Button";
            this.accountsDelete_Button.Size = new System.Drawing.Size(60, 30);
            this.accountsDelete_Button.TabIndex = 27;
            this.accountsDelete_Button.Text = "Delete";
            this.accountsDelete_Button.UseVisualStyleBackColor = true;
            this.accountsDelete_Button.Click += new System.EventHandler(this.accountsDelete_Button_Click);
            // 
            // employeesSearch_TextBox
            // 
            this.employeesSearch_TextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.employeesSearch_TextBox.Location = new System.Drawing.Point(331, 316);
            this.employeesSearch_TextBox.Name = "employeesSearch_TextBox";
            this.employeesSearch_TextBox.Size = new System.Drawing.Size(100, 22);
            this.employeesSearch_TextBox.TabIndex = 31;
            // 
            // accountsSearch_TextBox
            // 
            this.accountsSearch_TextBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Id",
            "Username"});
            this.accountsSearch_TextBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.accountsSearch_TextBox.Location = new System.Drawing.Point(856, 316);
            this.accountsSearch_TextBox.Name = "accountsSearch_TextBox";
            this.accountsSearch_TextBox.Size = new System.Drawing.Size(100, 22);
            this.accountsSearch_TextBox.TabIndex = 32;
            // 
            // customersSearch_ComboBox
            // 
            this.customersSearch_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.customersSearch_ComboBox.FormattingEnabled = true;
            this.customersSearch_ComboBox.Items.AddRange(new object[] {
            "Id",
            "First Name",
            "Last Name",
            "Address",
            "City",
            "State"});
            this.customersSearch_ComboBox.Location = new System.Drawing.Point(221, 10);
            this.customersSearch_ComboBox.Name = "customersSearch_ComboBox";
            this.customersSearch_ComboBox.Size = new System.Drawing.Size(100, 21);
            this.customersSearch_ComboBox.TabIndex = 33;
            // 
            // appointmentsSearch_ComboBox
            // 
            this.appointmentsSearch_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.appointmentsSearch_ComboBox.FormattingEnabled = true;
            this.appointmentsSearch_ComboBox.Items.AddRange(new object[] {
            "Id",
            "Type",
            "Customer Id",
            "Employee Id"});
            this.appointmentsSearch_ComboBox.Location = new System.Drawing.Point(751, 9);
            this.appointmentsSearch_ComboBox.Name = "appointmentsSearch_ComboBox";
            this.appointmentsSearch_ComboBox.Size = new System.Drawing.Size(100, 21);
            this.appointmentsSearch_ComboBox.TabIndex = 34;
            // 
            // employeesSearch_ComboBox
            // 
            this.employeesSearch_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.employeesSearch_ComboBox.FormattingEnabled = true;
            this.employeesSearch_ComboBox.Items.AddRange(new object[] {
            "Id",
            "First Name",
            "Last Name",
            "Address",
            "City",
            "State",
            "Job Title",
            "Status Number"});
            this.employeesSearch_ComboBox.Location = new System.Drawing.Point(225, 316);
            this.employeesSearch_ComboBox.Name = "employeesSearch_ComboBox";
            this.employeesSearch_ComboBox.Size = new System.Drawing.Size(100, 21);
            this.employeesSearch_ComboBox.TabIndex = 35;
            // 
            // accountsSearch_ComboBox
            // 
            this.accountsSearch_ComboBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.accountsSearch_ComboBox.FormattingEnabled = true;
            this.accountsSearch_ComboBox.Items.AddRange(new object[] {
            "Id",
            "Username"});
            this.accountsSearch_ComboBox.Location = new System.Drawing.Point(750, 316);
            this.accountsSearch_ComboBox.Name = "accountsSearch_ComboBox";
            this.accountsSearch_ComboBox.Size = new System.Drawing.Size(100, 21);
            this.accountsSearch_ComboBox.TabIndex = 36;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 611);
            this.ControlBox = false;
            this.Controls.Add(this.accountsSearch_ComboBox);
            this.Controls.Add(this.employeesSearch_ComboBox);
            this.Controls.Add(this.appointmentsSearch_ComboBox);
            this.Controls.Add(this.customersSearch_ComboBox);
            this.Controls.Add(this.accountsSearch_TextBox);
            this.Controls.Add(this.employeesSearch_TextBox);
            this.Controls.Add(this.accountsSearch_Button);
            this.Controls.Add(this.accountsCreate_Button);
            this.Controls.Add(this.accountsEdit_Button);
            this.Controls.Add(this.accountsDelete_Button);
            this.Controls.Add(this.employeesSearch_Button);
            this.Controls.Add(this.employeesCreate_Button);
            this.Controls.Add(this.employeesEdit_Button);
            this.Controls.Add(this.employeesDelete_Button);
            this.Controls.Add(this.reports_Button);
            this.Controls.Add(this.appointmentsSearch_TextBox);
            this.Controls.Add(this.customersSearch_TextBox);
            this.Controls.Add(this.customersSearch_Button);
            this.Controls.Add(this.appointmentsSearch_Button);
            this.Controls.Add(this.appointmentsCreate_Button);
            this.Controls.Add(this.appointmentsEdit_Button);
            this.Controls.Add(this.appointmentsDelete_Button);
            this.Controls.Add(this.customersCreate_Button);
            this.Controls.Add(this.customersEdit_Button);
            this.Controls.Add(this.customersDelete_Button);
            this.Controls.Add(this.customers_Label);
            this.Controls.Add(this.customers_DataGrid);
            this.Controls.Add(this.accounts_Label);
            this.Controls.Add(this.employees_Label);
            this.Controls.Add(this.employees_DataGrid);
            this.Controls.Add(this.accounts_DataGrid);
            this.Controls.Add(this.appointments_DataGrid);
            this.Controls.Add(this.appointments_Label);
            this.Controls.Add(this.logout_Button);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main_Form";
            this.Text = "HairSpa";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customers_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointments_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accounts_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employees_DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout_Button;
        private System.Windows.Forms.DataGridView customers_DataGrid;
        private System.Windows.Forms.Label customers_Label;
        private System.Windows.Forms.Label appointments_Label;
        private System.Windows.Forms.DataGridView appointments_DataGrid;
        private System.Windows.Forms.DataGridView accounts_DataGrid;
        private System.Windows.Forms.DataGridView employees_DataGrid;
        private System.Windows.Forms.Label employees_Label;
        private System.Windows.Forms.Label accounts_Label;
        private System.Windows.Forms.Button customersDelete_Button;
        private System.Windows.Forms.Button customersEdit_Button;
        private System.Windows.Forms.Button customersCreate_Button;
        private System.Windows.Forms.Button appointmentsDelete_Button;
        private System.Windows.Forms.Button appointmentsEdit_Button;
        private System.Windows.Forms.Button appointmentsCreate_Button;
        private System.Windows.Forms.Button appointmentsSearch_Button;
        private System.Windows.Forms.Button customersSearch_Button;
        private System.Windows.Forms.TextBox customersSearch_TextBox;
        private System.Windows.Forms.TextBox appointmentsSearch_TextBox;
        private System.Windows.Forms.Button reports_Button;
        private System.Windows.Forms.Button employeesSearch_Button;
        private System.Windows.Forms.Button employeesCreate_Button;
        private System.Windows.Forms.Button employeesEdit_Button;
        private System.Windows.Forms.Button employeesDelete_Button;
        private System.Windows.Forms.Button accountsSearch_Button;
        private System.Windows.Forms.Button accountsCreate_Button;
        private System.Windows.Forms.Button accountsEdit_Button;
        private System.Windows.Forms.Button accountsDelete_Button;
        private System.Windows.Forms.TextBox employeesSearch_TextBox;
        private System.Windows.Forms.TextBox accountsSearch_TextBox;
        private System.Windows.Forms.ComboBox customersSearch_ComboBox;
        private System.Windows.Forms.ComboBox appointmentsSearch_ComboBox;
        private System.Windows.Forms.ComboBox employeesSearch_ComboBox;
        private System.Windows.Forms.ComboBox accountsSearch_ComboBox;
    }
}