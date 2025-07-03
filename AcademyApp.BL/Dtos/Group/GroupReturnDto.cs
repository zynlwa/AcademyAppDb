namespace AcademyApp.BL.Dtos.Group
{
    public class GroupReturnDto
    {
        public string No { get; set; }
        public int Limit { get; set; }
        public List<string> Students { get; set; }
        public override string ToString()
        {
            return $"GroupNo: {No}, Limit: {Limit}, Students: {string.Join(",",Students ?? new List<string>())}";
        }
    }
}
