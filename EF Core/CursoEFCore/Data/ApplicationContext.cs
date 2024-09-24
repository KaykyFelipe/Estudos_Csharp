using CursoEFCore.Domain;
using Microsoft.EntityFrameworkCore;
using CursoEFCore.Data.Configuration;
using Microsoft.Extensions.Logging;


namespace CursoEFCore.Data
{


    public class ApplicationContext : DbContext
    {

          public DbSet<Cliente> Clientes { get; set; } 
          public DbSet<Produto> Produtos { get; set; }

        private static readonly ILoggerFactory _logger = LoggerFactory.Create(p=>p.AddConsole()); //log das querys

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            
            optionsBuilder
            .UseLoggerFactory(_logger)
            .EnableSensitiveDataLogging()
            .UseSqlServer("Server=DESKTOP-6A2B638\\SQLSERVER2022;Database=CursoEF;Trusted_Connection=True;TrustServerCertificate=True;");// Qual Banco estamos usando e qual string de conexao
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);

        }
    }
}