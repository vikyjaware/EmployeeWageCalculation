using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int EMP_ABSENT = 0, EMP_PRESENT = 1,EMP_PARTTIME_PRESENT=2,FULL_DAY_HR = 8, PARTTIME_HR = 4;
        string Company;
        int TotalWorkingHrs=0, EmpTotalWage=0, WagePerHrs,TotalWorkingDays,MaxWorkingHrs;
        public void CompanyEmpWage()
        {
            Console.WriteLine("Enter company name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter wage per hrs ");
            WagePerHrs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total number of working days ");
            TotalWorkingDays  =Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Enter maximum working hrs per month");
            MaxWorkingHrs = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < TotalWorkingDays && this.TotalWorkingHrs <= MaxWorkingHrs ; i++)
            {
            Random rand = new Random();
            int EmpCheck = rand.Next(0, 3);
                switch (EmpCheck)
                {
                    case EMP_PRESENT:
                        this.TotalWorkingHrs += FULL_DAY_HR;
                        break;

                    case EMP_PARTTIME_PRESENT:
                        this.TotalWorkingHrs += PARTTIME_HR;
                        break;

                    default:
                        this.TotalWorkingHrs += 0;
                        break;
                }
            }
            EmpTotalWage = TotalWorkingHrs * WagePerHrs;
            Console.WriteLine(" Employee's total wage is "+ EmpTotalWage);
        }
    }
}
