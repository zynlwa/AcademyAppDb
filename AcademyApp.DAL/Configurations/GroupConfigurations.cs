using AcademyApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyApp.DAL.Configurations
{
    public class GroupConfigurations : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.Property(g => g.No)
                .HasMaxLength(10)
                .IsRequired(true);
            builder.Property(g=>g.Limit)
                .IsRequired(true);
            builder.HasIndex(g => g.No)
                .IsUnique(true);
            builder.HasData
                (
                new Group
                {
                    Id = 1,
                    No = "G-001",
                    Limit = 12
                },
                new Group
                {
                    Id = 2,
                    No = "G-002",
                    Limit = 15
                },
                new Group
                {
                    Id = 3,
                    No = "G-003",
                    Limit = 20
                }

                );


        }
    }
}
