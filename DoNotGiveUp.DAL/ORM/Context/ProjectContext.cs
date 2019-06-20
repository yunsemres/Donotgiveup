using DoNotGiveUp.DAL.ORM.Entity;
using DoNotGiveUp.DAL.ORM.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoNotGiveUp.DAL.ORM.Context
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.Connection.ConnectionString = "Server=.;Database=DoNotGiveUp;UID=sa;PWD=1234;";
        }
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
