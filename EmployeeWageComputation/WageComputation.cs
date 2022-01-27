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

        public void EmpPartTimeWage()
        {
            Random rand = new Random();
            int EmpCheck = rand.Next(0, 3);
            if (EmpCheck == 0)
            {
                Console.WriteLine("Employee's daily wage is Rs 0 as employee is absent ");
            }

            if (EmpCheck == 1)

            {
                int DailyEmpWage = FULL_DAY_HR * WAGE_PER_HR;
                Console.WriteLine("Employee's daily wage is Rs " + DailyEmpWage);
            }
            if (EmpCheck == 2)
            {
                int DailyEmpWage = PARTTIME_HR * WAGE_PER_HR;
                Console.WriteLine("Employee's daily part time wage is Rs " + DailyEmpWage);
            }

        }
    }
}
