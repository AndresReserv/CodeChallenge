/// <summary>
/// Developmented By Andrés Casas
/// </summary>
namespace Paysheet.Data.Context
{
    using Microsoft.EntityFrameworkCore;
    using Paysheet.Entities;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        /// <summary>
        /// API Fluent
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnType("varchar(250)")
                .IsUnicode(false);

                entity.Property(e => e.ContractTypeName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnType("varchar(50)")
                .IsUnicode(false);

                entity.Property(e => e.AnnualSalary)
                .IsRequired()
                .IsUnicode(false);
            });
        }


        /// <summary>
        /// Db Sets
        /// </summary>
        public virtual DbSet<ContractType> ContractType { get; set; }
    }
}
