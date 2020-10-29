using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EmployeesWebApi.Models
{
    public class EmployeesWebApiContext : DbContext
    {
        public EmployeesWebApiContext (DbContextOptions<EmployeesWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeesWebApi.Models.Employee> Employee { get; set; }
    }
}
