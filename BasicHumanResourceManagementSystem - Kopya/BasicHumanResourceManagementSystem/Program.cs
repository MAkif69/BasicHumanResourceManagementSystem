using System;

namespace BasicHumanResourceManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();

            //EmployeeManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());

            ProjectManager projectManager2 = new ProjectManager();
            projectManager2.Add(new EmployeeManager());
        }
    }
}
