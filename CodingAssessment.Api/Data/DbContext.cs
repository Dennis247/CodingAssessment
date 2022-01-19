using CodingAssessment.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Data;

namespace CodingAssessment.Api.Data
{
    public interface IApplicationDbContext
    {
        public IDbConnection Connection { get; }
        DatabaseFacade Database { get; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Weight> Weights { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }


    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public IDbConnection Connection => Database.GetDbConnection();

        public DbSet<Cat> Cats { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Weight> Weights { get; set; }


       
    }
}
