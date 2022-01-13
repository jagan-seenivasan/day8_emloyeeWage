using System;

namespace Employee_Wages_usingObject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("----------------------\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                         UC1_EmpCheck uc1 = new  UC1_EmpChecke();
                        uc1.CheckDailySalary();
                        break;
                    case 2:
                        Employee_Wages_usingObject.UC2_DailyWage uc2 = new UC2_DailyWage();
                        uc2.EmpDailyWage();
                        break;
                    case 3:
                        Employee_Wages_usingObject.UC3_PartTimeEmpAndWage uc3 = new UC3_PartTimeEmpAndWage();
                        uc3.CheckPartTimeEmpWage();
                        break;
                    case 4:
                        Employee_Wages_usingObject.UC4_PartTimeEmpWage_usingSwitch  uc4 = new UC4_PartTimeEmpWage_usingSwitch ();
                        uc4.CheckEmpWageUsingSwitch();
                        break;
                    case 5:
                       Employee_Wages_usingObject.UC5_CalculateEmpSalaryForMonth uc5 = new UC5_CalculateEmpSalaryForMonth();
                        uc5.CheckFor20DaysInMonth();
                        break;
                    case 6:
                        Employee_Wages_usingObject.UC6_SalaryForTotalWorkingHrs100_OrMonthsOf20 uc6 = new UC6_SalaryForTotalWorkingHrs100_OrMonthsOf20();
                        uc6.CheckUC6_SalaryForTotalWorkingHrs100_OrMonthsOf20();
                        break;
                    case 7:
                        Employee_Wages_usingObject.UC7_RefactorTheCodeUsingClass uc7 = new UC7_RefactorTheCodeUsingClass
                        UC7_RefactorTheCodeUsingClass.ComputeEmpWage();
                        break;
                    case 8:
                        flag = false;
                        break;
                }
            }
                 
          
        }
    }
}
