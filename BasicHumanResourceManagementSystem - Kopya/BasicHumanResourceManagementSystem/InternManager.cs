using System;
using System.Collections.Generic;
using System.Text;

namespace BasicHumanResourceManagementSystem
{
    class InternManager : IPersonManager
    {
        public void Add()
        {
            //We asssue that wrote codes about Add Intern.
            Console.WriteLine("Intern added");
        }

        public void Delete()
        {
            Console.WriteLine("Intern deleted");
        }

        public void Update()
        {
            Console.WriteLine("Intern updated");
        }
    }
}
