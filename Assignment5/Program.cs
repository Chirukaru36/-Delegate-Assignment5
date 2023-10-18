using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeaveRequestProgramLibrary;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            
            employee.LeaveRequested += (requestedLeaves) =>
            {
                Console.WriteLine($"Leave request approved. Deducted {requestedLeaves} leaves. Leaves balance: {employee.LeavesBalance}");
            };

            Console.WriteLine("Employee leaves balance: " + employee.LeavesBalance);

            
            employee.RequestLeave(3);
            employee.RequestLeave(5);
            employee.RequestLeave(4);

            Console.WriteLine("Final leaves balance: " + employee.LeavesBalance);

            Console.ReadLine();
        }
    }
}
 
