using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int EMP_ABSENT = 0, EMP_PRESENT = 1, WAGE_PER_HR = 20, FULL_DAY_HR = 8;
        public void EmpDaiyWage()
        {
            Random rand = new Random();
            int EmpCheck=rand.Next(0,2);
            if (EmpCheck == 0)
            {
                Console.WriteLine("Employee's daily wage is Rs 0 as employee is absent "); 
            }
            if (EmpCheck==1)
            {
                int DailyEmpWage = FULL_DAY_HR * WAGE_PER_HR;
                Console.WriteLine("Employee's daily wage is Rs "+ DailyEmpWage );
            }
        }

        
    }
}
