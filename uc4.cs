namespace EmployeeWageComputationProblem
{
    public class EmpWageUsingCase4
    {
        public static void Case()
        {

            int empHrs = 0;
            int empWage = 0;
            int EMP_RATE_PER_HOUR = 20;

            Random random = new Random();

            int empCheck = random.Next(3);

            switch (empCheck)
            {
                case 0:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;

                case 1:
                    Console.WriteLine("Employee is Present for Full Time");
                    empHrs = 8;
                    break;

                case 2:
                    Console.WriteLine("Employee is Present For Part Time");
                    empHrs = 4;
                    break;
            }


            empWage = empHrs * EMP_RATE_PER_HOUR;


            Console.WriteLine("Emp Wage :" + empWage);
        }

    }
}

