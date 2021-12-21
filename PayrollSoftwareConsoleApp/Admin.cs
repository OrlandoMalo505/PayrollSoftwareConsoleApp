using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSoftwareConsoleApp
{
    internal class Admin: Staff
    {

        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30;

        public float Overtime
        {
            get
            {
                return Overtime;
            }
            private set
            {
                Overtime = value;
            }
        }

        public Admin(string name): base(name, adminHourlyRate)
        {

        }

        public override void CalculatePay()
        {
            base.CalculatePay();
            Overtime = overtimeRate * (hoursWorked - 160);
            if (hoursWorked > 160)
            {
                TotalPay = BasicPay + Overtime;
            }
        }

        public override string ToString()
        {
            return "Overtime: "+Overtime+"admin hourly rate:"+adminHourlyRate+"overtime Rate="+overtimeRate;
        }
    }
}
