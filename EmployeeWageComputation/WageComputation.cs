using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class WageComputation
    {
        const int EMP_ABSENT = 0, EMP_PRESENT = 1;
        public void EmpAttendance()
        {
            Random rand = new Random();
            int EmpCheck=rand.Next(0,2);
            if (EmpCheck == 0)
            {
                Console.WriteLine("Employee is absent "); 
            }
            if (EmpCheck==1)
            {
                Console.WriteLine("Employee is present ");
            }
        }

        
    }
}
