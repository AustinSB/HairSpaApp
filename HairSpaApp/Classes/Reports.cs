using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HairSpaApp.Classes.Main;

namespace HairSpaApp.Classes
{
    static public class Reports
    {
        static private string newLine = Environment.NewLine;
        static private string seperator = new string('-', 75);

        static public void AppointmentsByMonth(RichTextBox box, HairSpaContext context)
        {
            var list = context.Appointments.OrderBy(ap => ap.StartTime);

            box.AppendText($"APPOINTMENTS BY MONTH{newLine}");
            box.AppendText($"REPORT GENERATED: {DateTime.Now}{newLine}{newLine}");

            foreach (var ap in list)
            {
                if (ap.StartTime.Kind == DateTimeKind.Unspecified || ap.StartTime.Kind == DateTimeKind.Utc)
                {
                    ap.StartTime = DateTime.SpecifyKind(ap.StartTime, DateTimeKind.Utc).ToLocalTime();
                }

                if (ap.EndTime.Kind == DateTimeKind.Unspecified || ap.EndTime.Kind == DateTimeKind.Utc)
                {
                    ap.EndTime = DateTime.SpecifyKind(ap.EndTime, DateTimeKind.Utc).ToLocalTime();
                }


                var cu = context.Customers.FirstOrDefault(c => c.Id == ap.CustomersId);
                var emp = context.Employees.FirstOrDefault(e => e.Id == ap.EmployeesId);

                string id = $"ID: {ap.Id}";
                string type = $"APPT TYPE: {ap.Type}";
                string time = $"APPT TIME: {ap.StartTime.ToString("t")} - {ap.EndTime.ToString("t")}, {ap.StartTime.Date.ToShortDateString()}";
                string cost = $"COST: {ap.Cost:c}";
                string customer = $"FOR CUSTOMER: {cu.FirstName} {cu.LastName}";
                string employee = $"HELD BY EMPLOYEE: {emp.FirstName} {emp.LastName}";

                box.AppendText($"{id}{newLine}");
                box.AppendText($"{type}{newLine}");
                box.AppendText($"{time}{newLine}");
                box.AppendText($"{cost}{newLine}");
                box.AppendText($"{customer}{newLine}");
                box.AppendText($"{employee}{newLine}");

                box.AppendText($"{seperator}{newLine}");
            }
        }

        static public void CustomersByName(RichTextBox box, HairSpaContext context)
        {
            var list = context.Customers.OrderBy(c => c.FirstName);

            box.AppendText($"CUSTOMERS BY NAME{newLine}");
            box.AppendText($"REPORT GENERATED: {DateTime.Now}{newLine}{newLine}");

            foreach (var cu in list)
            {
                string id = $"ID: {cu.Id}";
                string name = $"NAME: {cu.FirstName} {cu.LastName}";
                string address = $"ADDRESS: {cu.Address} - {cu.City}, {cu.State}";
                string phone = $"PHONE: {cu.Phone}";
                string email = $"EMAIL: {cu.Email}";

                box.AppendText($"{id}{newLine}");
                box.AppendText($"{name}{newLine}");
                box.AppendText($"{address}{newLine}");
                box.AppendText($"{phone}{newLine}");
                box.AppendText($"{email}{newLine}");

                box.AppendText($"{seperator}{newLine}");
            }
        }

        static public void EmployeesByJobTitle(RichTextBox box, HairSpaContext context)
        {
            var list = context.Employees.OrderBy(e => e.JobTitle);
            
            box.AppendText($"EMPLOYEES BY JOB TITLE{newLine}");
            box.AppendText($"REPORT GENERATED: {DateTime.Now}{newLine}{newLine}");

            foreach (var emp in list)
            {
                string id = $"ID: {emp.Id}";
                string name = $"NAME: {emp.FirstName} {emp.LastName}";
                string address = $"ADDRESS: {emp.Address} - {emp.City}, {emp.State}";
                string jobTitle = $"JOB TITLE: {emp.JobTitle}";
                string pay = $"PAY TYPE: {emp.PayType} - PAY: {emp.Pay:c}";
                string initialDate = $"INITIAL DATE: {emp.InitialDate.ToShortDateString()}";

                box.AppendText($"{id}{newLine}");
                box.AppendText($"{name}{newLine}");
                box.AppendText($"{address}{newLine}");
                box.AppendText($"{jobTitle}{newLine}");
                box.AppendText($"{pay}{newLine}");
                box.AppendText($"{initialDate}{newLine}");

                box.AppendText($"{seperator}{newLine}");
            }
        }

        static public void AccountsByUsername(RichTextBox box, HairSpaContext context)
        {
            var list = context.Accounts.OrderBy(a => a.Username);

            box.AppendText($"ACCOUNTS BY USERNAME{newLine}");
            box.AppendText($"REPORT GENERATED: {DateTime.Now}{newLine}{newLine}");

            foreach (var ac in list)
            {
                var emp = ac.Employees.FirstOrDefault();

                string id = $"ID: {ac.Id}";
                string username = $"USERNAME: {ac.Username}";
                string employee = $"ACCOUNT FOR EMPLOYEE: {emp.FirstName} {emp.LastName}";

                box.AppendText($"{id}{newLine}");
                box.AppendText($"{username}{newLine}");
                box.AppendText($"{employee}{newLine}");

                box.AppendText($"{seperator}{newLine}");
            }
        }
    }
}
