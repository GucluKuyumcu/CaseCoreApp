using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseCoreApp.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost\\MSSQLSERVER1; database=CaseCoreApp; integrated security=true;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<TargetApp> TargetApps { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}
