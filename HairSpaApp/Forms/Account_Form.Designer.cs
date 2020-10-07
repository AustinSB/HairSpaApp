namespace HairSpaApp.Forms
{
    partial class Account_Form
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
            this.account_Label = new System.Windows.Forms.Label();
            this.acctCancel_Button = new System.Windows.Forms.Button();
            this.acctSave_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.showPass_Button = new System.Windows.Forms.Button();
            this.pass2_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // account_Label
            // 
            this.account_Label.AutoSize = true;
            this.account_Label.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.account_Label.Location = new System.Drawing.Point(12, 9);
            this.account_Label.Name = "account_Label";
            this.account_Label.Size = new System.Drawing.Size(66, 21);
            this.account_Label.TabIndex = 0;
            this.account_Label.Text = "Account";
            // 
            // acctCancel_Button
            // 
            this.acctCancel_Button.Location = new System.Drawing.Point(12, 217);
            this.acctCancel_Button.Name = "acctCancel_Button";
            this.acctCancel_Button.Size = new System.Drawing.Size(75, 30);
            this.acctCancel_Button.TabIndex = 1;
            this.acctCancel_Button.Text = "Cancel";
            this.acctCancel_Button.UseVisualStyleBackColor = true;
            this.acctCancel_Button.Click += new System.EventHandler(this.acctCancel_Button_Click);
            // 
            // acctSave_Button
            // 
            this.acctSave_Button.Location = new System.Drawing.Point(235, 217);
            this.acctSave_Button.Name = "acctSave_Button";
            this.acctSave_Button.Size = new System.Drawing.Size(75, 30);
            this.acctSave_Button.TabIndex = 2;
            this.acctSave_Button.Text = "Save";
            this.acctSave_Button.UseVisualStyleBackColor = true;
            this.acctSave_Button.Click += new System.EventHandler(this.acctSave_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // username_TextBox
            // 
            this.username_TextBox.Location = new System.Drawing.Point(110, 50);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(150, 25);
            this.username_TextBox.TabIndex = 5;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(110, 100);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '*';
            this.password_TextBox.Size = new System.Drawing.Size(150, 25);
            this.password_TextBox.TabIndex = 6;
            // 
            // showPass_Button
            // 
            this.showPass_Button.Location = new System.Drawing.Point(266, 100);
            this.showPass_Button.Name = "showPass_Button";
            this.showPass_Button.Size = new System.Drawing.Size(51, 30);
            this.showPass_Button.TabIndex = 7;
            this.showPass_Button.Text = "Show";
            this.showPass_Button.UseVisualStyleBackColor = true;
            this.showPass_Button.Click += new System.EventHandler(this.showPass_Button_Click);
            // 
            // pass2_TextBox
            // 
            this.pass2_TextBox.Location = new System.Drawing.Point(110, 150);
            this.pass2_TextBox.Name = "pass2_TextBox";
            this.pass2_TextBox.PasswordChar = '*';
            this.pass2_TextBox.Size = new System.Drawing.Size(150, 25);
            this.pass2_TextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 38);
            this.label3.TabIndex = 9;
            this.label3.Text = "Re-Enter\r\nPassword";
            // 
            // Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 259);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pass2_TextBox);
            this.Controls.Add(this.showPass_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.username_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.acctSave_Button);
            this.Controls.Add(this.acctCancel_Button);
            this.Controls.Add(this.account_Label);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Account_Form";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account_Label;
        private System.Windows.Forms.Button acctCancel_Button;
        private System.Windows.Forms.Button acctSave_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button showPass_Button;
        private System.Windows.Forms.TextBox pass2_TextBox;
        private System.Windows.Forms.Label label3;
    }
}