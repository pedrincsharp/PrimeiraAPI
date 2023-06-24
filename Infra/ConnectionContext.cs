using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.Infra
{
    public class ConnectionContext : DbContext
    {
        string _connectionString = "Server=localhost;" +
                "Port=3306;" +
                "Database=bd_api;" +
                "Uid=root;" +
                "Pwd=123;";

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql(_connectionString, ServerVersion.AutoDetect(_connectionString));
    }
}
