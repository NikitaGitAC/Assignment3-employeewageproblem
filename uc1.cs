﻿namespace Employeewagecomputationproblem
{
    public class Employeecheck
    {
        public static void EmployeeAttendence()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");

            }
        }
    }
}

