using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSoftwareConsoleApp
{
    internal class Manager:Staff
    {
        private const float managerHourlyRate = 50;
        public int _Allowance;

        public int Allowance
        {
            get {
                return _Allowance; 
                }
            private set
            {
                _Allowance = value;
            }
        }

        public Manager(string name ) : base( name,  managerHourlyRate)
        {

        }

        public override void CalculatePay()
        {
            base.CalculatePay();
            Allowance = 1000;
            if (hoursWorked > 160)
            {
                TotalPay = BasicPay + Allowance;
            }
        }

        public override string ToString()
        {
            return "Allowance= "+Allowance+", Manager Hourly Rate="+managerHourlyRate;
        }
    }
}
