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
    public partial class Appointment_Form : Form
    {
        HairSpaContext _context;

        public Appointment_Form()
        {
            InitializeComponent();
        }

        private void Appointment_Form_Load(object sender, EventArgs e)
        {
            SetMinDate(start_DatePicker, end_DatePicker);
            PopulateAppointmentForm();
        }

        //Controls
        public event EventHandler AppointmentFormClosed;
        private void apptSave_Button_Click(object sender, EventArgs e)
        {
            if (!ValidateAppointment()) { return; }

            using (_context = new HairSpaContext())
            {
                if (AppointmentIndex == null) //create
                {
                    var newAppt = new Appointment();
                    SetAppointmentData(newAppt);
                    _context.Appointments.Add(newAppt);
                    _context.SaveChanges();
                }
                else //edit
                {
                    var selectedAppt = _context.Appointments.Attach(AppointmentIndex);
                    SetAppointmentData(selectedAppt);
                    _context.SaveChanges();
                }
            }
            AppointmentFormClosed(this, e);
            this.Close();
        }

        private void apptCancel_Button_Click(object sender, EventArgs e)
        {
            AppointmentFormClosed(this, e);
            this.Close();
        }

        //Methods
        private void PopulateAppointmentForm()
        {
            SetApptComboBoxes();

            if (AppointmentIndex == null) //create
            {
                appt_Label.Text = "Create Appointment";
            }
            else //edit
            {
                appt_Label.Text = "Edit Appointment";

                type_TextBox.Text = AppointmentIndex.Type;
                cost_TextBox.Text = AppointmentIndex.Cost.ToString();
                start_DatePicker.Value = AppointmentIndex.StartTime;
                end_DatePicker.Value = AppointmentIndex.EndTime;

                foreach (var item in customer_ComboBox.Items)
                {
                    var cId = AppointmentIndex.CustomersId;

                    if (item.ToString().Contains($"{cId} - "))
                    {
                        customer_ComboBox.SelectedItem = item;
                    }
                }

                foreach (var item in employee_ComboBox.Items)
                {
                    var eId = AppointmentIndex.EmployeesId;

                    if (item.ToString().Contains($"{eId} - "))
                    {
                        employee_ComboBox.SelectedItem = item;
                    }
                }
            }
            
        }

        private void SetApptComboBoxes()
        {
            using (_context = new HairSpaContext())
            {
                _context.Customers.ToList().ForEach(cu => 
                customer_ComboBox.Items.Add($"{cu.Id} - {cu.FirstName} {cu.LastName}"));

                //Only active employees can hold an appointment
                var empList = _context.Employees.Where(emp => emp.Status == 2);
                empList.ToList().ForEach(emp =>
                employee_ComboBox.Items.Add($"{emp.Id} - {emp.FirstName} {emp.LastName}"));


                
               

            }
        }

        private void SetAppointmentData(Appointment ap)
        {
            ap.Type = type_TextBox.Text;
            ap.Cost = Convert.ToDecimal(cost_TextBox.Text);
            ap.StartTime = start_DatePicker.Value.ToUniversalTime(); //timezone change
            ap.EndTime = end_DatePicker.Value.ToUniversalTime();
            ap.CustomersId = Convert.ToInt32(customer_ComboBox.SelectedItem.ToString()
                .FirstOrDefault().ToString());
            ap.EmployeesId = Convert.ToInt32(employee_ComboBox.SelectedItem.ToString()
                .FirstOrDefault().ToString());
        }

        private bool ValidateAppointment()
        {
            if (   !IsTextValid(type_TextBox.Text, "Type") 
                || !IsTextValid(cost_TextBox.Text, "Cost")
                || !IsDateValid(start_DatePicker, end_DatePicker) 
                || !IsComboBoxValid(customer_ComboBox, "Customer")
                || !IsComboBoxValid(employee_ComboBox, "Employee")
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
