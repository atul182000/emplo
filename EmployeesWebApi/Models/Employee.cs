using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesWebApi.Models
{
    // Employee model class representing table Employee in Database
    public class Employee
    {
        // create Primary Key for table
        [Key]
        public int ID { get; set; }
        // Name of the employee
        public string Name { get; set; }
        // gender of th employee
        public string Gender { get; set; }
        // and salary of the employee
        public double Salary { get; set; }
    }
}
