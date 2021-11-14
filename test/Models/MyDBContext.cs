//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace test.Models
//{

//    public class MyDBContext : IdentityDbContext<MyUser>
//    {




//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer("DefaultConnection", builder =>
//            {
//                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
//            });
//            base.OnConfiguring(optionsBuilder);
//        }




//        public MyDBContext(DbContextOptions<MyDBContext> options)
//            : base(options)
//        {
//        }

//        public MyDBContext()
//        {
//        }

//        protected override void OnModelCreating(ModelBuilder builder)
//        {
//            base.OnModelCreating(builder);
//            // Customize the ASP.NET Identity model and override the defaults if needed.
//            // For example, you can rename the ASP.NET Identity table names and more.
//            // Add your customizations after calling base.OnModelCreating(builder);
//        }




//        public DbSet<Teacher> Teachers { get; set; }
//        public DbSet<Course> Courses { get; set; }
//        public DbSet<Student> Students { get; set; }
//    }
//}
