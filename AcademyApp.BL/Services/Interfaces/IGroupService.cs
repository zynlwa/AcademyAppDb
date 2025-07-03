using AcademyApp.BL.Dtos.Group;

namespace AcademyApp.BL.Services.Interfaces
{
    public interface IGroupService
    {
        List<GroupReturnDto> GetAllGroup();
    }
}
