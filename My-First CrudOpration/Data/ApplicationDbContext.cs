using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using My_First_CrudOpration.Models;
using System;
using System.Collections.Generic;
using System.Text;
using My_First_CrudOpration.Areas.Admin.Models;

namespace My_First_CrudOpration.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> students { get; set; }

        public DbSet<My_First_CrudOpration.Areas.Admin.Models.Employee> Employee { get; set; }
    }
}
