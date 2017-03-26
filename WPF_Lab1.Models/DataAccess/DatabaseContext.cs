using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Lab1.Models.DataAccess
{
    public class DatabaseContext : DbContext
    {
        static DatabaseContext()
        {
            Database.SetInitializer(new DbInitializer());
        }

        public DatabaseContext() : base("defaultConnection")
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Group> Groups { get; set; }

    }
}
