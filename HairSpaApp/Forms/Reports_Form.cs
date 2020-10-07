using HairSpaApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HairSpaApp.Classes.Reports;
using static HairSpaApp.Classes.Validate;

namespace HairSpaApp.Forms
{
    public partial class Reports_Form : Form
    {
        HairSpaContext _context;

        public Reports_Form()
        {
            InitializeComponent();
        }

        private void Reports_Form_Load(object sender, EventArgs e)
        {
        }

        private void showReport_Button_Click(object sender, EventArgs e)
        {
            if (!ValidateReports()) { return; }

            report_TextBox.Text = "";

            using (_context = new HairSpaContext())
            {
                switch (selectReport_ComboBox.SelectedItem)
                {
                    case "Appointments by month":
                        AppointmentsByMonth(report_TextBox, _context);
                        break;
                    case "Customers by name":
                        CustomersByName(report_TextBox, _context);
                        break;
                    case "Employees by job title":
                        EmployeesByJobTitle(report_TextBox, _context);
                        break;
                    default:
                        MessageBox.Show("Must select report type", "Invalid Selection");
                        break;
                }
            }
        }

        public event EventHandler ReportFormClosed;
        private void cancel_Button_Click(object sender, EventArgs e)
        {
            ReportFormClosed(this, e);
            this.Close();
        }

        //Methods
        private bool ValidateReports()
        {
            if (!IsComboBoxValid(selectReport_ComboBox, "Report"))
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
