using AcademyApp.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AcademyApp.DAL.Configurations
{
    public class TeacherGroupConfiguration : IEntityTypeConfiguration<TeacherGroup>
    {
        public void Configure(EntityTypeBuilder<TeacherGroup> builder)
        {
            builder.HasKey(tg => new { tg.TeacherId, tg.GroupId });
            builder.HasOne(tg => tg.Teacher)
                .WithMany(t => t.TeacherGroups)
                .HasForeignKey(tg => tg.TeacherId);
            builder.HasOne(tg=>tg.Group)
                .WithMany(t=>t.TeacherGroups)
                .HasForeignKey(tg => tg.GroupId);
          
        }
    }
}
