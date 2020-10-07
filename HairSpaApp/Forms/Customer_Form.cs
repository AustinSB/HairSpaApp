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
using static HairSpaApp.Classes.Main;
using static HairSpaApp.Classes.Validate;

namespace HairSpaApp.Forms
{
    public partial class Customer_Form : Form
    {
        HairSpaContext _context;

        public Customer_Form()
        {
            InitializeComponent();
        }

        private void Customer_Form_Load(object sender, EventArgs e)
        {
            PopulateCustomerForm();
        }

        //Controls
        public event EventHandler CustomerFormClosed;
        private void customerSave_Button_Click(object sender, EventArgs e)
        {
            if (!ValidateCustomer()) { return; }

            using (_context = new HairSpaContext())
            {
                if (CustomerIndex == null) //create new customer
                {
                    var newCustomer = new Customer();
                    SetCustomerData(newCustomer);
                    _context.Customers.Add(newCustomer);
                    _context.SaveChanges();
                }
                else //edit existing customer
                {
                    var selectedCustomer = _context.Customers.Attach(CustomerIndex);
                    SetCustomerData(selectedCustomer);
                    _context.SaveChanges();
                }
            }

            CustomerFormClosed(this, e);
            this.Close();
        }

        private void customerCancel_Button_Click(object sender, EventArgs e)
        {
            CustomerFormClosed(this, e);
            this.Close();
        }

        //Methods
        private void PopulateCustomerForm()
        {
            if (CustomerIndex == null) //blank input fields for new customer
            {
                customerHeader_Label.Text = "Create Customer";
            }
            else //fill input fields with selected customer's data
            {
                customerHeader_Label.Text = "Edit Customer";

                firstName_TextBox.Text = CustomerIndex.FirstName;
                lastName_TextBox.Text = CustomerIndex.LastName;
                address_TextBox.Text = CustomerIndex.Address;
                city_TextBox.Text = CustomerIndex.City;
                state_ComboBox.SelectedItem = CustomerIndex.State;
                phone_TextBox.Text = CustomerIndex.Phone;
                email_TextBox.Text = CustomerIndex.Email;
            }
        }

        private void SetCustomerData(Customer c)
        {
            c.FirstName = firstName_TextBox.Text;
            c.LastName = lastName_TextBox.Text;
            c.Address = address_TextBox.Text;
            c.City = city_TextBox.Text;
            c.State = state_ComboBox.SelectedItem.ToString();
            c.Phone = phone_TextBox.Text;
            c.Email = email_TextBox.Text;
        }

        private bool ValidateCustomer()
        {
            if (   !IsTextValid(firstName_TextBox.Text, "First Name") 
                || !IsTextValid(lastName_TextBox.Text, "Last Name") 
                || !IsTextValid(address_TextBox.Text, "Address") 
                || !IsTextValid(city_TextBox.Text, "City") 
                || !IsComboBoxValid(state_ComboBox, "State")
                || !IsPhoneValid(phone_TextBox.Text)
                || !IsEmailValid(email_TextBox.Text)
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
