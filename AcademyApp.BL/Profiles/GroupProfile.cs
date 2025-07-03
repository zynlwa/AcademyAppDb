using AcademyApp.BL.Dtos.Group;
using AcademyApp.Core.Entities;

namespace AcademyApp.BL.Profiles
{
    public class GroupProfile
    {
        public static GroupReturnDto GroupReturnDto(Group group)
        {
            return new GroupReturnDto()
            {
                No = group.No,
                Limit = group.Limit,
                Students = group.Students.Select(x => x.Name).ToList()
            };
        }
        public static List<GroupReturnDto> GroupsReturnDto(List<Group> groups)
        {
            return groups.Select(g=>GroupReturnDto(g)).ToList();
        }
    }
}
