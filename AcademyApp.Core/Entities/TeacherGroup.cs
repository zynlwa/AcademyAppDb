using AcademyApp.Core.Entities.Common;

namespace AcademyApp.Core.Entities
{
    public class TeacherGroup:BaseEntity
    {
        public int TeacherId { get; set; }
        public int GroupId { get; set; }
        public Teacher Teacher{ get; set; }
        public Group Group {get; set;}
    }
}
