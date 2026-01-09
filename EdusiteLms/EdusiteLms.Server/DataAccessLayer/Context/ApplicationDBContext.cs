using EdusiteLms.Server.BusinessObject.Model;
using Microsoft.EntityFrameworkCore;

namespace EdusiteLms.Server.DataAccessLayer.Context
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);


            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseModel).IsAssignableFrom(entityType.ClrType))
                {
                    var entity = modelBuilder.Entity(entityType.ClrType);
                    entity.HasKey(nameof(BaseModel.Id));

                    entity.Property(nameof(BaseModel.Id))
                          .HasColumnName("id")
                          .ValueGeneratedOnAdd();

                    entity.Property(nameof(BaseModel.CreatedAt))
                          .HasColumnName("created_at")
                          .HasDefaultValueSql("GETUTCDATE()");

                    entity.Property(nameof(BaseModel.UpdatedAt))
                          .HasColumnName("updated_at")
                          .HasDefaultValueSql("GETUTCDATE()");

                    entity.Property(nameof(BaseModel.IsDeleted))
                          .HasColumnName("is_deleted")
                          .HasDefaultValue(false);
                }
            }
            base.OnModelCreating(modelBuilder);
        }

    }
}
