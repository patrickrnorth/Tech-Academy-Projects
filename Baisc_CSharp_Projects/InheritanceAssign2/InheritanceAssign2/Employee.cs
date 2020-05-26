using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAssign2
{
    public class Employee : Person, IQuittable
    {        
        public void Quit(Employee employee);        
    }
}
