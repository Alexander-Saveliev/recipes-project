using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Entities;

namespace WebApi.DbInfrastructure
{
    public class ToDoEntityConfiguration : IEntityTypeConfiguration<ToDoEntity>
    {
        public void Configure( EntityTypeBuilder<ToDoEntity> builder )
        {
            builder.ToTable( "ToDoList" )
                .HasKey( item => item.Id );

            builder.Property( item => item.Id )
                .HasColumnName( "ToDoId" );
        }
    }
}
