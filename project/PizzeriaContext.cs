using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project
{
    public class PizzeriaContext : DbContext
    {
        public DbSet<Pizza> pizze { get; set; }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost\\MSSQLSERVER01;Initial Catalog=Pizzeria;Integrated Security=True; TrustServerCertificate=True");
        }
    }
}
