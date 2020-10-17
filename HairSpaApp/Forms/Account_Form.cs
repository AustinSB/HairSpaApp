using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HairSpaApp.Classes.Main;
using static HairSpaApp.Classes.Validate;

namespace HairSpaApp.Forms
{
    public partial class Account_Form : Form
    {
        HairSpaContext _context;

        public Account_Form()
        {
            InitializeComponent();
        }

        private void Account_Form_Load(object sender, EventArgs e)
        {
            PopulateAccountData();
        }

        //Controls
        private void showPass_Button_Click(object sender, EventArgs e)
        {
            switch (password_TextBox.PasswordChar)
            {
                case '*':
                    password_TextBox.PasswordChar = '\0';
                    pass2_TextBox.PasswordChar = '\0';
                    showPass_Button.Text = "Hide";
                    break;
                case '\0':
                    password_TextBox.PasswordChar = '*';
                    pass2_TextBox.PasswordChar = '*';
                    showPass_Button.Text = "Show";
                    break;
            }
        }

        public event EventHandler AccountFormClosed;
        private void acctSave_Button_Click(object sender, EventArgs e)
        {
            if (!ValidateAccount()) { return; }

            using (_context = new HairSpaContext())
            {
                if (AccountIndex == null) //create
                {
                    var newAcct = new Account();
                    SetAccountData(newAcct);
                    _context.Accounts.Add(newAcct);
                    _context.SaveChanges();
                }
                else //edit
                {
                    var selectedAcct = _context.Accounts.Attach(AccountIndex);
                    SetAccountData(selectedAcct);
                    _context.SaveChanges();
                }
            }

            AccountFormClosed(this, e);
            this.Close();
        }

        private void acctCancel_Button_Click(object sender, EventArgs e)
        {
            AccountFormClosed(this, e);
            this.Close();
        }

        //Methods
        private void PopulateAccountData()
        {
            if (AccountIndex == null) //create
            {
                account_Label.Text = "Create Account";
            }
            else //edit
            {
                account_Label.Text = "Edit Account";

                username_TextBox.Text = AccountIndex.Username;
                password_TextBox.Text = AccountIndex.Password;
                isAdmin_CheckBox.Checked = AccountIndex.IsAdmin;
            }
        }

        private void SetAccountData(Account ac)
        {
            ac.Username = username_TextBox.Text;
            ac.Password = password_TextBox.Text;
            ac.IsAdmin = isAdmin_CheckBox.Checked;
        }

        private bool ValidateAccount()
        {
            if (!IsTextValid(username_TextBox.Text, "Username") || !IsPasswordValid(password_TextBox.Text, pass2_TextBox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
