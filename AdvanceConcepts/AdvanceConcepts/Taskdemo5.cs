using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AdvanceConcepts
{
    // This program demo. how to return complex type using Task<tResult>
    class Taskdemo5
    {
        static void Main()
        {
            var tResult = Task<Employee>.Run(() =>
             {
                 List<Employee> employees = new List<Employee>
                 {
                    new Employee{EmpCode=100,EmpName="Rachana",Email="rachna@gmail.com" };
                 new Employee { EmpCode = 102, EmpName = "Rachana1", Email = "rachna1@gmail.com" };

                  };
                     return employees;
                });
        foreach(var employee in tResult.Result)
            {
            Console.WriteLine($"Code={employee.EmpCode}\n Name={employee.EmpName}\n Email={employee.Email});
            }
          Console.ReadLine();
            }
        }
    }

