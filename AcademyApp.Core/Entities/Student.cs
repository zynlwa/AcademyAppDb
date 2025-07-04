using AcademyApp.Core.Entities.Common;
using AcademyApp.Core.Enums;

namespace AcademyApp.Core.Entities
{
    public class Student:BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public StudentStatus Status { get; set; } = StudentStatus.Active;
        public int GroupId { get; set; }
        public Group Group { get; set; }
        
    }
}
