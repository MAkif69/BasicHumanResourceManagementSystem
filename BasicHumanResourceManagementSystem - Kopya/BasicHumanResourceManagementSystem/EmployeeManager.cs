using System;
using System.Collections.Generic;
using System.Text;

namespace BasicHumanResourceManagementSystem
{
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //We asssue that wrote codes about Add Employer.
            Console.WriteLine("Employer Added");
        }

        public void Delete()
        {
            Console.WriteLine("Employer Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Employer Updated");
        }
    }
}
