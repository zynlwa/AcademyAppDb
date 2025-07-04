using AcademyApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyApp.DAL.Configurations
{
    public class TeacherConfigurations : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(t=>t.Firstname)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(t => t.Lastname)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(t => t.PhoneNumber)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(t => t.Subject)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
