using FIT.Data;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace FIT.Infrastructure
{
    public class DLWMSDbContext : DbContext 
    {
        private readonly string dbPutanja; // = "data Source = C:\\Users\\Elmir\\Desktop\\DLWMS.db";

        public DLWMSDbContext()
        {
            dbPutanja = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }

        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Student> Studenti { get; set; }
    }
}