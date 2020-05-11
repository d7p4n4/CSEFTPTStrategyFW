using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEFTPTStrategyFW
{
    public class Context : DbContext
    {
        public Context() : base("employeeConnectionString") {

            Database.SetInitializer<Context>(new CreateDatabaseIfNotExists<Context>());
        }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContractEmployee>().ToTable("ContractEmployees");
            modelBuilder.Entity<PermanentEmployee>().ToTable("PermanentEmployees");

            base.OnModelCreating(modelBuilder);
        }
    }
}
