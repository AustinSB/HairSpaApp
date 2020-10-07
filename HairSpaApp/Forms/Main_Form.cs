using HairSpaApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSpaApp.Forms
{
    public partial class Main_Form : Form
    {
        HairSpaContext _context;

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            SetDataGrids();
        }

        //Controls
        public event EventHandler LogoutClicked;
        private void logout_Button_Click(object sender, EventArgs e)
        {
            if (ActiveUser.ConfirmLogout())
            {
                LogoutClicked(this, e);
                this.Close();
            }
        }

        //Account Controls
        private void accounts_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                Main.AccountIndex = Main.AccountList[0];
                accounts_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                Main.AccountIndex = Main.AccountList[e.RowIndex];
            }
        }

        private void accountsCreate_Button_Click(object sender, EventArgs e)
        {
            Main.AccountIndex = null;
            var account_Form = new Account_Form();
            account_Form.AccountFormClosed += new EventHandler(accountForm_Closed);
            account_Form.Show();
            this.Enabled = false;
        }

        private void accountsEdit_Button_Click(object sender, EventArgs e)
        {
            if (Main.AccountIndex == null) 
            {
                MessageBox.Show("Must select item to edit", "Invalid Selection");
                return;
            }

            var account_Form = new Account_Form();
            account_Form.AccountFormClosed += new EventHandler(accountForm_Closed);
            account_Form.Show();
            this.Enabled = false;
        }

        private void accountForm_Closed(object sender, EventArgs e) => RefreshMain();

        private void accountsDelete_Button_Click(object sender, EventArgs e)
        {
            using (_context = new HairSpaContext())
            {
                if (Main.DeleteAccount(_context)) { SetDataGrids(); }
                else { return; }
            }
        }

        private void accountsSearch_Button_Click(object sender, EventArgs e)
        {
            using (_context = new HairSpaContext())
            {
                switch (accountsSearch_Button.Text)
                {
                    case "Search":
                        Main.SearchAccount(accountsSearch_ComboBox, accountsSearch_TextBox, _context);
                        accountsSearch_Button.Text = "Clear";
                        break;
                    case "Clear":
                        SetDataGrids();
                        accountsSearch_Button.Text = "Search";
                        accountsSearch_TextBox.Text = "";
                        break;
                }
            }
        }

        //Customer Controls
        private void customers_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                Main.CustomerIndex = Main.CustomerList[0];
                customers_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                Main.CustomerIndex = Main.CustomerList[e.RowIndex];
            }
        }

        private void customersCreate_Button_Click(object sender, EventArgs e)
        {
            Main.CustomerIndex = null;
            var customer_Form = new Customer_Form();
            customer_Form.CustomerFormClosed += new EventHandler(customerForm_Closed);
            customer_Form.Show();
            this.Enabled = false;
        }

        private void customersEdit_Button_Click(object sender, EventArgs e)
        {
            if (Main.CustomerIndex == null) 
            {
                MessageBox.Show("Must select item to edit", "Invalid Selection");
                return; 
            }

            var customer_Form = new Customer_Form();
            customer_Form.CustomerFormClosed += new EventHandler(customerForm_Closed);
            customer_Form.Show();
            this.Enabled = false;
        }

        private void customerForm_Closed(object sender, EventArgs e) => RefreshMain();

        private void customersDelete_Button_Click(object sender, EventArgs e)
        {
            using (_context = new HairSpaContext())
            {
                if (Main.DeleteCustomer(_context)) { SetDataGrids(); }
                else { return; }
            }
        }

        private void customersSearch_Button_Click(object sender, EventArgs e)
        {
            using (_context = new HairSpaContext())
            {
                switch (customersSearch_Button.Text)
                {
                    case "Search":
                        Main.SearchCustomer(customersSearch_ComboBox, customersSearch_TextBox, _context);
                        customersSearch_Button.Text = "Clear";
                        break;
                    case "Clear":
                        SetDataGrids();
                        customersSearch_Button.Text = "Search";
                        customersSearch_TextBox.Text = "";
                        break;
                }
            }
        }

        //Employees Controls
        private void employees_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                Main.EmployeeIndex = Main.EmployeeList[0];
                employees_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                Main.EmployeeIndex = Main.EmployeeList[e.RowIndex];
            }
        }

        private void employeesCreate_Button_Click(object sender, EventArgs e)
        {
            Main.EmployeeIndex = null;
            var employee_Form = new Employee_Form();
            employee_Form.EmployeeFormClosed += new EventHandler(employeeForm_Closed);
            employee_Form.Show();
            this.Enabled = false;
        }

        private void employeesEdit_Button_Click(object sender, EventArgs e)
        {
            if (Main.EmployeeIndex == null) 
            {
                MessageBox.Show("Must select item to edit", "Invalid Selection");
                return;
            }

            var employee_Form = new Employee_Form();
            employee_Form.EmployeeFormClosed += new EventHandler(employeeForm_Closed);
            employee_Form.Show();
            this.Enabled = false;
        }

        private void employeeForm_Closed(object sender, EventArgs e) => RefreshMain();

        private void employeesDelete_Button_Click(object sender, EventArgs e)
        {
            using (_context = new HairSpaContext())
            {
                if (Main.DeleteEmployee(_context)) { SetDataGrids(); }
                else { return; }
            }
        }

        private void employeesSearch_Button_Click(object sender, EventArgs e)
        {
            using (_context = new HairSpaContext())
            {
                switch (employeesSearch_Button.Text)
                {
                    case "Search":
                        Main.SearchEmployee(employeesSearch_ComboBox, employeesSearch_TextBox, _context);
                        employeesSearch_Button.Text = "Clear";
                        break;
                    case "Clear":
                        SetDataGrids();
                        employeesSearch_Button.Text = "Search";
                        employeesSearch_TextBox.Text = "";
                        break;
                }
            }
        }

        //Appointments Controls
        private void appointments_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                Main.AppointmentIndex = Main.AppointmentList[0];
                appointments_DataGrid.Rows[0].Selected = true;
            }
            else
            {
                Main.AppointmentIndex = Main.AppointmentList[e.RowIndex];
            }
        }

        private void appointmentsCreate_Button_Click(object sender, EventArgs e)
        {
            Main.AppointmentIndex = null;
            var appointment_Form = new Appointment_Form();
            appointment_Form.AppointmentFormClosed += new EventHandler(appointmentForm_Closed);
            appointment_Form.Show();
            this.Enabled = false;
        }

        private void appointmentsEdit_Button_Click(object sender, EventArgs e)
        {
            if(Main.AppointmentIndex == null) 
            {
                MessageBox.Show("Must select item to edit", "Invalid Selection");
                return;
            }

            var appointment_Form = new Appointment_Form();
            appointment_Form.AppointmentFormClosed += new EventHandler(appointmentForm_Closed);
            appointment_Form.Show();
            this.Enabled = false;
        }

        private void appointmentForm_Closed(object sender, EventArgs e) => RefreshMain();

        private void appointmentsDelete_Button_Click(object sender, EventArgs e)
        {
            using (_context = new HairSpaContext())
            {
                if (Main.DeleteAppointment(_context)) { SetDataGrids(); }
                else { return; }
            }
        }

        private void appointmentsSearch_Button_Click(object sender, EventArgs e)
        {
            using (_context = new HairSpaContext())
            {
                switch (appointmentsSearch_Button.Text)
                {
                    case "Search":
                        Main.SearchAppointment(appointmentsSearch_ComboBox, appointmentsSearch_TextBox, _context);
                        appointmentsSearch_Button.Text = "Clear";
                        break;
                    case "Clear":
                        SetDataGrids();
                        appointmentsSearch_Button.Text = "Search";
                        appointmentsSearch_TextBox.Text = "";
                        break;
                }
            }
        }

        //Reports
        private void reports_Button_Click(object sender, EventArgs e)
        {
            var report_Form = new Reports_Form();
            report_Form.ReportFormClosed += new EventHandler(reportForm_Closed);
            report_Form.Show();
            this.Enabled = false;
        }

        private void reportForm_Closed(object sender, EventArgs e) => RefreshMain();

        //Methods
        private void RefreshMain()
        {
            SetDataGrids();
            this.Enabled = true;
        }

        private void SetDataGrids()
        {
            using(_context = new HairSpaContext())
            {
                Main.GetAllAccounts(_context);
                Main.GetAllCustomers(_context);
                Main.GetAllEmployees(_context);
                Main.GetAllAppointments(_context);

                accounts_DataGrid.DataSource = Main.AccountList;
                customers_DataGrid.DataSource = Main.CustomerList;
                employees_DataGrid.DataSource = Main.EmployeeList;
                appointments_DataGrid.DataSource = Main.AppointmentList;

                HideColumns();
            }

            ChangeTimeZone();

            Main.AccountIndex = null;
            Main.CustomerIndex = null;
            Main.EmployeeIndex = null;
            Main.AppointmentIndex = null;

            DeselectRows(accounts_DataGrid);
            DeselectRows(customers_DataGrid);
            DeselectRows(employees_DataGrid);
            DeselectRows(appointments_DataGrid);
        }

        private void DeselectRows(DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                dataGrid.Rows[i].Selected = false;
            }
        }

        private void HideColumns()
        {
            accounts_DataGrid.Columns["Password"].Visible = false;
            accounts_DataGrid.Columns["Employees"].Visible = false;

            customers_DataGrid.Columns["Appointments"].Visible = false;

            employees_DataGrid.Columns["Account"].Visible = false;
            employees_DataGrid.Columns["Appointments"].Visible = false;

            appointments_DataGrid.Columns["Customer"].Visible = false;
            appointments_DataGrid.Columns["Employee"].Visible = false;
        }
        
        //move to main (there is a duplicate of this in reports class)
        private void ChangeTimeZone()
        {
            foreach (var ap in Main.AppointmentList)
            {
                if (ap.StartTime.Kind == DateTimeKind.Unspecified || ap.StartTime.Kind == DateTimeKind.Utc)
                {
                    ap.StartTime = DateTime.SpecifyKind(ap.StartTime, DateTimeKind.Utc).ToLocalTime();
                }

                if (ap.EndTime.Kind == DateTimeKind.Unspecified || ap.EndTime.Kind == DateTimeKind.Utc)
                {
                    ap.EndTime = DateTime.SpecifyKind(ap.EndTime, DateTimeKind.Utc).ToLocalTime();
                }
            }
        }
    }
}
