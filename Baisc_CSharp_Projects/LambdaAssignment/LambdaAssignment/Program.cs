using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {            
            List<Employees> employees = new List<Employees>();//full employee list

            employees.Add(new Employees { FName = "Joe", LName = "Douglas", Id = 1 });
            employees.Add(new Employees { FName = "James", LName = "White", Id = 3 });
            employees.Add(new Employees { FName = "Kevin", LName = "Adams", Id = 1224 });
            employees.Add(new Employees { FName = "James", LName = "Dean", Id = 1244 });
            employees.Add(new Employees { FName = "Johnny", LName = "Bravo", Id = 1236 });
            employees.Add(new Employees { FName = "Joe", LName = "Jordan", Id = 1274 });
            employees.Add(new Employees { FName = "Anakin", LName = "Skywalker", Id = 2 });
            employees.Add(new Employees { FName = "Marcus", LName = "Novak", Id = 1230 });
            employees.Add(new Employees { FName = "Joe", LName = "Gaines", Id = 1034 });
            employees.Add(new Employees { FName = "Yasir", LName = "Rocha", Id = 1004 });

            List<Employees> theJoes = new List<Employees>();//new list that all of the joes go into.

            //loop that adds any employe whos first name is joe to a new list
            foreach (Employees employee in employees)
            {
                if (employee.FName == "Joe")
                    theJoes.Add(employee);
            }                       

            //Lambda function to find the first name "Joe" in a list.
            List<Employees> theJoesFNameLambda = employees.Where(x => x.FName.Contains("Joe")).ToList();
            
            //Lambda function to find the Id of all employees over 5.
            List<Employees> theJoesId = employees.Where(x => x.Id > 5).ToList();

            //Code to check for contents of lists
            //foreach (Employees joe in theJoesId)
            //{
            //    Console.WriteLine(joe.FName + " " + joe.LName + " Id: " + joe.Id);
            //}
        }
        
        class Employees
            {
                public string FName { get; set; }
                public string LName { get; set; }
                public int Id { get; set; }
            }
        
    }
}
