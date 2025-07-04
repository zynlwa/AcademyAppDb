using AcademyApp.Core.Entities.Common;

namespace AcademyApp.Core.Entities
{
    public class Teacher:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Subject { get; set; }
        public List<TeacherGroup> TeacherGroups { get; set; }
    }
}
