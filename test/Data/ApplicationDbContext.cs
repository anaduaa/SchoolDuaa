using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace test.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
            // public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Models.Course> Courses { get; set; }
        public DbSet<test.Models.Student> Student { get; set; }
        public DbSet<test.Models.Teacher> Teacher { get; set; }
    
    }
}
