using Core.Aspects;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterceptionAutofac
{
    public interface IEmployeeService
    {
        void Add(Employee employee);
    }

    [PerformanceAspect(Priority = 1)]
    [LoggingAspect(Priority = 2)]
    public class EmployeeManager : IEmployeeService
    {
        public void Add(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} eklendi");
        }
    }
}
