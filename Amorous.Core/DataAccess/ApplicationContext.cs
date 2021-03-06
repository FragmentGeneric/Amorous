using Amorous.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Amorous.Core.DataAccess
{
    /// <summary>
    /// DbContexts can Optional extend ApplicationDbContext.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class AbstractApplicationContext<T> : DbContext where T : ApplicationUser
    {
        /// <summary>
        /// Required field <see cref="DbSet{TEntity}"/> defines the derived DbContext
        /// as <see cref="Amorous.Core"/> compliant applicationContext.
        /// </summary>
        /// <example>
        /// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        /// {
        ///    base.OnConfiguring(optionsBuilder);
        ///    optionsBuilder.UseSqlite("Data Source=Users.db");
        /// }
        /// </example>
        public virtual DbSet<T> Users { get; set; }

        public AbstractApplicationContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //

            /**
             * todo refactor: change application storagePath "App.db -> Data/App.db" via find connection string
             */
            optionsBuilder.UseSqlite("filename=App.db");
        }
    }
}
