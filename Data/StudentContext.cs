using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentAppAutoDbContextCreate;

namespace StudentAppAutoDbContextCreate.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<StudentAppAutoDbContextCreate.Student> Student { get; set; }
    }
}
