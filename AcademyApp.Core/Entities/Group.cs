using AcademyApp.Core.Entities.Common;

namespace AcademyApp.Core.Entities
{
    public class Group:BaseEntity
    {
        public string No { get; set; }
        public int Limit { get; set; }
        public List<Student> Students { get; set; } 
        public List<TeacherGroup> TeacherGroups { get; set; }
        public override string ToString()
        {
            return $"NO: {No}, Limit: {Limit}, Student Count: {Students.Count}, TeacherCount: {string.Join(",", TeacherGroups.Select(t => t.Teacher.Firstname))}";
        }


    }
}
