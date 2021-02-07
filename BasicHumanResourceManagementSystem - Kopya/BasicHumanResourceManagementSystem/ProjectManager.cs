using System;
using System.Collections.Generic;
using System.Text;

namespace BasicHumanResourceManagementSystem
{
    //This class our base class to manage all project.
    class ProjectManager
    {
        public void Add(IPersonManager personManager) 
        {
            personManager.Add();
        }

    }
}
