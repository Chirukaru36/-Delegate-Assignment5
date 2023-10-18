using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveRequestProgramLibrary
{
    public class Employee
    {
        private int leaves;

       
        public delegate void LeaveRequestHandler(int requestedLeaves);

     
        public event LeaveRequestHandler LeaveRequested;

        public Employee()
        {
            leaves = 10; 
        }

        public int LeavesBalance
        {
            get { return leaves; }
        }

   
        public void RequestLeave(int requestedLeaves)
        {
            if (requestedLeaves <= leaves)
            {
                leaves -= requestedLeaves;

               
                LeaveRequested?.Invoke(requestedLeaves);
            }
            else
            {
                Console.WriteLine("Not enough leaves available for the request.");
            }
        }
    }
}

