using Microsoft.EntityFrameworkCore;

namespace WebApi.DbInfrastructure
{
    public class ToDoDbContext : DbContext, IUnitOfWork
    {
        public ToDoDbContext( DbContextOptions<ToDoDbContext> options )
            : base( options )
        { }

        void IUnitOfWork.Commit()
        {
            this.SaveChanges();
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder )
        {
            modelBuilder.ApplyConfiguration( new ToDoEntityConfiguration() );
        }
    }
}
