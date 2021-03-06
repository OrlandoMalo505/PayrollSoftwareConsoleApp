using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSoftwareConsoleApp
{
    internal class Staff
    {

        private float hourlyRate;
        public float _TotalPay;
        private int hWorked;
        public string _NameOfStaff;
        public float _BasicPay;

        public float TotalPay
        {
            get
            {
                return _TotalPay;
            }
            protected set => _TotalPay = value;
        }

        public float BasicPay { get; private set; }
       

        public string NameOfStaff
        {
            get
            {
                return _NameOfStaff;
            }
            private set {
                _NameOfStaff = value;
            }
        }

        public int hoursWorked
        {
            get
            {
                return hWorked;
            }
            set
            {
                if (value > 0)
                {
                    hWorked = value;
                }
                else
                    hWorked = 0;
                   
            }
        }

        public Staff(string name, float rate)
        {
            _NameOfStaff = name;
            hourlyRate = rate;
        }

        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = hoursWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return "\nHourlyRate=" + hourlyRate + "\n Hours Worked= " + hWorked + ", Basic Pay = " + BasicPay + ", Total Pay=" + TotalPay +
                ", Name of Staff" + NameOfStaff;
        }

    }
}
