using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeManagementSystemContext : DbContext
    {
        public EmployeeManagementSystemContext (DbContextOptions<EmployeeManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<EmployeeManagementSystem.Models.Employee> Employee { get; set; } = default!;
    }
}
