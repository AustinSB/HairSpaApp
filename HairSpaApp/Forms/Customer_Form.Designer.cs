namespace HairSpaApp.Forms
{
    partial class Customer_Form
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
            this.customerCancel_Button = new System.Windows.Forms.Button();
            this.customerSave_Button = new System.Windows.Forms.Button();
            this.firstName_TextBox = new System.Windows.Forms.TextBox();
            this.lastName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.address_TextBox = new System.Windows.Forms.TextBox();
            this.city_TextBox = new System.Windows.Forms.TextBox();
            this.phone_TextBox = new System.Windows.Forms.TextBox();
            this.email_TextBox = new System.Windows.Forms.TextBox();
            this.customerHeader_Label = new System.Windows.Forms.Label();
            this.state_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // customerCancel_Button
            // 
            this.customerCancel_Button.Location = new System.Drawing.Point(12, 319);
            this.customerCancel_Button.Name = "customerCancel_Button";
            this.customerCancel_Button.Size = new System.Drawing.Size(75, 30);
            this.customerCancel_Button.TabIndex = 1;
            this.customerCancel_Button.Text = "Cancel";
            this.customerCancel_Button.UseVisualStyleBackColor = true;
            this.customerCancel_Button.Click += new System.EventHandler(this.customerCancel_Button_Click);
            // 
            // customerSave_Button
            // 
            this.customerSave_Button.Location = new System.Drawing.Point(447, 319);
            this.customerSave_Button.Name = "customerSave_Button";
            this.customerSave_Button.Size = new System.Drawing.Size(75, 30);
            this.customerSave_Button.TabIndex = 2;
            this.customerSave_Button.Text = "Save";
            this.customerSave_Button.UseVisualStyleBackColor = true;
            this.customerSave_Button.Click += new System.EventHandler(this.customerSave_Button_Click);
            // 
            // firstName_TextBox
            // 
            this.firstName_TextBox.Location = new System.Drawing.Point(100, 50);
            this.firstName_TextBox.Name = "firstName_TextBox";
            this.firstName_TextBox.Size = new System.Drawing.Size(150, 25);
            this.firstName_TextBox.TabIndex = 3;
            // 
            // lastName_TextBox
            // 
            this.lastName_TextBox.Location = new System.Drawing.Point(100, 100);
            this.lastName_TextBox.Name = "lastName_TextBox";
            this.lastName_TextBox.Size = new System.Drawing.Size(150, 25);
            this.lastName_TextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "City";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // address_TextBox
            // 
            this.address_TextBox.Location = new System.Drawing.Point(100, 150);
            this.address_TextBox.Name = "address_TextBox";
            this.address_TextBox.Size = new System.Drawing.Size(150, 25);
            this.address_TextBox.TabIndex = 12;
            // 
            // city_TextBox
            // 
            this.city_TextBox.Location = new System.Drawing.Point(100, 200);
            this.city_TextBox.Name = "city_TextBox";
            this.city_TextBox.Size = new System.Drawing.Size(150, 25);
            this.city_TextBox.TabIndex = 13;
            // 
            // phone_TextBox
            // 
            this.phone_TextBox.Location = new System.Drawing.Point(370, 50);
            this.phone_TextBox.Name = "phone_TextBox";
            this.phone_TextBox.Size = new System.Drawing.Size(150, 25);
            this.phone_TextBox.TabIndex = 15;
            // 
            // email_TextBox
            // 
            this.email_TextBox.Location = new System.Drawing.Point(370, 100);
            this.email_TextBox.Name = "email_TextBox";
            this.email_TextBox.Size = new System.Drawing.Size(150, 25);
            this.email_TextBox.TabIndex = 16;
            // 
            // customerHeader_Label
            // 
            this.customerHeader_Label.AutoSize = true;
            this.customerHeader_Label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.customerHeader_Label.Location = new System.Drawing.Point(12, 9);
            this.customerHeader_Label.Name = "customerHeader_Label";
            this.customerHeader_Label.Size = new System.Drawing.Size(78, 21);
            this.customerHeader_Label.TabIndex = 17;
            this.customerHeader_Label.Text = "Customer";
            // 
            // state_ComboBox
            // 
            this.state_ComboBox.FormattingEnabled = true;
            this.state_ComboBox.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.state_ComboBox.Location = new System.Drawing.Point(100, 245);
            this.state_ComboBox.Name = "state_ComboBox";
            this.state_ComboBox.Size = new System.Drawing.Size(75, 25);
            this.state_ComboBox.TabIndex = 18;
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.state_ComboBox);
            this.Controls.Add(this.customerHeader_Label);
            this.Controls.Add(this.email_TextBox);
            this.Controls.Add(this.phone_TextBox);
            this.Controls.Add(this.city_TextBox);
            this.Controls.Add(this.address_TextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastName_TextBox);
            this.Controls.Add(this.firstName_TextBox);
            this.Controls.Add(this.customerSave_Button);
            this.Controls.Add(this.customerCancel_Button);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Customer_Form";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button customerCancel_Button;
        private System.Windows.Forms.Button customerSave_Button;
        private System.Windows.Forms.TextBox firstName_TextBox;
        private System.Windows.Forms.TextBox lastName_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox address_TextBox;
        private System.Windows.Forms.TextBox city_TextBox;
        private System.Windows.Forms.TextBox phone_TextBox;
        private System.Windows.Forms.TextBox email_TextBox;
        private System.Windows.Forms.Label customerHeader_Label;
        private System.Windows.Forms.ComboBox state_ComboBox;
    }
}