
namespace PayrollSoftwareConsoleApp

{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Staff> myStaff;
            FileReader fr = new FileReader();
            int month = 0;
            int year = 0;

            while (year == 0)
            {
                Console.Write("\n Please Enter The Year: ");
                try
                {
                    var y = Console.ReadLine();
                    year=Convert.ToInt32(y);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Year must be a number.");
                }

            }
            while (month == 0)
            {
                Console.WriteLine("Please Enter The Month:");
                try
                {
                    var m=Console.ReadLine();
                    month=Convert.ToInt32(m);
                    if(month<1 || month > 12)
                    {
                        Console.WriteLine("Month must have a value between 1 and 12.");
                        month = 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please Enter a Number.");
                }
            }

            myStaff = fr.ReadFile();

            foreach (Staff f in myStaff)
            {
                Console.WriteLine("Enter the hours worked for {0}:", f.NameOfStaff);
                f.hoursWorked = Convert.ToInt32(Console.ReadLine());
                f.CalculatePay();
            }

            PaySlip ps = new PaySlip(month,year);
            ps.GeneratePaySlip(myStaff);
            ps.GenerateSummary(myStaff);
            Console.Read();

        }
    }
}









