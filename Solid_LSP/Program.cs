using System;
using System.Collections.Generic;

namespace Solid_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new JuniorEmployee());
            list.Add(new SeniorEmployee());
            foreach (Employee emp in list)
            {
                var empdetal = emp.GetEmployeeDetal();
                var workdetal = emp.GetWorkDetal();
                Console.WriteLine(workdetal);
                Console.WriteLine(empdetal);
            }

        }
    }
    // not lsp
    public abstract class Employee
    {
        public virtual string GetWorkDetal()
        {
            return "Base work";
        }

        public virtual string GetEmployeeDetal()
        {
            return "Base Employee";
        }
    }

    public class SeniorEmployee : Employee
    {
        public override string GetWorkDetal()
        {
            return "Senior work";

        }

        public override string GetEmployeeDetal()
        {
            return "Senior Employee";
        }
    }

    public class JuniorEmployee : Employee
    {
        public override string GetWorkDetal()
        {
            throw new NotImplementedException();
        }

        public override string GetEmployeeDetal()
        {
            return "Junior Employee";
        }

    }
    // lsp
    public interface IEmployee
    {
        string GetEmployeeDetal();
    }

    public interface IWork
    {
        string GetWorkDetal();
    }

    public class Senior : IEmployee, IWork
    {
        public string GetEmployeeDetal()
        {
            return "Senior Employee ";
        }

        public string GetWorkDetal()
        {
            return "Senior Work";
        }
    }
    public class Junior : IEmployee
    {
        public string GetEmployeeDetal()
        {
            return "Junior Employee";
        }
    }
}
