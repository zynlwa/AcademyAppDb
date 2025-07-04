using AcademyApp.BL.Dtos;
using AcademyApp.BL.Dtos.Group;
using AcademyApp.BL.Profiles;
using AcademyApp.BL.Services.Interfaces;
using AcademyApp.Core.Entities;
using AcademyApp.DAL.Contexts;
using AcademyApp.DAL.Repositories.Concretes;
using AcademyApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace AcademyApp.BL.Services.Concretes
{
    public class GroupService:IGroupService
    {
        private readonly IRepository<Group> _repository;
        private readonly AppDbContext _context;
        public GroupService()
        {
            _repository=new Repository<Group>();
            _context=new AppDbContext();
        }
        public Group GetGroupById(int id)
        {
            //var group = _context.Groups
            //    .Where(g=>g.Id==id)
            //    //.Include(g=>g.TeacherGroups)
            //    //.ThenInclude(tg=>tg.Teacher)
            //    //.Include(s=>s.Students) Select yazilsa include-a ehtiyac yoxdu,asnotrackingde yazilmir(tip ferqlilidir)
            //    .Select(g=> new GroupReturnDto //sqlden o tip
            //    { No=g.No,
            //      Limit=g.Limit,

            //    })
            //    .FirstOrDefault();
            //return group;
            //var group = _repository.GetById(id, false, "Students", "TeacherGroups.Teacher");1
            var group = _repository.GetById(id, false, include =>
                        include.Include(g => g.Students)
                               .Include(g => g.TeacherGroups)
                               .ThenInclude(t => t.Teacher)
                );
                
                return group;
        }

        public void Add(GroupCreateDto groupCreateDto)
        {
            if (_repository.IsExist(g => g.No == groupCreateDto.No))
            {
                throw new Exception("Movcuddur");
            }
            _repository.Add(GroupProfile.GroupCreatedDtoToGroup(groupCreateDto));
            _repository.Savechanges();
        }

        public List<GroupReturnDto> GetAllGroup()
        {
            var groups= _repository.GetAll(false,g=>g.Limit>10,1,2,"Students").ToList();
            return GroupProfile.GroupsReturnDto(groups);
        }
    }
}
