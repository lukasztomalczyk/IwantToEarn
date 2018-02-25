using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IwantToEarn.DbConfig
{
    public class JobModelConfig : IEntityTypeConfiguration<JobModel>
    {
        public void Configure(EntityTypeBuilder<JobModel> builder)
        {
            builder.Property(p => p.Id)
                   .HasColumnType("int")
                   .IsRequired();
            builder.HasKey(a => a.Id);
            builder.Property(p => p.Title)
                   .HasMaxLength(25)
                   .HasColumnType("nchar(20)")
                   .HasColumnName("JobTitle")
                   .IsRequired();
            builder.Property(p => p.Where)
                   .HasColumnType("nchar(20)")
                   .HasMaxLength(20)
                   .HasColumnName("WhereIsJob")
                   .IsRequired();
            builder.Property(u => u.WholeOrHour)
                   .HasMaxLength(1)
                   .HasColumnType("bit")
                   .HasColumnName("ForHourOrWholeJob")
                   .IsRequired();
            builder.Property(p => p.Cash)
                   .HasColumnType("money")
                   .HasColumnName("Cash")
                   .IsRequired();
            builder.Property(p => p.Description)
                   .HasColumnType("ntext")
                   .HasColumnName("Description")
                   .IsRequired();
        }
    }
}