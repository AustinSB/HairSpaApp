namespace HairSpaApp.Forms
{
    partial class Appointment_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.appt_Label = new System.Windows.Forms.Label();
            this.type_TextBox = new System.Windows.Forms.TextBox();
            this.cost_TextBox = new System.Windows.Forms.TextBox();
            this.start_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.end_DatePicker = new System.Windows.Forms.DateTimePicker();
            this.employee_ComboBox = new System.Windows.Forms.ComboBox();
            this.customer_ComboBox = new System.Windows.Forms.ComboBox();
            this.apptCancel_Button = new System.Windows.Forms.Button();
            this.apptSave_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Starts";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ends";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer";
            // 
            // appt_Label
            // 
            this.appt_Label.AutoSize = true;
            this.appt_Label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.appt_Label.Location = new System.Drawing.Point(12, 9);
            this.appt_Label.Name = "appt_Label";
            this.appt_Label.Size = new System.Drawing.Size(101, 21);
            this.appt_Label.TabIndex = 6;
            this.appt_Label.Text = "Appointment";
            // 
            // type_TextBox
            // 
            this.type_TextBox.Location = new System.Drawing.Point(75, 50);
            this.type_TextBox.Name = "type_TextBox";
            this.type_TextBox.Size = new System.Drawing.Size(150, 25);
            this.type_TextBox.TabIndex = 7;
            // 
            // cost_TextBox
            // 
            this.cost_TextBox.Location = new System.Drawing.Point(75, 100);
            this.cost_TextBox.Name = "cost_TextBox";
            this.cost_TextBox.Size = new System.Drawing.Size(100, 25);
            this.cost_TextBox.TabIndex = 8;
            // 
            // start_DatePicker
            // 
            this.start_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.start_DatePicker.Location = new System.Drawing.Point(75, 150);
            this.start_DatePicker.Name = "start_DatePicker";
            this.start_DatePicker.Size = new System.Drawing.Size(256, 25);
            this.start_DatePicker.TabIndex = 9;
            // 
            // end_DatePicker
            // 
            this.end_DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.end_DatePicker.Location = new System.Drawing.Point(75, 200);
            this.end_DatePicker.Name = "end_DatePicker";
            this.end_DatePicker.Size = new System.Drawing.Size(256, 25);
            this.end_DatePicker.TabIndex = 10;
            // 
            // employee_ComboBox
            // 
            this.employee_ComboBox.FormattingEnabled = true;
            this.employee_ComboBox.Location = new System.Drawing.Point(375, 50);
            this.employee_ComboBox.Name = "employee_ComboBox";
            this.employee_ComboBox.Size = new System.Drawing.Size(121, 25);
            this.employee_ComboBox.TabIndex = 11;
            // 
            // customer_ComboBox
            // 
            this.customer_ComboBox.FormattingEnabled = true;
            this.customer_ComboBox.Location = new System.Drawing.Point(375, 100);
            this.customer_ComboBox.Name = "customer_ComboBox";
            this.customer_ComboBox.Size = new System.Drawing.Size(121, 25);
            this.customer_ComboBox.TabIndex = 12;
            // 
            // apptCancel_Button
            // 
            this.apptCancel_Button.Location = new System.Drawing.Point(12, 269);
            this.apptCancel_Button.Name = "apptCancel_Button";
            this.apptCancel_Button.Size = new System.Drawing.Size(75, 30);
            this.apptCancel_Button.TabIndex = 13;
            this.apptCancel_Button.Text = "Cancel";
            this.apptCancel_Button.UseVisualStyleBackColor = true;
            this.apptCancel_Button.Click += new System.EventHandler(this.apptCancel_Button_Click);
            // 
            // apptSave_Button
            // 
            this.apptSave_Button.Location = new System.Drawing.Point(447, 269);
            this.apptSave_Button.Name = "apptSave_Button";
            this.apptSave_Button.Size = new System.Drawing.Size(75, 30);
            this.apptSave_Button.TabIndex = 14;
            this.apptSave_Button.Text = "Save";
            this.apptSave_Button.UseVisualStyleBackColor = true;
            this.apptSave_Button.Click += new System.EventHandler(this.apptSave_Button_Click);
            // 
            // Appointment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.apptSave_Button);
            this.Controls.Add(this.apptCancel_Button);
            this.Controls.Add(this.customer_ComboBox);
            this.Controls.Add(this.employee_ComboBox);
            this.Controls.Add(this.end_DatePicker);
            this.Controls.Add(this.start_DatePicker);
            this.Controls.Add(this.cost_TextBox);
            this.Controls.Add(this.type_TextBox);
            this.Controls.Add(this.appt_Label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Appointment_Form";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label appt_Label;
        private System.Windows.Forms.TextBox type_TextBox;
        private System.Windows.Forms.TextBox cost_TextBox;
        private System.Windows.Forms.DateTimePicker start_DatePicker;
        private System.Windows.Forms.DateTimePicker end_DatePicker;
        private System.Windows.Forms.ComboBox employee_ComboBox;
        private System.Windows.Forms.ComboBox customer_ComboBox;
        private System.Windows.Forms.Button apptCancel_Button;
        private System.Windows.Forms.Button apptSave_Button;
    }
}