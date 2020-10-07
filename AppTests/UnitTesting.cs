using System;
using System.Linq;
using HairSpaApp;
using HairSpaApp.Forms;
using HairSpaApp.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace AppTests
{
    [TestClass]
    public class UnitTesting
    {
        HairSpaContext _context;

        [TestMethod]
        public void LoginTest()
        {
            using (_context = new HairSpaContext())
            {
                var credentials = _context.Accounts.FirstOrDefault(a => a.Username == "admin" && a.Password == "password1");

                if (credentials != null)
                { Debug.WriteLine("Test 1: LoginTest Successful"); }
                else
                { Debug.WriteLine("Test 1: LoginTest Failed"); }

                Assert.IsNotNull(credentials);
            }
        }

        [TestMethod]
        public void CreateCustomerTest()
        {
            using (_context = new HairSpaContext())
            {
                var customer = new Customer
                {
                    FirstName = "test", LastName = "test", Address = "123 test",
                    City = "test city", State = "MD", Email = "test@email.com", Phone = "9990009999"
                };

                _context.Customers.Add(customer);
                _context.SaveChanges();

                if (_context.Customers.AsEnumerable().Contains(customer))
                { Debug.WriteLine("Test 2: CreateCustomerTest Successful"); }
                else
                { Debug.WriteLine("Test 2: CreateCustomerTest Failed"); }

                Assert.IsTrue(_context.Customers.AsEnumerable().Contains(customer));
            }
        }

        [TestMethod]
        public void EditCustomerTest()
        {
            using (_context = new HairSpaContext())
            {
                var index = _context.Customers.FirstOrDefault(c => c.FirstName == "test");
                index.Address = "999 new drive";
                _context.Customers.Attach(index);

                if (index.Address == "999 new drive")
                { Debug.WriteLine("Test 3: EditCustomerTest Successful"); }
                else
                { Debug.WriteLine("Test 3: EditCustomerTest Failed"); }

                Assert.IsTrue(index.Address == "999 new drive");
            }  
        }

        [TestMethod]
        public void DeleteCustomerTest()
        {
            using (_context = new HairSpaContext())
            {
                var index = _context.Customers.FirstOrDefault(c => c.FirstName == "test");
                _context.Customers.Attach(index);
                _context.Customers.Remove(index);
                _context.SaveChanges();

                if (!_context.Customers.AsEnumerable().Contains(index))
                { Debug.WriteLine("Test 4: DeleteCustomerTest Successful"); }
                else
                { Debug.WriteLine("Test 4: DeleteCustomerTest Failed"); }

                Assert.IsFalse(_context.Customers.AsEnumerable().Contains(index));
            }
        }

        [TestMethod]
        public void SearchCustomerTest()
        {
            using (_context = new HairSpaContext())
            {
                var list = _context.Customers.Where(c => c.LastName.Contains("Boyde"));

                if (list != null)
                { Debug.WriteLine("Test 5: SearchCustomerTest Successful"); }
                else
                { Debug.WriteLine("Test 5: SearchCustomerTest Failed"); }

                Assert.IsNotNull(list);
            }
        }
    }
}
