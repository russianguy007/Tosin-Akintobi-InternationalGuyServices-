using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using UserService.Database.Entities;

namespace UserService.Database
{
    public class DatabaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=UserMicroservice;TrustServerCertificate=True;Data Source=DESKTOP-PIMV8MQ\\SQLEXPRESS");
            //Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=UserMicroservice;Data Source=DESKTOP-PIMV8MQ\SQLEXPRESS
        }
    }
}
