using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSpaApp.Classes
{
    public static class Validate
    {
        public static void SetMinDate(DateTimePicker start, DateTimePicker end)
        {
            start.MinDate = DateTime.Now;
            end.MinDate = DateTime.Now;
        }

        public static bool IsDateValid(DateTimePicker start, DateTimePicker end)
        {   
            if (start.Value.Date != end.Value.Date)
            {
                MessageBox.Show("Start and end times must be on the same day", "Invalid Dates");
                return false;
            }

            if (start.Value.Hour > end.Value.Hour)
            {
                MessageBox.Show("Start time must be before end time", "Invalid Times");
                return false;
            }

            if (start.Value.Hour < 8 || start.Value.Hour > 17 
               || end.Value.Hour < 8 || end.Value.Hour > 17)
            {
                MessageBox.Show("Hours must be within business hours (8am - 5pm)", "Invalid Hours");
                return false;
            }

            return true;
        }

        public static bool IsTextValid(string text, string inputName)
        {
            if (String.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show($"{inputName} cannot be empty", "Empty Input");
                return false;
            }

            return true;
        }
        
        public static bool IsPasswordValid(string pass, string pass2)
        {
            if (String.IsNullOrWhiteSpace(pass) || String.IsNullOrWhiteSpace(pass2))
            {
                MessageBox.Show("Passwords cannot be empty", "Empty Input");
                return false;
            }
            else if (pass != pass2)
            {
                MessageBox.Show("Passwords must match", "Invalid Input");
                return false;
            }

            return true;
        }

        public static bool IsComboBoxValid(ComboBox box, string inputName)
        {
            if (box.SelectedIndex > -1) { return true; }
            else 
            {
                MessageBox.Show($"Must select valid option for {inputName}", "Invalid Selection");
                return false; 
            }
        }

        public static bool IsPhoneValid(string phone)
        {
            if (phone.Length == 10 && phone.All(c => Char.IsDigit(c)))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Phone # must be a 10 digit number", "Invalid Phone");
                return false;
            }
        }

        public static bool IsEmailValid(string email)
        {
            if (String.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email cannot be empty","Empty Email");
                return false;
            }

            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid email format", "Invalid Email");
                return false;
            }
        }
    }
}
