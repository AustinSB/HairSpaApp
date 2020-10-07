using HairSpaApp.Forms;
using HairSpaApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSpaApp
{
    public partial class login_Form : Form
    {
        HairSpaContext _context;

        public login_Form()
        {
            InitializeComponent();
        }

        private void login_Button_Click(object sender, EventArgs e)
        {
            using (_context = new HairSpaContext())
            {
                if (ActiveUser.AreCredentialsValid(_context, username_TextBox.Text, password_TextBox.Text))
                {
                    var main_Form = new Main_Form();
                    main_Form.LogoutClicked += new EventHandler(main_Form_LogoutClicked);
                    main_Form.Show();

                    username_TextBox.Text = "";
                    password_TextBox.Text = "";
                    this.Hide();
                }
            } 
        }

        private void showPass_Button_Click(object sender, EventArgs e)
        {
            switch (password_TextBox.PasswordChar)
            {
                case '*':
                    password_TextBox.PasswordChar = '\0';
                    showPass_Button.Text = "Hide";
                    break;
                case '\0':
                    password_TextBox.PasswordChar = '*';
                    showPass_Button.Text = "Show";
                    break;
            }
        }

        private void RemoveActive()
        {
            using (_context = new HairSpaContext())
            {
                _context.Accounts.ToList().ForEach(ac => ac.IsActive = false);
                _context.SaveChanges();
            }
        }

        private void main_Form_LogoutClicked(object sender, EventArgs e)
        {
            RemoveActive();
            this.Show();
        }

        private void exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
