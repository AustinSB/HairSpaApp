namespace HairSpaApp
{
    partial class login_Form
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
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.login_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.showPass_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // username_TextBox
            // 
            this.username_TextBox.Location = new System.Drawing.Point(116, 27);
            this.username_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(116, 25);
            this.username_TextBox.TabIndex = 2;
            // 
            // password_TextBox
            // 
            this.password_TextBox.Location = new System.Drawing.Point(116, 104);
            this.password_TextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.PasswordChar = '*';
            this.password_TextBox.Size = new System.Drawing.Size(116, 25);
            this.password_TextBox.TabIndex = 3;
            // 
            // login_Button
            // 
            this.login_Button.Location = new System.Drawing.Point(187, 170);
            this.login_Button.Name = "login_Button";
            this.login_Button.Size = new System.Drawing.Size(100, 30);
            this.login_Button.TabIndex = 4;
            this.login_Button.Text = "Login";
            this.login_Button.UseVisualStyleBackColor = true;
            this.login_Button.Click += new System.EventHandler(this.login_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(12, 170);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(100, 30);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // showPass_Button
            // 
            this.showPass_Button.Location = new System.Drawing.Point(238, 104);
            this.showPass_Button.Name = "showPass_Button";
            this.showPass_Button.Size = new System.Drawing.Size(51, 30);
            this.showPass_Button.TabIndex = 6;
            this.showPass_Button.Text = "Show";
            this.showPass_Button.UseVisualStyleBackColor = true;
            this.showPass_Button.Click += new System.EventHandler(this.showPass_Button_Click);
            // 
            // login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 211);
            this.Controls.Add(this.showPass_Button);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.login_Button);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.username_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "login_Form";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.Button login_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button showPass_Button;
    }
}

