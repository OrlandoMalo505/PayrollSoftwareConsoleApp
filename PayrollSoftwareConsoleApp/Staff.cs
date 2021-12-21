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

        private int hWorked;

        public float TotalPay {
            get
            {
                return TotalPay;
            }
            protected set
            {
                TotalPay = value;
            } 
        }

        public float BasicPay
        {
            get
            {
                return BasicPay;
            }
            private set
            {
                BasicPay = value;
            }
        }

        public string NameOfStaff
        {
            get
            {
                return NameOfStaff;
            }
            private set
            {
                NameOfStaff = value;
            }
        }

        public int hoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                if(hoursWorked >0)
                    hoursWorked = value;
                else
                    hoursWorked = 0;
            }
        }

        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return "HourlyRate=" + hourlyRate + ", Hours Worked= " + hWorked + ", Basic Pay = " + BasicPay + ", Total Pay=" + TotalPay +
                ", Name of Staff" + NameOfStaff;
        }

    }
}
