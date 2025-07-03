using AcademyApp.Core.Entities;
using AcademyApp.Core.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyApp.DAL.Configurations
{
    public class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .HasOne(s => s.Group)
                .WithMany(g => g.Students)
                .OnDelete(DeleteBehavior.Cascade);
            builder.Property(s => s.Name)
                .HasMaxLength(20)
                .IsRequired(true);

            builder.Property(s => s.Surname)
                   .HasMaxLength(50)
                   .IsRequired(true);
            builder.Property(s => s.Email)
                   .HasMaxLength(100)
                   .IsRequired(true);
            builder.Property(s => s.Status).HasDefaultValue(StudentStatus.Active);
            builder.HasIndex(s => s.Email)
                   .IsUnique(true);




        }
    }
}
