using System;
using System.Collections.Generic;
using System.Text;

namespace BasicHumanResourceManagementSystem
{
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //We asssue that wrote codes about Add Customer.
            Console.WriteLine("Customer Added");
        }

        public void Delete()
        {
            Console.WriteLine("Customer Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }
    }
}
