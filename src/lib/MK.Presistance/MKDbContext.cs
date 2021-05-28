using Microsoft.EntityFrameworkCore;

namespace MK.Presistance
{
    /// <summary>
    /// Represent Entities Store in Database
    /// </summary>
    public sealed class MKDbContext : DbContext
    {
        #region ctor

        public MKDbContext(DbContextOptions<MKDbContext> options) : base(options)

        {
        }

        #endregion ctor

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MKDbContext).Assembly);
        }

        #endregion Methods
    }
}