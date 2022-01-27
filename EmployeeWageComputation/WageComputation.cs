using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int EMP_ABSENT = 0, EMP_PRESENT = 1,EMP_PARTTIME_PRESENT=2, WAGE_PER_HR = 20, FULL_DAY_HR = 8, PARTTIME_HR = 4 ;
        int EmpHrs = 0, EmpTotalWage = 0;
        public void EmpPartTimeWage()
        {
            Random rand = new Random();
            int EmpCheck = rand.Next(0, 3);
            switch (EmpCheck)
            {

                case EMP_PRESENT:
                    this.EmpHrs += FULL_DAY_HR;
                    Console.WriteLine("Employee is Full time present");
                    break;
            
                case EMP_PARTTIME_PRESENT:
                    this.EmpHrs += PARTTIME_HR;
                    Console.WriteLine("Employee is part time present");
                    break;

                default:
                    Console.WriteLine("Emplyoee is absent");
                    this.EmpHrs += 0;
                    break;
            }
            this.EmpTotalWage = EmpHrs * WAGE_PER_HR;
            Console.WriteLine("Employee's total wage is ");
            Console.WriteLine(this.EmpTotalWage);
        }
    }
}
