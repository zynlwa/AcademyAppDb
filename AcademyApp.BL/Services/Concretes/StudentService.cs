using AcademyApp.BL.Dtos;
using AcademyApp.BL.Dtos.Student;
using AcademyApp.BL.Profiles;
using AcademyApp.BL.Services.Interfaces;
using AcademyApp.Core.Entities;
using AcademyApp.DAL.Contexts;
using AcademyApp.DAL.Repositories.Concretes;
using AcademyApp.DAL.Repositories.Interfaces;

namespace AcademyApp.BL.Services.Concretes
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student> _repository;
        public StudentService()
        {
            _repository = new Repository<Student>();
        }
        public void CreateStudent(StudentCreateDto studentCreateDto)
        {
            var student = StudentProfile.StudentCreateDtoToStudent(studentCreateDto);
            _repository.Add(student);

        }

        public List<StudentReturnDto> GetAllStudents()
        {
            var students= StudentProfile.StudentsToStudentReturnDto(_repository.GetAll().ToList());
            return students;
        }
    }
}
