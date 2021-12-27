using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSoftwareConsoleApp
{
    internal class PaySlip
    {
        private int month;
        private int year;

        public enum MonthsOfYear
        {
            January=1,February, March, April, May, June, July, August, September, October, November, December
        }

        public PaySlip(int payMonth, int payYear)
        {
            month = payMonth;
            year = payYear;
        }

        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;
            foreach(Staff staff in myStaff)
            {
                path = staff.NameOfStaff + ".txt";
                StreamWriter sw = new StreamWriter(path);
                sw.WriteLine("PAYSLIP FOR {0} {1}",(MonthsOfYear)month,year);
                sw.WriteLine("===================");
                sw.WriteLine("Name of Staff: {0}", staff.NameOfStaff);
                sw.WriteLine("Hours Worked: {0}", staff.hoursWorked);
                sw.WriteLine("");
                sw.WriteLine("Basic Pay: {0}",staff.BasicPay);
                if (staff.GetType() == typeof(Manager))
                {
                    sw.WriteLine("Allowance: {0:C}",((Manager)staff).Allowance);

                }
                else if(staff.GetType()== typeof(Admin))
                {
                    sw.WriteLine("Overtime Pay: {0:C}",((Admin)staff).Overtime);
                }
                sw.WriteLine("");
                sw.WriteLine("====================");
                sw.WriteLine("Total Pay: {0}",staff.TotalPay);
                sw.WriteLine("====================");
                sw.Close();

            }
        }

        public void GenerateSummary(List<Staff> myStaff)
        {
            var result = from staff in myStaff
                         where staff.hoursWorked < 10
                         orderby staff.NameOfStaff ascending
                         select new { staff.NameOfStaff, staff.hoursWorked };

            string path = "summary.txt";
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine("Staff with less than 10 working hours");
            sw.WriteLine("");
            foreach(var staff in result)
            {
                sw.WriteLine("Name of Staff: {0}, Hours Worked: {1}",staff.NameOfStaff,staff.hoursWorked);

            }
            sw.Close();
           
        }

        public override string ToString()
        {
            return "Month= "+month+"Year: "+year;
        }
    }
}
