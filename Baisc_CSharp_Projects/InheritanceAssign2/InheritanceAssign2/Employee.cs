﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace InheritanceAssign2
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        
        public void Quit(Employee employee)
        {
            throw new NotImplementedException();
        }
        public static bool operator==(Employee employee1, Employee employee2)
        {
            if(employee1.Id == employee2.Id)
                return true;
            else
                return false;
        }
        public static bool operator!=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
                return true;
            else
                return false;
        }
        public static bool operatorEquals(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
                return true;
            else
                return false;
        }
        public static bool operatorGetHashCode(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
                return true;
            else
                return false;
        }

    }
}
