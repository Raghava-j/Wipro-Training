using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication20.Models;

namespace WebApplication20.Data
{
    public class WebApplication20Context : DbContext
    {
        public WebApplication20Context (DbContextOptions<WebApplication20Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication20.Models.Product> Product { get; set; } = default!;
    }
}
