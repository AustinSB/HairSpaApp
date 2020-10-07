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
using static HairSpaApp.Classes.Main;
using static HairSpaApp.Classes.Validate;

namespace HairSpaApp.Forms
{
    public partial class Employee_Form : Form
    {
        HairSpaContext _context;

        public Employee_Form()
        {
            InitializeComponent();
        }

        private void Employee_Form_Load(object sender, EventArgs e)
        {
            PopulateEmployeeForm();
        }

        //Controls
        public event EventHandler EmployeeFormClosed;
        private void employeeSave_Button_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployee()) { return; }

            using (_context = new HairSpaContext())
            {
                if (EmployeeIndex == null) //create new employee
                {
                    var newEmployee = new Employee();
                    SetEmployeeData(newEmployee);
                    _context.Employees.Add(newEmployee);
                    _context.SaveChanges();
                }
                else // edit existing employee
                {
                    var selectedEmployee = _context.Employees.Attach(EmployeeIndex);
                    SetEmployeeData(selectedEmployee);
                    _context.SaveChanges();
                }
            }

            EmployeeFormClosed(this, e);
            this.Close();
        }

        private void employeeCancel_Button_Click(object sender, EventArgs e)
        {
            EmployeeFormClosed(this, e);
            this.Close();
        }

        //Methods
        private void PopulateEmployeeForm()
        {
            if (EmployeeIndex == null) //blank input fields for new employee
            {
                employeeHeader_Label.Text = "Create Employee";

                SetAccountComboBox();
            }
            else //fill input fields with selected employee's data
            {
                employeeHeader_Label.Text = "Edit Employee";

                firstName_TextBox.Text = EmployeeIndex.FirstName;
                lastName_TextBox.Text = EmployeeIndex.LastName;
                address_TextBox.Text = EmployeeIndex.Address;
                city_TextBox.Text = EmployeeIndex.City;
                state_ComboBox.SelectedItem = EmployeeIndex.State;
                phone_TextBox.Text = EmployeeIndex.Phone;
                email_TextBox.Text = EmployeeIndex.Email;

                jobTitle_TextBox.Text = EmployeeIndex.JobTitle;
                initialDate_DatePicker.Value = EmployeeIndex.InitialDate;
                status_ComboBox.SelectedIndex = EmployeeIndex.Status;
                payType_ComboBox.SelectedItem = EmployeeIndex.PayType;
                pay_TextBox.Text = EmployeeIndex.Pay.ToString();

                SetAccountComboBox();
                //account_ComboBox.SelectedItem = EmployeeIndex.AccountsId;
            }
        }

        private void SetAccountComboBox()
        {
            using (_context = new HairSpaContext())
            {
                var acct = _context.Accounts.Where(ac => ac.Employees.Count <= 0);
                acct.ToList().ForEach(ac => account_ComboBox.Items.Add($"{ac.Id} - {ac.Username}"));

                if (EmployeeIndex != null)
                {
                    var indexAcct = _context.Accounts.FirstOrDefault(ac => ac.Id == EmployeeIndex.AccountsId);
                    account_ComboBox.Items.Add($"{indexAcct.Id} - {indexAcct.Username}");
                    account_ComboBox.SelectedItem = $"{indexAcct.Id} - {indexAcct.Username}";
                }
                else if (EmployeeIndex == null)
                {
                    return;
                }
            }
        }

        private void SetEmployeeData(Employee emp)
        {
            emp.FirstName = firstName_TextBox.Text;
            emp.LastName = lastName_TextBox.Text;
            emp.Address = address_TextBox.Text;
            emp.City = city_TextBox.Text;
            emp.State = state_ComboBox.SelectedItem.ToString();
            emp.Phone = phone_TextBox.Text;
            emp.Email = email_TextBox.Text;

            emp.JobTitle = jobTitle_TextBox.Text;
            emp.InitialDate = initialDate_DatePicker.Value;
            emp.Status = status_ComboBox.SelectedIndex;
            emp.PayType = payType_ComboBox.SelectedItem.ToString();
            emp.Pay = Convert.ToDecimal(pay_TextBox.Text);

            emp.AccountsId = Convert.ToInt32(account_ComboBox.SelectedItem.ToString().FirstOrDefault().ToString());
        }

        private bool ValidateEmployee()
        {
            if (   !IsTextValid(firstName_TextBox.Text, "First Name")
                || !IsTextValid(lastName_TextBox.Text, "Last Name")
                || !IsTextValid(address_TextBox.Text, "Address")
                || !IsTextValid(city_TextBox.Text, "City")
                || !IsComboBoxValid(state_ComboBox, "State")
                || !IsPhoneValid(phone_TextBox.Text)
                || !IsEmailValid(email_TextBox.Text)
                //no check for date
                || !IsTextValid(jobTitle_TextBox.Text, "Job Title")
                || !IsComboBoxValid(status_ComboBox, "Status") 
                || !IsComboBoxValid(payType_ComboBox, "Pay Type") 
                || !IsTextValid(pay_TextBox.Text, "Pay") 
                || !IsComboBoxValid(account_ComboBox, "Account")
                )
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
