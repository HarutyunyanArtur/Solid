using System;

namespace Solid_OCP
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    // not ocp 

    public class Employee
    {

    }

    public class EmployeeReport
    {

        public string TypeReport { get; set; }

        public void GanarateReport(Employee emp)
        {
            if(TypeReport=="word")
            {
                // Ganarete word format
            }
            if(TypeReport=="pdf")
            {
                //ganarate pdf formate
            }
        }
    }
    // ocp 

    public interface IReportGenerator
    {
        void GanarateReport(Employee emp);
    }


    public class EmployeeWordReport: IReportGenerator
    {
        public void GanarateReport(Employee emp)
        {
            // Ganarate word formate
        }
    }

    public class EmployeePdfReport: IReportGenerator
    {
        public void GanarateReport(Employee emp)
        {
            // ganarate pdf formate
        }
    }
}
