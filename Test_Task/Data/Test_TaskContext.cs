using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test_Task.Models
{
    public class Test_TaskContext : DbContext
    {
        public Test_TaskContext (DbContextOptions<Test_TaskContext> options)
            : base(options)
        {
        }

        public DbSet<Test_Task.Models.User> User { get; set; }
    }
}
