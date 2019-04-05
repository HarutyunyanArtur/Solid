using System;

namespace Solid_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    // not SRP
    public class Employee_NotSRP
    {
        public int ID { get; set; }

        public string FullName { get; set; }

        public bool Add(Employee_NotSRP emp)
        {
            //Select data in DB
            return true;
        }

        public void GanareteReport(Employee_NotSRP emp)
        {
            //Ganareting Report 
        }
    }
    // SRP 
    public class Employee_SRP
    {
        public int ID { get; set; }

        public string FullName { get; set; }

        public bool Add(Employee_NotSRP emp)
        {
            //Select data in DB
            return true;
        }
    }

    public class Employee_GanarateReport
    {
        public void GanareteReport(Employee_NotSRP emp)
        {
            //Ganareting Report 
        }
    }
}