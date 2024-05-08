using Microsoft.EntityFrameworkCore;

namespace BE_ABC.Models.Context
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }
        #region DbSet

        #endregion

        #region model creating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
