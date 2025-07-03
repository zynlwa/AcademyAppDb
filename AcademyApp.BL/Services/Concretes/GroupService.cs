using AcademyApp.BL.Dtos.Group;
using AcademyApp.BL.Profiles;
using AcademyApp.BL.Services.Interfaces;
using AcademyApp.Core.Entities;
using AcademyApp.DAL.Repositories.Concretes;
using AcademyApp.DAL.Repositories.Interfaces;

namespace AcademyApp.BL.Services.Concretes
{
    public class GroupService:IGroupService
    {
        private readonly IRepository<Group> _repository;
        public GroupService()
        {
            _repository=new Repository<Group>();
        }

        public List<GroupReturnDto> GetAllGroup()
        {
            var groups= _repository.GetAll(false,g=>g.Limit>10,1,2,"Students").ToList();
            return GroupProfile.GroupsReturnDto(groups);
        }
    }
}
