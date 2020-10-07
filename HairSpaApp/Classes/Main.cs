using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSpaApp.Classes
{
    static class Main
    {
        static public BindingList<Account> AccountList { get; set; } = new BindingList<Account>();
        static public BindingList<Customer> CustomerList { get; set; } = new BindingList<Customer>();
        static public BindingList<Employee> EmployeeList { get; set; } = new BindingList<Employee>();
        static public BindingList<Appointment> AppointmentList { get; set; } = new BindingList<Appointment>();

        static private Account accountIndex;
        static public Account AccountIndex
        {
            get { return accountIndex; }
            set { accountIndex = value; }
        }

        static private Customer customerIndex;
        static public Customer CustomerIndex
        {
            get { return customerIndex; }
            set { customerIndex = value; }
        }

        static private Employee employeeIndex;
        static public Employee EmployeeIndex
        {
            get { return employeeIndex; }
            set { employeeIndex = value; }
        }

        static private Appointment appointmentIndex;
        static public Appointment AppointmentIndex
        {
            get { return appointmentIndex; }
            set { appointmentIndex = value; }
        }

        //Account Methods
        static public void GetAllAccounts(HairSpaContext context)
        {
            //Clear account list, then add customer table records to the list.
            AccountList.ToList().ForEach(ac => AccountList.Remove(ac));
            context.Accounts.ToList().ForEach(ac => AccountList.Add(ac));
        }

        static public void SearchAccount(ComboBox box, TextBox search, HairSpaContext context)
        {
            IQueryable<Account> list = null;
            AccountList.Clear();

            switch (box.SelectedItem)
            {
                case "Id":
                    list = context.Accounts.Where(ac => ac.Id.ToString().Contains(search.Text));
                    break;
                case "Username":
                    list = context.Accounts.Where(ac => ac.Username.Contains(search.Text));
                    break;
                default:
                    break;
            }

            try
            {
                if (list.ToList().Count <= 0)
                {
                    MessageBox.Show("No records were found", "No Results");
                    return;
                }
                else
                {
                    list.ToList().ForEach(ac => AccountList.Add(ac));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No records were found", "No Results");
                return;
            }
        }

        static public bool DeleteAccount(HairSpaContext context)
        {
            bool inUse = false;

            if (AccountIndex == null)
            {
                MessageBox.Show("Must select an account", "Invalid Selection");
                return false;
            }

            if (AccountIndex.IsActive == true)
            {
                MessageBox.Show("Cannot delete account that is currently active", "Active Account");
                return false;
            }

            //Is there an employee using this account?
            context.Employees.ToList().ForEach(e =>
            {
                if (e.AccountsId == AccountIndex.Id)
                {
                    MessageBox.Show($"Account cannot be deleted because it is associated with employee '{e.FirstName} {e.LastName}'", "Account In Use");
                    inUse = true;
                }
            });

            if (inUse) { return false; }

            var deleteMessage = MessageBox.Show("This will delete the account. Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (deleteMessage == DialogResult.Yes)
            {
                context.Accounts.Attach(AccountIndex);
                context.Accounts.Remove(AccountIndex);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Customer Methods
        static public void GetAllCustomers(HairSpaContext context)
        {
            //Clear customer list, then add customer table records to the list.
            CustomerList.ToList().ForEach(cu => CustomerList.Remove(cu));
            context.Customers.ToList().ForEach(cu => CustomerList.Add(cu));
        }

        static public void SearchCustomer(ComboBox box, TextBox search, HairSpaContext context)
        {
            IQueryable<Customer> list = null;
            CustomerList.Clear();

            switch (box.SelectedItem)
            {
                case "Id":
                    list = context.Customers.Where(cu => cu.Id.ToString().Contains(search.Text));
                    break;
                case "First Name":
                    list = context.Customers.Where(cu => cu.FirstName.Contains(search.Text));
                    break;
                case "Last Name":
                    list = context.Customers.Where(cu => cu.LastName.Contains(search.Text));
                    break;
                case "Address":
                    list = context.Customers.Where(cu => cu.Address.Contains(search.Text));
                    break;
                case "City":
                    list = context.Customers.Where(cu => cu.City.Contains(search.Text));
                    break;
                case "State":
                    list = context.Customers.Where(cu => cu.State.Contains(search.Text));
                    break;
                default:
                    break;
            }

            try
            {
                if (list.ToList().Count <= 0)
                {
                    MessageBox.Show("No records were found", "No Results");
                    return;
                }
                else
                {
                    list.ToList().ForEach(cu => CustomerList.Add(cu));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No records were found", "No Results");
                return;
            }
        }

        static public bool DeleteCustomer(HairSpaContext context)
        {
            bool inUse = false;

            if (CustomerIndex == null) 
            {
                MessageBox.Show("Must select a customer","Invalid Selection");
                return false;
            }

            //Is this customer used in an appointment?
            context.Appointments.ToList().ForEach(ap =>
            {
                if (ap.CustomersId == CustomerIndex.Id)
                {
                    MessageBox.Show($"Customer cannot be deleted because it is used in appointment with ID: {ap.Id}", "Customer In Use");
                    inUse = true;
                }
            });

            if (inUse) { return false; }

            var deleteMessage = MessageBox.Show("This will delete the customer. Are you sure?", "Confirm Delete",MessageBoxButtons.YesNo);
            if(deleteMessage == DialogResult.Yes)
            {
                context.Customers.Attach(CustomerIndex);
                context.Customers.Remove(CustomerIndex);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Employee Methods
        static public void GetAllEmployees(HairSpaContext context)
        {
            //Clear employee list, then add customer table records to the list.
            EmployeeList.ToList().ForEach(emp => EmployeeList.Remove(emp));
            context.Employees.ToList().ForEach(emp => EmployeeList.Add(emp));
        }

        static public void SearchEmployee(ComboBox box, TextBox search, HairSpaContext context)
        {
            IQueryable<Employee> list = null;
            EmployeeList.Clear();

            switch (box.SelectedItem)
            {
                case "Id":
                    list = context.Employees.Where(emp => emp.Id.ToString().Contains(search.Text));
                    break;
                case "First Name":
                    list = context.Employees.Where(emp => emp.FirstName.Contains(search.Text));
                    break;
                case "Last Name":
                    list = context.Employees.Where(emp => emp.LastName.Contains(search.Text));
                    break;
                case "Address":
                    list = context.Employees.Where(emp => emp.Address.Contains(search.Text));
                    break;
                case "City":
                    list = context.Employees.Where(emp => emp.City.Contains(search.Text));
                    break;
                case "State":
                    list = context.Employees.Where(emp => emp.State.Contains(search.Text));
                    break;
                case "Job Title":
                    list = context.Employees.Where(emp => emp.JobTitle.Contains(search.Text));
                    break;
                case "Status Number":
                    list = context.Employees.Where(emp => emp.Status.ToString().Contains(search.Text));
                    break;
                default:
                    break;
            }

            try
            {
                if (list.ToList().Count <= 0)
                {
                    MessageBox.Show("No records were found", "No Results");
                    return;
                }
                else
                {
                    list.ToList().ForEach(emp => EmployeeList.Add(emp));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No records were found", "No Results");
                return;
            }
        }

        static public bool DeleteEmployee(HairSpaContext context)
        {
            bool inUse = false;

            if (EmployeeIndex == null)
            {
                MessageBox.Show("Must select an employee","Invalid Selection");
                return false;
            }

            //Is this customer used in an appointment?
            context.Appointments.ToList().ForEach(ap =>
            {
                if (ap.EmployeesId == EmployeeIndex.Id)
                {
                    MessageBox.Show($"Employee cannot be deleted because it is used in appointment with ID: {ap.Id}", "Employee In Use");
                    inUse = true;
                }
            });

            if (inUse) { return false; }

            var deleteMessage = MessageBox.Show("This will delete the employee. Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (deleteMessage == DialogResult.Yes)
            {
                context.Employees.Attach(EmployeeIndex);
                context.Employees.Remove(EmployeeIndex);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Appointment Methods
        static public void GetAllAppointments(HairSpaContext context)
        {
            //Clear appointment list, then add appointment table records to the list.
            AppointmentList.ToList().ForEach(ap => AppointmentList.Remove(ap));
            context.Appointments.ToList().ForEach(ap => AppointmentList.Add(ap));
        }

        static public void SearchAppointment(ComboBox box, TextBox search, HairSpaContext context)
        {
            IQueryable<Appointment> list = null;
            AppointmentList.Clear();

            switch (box.SelectedItem)
            {
                case "Id":
                    list = context.Appointments.Where(ap => ap.Id.ToString().Contains(search.Text));
                    break;
                case "Type":
                    list = context.Appointments.Where(ap => ap.Type.Contains(search.Text));
                    break;
                case "Customer Id":
                    list = context.Appointments.Where(ap => ap.CustomersId.ToString().Contains(search.Text));
                    break;
                case "Employee Id":
                    list = context.Appointments.Where(ap => ap.EmployeesId.ToString().Contains(search.Text));
                    break;
                default:
                    break;
            }

            try
            {
                if (list.ToList().Count <= 0)
                {
                    MessageBox.Show("No records were found", "No Results");
                    return;
                }
                else
                {
                    list.ToList().ForEach(ap => AppointmentList.Add(ap));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No records were found", "No Results");
                return;
            }
        }

        static public bool DeleteAppointment(HairSpaContext context)
        {
            if (AppointmentIndex == null)
            {
                MessageBox.Show("Must select an appointment", "Invalid Selection");
                return false;
            }

            var deleteMessage = MessageBox.Show("This will delete the appointment. Are you sure?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (deleteMessage == DialogResult.Yes)
            {
                context.Appointments.Attach(AppointmentIndex);
                context.Appointments.Remove(AppointmentIndex);
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
