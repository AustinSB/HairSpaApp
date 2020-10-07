namespace HairSpaApp.Forms
{
    partial class Reports_Form
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
            this.report_TextBox = new System.Windows.Forms.RichTextBox();
            this.selectReport_ComboBox = new System.Windows.Forms.ComboBox();
            this.showReport_Button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            // 
            // report_TextBox
            // 
            this.report_TextBox.Location = new System.Drawing.Point(12, 48);
            this.report_TextBox.Name = "report_TextBox";
            this.report_TextBox.Size = new System.Drawing.Size(560, 350);
            this.report_TextBox.TabIndex = 1;
            this.report_TextBox.Text = "";
            this.report_TextBox.WordWrap = false;
            // 
            // selectReport_ComboBox
            // 
            this.selectReport_ComboBox.FormattingEnabled = true;
            this.selectReport_ComboBox.Items.AddRange(new object[] {
            "Appointments by month",
            "Customers by name",
            "Employees by job title"});
            this.selectReport_ComboBox.Location = new System.Drawing.Point(116, 15);
            this.selectReport_ComboBox.Name = "selectReport_ComboBox";
            this.selectReport_ComboBox.Size = new System.Drawing.Size(200, 25);
            this.selectReport_ComboBox.TabIndex = 2;
            // 
            // showReport_Button
            // 
            this.showReport_Button.Location = new System.Drawing.Point(322, 12);
            this.showReport_Button.Name = "showReport_Button";
            this.showReport_Button.Size = new System.Drawing.Size(150, 30);
            this.showReport_Button.TabIndex = 3;
            this.showReport_Button.Text = "Show Report";
            this.showReport_Button.UseVisualStyleBackColor = true;
            this.showReport_Button.Click += new System.EventHandler(this.showReport_Button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(12, 419);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 30);
            this.cancel_Button.TabIndex = 4;
            this.cancel_Button.Text = "Close";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // Reports_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.showReport_Button);
            this.Controls.Add(this.selectReport_ComboBox);
            this.Controls.Add(this.report_TextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Reports_Form";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox report_TextBox;
        private System.Windows.Forms.ComboBox selectReport_ComboBox;
        private System.Windows.Forms.Button showReport_Button;
        private System.Windows.Forms.Button cancel_Button;
    }
}