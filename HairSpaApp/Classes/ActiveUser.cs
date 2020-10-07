using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSpaApp.Classes
{
    static class ActiveUser
    {
        static private Employee emp;
        static public Employee ActiveEmp
        {
            get { return emp; }
            set { emp = ActiveEmp; }
        }

        static private Account acct;
        static public Account ActiveAcct
        {
            get { return acct; }
            set { acct = ActiveAcct; }
        }

        static public bool AreCredentialsValid(HairSpaContext context, string username, string password)
        {
            acct = context.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);
            
            if (acct != null)
            {
                emp = context.Employees.FirstOrDefault(e => e.AccountsId == acct.Id);

                acct.IsActive = true;
                context.SaveChanges();

                return true;
            }
            else
            {
                MessageBox.Show("Login attempt failed", "Invalid Login");
                return false;
            }
        }

        static public bool ConfirmLogout()
        {
            var logoutMessage = MessageBox.Show("Do you really want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo);
            if (logoutMessage == DialogResult.Yes)
            {
                acct.IsActive = false;
                acct = null;
                emp = null;

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
