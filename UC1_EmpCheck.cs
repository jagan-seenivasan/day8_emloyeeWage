using System;

namespace Employee_Wages_usingObject
{
    class UC1_EmpCheck
    {
        public static void CheckEmployee()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)
                Console.WriteLine("Employee Is Present");
            else
                Console.WriteLine("Employee Is Absent");
        }
    }
}
