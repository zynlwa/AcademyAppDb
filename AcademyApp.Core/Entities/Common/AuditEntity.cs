namespace AcademyApp.Core.Entities.Common
{
    public class AuditEntity:BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public DateTime DeltedDate { get; set; }
        public bool IsDeleted { get; set; }
        public string CreatedBy { get; set; }
    }
}
